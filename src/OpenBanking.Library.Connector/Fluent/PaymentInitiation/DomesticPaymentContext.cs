﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using FinnovationLabs.OpenBanking.Library.Connector.Model.Public.PaymentInitiation;

namespace FinnovationLabs.OpenBanking.Library.Connector.Fluent.PaymentInitiation
{
    public class DomesticPaymentContext
    {
        internal DomesticPaymentContext(OpenBankingContext context)
        {
            Context = context.ArgNotNull(nameof(context));
            Data = new DomesticPaymentRequest();
        }

        internal OpenBankingContext Context { get; }

        internal DomesticPaymentRequest Data { get; set; }

        internal string DomesticConsentId { get; set; }
    }
}
