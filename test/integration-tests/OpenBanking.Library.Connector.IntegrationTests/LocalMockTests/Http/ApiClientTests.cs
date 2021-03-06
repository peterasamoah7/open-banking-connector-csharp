﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FinnovationLabs.OpenBanking.Library.Connector.Http;
using FinnovationLabs.OpenBanking.Library.Connector.Instrumentation;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace FinnovationLabs.OpenBanking.Library.Connector.IntegrationTests.LocalMockTests.Http
{
    public class ApiClientTests
    {
        [Theory]
        [InlineData("https://www.google.com/")]
        public async Task ApiClient_SendAsync_Success(string url)
        {
            var b = new HttpRequestBuilder()
                .SetMethod(HttpMethod.Get)
                .SetUri(url);

            var req = b.Create();

            using (var http = new HttpClient())
            {
                var api = new ApiClient(Substitute.For<IInstrumentationClient>(), http);

                var r = await api.SendAsync(req);

                r.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }

        [Theory]
        [InlineData("https://github.com/a5b2a8a9-1220-4aa4-aa83-0036a7bd1e69")]
        public async Task ApiClient_SendAsync_NotFound(string url)
        {
            var b = new HttpRequestBuilder()
                .SetMethod(HttpMethod.Get)
                .SetUri(url);

            var req = b.Create();

            using (var http = new HttpClient())
            {
                var api = new ApiClient(Substitute.For<IInstrumentationClient>(), http);

                var r = await api.SendAsync(req);

                r.StatusCode.Should().Be(HttpStatusCode.NotFound);
            }
        }

        [Theory]
        [InlineData("https://a5b2a8a9-1220-4aa4-aa83-0036a7bd1e69.com/stuff")]
        public void ApiClient_SendAsync_Failure(string url)
        {
            var req = new HttpRequestBuilder()
                .SetMethod(HttpMethod.Get)
                .SetUri(url)
                .Create();

            using (var http = new HttpClient())
            {
                Func<Task> a = async () =>
                {
                    var api = new ApiClient(Substitute.For<IInstrumentationClient>(), http);
                    var r = await api.SendAsync(req);
                };

                a.Should().Throw<HttpRequestException>();
            }
        }
    }
}
