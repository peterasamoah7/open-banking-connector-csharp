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
    /// OBWriteDataDomesticScheduledConsent2
    /// </summary>
    [DataContract]
    public partial class OBWriteDataDomesticScheduledConsent2 :  IEquatable<OBWriteDataDomesticScheduledConsent2>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="Permission", EmitDefaultValue=false)]
        public OBExternalPermissions2Code Permission { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDataDomesticScheduledConsent2" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteDataDomesticScheduledConsent2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDataDomesticScheduledConsent2" /> class.
        /// </summary>
        /// <param name="permission">permission (required).</param>
        /// <param name="initiation">initiation (required).</param>
        /// <param name="authorisation">authorisation.</param>
        public OBWriteDataDomesticScheduledConsent2(OBExternalPermissions2Code permission = default(OBExternalPermissions2Code), OBDomesticScheduled2 initiation = default(OBDomesticScheduled2), OBAuthorisation1 authorisation = default(OBAuthorisation1))
        {
            this.Permission = permission;
            // to ensure "initiation" is required (not null)
            this.Initiation = initiation ?? throw new ArgumentNullException("initiation is a required property for OBWriteDataDomesticScheduledConsent2 and cannot be null");
            this.Authorisation = authorisation;
        }
        
        /// <summary>
        /// Gets or Sets Initiation
        /// </summary>
        [DataMember(Name="Initiation", EmitDefaultValue=false)]
        public OBDomesticScheduled2 Initiation { get; set; }

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
            sb.Append("class OBWriteDataDomesticScheduledConsent2 {\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
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
            return this.Equals(input as OBWriteDataDomesticScheduledConsent2);
        }

        /// <summary>
        /// Returns true if OBWriteDataDomesticScheduledConsent2 instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteDataDomesticScheduledConsent2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteDataDomesticScheduledConsent2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permission == input.Permission ||
                    this.Permission.Equals(input.Permission)
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
                hashCode = hashCode * 59 + this.Permission.GetHashCode();
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
