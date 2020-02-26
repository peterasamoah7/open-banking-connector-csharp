﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using FinnovationLabs.OpenBanking.Library.Connector.Model.Public.PaymentInitiation;

namespace FinnovationLabs.OpenBanking.Library.Connector.Fluent.PaymentInitiation
{
    public class DomesticPaymentConsentResponse : OpenBankingResponse
    {
        public DomesticPaymentConsentResponse(OpenBankingResponseMessage message) : this(new[] { message })
        {
        }

        public DomesticPaymentConsentResponse(IList<OpenBankingResponseMessage> messages) : base(messages)
        {
        }

        public DomesticPaymentConsentResponse(PaymentConsentResponse data)
        {
            Data = data;
        }


        public PaymentConsentResponse Data { get; set; }
    }
}