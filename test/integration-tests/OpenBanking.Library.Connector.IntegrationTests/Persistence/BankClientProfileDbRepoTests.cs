﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Persistent;
using FinnovationLabs.OpenBanking.Library.Connector.Persistence;
using FsCheck;
using FsCheck.Xunit;
using Xunit.Abstractions;

namespace FinnovationLabs.OpenBanking.Library.Connector.IntegrationTests.Persistence
{
    public class BankClientProfileDbRepoTests: DbTest
    {
        private readonly DbEntityRepository<BankClientProfile> _repo;
        private readonly ITestOutputHelper _output;

        public BankClientProfileDbRepoTests(ITestOutputHelper output)
        {
            _repo =  new DbEntityRepository<BankClientProfile>(_dB);
            _output = output;
        }
        
        [Property(Verbose = PropertyTests.VerboseTests)]
        public Property GetAsync_ReturnsEmpty(string id)
        {
            Func<bool> rule = () =>
            {
                return _repo.GetAsync(id).Result == null;
            };

            return rule.When(id != null);
        }

        [Property(Verbose = PropertyTests.VerboseTests)]
        public Property GetAsync_KnownId_ReturnsItem(string id, BankClientProfile value)
        {
            Func<bool> rule = () =>
            {
                value.Id = id;
                var _ = _repo.SetAsync(value).GetAwaiter().GetResult();
                _repo.SaveChangesAsync().Wait();

                return _repo.GetAsync(id).Result.Id == id;
            };
            
            // Run test avoiding C null character
            if ( !(id is null) && id.Contains("\0"))
            {
                return true.ToProperty();
            } else
            {
                return rule.When(id != null && value != null);
            }
        }

        [Property(Verbose = PropertyTests.VerboseTests)]
        public Property SetAsync_KnownId_ElementReplaced(string id, BankClientProfile value,
            BankClientProfile value2)
        {
            Func<bool> rule = () =>
            {
                value.Id = id;
                value2.Id = id;

                var _ = _repo.SetAsync(value).Result;
                var __ = _repo.SetAsync(value2).Result;
                _repo.SaveChangesAsync().Wait();
                
                var item = _repo.GetAsync(id).Result;

                return item.Id == id && item.XFapiFinancialId == value2.XFapiFinancialId;
            };
            
            // Run test avoiding C null character
            if ( !(id is null) && id.Contains("\0"))
            {
                return true.ToProperty();
            } else
            {
                return rule.When(id != null && value != null && value2 != null &&
                                 value.XFapiFinancialId != value2.XFapiFinancialId);
            }
        }

        [Property(Verbose = PropertyTests.VerboseTests)]
        public Property DeleteAsync_KnownId_ReturnsItem(string id, BankClientProfile value)
        {
            Func<bool> rule = () =>
            {
                value.Id = id;
                var _ = _repo.SetAsync(value).Result;
                _repo.SaveChangesAsync().Wait();

                _repo.DeleteAsync(value).Wait();
                _repo.SaveChangesAsync().Wait();

                return _repo.GetAsync(id).Result == null;
            };

            return rule.When(id != null && value != null);
        }
    }
}
