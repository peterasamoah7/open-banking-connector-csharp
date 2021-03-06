/* 
 * Payment Initiation API
 *
 * OpenAPI for Payment Initiation API Specification
 *
 * The version of the OpenAPI document: v3.1.1
 * Contact: ServiceDesk@openbanking.org.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p1.Model
{
    /// <summary>
    /// OBWriteDataInternationalConsent2
    /// </summary>
    [DataContract]
    public partial class OBWriteDataInternationalConsent2 :  IEquatable<OBWriteDataInternationalConsent2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDataInternationalConsent2" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteDataInternationalConsent2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDataInternationalConsent2" /> class.
        /// </summary>
        /// <param name="initiation">initiation (required).</param>
        /// <param name="authorisation">authorisation.</param>
        public OBWriteDataInternationalConsent2(OBInternational2 initiation = default(OBInternational2), OBAuthorisation1 authorisation = default(OBAuthorisation1))
        {
            // to ensure "initiation" is required (not null)
            this.Initiation = initiation ?? throw new ArgumentNullException("initiation is a required property for OBWriteDataInternationalConsent2 and cannot be null");
            this.Authorisation = authorisation;
        }
        
        /// <summary>
        /// Gets or Sets Initiation
        /// </summary>
        [DataMember(Name="Initiation", EmitDefaultValue=false)]
        public OBInternational2 Initiation { get; set; }

        /// <summary>
        /// Gets or Sets Authorisation
        /// </summary>
        [DataMember(Name="Authorisation", EmitDefaultValue=false)]
        public OBAuthorisation1 Authorisation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteDataInternationalConsent2 {\n");
            sb.Append("  Initiation: ").Append(Initiation).Append("\n");
            sb.Append("  Authorisation: ").Append(Authorisation).Append("\n");
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
            return this.Equals(input as OBWriteDataInternationalConsent2);
        }

        /// <summary>
        /// Returns true if OBWriteDataInternationalConsent2 instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteDataInternationalConsent2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteDataInternationalConsent2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Initiation == input.Initiation ||
                    (this.Initiation != null &&
                    this.Initiation.Equals(input.Initiation))
                ) && 
                (
                    this.Authorisation == input.Authorisation ||
                    (this.Authorisation != null &&
                    this.Authorisation.Equals(input.Authorisation))
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
                if (this.Initiation != null)
                    hashCode = hashCode * 59 + this.Initiation.GetHashCode();
                if (this.Authorisation != null)
                    hashCode = hashCode * 59 + this.Authorisation.GetHashCode();
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
