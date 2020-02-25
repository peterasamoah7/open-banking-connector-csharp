using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.Model.Persistent.PaymentInitiation
{
    /// <summary>
    ///     Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the
    ///     transaction.
    /// </summary>
    public class OBWriteDomesticDataInitiationDebtorAccount
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OBWriteDomesticDataInitiationDebtorAccount" /> class.
        /// </summary>
        [JsonConstructor]
        public OBWriteDomesticDataInitiationDebtorAccount()
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
        ///     The account name is the name or names of the account owner(s) represented at an account level, as displayed by the
        ///     ASPSP&#39;s online channels. Note, the account name is not the product name or the nickname of the account.
        /// </summary>
        /// <value>
        ///     The account name is the name or names of the account owner(s) represented at an account level, as displayed by
        ///     the ASPSP&#39;s online channels. Note, the account name is not the product name or the nickname of the account.
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