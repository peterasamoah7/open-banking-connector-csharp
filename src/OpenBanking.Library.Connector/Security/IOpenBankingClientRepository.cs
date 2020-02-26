﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FinnovationLabs.OpenBanking.Library.Connector.Model.Persistent;

namespace FinnovationLabs.OpenBanking.Library.Connector.Security
{
    public interface IOpenBankingClientRepository
    {
        Task<OpenBankingClient> GetAsync(string id);

        Task<IQueryable<OpenBankingClient>> GetAsync(Expression<Func<OpenBankingClient, bool>> predicate);

        Task<OpenBankingClient> SetAsync(OpenBankingClient profile);

        Task<bool> DeleteAsync(string id);

        Task<IList<string>> GetIdsAsync();
    }
}