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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p4.Model
{
    /// <summary>
    /// OBWriteInternationalConsent5Data
    /// </summary>
    [DataContract]
    public partial class OBWriteInternationalConsent5Data :  IEquatable<OBWriteInternationalConsent5Data>, IValidatableObject
    {
        /// <summary>
        /// Specifies to share the refund account details with PISP
        /// </summary>
        /// <value>Specifies to share the refund account details with PISP</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReadRefundAccountEnum
        {
            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 1,

            /// <summary>
            /// Enum Yes for value: Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes = 2

        }

        /// <summary>
        /// Specifies to share the refund account details with PISP
        /// </summary>
        /// <value>Specifies to share the refund account details with PISP</value>
        [DataMember(Name="ReadRefundAccount", EmitDefaultValue=false)]
        public ReadRefundAccountEnum? ReadRefundAccount { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalConsent5Data" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteInternationalConsent5Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalConsent5Data" /> class.
        /// </summary>
        /// <param name="readRefundAccount">Specifies to share the refund account details with PISP.</param>
        /// <param name="initiation">initiation (required).</param>
        /// <param name="authorisation">authorisation.</param>
        /// <param name="sCASupportData">sCASupportData.</param>
        public OBWriteInternationalConsent5Data(ReadRefundAccountEnum? readRefundAccount = default(ReadRefundAccountEnum?), OBWriteInternational3DataInitiation initiation = default(OBWriteInternational3DataInitiation), OBWriteDomesticConsent4DataAuthorisation authorisation = default(OBWriteDomesticConsent4DataAuthorisation), OBWriteDomesticConsent4DataSCASupportData sCASupportData = default(OBWriteDomesticConsent4DataSCASupportData))
        {
            // to ensure "initiation" is required (not null)
            this.Initiation = initiation ?? throw new ArgumentNullException("initiation is a required property for OBWriteInternationalConsent5Data and cannot be null");
            this.ReadRefundAccount = readRefundAccount;
            this.Authorisation = authorisation;
            this.SCASupportData = sCASupportData;
        }
        
        /// <summary>
        /// Gets or Sets Initiation
        /// </summary>
        [DataMember(Name="Initiation", EmitDefaultValue=false)]
        public OBWriteInternational3DataInitiation Initiation { get; set; }

        /// <summary>
        /// Gets or Sets Authorisation
        /// </summary>
        [DataMember(Name="Authorisation", EmitDefaultValue=false)]
        public OBWriteDomesticConsent4DataAuthorisation Authorisation { get; set; }

        /// <summary>
        /// Gets or Sets SCASupportData
        /// </summary>
        [DataMember(Name="SCASupportData", EmitDefaultValue=false)]
        public OBWriteDomesticConsent4DataSCASupportData SCASupportData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteInternationalConsent5Data {\n");
            sb.Append("  ReadRefundAccount: ").Append(ReadRefundAccount).Append("\n");
            sb.Append("  Initiation: ").Append(Initiation).Append("\n");
            sb.Append("  Authorisation: ").Append(Authorisation).Append("\n");
            sb.Append("  SCASupportData: ").Append(SCASupportData).Append("\n");
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
            return this.Equals(input as OBWriteInternationalConsent5Data);
        }

        /// <summary>
        /// Returns true if OBWriteInternationalConsent5Data instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteInternationalConsent5Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteInternationalConsent5Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReadRefundAccount == input.ReadRefundAccount ||
                    this.ReadRefundAccount.Equals(input.ReadRefundAccount)
                ) && 
                (
                    this.Initiation == input.Initiation ||
                    (this.Initiation != null &&
                    this.Initiation.Equals(input.Initiation))
                ) && 
                (
                    this.Authorisation == input.Authorisation ||
                    (this.Authorisation != null &&
                    this.Authorisation.Equals(input.Authorisation))
                ) && 
                (
                    this.SCASupportData == input.SCASupportData ||
                    (this.SCASupportData != null &&
                    this.SCASupportData.Equals(input.SCASupportData))
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
                hashCode = hashCode * 59 + this.ReadRefundAccount.GetHashCode();
                if (this.Initiation != null)
                    hashCode = hashCode * 59 + this.Initiation.GetHashCode();
                if (this.Authorisation != null)
                    hashCode = hashCode * 59 + this.Authorisation.GetHashCode();
                if (this.SCASupportData != null)
                    hashCode = hashCode * 59 + this.SCASupportData.GetHashCode();
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
            yield break;
        }
    }

}
