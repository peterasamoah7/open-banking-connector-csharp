﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.RegularExpressions;
using FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p4.Model;
using FluentValidation;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Validation.PaymentInitialisation
{
    public class
        OBWriteDomesticDataInitiationInstructedAmountValidator : AbstractValidator<
            OBWriteDomestic2DataInitiationInstructedAmount>
    {
        private static readonly Regex RegexAmount = new Regex(
            pattern: @"^\\d{1,13}\\.\\d{1,5}$",
            options: RegexOptions.CultureInvariant);

        private static readonly Regex RegexCurrency = new Regex(
            pattern: @"^[A-Z]{3,3}$",
            options: RegexOptions.CultureInvariant);

        public OBWriteDomesticDataInitiationInstructedAmountValidator()
        {
            CascadeMode = CascadeMode.Continue;
            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(x => x.Amount)
                .Must((x, y, z) => ValidationRules.IsMatch(arg1: x, arg2: y, arg3: z, regex: RegexAmount))
                .WithMessage($"Invalid value for Amount, must match a pattern of {RegexAmount}");

            RuleFor(x => x.Currency)
                .Must((x, y, z) => ValidationRules.IsMatch(arg1: x, arg2: y, arg3: z, regex: RegexCurrency))
                .WithMessage($"Invalid value for Amount, must match a pattern of {RegexCurrency}");
        }
    }
}
