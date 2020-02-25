﻿// Licensed to Finnovation Labs Limited under one or more agreements.
// Finnovation Labs Limited licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Net.Http.Headers;
using FinnovationLabs.OpenBanking.Library.Connector.Http;
using FluentAssertions;
using Xunit;

namespace FinnovationLabs.OpenBanking.Library.Connector.UnitTests.Http
{
    public class HttpRequestInfoExtensionsTests
    {
        [Theory]
        [InlineData("text/html")]
        [InlineData("application/pdf")]
        public void Create_ContentTypesPreserved(string contentType)
        {
            var info = new HttpRequestInfo
            {
                RequestUri = new Uri("http://tests"),
                Content = "abcdef"
            };
            info.ContentTypes.Add(contentType);

            var result = info.CreateRequestMessage();

            var resultContentTypes = result.Content.Headers.ContentType as MediaTypeWithQualityHeaderValue;

            resultContentTypes.MediaType.Should().Be(contentType);
        }

        [Theory]
        [InlineData("Chrome")]
        [InlineData("Mozilla")]
        public void Create_UserAgentPreserved(string userAgent)
        {
            var info = new HttpRequestInfo
            {
                RequestUri = new Uri("http://tests"),
                UserAgent = userAgent
            };

            var result = info.CreateRequestMessage();

            var resultAgents = result.Headers.UserAgent.OfType<ProductInfoHeaderValue>().Select(v => v.Product.Name);

            resultAgents.Should().BeEquivalentTo(userAgent);
        }

        [Fact]
        public void Create_EmptyContentTypesProduceDefaults()
        {
            var info = new HttpRequestInfo
            {
                RequestUri = new Uri("http://tests")
            };
            info.ContentTypes.Clear();

            var result = info.CreateRequestMessage();

            result.Headers.Accept.Should().HaveCount(2);
        }
    }
}
