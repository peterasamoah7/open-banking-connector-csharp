/* 
 * Payment Initiation API
 *
 * Swagger for Payment Initiation API Specification
 *
 * OpenAPI spec version: v3.1.1
 * Contact: ServiceDesk@openbanking.org.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModel.PaymentInitiation.V3p1p1.Model
{
    /// <summary>
    /// The amount of the first Standing Order
    /// </summary>
    [DataContract]
    public partial class OBDomesticStandingOrder3FirstPaymentAmount :  IEquatable<OBDomesticStandingOrder3FirstPaymentAmount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBDomesticStandingOrder3FirstPaymentAmount" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBDomesticStandingOrder3FirstPaymentAmount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBDomesticStandingOrder3FirstPaymentAmount" /> class.
        /// </summary>
        /// <param name="amount">A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217. (required).</param>
        /// <param name="currency">currency (required).</param>
        public OBDomesticStandingOrder3FirstPaymentAmount(string amount = default(string), string currency = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for OBDomesticStandingOrder3FirstPaymentAmount and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for OBDomesticStandingOrder3FirstPaymentAmount and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
        }
        
        /// <summary>
        /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.
        /// </summary>
        /// <value>A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBDomesticStandingOrder3FirstPaymentAmount {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OBDomesticStandingOrder3FirstPaymentAmount);
        }

        /// <summary>
        /// Returns true if OBDomesticStandingOrder3FirstPaymentAmount instances are equal
        /// </summary>
        /// <param name="input">Instance of OBDomesticStandingOrder3FirstPaymentAmount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBDomesticStandingOrder3FirstPaymentAmount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^\\d{1,13}\\.\\d{1,5}$", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
            }

            // Currency (string) pattern
            Regex regexCurrency = new Regex(@"^[A-Z]{3,3}$", RegexOptions.CultureInvariant);
            if (false == regexCurrency.Match(this.Currency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, must match a pattern of " + regexCurrency, new [] { "Currency" });
            }

            yield break;
        }
    }

}
