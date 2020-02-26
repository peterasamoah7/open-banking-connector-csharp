﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using FinnovationLabs.OpenBanking.Library.Connector.Model.Public.PaymentInitiation;
using FluentValidation;

namespace FinnovationLabs.OpenBanking.Library.Connector.Model.Validation.PaymentInitialisation
{
    public class OBWriteDomesticConsentValidator : AbstractValidator<OBWriteDomesticConsent>
    {
        public OBWriteDomesticConsentValidator()
        {
            CascadeMode = CascadeMode.Continue;
            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(x => x.OpenBankingClientProfileId)
                .Must(ValidationRules.IsNonWhitespace)
                .WithMessage($"Missing or invalid {nameof(OBWriteDomesticConsent.OpenBankingClientProfileId)}.");

            RuleFor(x => x.Data)
                .Must(ValidationRules.IsNotNull)
                .WithMessage($"The {nameof(OBWriteDomesticConsent.Data)} data is missing.");

            RuleFor(x => x.Risk)
                .Must(ValidationRules.IsNotNull)
                .WithMessage($"The {nameof(OBWriteDomesticConsent.Risk)} data is missing.");
        }
    }
}