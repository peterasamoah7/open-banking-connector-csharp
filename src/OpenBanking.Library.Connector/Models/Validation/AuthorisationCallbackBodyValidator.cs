﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using FinnovationLabs.OpenBanking.Library.Connector.Models.Public;
using FluentValidation;

namespace FinnovationLabs.OpenBanking.Library.Connector.Models.Validation
{
    public class AuthorisationCallbackBodyValidator : AbstractValidator<AuthorisationCallbackInfo>
    {
        public AuthorisationCallbackBodyValidator()
        {
            CascadeMode = CascadeMode.Continue;
            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(x => x.AuthorisationCode)
                .Must(ValidationRules.IsNotNullOrEmpty)
                .WithMessage($"Missing or invalid {nameof(AuthorisationCallbackInfo.AuthorisationCode)}.");

            RuleFor(x => x.IdToken)
                .Must(ValidationRules.IsNotNullOrEmpty)
                .WithMessage($"Missing or invalid {nameof(AuthorisationCallbackInfo.IdToken)}.");

            RuleFor(x => x.State)
                .Must(ValidationRules.IsNotNullOrEmpty)
                .WithMessage($"Missing or invalid {nameof(AuthorisationCallbackInfo.State)}.");
        }
    }
}