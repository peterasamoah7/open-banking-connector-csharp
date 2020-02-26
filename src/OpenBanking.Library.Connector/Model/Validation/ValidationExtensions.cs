﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using FinnovationLabs.OpenBanking.Library.Connector.Fluent;
using FluentValidation.Results;

namespace FinnovationLabs.OpenBanking.Library.Connector.Model.Validation
{
    internal static class ValidationExtensions
    {
        public static IList<OpenBankingResponseMessage> GetOpenBankingResponses(this ValidationResult validationResult)
        {
            var result = validationResult.Errors.Select(e => new OpenBankingResponseErrorMessage(e.ErrorMessage))
                .Cast<OpenBankingResponseMessage>()
                .ToList();

            return result;
        }

        public static void RaiseErrorOnValidationError(this ValidationResult validationResult)
        {
            if (!validationResult.IsValid)
            {
                var msgs = validationResult.Errors.Select(vf => vf.ErrorMessage);
                var msg = string.Join(Environment.NewLine, msgs);

                throw new Exception(msg);
            }
        }
    }
}