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

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p4.Model
{
    /// <summary>
    /// OBWriteInternationalScheduledConsent5
    /// </summary>
    [DataContract]
    public partial class OBWriteInternationalScheduledConsent5 :  IEquatable<OBWriteInternationalScheduledConsent5>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalScheduledConsent5" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteInternationalScheduledConsent5() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalScheduledConsent5" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="risk">risk (required).</param>
        public OBWriteInternationalScheduledConsent5(OBWriteInternationalScheduledConsent5Data data = default(OBWriteInternationalScheduledConsent5Data), OBRisk1 risk = default(OBRisk1))
        {
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for OBWriteInternationalScheduledConsent5 and cannot be null");
            // to ensure "risk" is required (not null)
            this.Risk = risk ?? throw new ArgumentNullException("risk is a required property for OBWriteInternationalScheduledConsent5 and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public OBWriteInternationalScheduledConsent5Data Data { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name="Risk", EmitDefaultValue=false)]
        public OBRisk1 Risk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteInternationalScheduledConsent5 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
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
            return this.Equals(input as OBWriteInternationalScheduledConsent5);
        }

        /// <summary>
        /// Returns true if OBWriteInternationalScheduledConsent5 instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteInternationalScheduledConsent5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteInternationalScheduledConsent5 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Risk == input.Risk ||
                    (this.Risk != null &&
                    this.Risk.Equals(input.Risk))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Risk != null)
                    hashCode = hashCode * 59 + this.Risk.GetHashCode();
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