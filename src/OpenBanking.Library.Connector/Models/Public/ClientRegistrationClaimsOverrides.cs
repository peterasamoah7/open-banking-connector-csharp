﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Public
{
    public class BankClientRegistrationClaimsOverrides
    {
        public BankClientRegistrationClaimsOverrides()
        {
            GrantTypes = new List<string>();
        }

        [JsonProperty("iss")]
        public string SsaIssuer { get; set; }

        [JsonProperty("aud")]
        public string RequestAudience { get; set; }

        [JsonProperty("token_endpoint_auth_method")]
        public string TokenEndpointAuthMethod { get; set; }

        [JsonProperty("grant_types")]
        public IList<string> GrantTypes { get; set; }


        // Notionally a nullable bool, but Json serialisation doesn't handle well. Assume false as default.
        [JsonProperty("scope__useStringArray")]
        public bool ScopeUseStringArray { get; set; }

        [JsonProperty("token_endpoint_auth_signing_alg")]
        public string TokenEndpointAuthSigningAlgorithm { get; set; }
    }
}
