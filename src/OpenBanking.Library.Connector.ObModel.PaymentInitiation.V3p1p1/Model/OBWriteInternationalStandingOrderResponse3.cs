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
    /// OBWriteInternationalStandingOrderResponse3
    /// </summary>
    [DataContract]
    public partial class OBWriteInternationalStandingOrderResponse3 :  IEquatable<OBWriteInternationalStandingOrderResponse3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalStandingOrderResponse3" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteInternationalStandingOrderResponse3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalStandingOrderResponse3" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="links">links (required).</param>
        /// <param name="meta">meta (required).</param>
        public OBWriteInternationalStandingOrderResponse3(OBWriteDataInternationalStandingOrderResponse3 data = default(OBWriteDataInternationalStandingOrderResponse3), Links links = default(Links), Meta meta = default(Meta))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for OBWriteInternationalStandingOrderResponse3 and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new InvalidDataException("links is a required property for OBWriteInternationalStandingOrderResponse3 and cannot be null");
            }
            else
            {
                this.Links = links;
            }
            // to ensure "meta" is required (not null)
            if (meta == null)
            {
                throw new InvalidDataException("meta is a required property for OBWriteInternationalStandingOrderResponse3 and cannot be null");
            }
            else
            {
                this.Meta = meta;
            }
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public OBWriteDataInternationalStandingOrderResponse3 Data { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public Links Links { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="Meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteInternationalStandingOrderResponse3 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as OBWriteInternationalStandingOrderResponse3);
        }

        /// <summary>
        /// Returns true if OBWriteInternationalStandingOrderResponse3 instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteInternationalStandingOrderResponse3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteInternationalStandingOrderResponse3 input)
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
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
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
