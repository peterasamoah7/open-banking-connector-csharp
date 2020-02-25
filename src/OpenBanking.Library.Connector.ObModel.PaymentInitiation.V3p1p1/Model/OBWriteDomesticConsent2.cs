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
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModel.PaymentInitiation.V3p1p1.Model
{
    /// <summary>
    /// OBWriteDomesticConsent2
    /// </summary>
    [DataContract]
    public partial class OBWriteDomesticConsent2 :  IEquatable<OBWriteDomesticConsent2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDomesticConsent2" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteDomesticConsent2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDomesticConsent2" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="risk">risk (required).</param>
        public OBWriteDomesticConsent2(OBWriteDataDomesticConsent2 data = default(OBWriteDataDomesticConsent2), OBRisk1 risk = default(OBRisk1))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for OBWriteDomesticConsent2 and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            // to ensure "risk" is required (not null)
            if (risk == null)
            {
                throw new InvalidDataException("risk is a required property for OBWriteDomesticConsent2 and cannot be null");
            }
            else
            {
                this.Risk = risk;
            }
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public OBWriteDataDomesticConsent2 Data { get; set; }

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
            sb.Append("class OBWriteDomesticConsent2 {\n");
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
            return this.Equals(input as OBWriteDomesticConsent2);
        }

        /// <summary>
        /// Returns true if OBWriteDomesticConsent2 instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteDomesticConsent2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteDomesticConsent2 input)
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
