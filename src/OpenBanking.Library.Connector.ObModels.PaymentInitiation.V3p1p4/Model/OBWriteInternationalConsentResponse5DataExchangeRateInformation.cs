/* 
 * Payment Initiation API
 *
 * OpenAPI for Payment Initiation API Specification
 *
 * The version of the OpenAPI document: v3.1.4
 * Contact: ServiceDesk@openbanking.org.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p4.Model
{
    /// <summary>
    /// Further detailed information on the exchange rate that has been used in the payment transaction.
    /// </summary>
    [DataContract]
    public partial class OBWriteInternationalConsentResponse5DataExchangeRateInformation :  IEquatable<OBWriteInternationalConsentResponse5DataExchangeRateInformation>, IValidatableObject
    {
        /// <summary>
        /// Specifies the type used to complete the currency exchange.
        /// </summary>
        /// <value>Specifies the type used to complete the currency exchange.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RateTypeEnum
        {
            /// <summary>
            /// Enum Actual for value: Actual
            /// </summary>
            [EnumMember(Value = "Actual")]
            Actual = 1,

            /// <summary>
            /// Enum Agreed for value: Agreed
            /// </summary>
            [EnumMember(Value = "Agreed")]
            Agreed = 2,

            /// <summary>
            /// Enum Indicative for value: Indicative
            /// </summary>
            [EnumMember(Value = "Indicative")]
            Indicative = 3

        }

        /// <summary>
        /// Specifies the type used to complete the currency exchange.
        /// </summary>
        /// <value>Specifies the type used to complete the currency exchange.</value>
        [DataMember(Name="RateType", EmitDefaultValue=false)]
        public RateTypeEnum RateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalConsentResponse5DataExchangeRateInformation" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteInternationalConsentResponse5DataExchangeRateInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalConsentResponse5DataExchangeRateInformation" /> class.
        /// </summary>
        /// <param name="unitCurrency">Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP &#x3D; xxxCUR, the unit currency is GBP. (required).</param>
        /// <param name="exchangeRate">The factor used for conversion of an amount from one currency to another. This reflects the price at which one currency was bought with another currency. (required).</param>
        /// <param name="rateType">Specifies the type used to complete the currency exchange. (required).</param>
        /// <param name="contractIdentification">Unique and unambiguous reference to the foreign exchange contract agreed between the initiating party/creditor and the debtor agent..</param>
        /// <param name="expirationDateTime">Specified date and time the exchange rate agreement will expire.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        public OBWriteInternationalConsentResponse5DataExchangeRateInformation(string unitCurrency = default(string), decimal exchangeRate = default(decimal), RateTypeEnum rateType = default(RateTypeEnum), string contractIdentification = default(string), DateTimeOffset expirationDateTime = default(DateTimeOffset))
        {
            // to ensure "unitCurrency" is required (not null)
            this.UnitCurrency = unitCurrency ?? throw new ArgumentNullException("unitCurrency is a required property for OBWriteInternationalConsentResponse5DataExchangeRateInformation and cannot be null");
            this.ExchangeRate = exchangeRate;
            this.RateType = rateType;
            this.ContractIdentification = contractIdentification;
            this.ExpirationDateTime = expirationDateTime;
        }
        
        /// <summary>
        /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP &#x3D; xxxCUR, the unit currency is GBP.
        /// </summary>
        /// <value>Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP &#x3D; xxxCUR, the unit currency is GBP.</value>
        [DataMember(Name="UnitCurrency", EmitDefaultValue=false)]
        public string UnitCurrency { get; set; }

        /// <summary>
        /// The factor used for conversion of an amount from one currency to another. This reflects the price at which one currency was bought with another currency.
        /// </summary>
        /// <value>The factor used for conversion of an amount from one currency to another. This reflects the price at which one currency was bought with another currency.</value>
        [DataMember(Name="ExchangeRate", EmitDefaultValue=false)]
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// Unique and unambiguous reference to the foreign exchange contract agreed between the initiating party/creditor and the debtor agent.
        /// </summary>
        /// <value>Unique and unambiguous reference to the foreign exchange contract agreed between the initiating party/creditor and the debtor agent.</value>
        [DataMember(Name="ContractIdentification", EmitDefaultValue=false)]
        public string ContractIdentification { get; set; }

        /// <summary>
        /// Specified date and time the exchange rate agreement will expire.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Specified date and time the exchange rate agreement will expire.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="ExpirationDateTime", EmitDefaultValue=false)]
        public DateTimeOffset ExpirationDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteInternationalConsentResponse5DataExchangeRateInformation {\n");
            sb.Append("  UnitCurrency: ").Append(UnitCurrency).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  ContractIdentification: ").Append(ContractIdentification).Append("\n");
            sb.Append("  ExpirationDateTime: ").Append(ExpirationDateTime).Append("\n");
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
            return this.Equals(input as OBWriteInternationalConsentResponse5DataExchangeRateInformation);
        }

        /// <summary>
        /// Returns true if OBWriteInternationalConsentResponse5DataExchangeRateInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteInternationalConsentResponse5DataExchangeRateInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteInternationalConsentResponse5DataExchangeRateInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitCurrency == input.UnitCurrency ||
                    (this.UnitCurrency != null &&
                    this.UnitCurrency.Equals(input.UnitCurrency))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    this.ExchangeRate.Equals(input.ExchangeRate)
                ) && 
                (
                    this.RateType == input.RateType ||
                    this.RateType.Equals(input.RateType)
                ) && 
                (
                    this.ContractIdentification == input.ContractIdentification ||
                    (this.ContractIdentification != null &&
                    this.ContractIdentification.Equals(input.ContractIdentification))
                ) && 
                (
                    this.ExpirationDateTime == input.ExpirationDateTime ||
                    (this.ExpirationDateTime != null &&
                    this.ExpirationDateTime.Equals(input.ExpirationDateTime))
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
                if (this.UnitCurrency != null)
                    hashCode = hashCode * 59 + this.UnitCurrency.GetHashCode();
                hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                hashCode = hashCode * 59 + this.RateType.GetHashCode();
                if (this.ContractIdentification != null)
                    hashCode = hashCode * 59 + this.ContractIdentification.GetHashCode();
                if (this.ExpirationDateTime != null)
                    hashCode = hashCode * 59 + this.ExpirationDateTime.GetHashCode();
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
            // UnitCurrency (string) pattern
            Regex regexUnitCurrency = new Regex(@"^[A-Z]{3,3}$", RegexOptions.CultureInvariant);
            if (false == regexUnitCurrency.Match(this.UnitCurrency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitCurrency, must match a pattern of " + regexUnitCurrency, new [] { "UnitCurrency" });
            }

            // ContractIdentification (string) maxLength
            if(this.ContractIdentification != null && this.ContractIdentification.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractIdentification, length must be less than 256.", new [] { "ContractIdentification" });
            }

            // ContractIdentification (string) minLength
            if(this.ContractIdentification != null && this.ContractIdentification.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractIdentification, length must be greater than 1.", new [] { "ContractIdentification" });
            }

            yield break;
        }
    }

}
