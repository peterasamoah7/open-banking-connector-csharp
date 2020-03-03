// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FinnovationLabs.OpenBanking.Library.Connector.Http;
using FinnovationLabs.OpenBanking.Library.Connector.Model.Mapping;
using FinnovationLabs.OpenBanking.Library.Connector.Model.Persistent;
using FinnovationLabs.OpenBanking.Library.Connector.Model.Public;
using FinnovationLabs.OpenBanking.Library.Connector.Model.Validation;
using FinnovationLabs.OpenBanking.Library.Connector.Security;
using BankClientProfile = FinnovationLabs.OpenBanking.Library.Connector.Model.Persistent.BankClientProfile;
using OpenBankingClientRegistrationClaims =
    FinnovationLabs.OpenBanking.Library.Connector.Model.Public.OpenBankingClientRegistrationClaims;

namespace FinnovationLabs.OpenBanking.Library.Connector.Operations
{
    public class CreateBankClientProfile
    {
        private readonly IApiClient _apiClient;
        private readonly IEntityMapper _mapper;
        private readonly ISoftwareStatementProfileRepository _softwareStatementProfileRepo;
        private readonly IOpenBankingClientProfileRepository _openBankingClientRepo;

        public CreateBankClientProfile(IApiClient apiClient, IEntityMapper mapper, ISoftwareStatementProfileRepository softwareStatementProfileRepo, IOpenBankingClientProfileRepository openBankingClientRepo)
        {
            _apiClient = apiClient;
            _mapper = mapper;
            _softwareStatementProfileRepo = softwareStatementProfileRepo;
            _openBankingClientRepo = openBankingClientRepo;
        }
        
        public async Task<Model.Public.Response.BankClientProfile> CreateAsync(Model.Public.Request.BankClientProfile bankClientProfile)
        {
            bankClientProfile.ArgNotNull(nameof(bankClientProfile));

            // Load relevant objects
            var softwareStatementProfile = await _softwareStatementProfileRepo.GetAsync(bankClientProfile.SoftwareStatementProfileId) ?? throw new KeyNotFoundException("The Software Statement Profile does not exist.");

            // STEP 1
            // Compute claims associated with Open Banking client

            // Get OpenID Connect configuration info
            var openIdConfiguration =
                await GetOpenIdConfigurationAsync(bankClientProfile.IssuerUrl);
            new OpenBankingOpenIdConfigurationResponseValidator().Validate(openIdConfiguration)
                .RaiseErrorOnValidationError();

            // Create claims for client reg
            var registrationClaims = Factories.CreateRegistrationClaims(bankClientProfile.IssuerUrl,
                softwareStatementProfile, false);
            var registrationClaimsOverrides =
                bankClientProfile.ClientRegistrationClaimsOverrides;
            if (registrationClaimsOverrides != null)
            {
                registrationClaims.Aud = registrationClaimsOverrides.RequestAudience;
            }

            var persistentRegistrationClaims =
                _mapper.Map<Model.Persistent.BankClientRegistrationClaims>(registrationClaims);

            // STEP 2
            // Check for existing Open Banking client for issuer URL
            // If we have an Open Banking client with the same issuer URL we will check if the claims match.
            // If they do, we will re-use this client.
            // Otherwise we will return an error as only support a single client per issuer URL at present.
            var existingClient =
                (await _openBankingClientRepo.GetAsync(c => c.IssuerUrl == bankClientProfile.IssuerUrl))
                .SingleOrDefault();
            if (existingClient != null)
            {
                if (existingClient.BankClientRegistrationClaims != persistentRegistrationClaims)
                {
                    throw new Exception(
                        "There is already a client for this issuer URL but it cannot be re-used because claims are different.");
                }
            }

            // STEP 3
            // Create new Open Banking client by posting JWT
            string jwt = null; // null by default, will be defined if new client created
            BankClientProfile client;
            if (existingClient == null)
            {
                var jwtFactory = new JwtFactory();
                jwt = jwtFactory.CreateJwt(softwareStatementProfile, registrationClaims, false);

                var registrationResponse = await new HttpRequestBuilder()
                    .SetMethod(HttpMethod.Post)
                    .SetUri(openIdConfiguration.RegistrationEndpoint)
                    .SetContent(jwt)
                    .SetContentType("application/jwt")
                    .Create()
                    .RequestJsonAsync<OpenBankingClientRegistrationResponse>(_apiClient, false);

                var openBankingClientResponse = new BankClientRegistrationData
                {
                    ClientId = registrationResponse.ClientId,
                    ClientIdIssuedAt = registrationResponse.ClientIdIssuedAt,
                    ClientSecret = registrationResponse.ClientSecret,
                    ClientSecretExpiresAt = registrationResponse.ClientSecretExpiresAt
                };

                // Create and store Open Banking client
                client = _mapper.Map<BankClientProfile>(bankClientProfile);
                client = await PersistOpenBankingClient(client, openIdConfiguration, registrationClaims,
                    openBankingClientResponse);
            }
            else
            {
                client = existingClient;
            }

            // Return
            return new Model.Public.Response.BankClientProfile(client);
            
        }

        private async Task<Model.Persistent.BankClientProfile> PersistOpenBankingClient(
            Model.Persistent.BankClientProfile value,
            OpenIdConfiguration openIdConfiguration,
            OpenBankingClientRegistrationClaims registrationClaims,
            BankClientRegistrationData openBankingRegistrationData
        )
        {
            value.Id = Guid.NewGuid().ToString();
            value.State = "ok";
            value.OpenIdConfiguration = openIdConfiguration;
            value.BankClientRegistrationClaims =
                _mapper.Map<Model.Persistent.BankClientRegistrationClaims>(registrationClaims);
            value.BankClientRegistrationData = openBankingRegistrationData;

            await _openBankingClientRepo.SetAsync(value);

            return value;
        }

        private async Task<Model.Persistent.BankClientProfile> PersistOpenBankingClientProfile(
            Model.Persistent.BankClientProfile value,
            string openBankingClientId
        )
        {
            value.Id = Guid.NewGuid().ToString();
            value.State = "ok";

            await _openBankingClientRepo.SetAsync(value);

            return value;
        }

        private async Task<OpenIdConfiguration> GetOpenIdConfigurationAsync(string issuerUrl)
        {
            var ub = new UriBuilder(new Uri(issuerUrl)) { Path = ".well-known/openid-configuration" };

            return await new HttpRequestBuilder()
                .SetMethod(HttpMethod.Get)
                .SetUri(ub.Uri)
                .Create()
                .RequestJsonAsync<OpenIdConfiguration>(_apiClient, false);
        }
    }
}