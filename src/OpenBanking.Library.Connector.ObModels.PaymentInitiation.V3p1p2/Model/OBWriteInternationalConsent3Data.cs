/* 
 * Payment Initiation API
 *
 * OpenAPI for Payment Initiation API Specification
 *
 * The version of the OpenAPI document: v3.1.2
 * Contact: ServiceDesk@openbanking.org.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p2.Model
{
    /// <summary>
    /// OBWriteInternationalConsent3Data
    /// </summary>
    [DataContract]
    public partial class OBWriteInternationalConsent3Data :  IEquatable<OBWriteInternationalConsent3Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalConsent3Data" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteInternationalConsent3Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalConsent3Data" /> class.
        /// </summary>
        /// <param name="initiation">initiation (required).</param>
        /// <param name="authorisation">authorisation.</param>
        /// <param name="sCASupportData">sCASupportData.</param>
        public OBWriteInternationalConsent3Data(OBWriteInternational2DataInitiation initiation = default(OBWriteInternational2DataInitiation), OBWriteDomesticConsent3DataAuthorisation authorisation = default(OBWriteDomesticConsent3DataAuthorisation), OBWriteDomesticConsent3DataSCASupportData sCASupportData = default(OBWriteDomesticConsent3DataSCASupportData))
        {
            // to ensure "initiation" is required (not null)
            this.Initiation = initiation ?? throw new ArgumentNullException("initiation is a required property for OBWriteInternationalConsent3Data and cannot be null");
            this.Authorisation = authorisation;
            this.SCASupportData = sCASupportData;
        }
        
        /// <summary>
        /// Gets or Sets Initiation
        /// </summary>
        [DataMember(Name="Initiation", EmitDefaultValue=false)]
        public OBWriteInternational2DataInitiation Initiation { get; set; }

        /// <summary>
        /// Gets or Sets Authorisation
        /// </summary>
        [DataMember(Name="Authorisation", EmitDefaultValue=false)]
        public OBWriteDomesticConsent3DataAuthorisation Authorisation { get; set; }

        /// <summary>
        /// Gets or Sets SCASupportData
        /// </summary>
        [DataMember(Name="SCASupportData", EmitDefaultValue=false)]
        public OBWriteDomesticConsent3DataSCASupportData SCASupportData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteInternationalConsent3Data {\n");
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
            return this.Equals(input as OBWriteInternationalConsent3Data);
        }

        /// <summary>
        /// Returns true if OBWriteInternationalConsent3Data instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteInternationalConsent3Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteInternationalConsent3Data input)
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
