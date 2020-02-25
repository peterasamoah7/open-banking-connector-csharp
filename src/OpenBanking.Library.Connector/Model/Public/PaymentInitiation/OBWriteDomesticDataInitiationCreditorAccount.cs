using FinnovationLabs.OpenBanking.Library.Connector.Model.Converters;
using FinnovationLabs.OpenBanking.Library.Connector.ObModel.PaymentInitiation.V3p1p1.Model;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.Model.Public.PaymentInitiation
{
    /// <summary>
    ///     Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the
    ///     payment transaction.
    /// </summary>
    [OpenBankingEquivalent(typeof(OBCashAccountCreditor3), EquivalentTypeMapper = typeof(OBWriteDomesticDataInitiationCreditorAccountConverter))]
    [PersistenceEquivalent(typeof(Persistent.PaymentInitiation.OBWriteDomesticDataInitiationCreditorAccount))]
    public class OBWriteDomesticDataInitiationCreditorAccount
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OBWriteDomesticDataInitiationCreditorAccount" /> class.
        /// </summary>
        [JsonConstructor]
        public OBWriteDomesticDataInitiationCreditorAccount()
        {
        }


        /// <summary>
        ///     Name of the identification scheme, in a coded form as published in an external list.
        /// </summary>
        /// <value>Name of the identification scheme, in a coded form as published in an external list.</value>
        [JsonProperty("schemeName")]
        public string SchemeName { get; set; }

        /// <summary>
        ///     Identification assigned by an institution to identify an account. This identification is known by the account
        ///     owner.
        /// </summary>
        /// <value>
        ///     Identification assigned by an institution to identify an account. This identification is known by the account
        ///     owner.
        /// </value>
        [JsonProperty("identification")]
        public string Identification { get; set; }

        /// <summary>
        ///     The account name is the name or names of the account owner(s) represented at an account level. Note, the account
        ///     name is not the product name or the nickname of the account. OB: ASPSPs may carry out name validation for
        ///     Confirmation of Payee, but it is not mandatory.
        /// </summary>
        /// <value>
        ///     The account name is the name or names of the account owner(s) represented at an account level. Note, the account
        ///     name is not the product name or the nickname of the account. OB: ASPSPs may carry out name validation for
        ///     Confirmation of Payee, but it is not mandatory.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     This is secondary identification of the account, as assigned by the account servicing institution.  This can be
        ///     used by building societies to additionally identify accounts with a roll number (in addition to a sort code and
        ///     account number combination).
        /// </summary>
        /// <value>
        ///     This is secondary identification of the account, as assigned by the account servicing institution.  This can be
        ///     used by building societies to additionally identify accounts with a roll number (in addition to a sort code and
        ///     account number combination).
        /// </value>
        [JsonProperty("secondaryIdentification")]
        public string SecondaryIdentification { get; set; }

        
    }
}