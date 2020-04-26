﻿using FinnovationLabs.OpenBanking.Library.Connector.Models.Fluent;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Fluent.PaymentInitiation;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Public.PaymentInitiation;
using FluentAssertions;
using System;
using FinnovationLabs.OpenBanking.Library.Connector.Models.Public;
using System.Web;

namespace FinnovationLabs.OpenBanking.Library.Connector.IntegrationTests.WireMockTests.Payments
{
    
    public class MockPaymentsTests
    {
        private readonly IMockPaymentData _mockData;
        private readonly IMockPaymentServer _mockPaymentsServer;

        public MockPaymentsTests(IMockPaymentData mockData, IMockPaymentServer mockPaymentsServer)
        {
            _mockData = mockData;
            _mockPaymentsServer = mockPaymentsServer; 
        }

        public void RunMockPaymentTest()
        {
            var requestBuilder = _mockData.CreateMockRequestBuilder();

            var softwareStatementProfileResp = requestBuilder.SoftwareStatementProfile()
                .Id("0")
                .SoftwareStatement("header.ewogICJzb2Z0d2FyZV9pZCI6ICJpZCIsCiAgInNvZnR3YXJlX2NsaWVudF9pZCI6ICJjbGllbnRfaWQiLAogICJzb2Z0d2FyZV9jbGllbnRfbmFtZSI6ICJUUFAgQ2xpZW50IiwKICAic29mdHdhcmVfY2xpZW50X2Rlc2NyaXB0aW9uIjogIkNsaWVudCBkZXNjcmlwdGlvbiIsCiAgInNvZnR3YXJlX3ZlcnNpb24iOiAxLAogICJzb2Z0d2FyZV9jbGllbnRfdXJpIjogImh0dHBzOi8vZXhhbXBsZS5jb20iLAogICJzb2Z0d2FyZV9yZWRpcmVjdF91cmlzIjogWwogICAgImh0dHBzOi8vZXhhbXBsZS5jb20iCiAgXSwKICAic29mdHdhcmVfcm9sZXMiOiBbCiAgICAiQUlTUCIsCiAgICAiUElTUCIsCiAgICAiQ0JQSUkiCiAgXSwKICAib3JnX2lkIjogIm9yZ19pZCIsCiAgIm9yZ19uYW1lIjogIk9yZyBOYW1lIiwKICAic29mdHdhcmVfb25fYmVoYWxmX29mX29yZyI6ICJPcmcgTmFtZSIKfQ==.signature")
                .SigningKeyInfo("signingkeyid", _mockData.GetMockPrivateKey(), _mockData.GetMockCertificate())
                .TransportKeyInfo(_mockData.GetMockPrivateKey(), _mockData.GetMockCertificate())
                .DefaultFragmentRedirectUrl("http://redirecturl.com")
                .SubmitAsync().Result;

            softwareStatementProfileResp.Messages.Should().BeEmpty();
            softwareStatementProfileResp.Data.Should().NotBeNull();
            softwareStatementProfileResp.Data.Id.Should().NotBeNullOrWhiteSpace();

            _mockPaymentsServer.SetUpOpenIdMock();
            _mockPaymentsServer.SetupRegistrationMock();

            var bankClientProfileResp = requestBuilder.BankClientProfile()
                .Id("MyBankClientProfileId")
                .SoftwareStatementProfileId(softwareStatementProfileResp.Data.Id)
                .IssuerUrl(new Uri(MockRoutes.Url))
                .XFapiFinancialId(_mockData.GetFapiHeader())
                .BankClientRegistrationClaimsOverrides(new Models.Public.BankClientRegistrationClaimsOverrides())
                .SubmitAsync().Result;

            bankClientProfileResp.Should().NotBeNull();
            bankClientProfileResp.Messages.Should().BeEmpty();
            bankClientProfileResp.Data.Should().NotBeNull();
         
            var paymentInitiationApiProfileResp = requestBuilder.PaymentInitiationApiProfile()
               .Id("NewPaymentInitiationProfile")
               .BankClientProfileId(bankClientProfileResp.Data.Id)
               .PaymentInitiationApiInfo(Models.Public.PaymentInitiation.ApiVersion.V3P1P2, MockRoutes.Url)
               .SubmitAsync().Result;

            paymentInitiationApiProfileResp.Should().NotBeNull();
            paymentInitiationApiProfileResp.Messages.Should().BeEmpty();
            paymentInitiationApiProfileResp.Data.Should().NotBeNull();

            _mockPaymentsServer.SetupTokenEndpointMock();
            _mockPaymentsServer.SetupPaymentEndpointMock();

            var consentResp = requestBuilder.DomesticPaymentConsent(paymentInitiationApiProfileResp.Data.Id)
                .Merchant(null, null, PaymentContextCode.EcommerceGoods)
                .CreditorAccount("BE56456394728288", "IBAN", "ACME DIY", "secondary-identif")
                .DeliveryAddress(new OBRiskDeliveryAddress
                {
                    BuildingNumber = "42",
                    StreetName = "Oxford Street",
                    TownName = "London",
                    Country = "UK",
                    PostCode = "SW1 1AA"
                })
                .Amount("GBP", 50)
                .InstructionIdentification("instr-identification")
                .EndToEndIdentification("e2e-identification")
                .Remittance("Tools", "Tools")
                .SubmitAsync().Result;

            consentResp.Should().NotBeNull();
            consentResp.Messages.Should().BeEmpty();
            consentResp.Data.Should().NotBeNull();

            var query = HttpUtility.ParseQueryString(new Uri(consentResp.Data.AuthUrl).Query);

            query["redirect_uri"].Should().Be("http://redirecturl.com");
            query["scope"].Should().Contain("openid payments");
            query["response_type"].Should().Contain("code id_token");
            query["client_id"].Should().Be(_mockData.GetClientId());
            query["request"].Should().NotBeNull();
            query["nonce"].Should().NotBeNull();
            query["state"].Should().NotBeNull();

            _mockPaymentsServer.SetUpAuthEndpoint();

            // Call Fluent method to pass auth code and state (set up mock bank token endpoint)
            var authCallbackDataResp = requestBuilder.AuthorisationCallbackData()
                .ResponseMode("fragment")
                .Response(new AuthorisationCallbackPayload(_mockData.GetAccessToken(), query["state"])
                {
                    Nonce = query["nonce"]
                })
                .SubmitAsync().Result;

            authCallbackDataResp.Should().NotBeNull();
            authCallbackDataResp.Messages.Should().BeEmpty();
            authCallbackDataResp.Data.Should().NotBeNull();

            _mockPaymentsServer.SetUpOBDomesticResponseEndpoint(); 

            // Call Fluent method to make payment (set up mock bank payment endpoint)
            var paymentResp = requestBuilder.DomesticPayment()
                .ConsentId(consentResp.Data.ConsentId)
                .SubmitAsync().Result;

            paymentResp.Should().NotBeNull();
            paymentResp.Messages.Should().BeEmpty();
            paymentResp.Data.Should().NotBeNull();

            // All done!
        }
    }
}
