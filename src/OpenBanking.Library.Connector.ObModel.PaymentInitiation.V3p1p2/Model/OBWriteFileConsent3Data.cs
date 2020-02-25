/* 
 * Payment Initiation API
 *
 * Swagger for Payment Initiation API Specification
 *
 * OpenAPI spec version: v3.1.2-RC1
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

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModel.PaymentInitiation.V3p1p2.Model
{
    /// <summary>
    /// OBWriteFileConsent3Data
    /// </summary>
    [DataContract]
    public partial class OBWriteFileConsent3Data :  IEquatable<OBWriteFileConsent3Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteFileConsent3Data" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteFileConsent3Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteFileConsent3Data" /> class.
        /// </summary>
        /// <param name="sCASupportData">sCASupportData.</param>
        /// <param name="authorisation">authorisation.</param>
        /// <param name="initiation">initiation (required).</param>
        public OBWriteFileConsent3Data(OBWriteFileConsent3DataSCASupportData sCASupportData = default(OBWriteFileConsent3DataSCASupportData), OBWriteFileConsent3DataAuthorisation authorisation = default(OBWriteFileConsent3DataAuthorisation), OBWriteFile2DataInitiation initiation = default(OBWriteFile2DataInitiation))
        {
            // to ensure "initiation" is required (not null)
            if (initiation == null)
            {
                throw new InvalidDataException("initiation is a required property for OBWriteFileConsent3Data and cannot be null");
            }
            else
            {
                this.Initiation = initiation;
            }
            this.SCASupportData = sCASupportData;
            this.Authorisation = authorisation;
        }
        
        /// <summary>
        /// Gets or Sets SCASupportData
        /// </summary>
        [DataMember(Name="SCASupportData", EmitDefaultValue=false)]
        public OBWriteFileConsent3DataSCASupportData SCASupportData { get; set; }

        /// <summary>
        /// Gets or Sets Authorisation
        /// </summary>
        [DataMember(Name="Authorisation", EmitDefaultValue=false)]
        public OBWriteFileConsent3DataAuthorisation Authorisation { get; set; }

        /// <summary>
        /// Gets or Sets Initiation
        /// </summary>
        [DataMember(Name="Initiation", EmitDefaultValue=false)]
        public OBWriteFile2DataInitiation Initiation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteFileConsent3Data {\n");
            sb.Append("  SCASupportData: ").Append(SCASupportData).Append("\n");
            sb.Append("  Authorisation: ").Append(Authorisation).Append("\n");
            sb.Append("  Initiation: ").Append(Initiation).Append("\n");
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
            return this.Equals(input as OBWriteFileConsent3Data);
        }

        /// <summary>
        /// Returns true if OBWriteFileConsent3Data instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteFileConsent3Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteFileConsent3Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SCASupportData == input.SCASupportData ||
                    (this.SCASupportData != null &&
                    this.SCASupportData.Equals(input.SCASupportData))
                ) && 
                (
                    this.Authorisation == input.Authorisation ||
                    (this.Authorisation != null &&
                    this.Authorisation.Equals(input.Authorisation))
                ) && 
                (
                    this.Initiation == input.Initiation ||
                    (this.Initiation != null &&
                    this.Initiation.Equals(input.Initiation))
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
                if (this.SCASupportData != null)
                    hashCode = hashCode * 59 + this.SCASupportData.GetHashCode();
                if (this.Authorisation != null)
                    hashCode = hashCode * 59 + this.Authorisation.GetHashCode();
                if (this.Initiation != null)
                    hashCode = hashCode * 59 + this.Initiation.GetHashCode();
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
