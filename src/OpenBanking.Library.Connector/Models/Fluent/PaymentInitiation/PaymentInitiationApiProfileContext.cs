﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using FinnovationLabs.OpenBanking.Library.Connector.Models.Public.PaymentInitiation;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Public.PaymentInitiation.Request;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Fluent.PaymentInitiation
{
    public class PaymentInitiationApiProfileContext
    {
        internal PaymentInitiationApiProfileContext(ISharedContext context)
        {
            Context = context;
        }

        internal ISharedContext Context { get; }

        internal PaymentInitiationApiProfile Data { get; set; }

        internal string Id { get; set; }

        internal string BankClientProfileId { get; set; }

        internal ApiVersion? ApiVersion { get; set; }

        internal string BaseUrl { get; set; }
    }
}
