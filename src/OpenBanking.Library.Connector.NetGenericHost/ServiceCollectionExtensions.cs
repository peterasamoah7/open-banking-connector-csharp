﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Net.Http;
using FinnovationLabs.OpenBanking.Library.Connector.Http;
using FinnovationLabs.OpenBanking.Library.Connector.Instrumentation;
using FinnovationLabs.OpenBanking.Library.Connector.KeySecrets;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Fluent;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Mapping;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Persistent;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Persistent.PaymentInitiation;
using FinnovationLabs.OpenBanking.Library.Connector.NetGenericHost.Configuration;
using FinnovationLabs.OpenBanking.Library.Connector.NetGenericHost.Instrumentation;
using FinnovationLabs.OpenBanking.Library.Connector.NetGenericHost.KeySecrets;
using FinnovationLabs.OpenBanking.Library.Connector.Persistence;
using FinnovationLabs.OpenBanking.Library.Connector.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IConfigurationProvider = FinnovationLabs.OpenBanking.Library.Connector.Configuration.IConfigurationProvider;

namespace FinnovationLabs.OpenBanking.Library.Connector.NetGenericHost
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOpenBankingConnector(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            const string httpClientName = "OBC";

            services.AddHttpClient(httpClientName)
                .ConfigurePrimaryHttpMessageHandler(
                    sp =>
                    {
                        IKeySecretProvider secrets = sp.GetService<IKeySecretProvider>();

                        HttpMessageHandler handler = new HttpRequestBuilder()
                            .SetClientCertificates(CertificateFactories.GetCertificates(secrets))
                            .CreateMessageHandler();

                        return handler;
                    });

            services.AddSingleton<IConfigurationProvider>(sp => new AppsettingsConfigurationProvider(configuration));
            services.AddSingleton<IInstrumentationClient, LoggerInstrumentationClient>();
            services.AddSingleton(
                sp =>
                {
                    KeySecretBuilder builder = new KeySecretBuilder();
                    IConfigurationProvider configProvider = sp.GetService<IConfigurationProvider>();

                    return builder.GetKeySecretProvider(
                        config: configuration,
                        obcConfig: configProvider.GetRuntimeConfiguration());
                });
            services.AddSingleton<IApiClient>(
                sp =>
                {
                    IHttpClientFactory hcf = sp.GetService<IHttpClientFactory>();

                    HttpClient client = hcf.CreateClient(httpClientName);

                    return new ApiClient(instrumentation: sp.GetService<IInstrumentationClient>(), httpClient: client);
                });
            services.AddSingleton<ICertificateReader, PemParsingCertificateReader>();
            services.AddSingleton<IEntityMapper, EntityMapper>();

            // Configure DB
            switch (configuration["DbProvider"])
            {
                case "Sqlite":
                    services
                        // See e.g. https://jasonwatmore.com/post/2020/01/03/aspnet-core-ef-core-migrations-for-multiple-databases-sqlite-and-sql-server 
                        .AddDbContext<BaseDbContext, SqliteDbContext>(
                            options =>
                            {
                                string connectionString = configuration.GetConnectionString("SqliteDbContext");
                                options.UseSqlite(connectionString);
                            });
                    break;
                default:
                    throw new ArgumentException(message: "Unknown DB provider", paramName: configuration["DbProvider"]);
            }

            services.AddScoped<IDbMultiEntityMethods,
                DbMultiEntityMethods>();
            services.AddScoped<IDbEntityRepository<SoftwareStatementProfile>,
                DbEntityRepository<SoftwareStatementProfile>>();
            services.AddScoped<IDbEntityRepository<BankClientProfile>,
                DbEntityRepository<BankClientProfile>>();
            services.AddScoped<IDbEntityRepository<ApiProfile>,
                DbEntityRepository<ApiProfile>>();
            services.AddScoped<IDbEntityRepository<DomesticConsent>,
                DbEntityRepository<DomesticConsent>>();
            services.AddScoped<IOpenBankingRequestBuilder, RequestBuilder>();

            return services;
        }
    }
}