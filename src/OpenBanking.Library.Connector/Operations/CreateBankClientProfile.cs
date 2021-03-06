// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FinnovationLabs.OpenBanking.Library.Connector.Http;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Mapping;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Persistent;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Public;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Public.Response;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Validation;
using FinnovationLabs.OpenBanking.Library.Connector.Persistence;
using FinnovationLabs.OpenBanking.Library.Connector.Security;
using FinnovationLabs.OpenBanking.Library.Connector.Services;
using BankClientProfilePublic = FinnovationLabs.OpenBanking.Library.Connector.Models.Public.Request.BankClientProfile;

namespace FinnovationLabs.OpenBanking.Library.Connector.Operations
{
    public interface ICreateBankClientProfile
    {
        Task<BankClientProfileResponse> CreateAsync(BankClientProfilePublic bankClientProfile);
    }

    public class CreateBankClientProfile : ICreateBankClientProfile
    {
        private readonly IApiClient _apiClient;
        private readonly IDbEntityRepository<BankClientProfile> _bankClientProfileRepo;
        private readonly IDbMultiEntityMethods _dbMultiEntityMethods;
        private readonly IEntityMapper _mapper;
        private readonly ISoftwareStatementProfileService _softwareStatementProfileService;

        public CreateBankClientProfile(
            IApiClient apiClient,
            IEntityMapper mapper,
            IDbMultiEntityMethods dbMultiEntityMethods,
            IDbEntityRepository<BankClientProfile> bankClientProfileRepo,
            ISoftwareStatementProfileService softwareStatementProfileService)
        {
            _apiClient = apiClient;
            _mapper = mapper;
            _dbMultiEntityMethods = dbMultiEntityMethods;
            _bankClientProfileRepo = bankClientProfileRepo;
            _softwareStatementProfileService = softwareStatementProfileService;
        }

        public async Task<BankClientProfileResponse> CreateAsync(BankClientProfilePublic bankClientProfile)
        {
            bankClientProfile.ArgNotNull(nameof(bankClientProfile));

            // Load relevant objects
            SoftwareStatementProfile softwareStatementProfile =
                _softwareStatementProfileService.GetSoftwareStatementProfile(
                    bankClientProfile.SoftwareStatementProfileId);

            // STEP 1
            // Compute claims associated with Open Banking client

            // Get OpenID Connect configuration info
            OpenIdConfiguration openIdConfiguration =
                await GetOpenIdConfigurationAsync(bankClientProfile.IssuerUrl);
            new OpenBankingOpenIdConfigurationResponseValidator().Validate(openIdConfiguration)
                .RaiseErrorOnValidationError();

            // Create claims for client reg
            OpenBankingClientRegistrationClaims registrationClaims = Factories.CreateRegistrationClaims(
                issuerUrl: bankClientProfile.IssuerUrl,
                sProfile: softwareStatementProfile,
                concatScopes: false);
            BankClientRegistrationClaimsOverrides registrationClaimsOverrides =
                bankClientProfile.BankClientRegistrationClaimsOverrides;
            if (!(registrationClaimsOverrides is null))
            {
                if (!(registrationClaimsOverrides.RequestAudience is null))
                {
                    registrationClaims.Aud = registrationClaimsOverrides.RequestAudience;
                }
            }

            BankClientRegistrationClaims persistentRegistrationClaims =
                _mapper.Map<BankClientRegistrationClaims>(registrationClaims);

            // STEP 2
            // Check for existing Open Banking client for issuer URL
            // If we have an Open Banking client with the same issuer URL we will check if the claims match.
            // If they do, we will re-use this client.
            // Otherwise we will return an error as only support a single client per issuer URL at present.
            IQueryable<BankClientProfile> clientList = await _bankClientProfileRepo
                .GetAsync(c => c.IssuerUrl == bankClientProfile.IssuerUrl);
            BankClientProfile existingClient = clientList
                .SingleOrDefault();
            if (existingClient is object)
            {
                if (existingClient.BankClientRegistrationClaims != persistentRegistrationClaims)
                {
                    throw new Exception(
                        "There is already a client for this issuer URL but it cannot be re-used because claims are different.");
                }
            }

            // STEP 3
            // Create new Open Banking client by posting JWT
            BankClientProfile client;
            if (existingClient is null)
            {
                JwtFactory jwtFactory = new JwtFactory();
                string jwt = jwtFactory.CreateJwt(
                    profile: softwareStatementProfile,
                    claims: registrationClaims,
                    useOpenBankingJwtHeaders: false);

                OpenBankingClientRegistrationResponse registrationResponse = await new HttpRequestBuilder()
                    .SetMethod(HttpMethod.Post)
                    .SetUri(openIdConfiguration.RegistrationEndpoint)
                    .SetContent(jwt)
                    .SetContentType("application/jwt")
                    .Create()
                    .RequestJsonAsync<OpenBankingClientRegistrationResponse>(
                        client: _apiClient,
                        requestContentIsJson: false);

                BankClientRegistrationData openBankingClientResponse = new BankClientRegistrationData
                {
                    ClientId = registrationResponse.ClientId,
                    ClientIdIssuedAt = registrationResponse.ClientIdIssuedAt,
                    ClientSecret = registrationResponse.ClientSecret,
                    ClientSecretExpiresAt = registrationResponse.ClientSecretExpiresAt
                };

                // Create and store Open Banking client
                BankClientProfile newClient = _mapper.Map<BankClientProfile>(bankClientProfile);
                client = await PersistOpenBankingClient(
                    value: newClient,
                    openIdConfiguration: openIdConfiguration,
                    registrationClaims: registrationClaims,
                    openBankingRegistrationData: openBankingClientResponse);
                await _dbMultiEntityMethods.SaveChangesAsync();
            }
            else
            {
                client = existingClient;
            }

            // Return
            return new BankClientProfileResponse(client);
        }

        private async Task<BankClientProfile> PersistOpenBankingClient(
            BankClientProfile value,
            OpenIdConfiguration openIdConfiguration,
            OpenBankingClientRegistrationClaims registrationClaims,
            BankClientRegistrationData openBankingRegistrationData)
        {
            value.State = "ok";
            value.OpenIdConfiguration = openIdConfiguration;
            value.BankClientRegistrationClaims =
                _mapper.Map<BankClientRegistrationClaims>(registrationClaims);
            value.BankClientRegistrationData = openBankingRegistrationData;

            await _bankClientProfileRepo.UpsertAsync(value);

            return value;
        }

        private async Task<BankClientProfile> PersistOpenBankingClientProfile(
            BankClientProfile value,
            string openBankingClientId)
        {
            value.Id = Guid.NewGuid().ToString();
            value.State = "ok";

            await _bankClientProfileRepo.UpsertAsync(value);

            return value;
        }

        private async Task<OpenIdConfiguration> GetOpenIdConfigurationAsync(string issuerUrl)
        {
            UriBuilder ub = new UriBuilder(new Uri(issuerUrl)) { Path = ".well-known/openid-configuration" };

            return await new HttpRequestBuilder()
                .SetMethod(HttpMethod.Get)
                .SetUri(ub.Uri)
                .Create()
                .RequestJsonAsync<OpenIdConfiguration>(client: _apiClient, requestContentIsJson: false);
        }
    }
}
