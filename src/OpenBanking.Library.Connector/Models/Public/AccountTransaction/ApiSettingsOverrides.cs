﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Public.AccountTransaction
{
    public class ApiSettingsOverrides
    {
        [JsonProperty("accountAccessConsentPermissions")]
        public IList<string> AccountAccessConsentPermissions { get; set; }
    }
}
