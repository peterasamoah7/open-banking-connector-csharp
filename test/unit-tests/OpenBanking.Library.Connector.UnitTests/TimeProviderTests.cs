﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using FsCheck.Xunit;

namespace FinnovationLabs.OpenBanking.Library.Connector.UnitTests
{
    public class TimeProviderTests
    {
        [Property(Verbose = PropertyTests.VerboseTests)]
        public bool GetUtcNow_ResultIsWithinBounds()
        {
            var now = DateTimeOffset.UtcNow;

            var result = new TimeProvider().GetUtcNow();

            return (result >= now) & (result <= now.AddSeconds(1));
        }
    }
}
