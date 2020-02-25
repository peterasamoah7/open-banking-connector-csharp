﻿using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.Model.Public.PaymentInitiation
{
    public class OBInternationalInstructedAmount
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }
        
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
