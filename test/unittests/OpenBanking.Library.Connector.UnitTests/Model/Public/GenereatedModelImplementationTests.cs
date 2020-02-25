﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace FinnovationLabs.OpenBanking.Library.Connector.UnitTests.Model.Public
{
    public class GenereatedModelImplementationTests
    {
        [Fact]
        public void AllObjectsAreEqualToThemselves()
        {
            var modelTypes = TypeExtensions.GetPublicModelTypes().Select(t => t.GetConstructor()).Where(t => t != null);

            foreach (var (type, ctor) in modelTypes)
            {
                var instance = ctor.CreateInstanceSafe();
                if (instance != null)
                {
                    var r = instance.Equals(instance);
                }
            }
        }

        [Fact]
        public void AllObjectsHaveToString()
        {
            var modelTypes = TypeExtensions.GetPublicModelTypes().Select(t => t.GetConstructor()).Where(t => t != null);

            foreach (var (type, ctor) in modelTypes)
            {
                var instance = ctor.CreateInstanceSafe();
                if (instance != null)
                {
                    var r = instance.ToString();

                    r.Should().NotBeNullOrWhiteSpace();
                }
            }
        }


        [Fact]
        public void AllObjectsHaveGetHashCode()
        {
            var modelTypes = TypeExtensions.GetPublicModelTypes().Select(t => t.GetConstructor()).Where(t => t != null);

            foreach (var (type, ctor) in modelTypes)
            {
                var instance = ctor.CreateInstanceSafe();
                if (instance != null)
                {
                    var r = instance.GetHashCode();
                }
            }
        }


        [Fact]
        public void AllObjectsAreSerialisable()
        {
            var modelTypes = TypeExtensions.GetPublicModelTypes().Select(t => t.GetConstructor()).Where(t => t != null);

            foreach (var (type, ctor) in modelTypes)
            {
                var instance = ctor.CreateInstanceSafe();
                if (instance != null)
                {
                    instance = instance.PopulateRequiredFields();

                    var r = JsonConvert.SerializeObject(instance);

                    var r2 = JsonConvert.DeserializeObject(r, type);
                }
            }
        }
    }
}
