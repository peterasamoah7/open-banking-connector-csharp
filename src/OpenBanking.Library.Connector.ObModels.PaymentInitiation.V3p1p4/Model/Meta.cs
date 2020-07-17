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
    /// Meta Data relevant to the payload
    /// </summary>
    [TargetApiEquivalent(typeof(ObModels.PaymentInitiation.V3p1p1.Model.Meta))]
    [SourceApiEquivalent(typeof(ObModels.PaymentInitiation.V3p1p1.Model.Meta))]
    [SourceApiEquivalent(typeof(ObModels.PaymentInitiation.V3p1p2.Model.Meta))]
    [TargetApiEquivalent(typeof(ObModels.PaymentInitiation.V3p1p2.Model.Meta))]
    [DataContract]
    public partial class Meta :  IEquatable<Meta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="firstAvailableDateTime">All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        /// <param name="lastAvailableDateTime">All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        public Meta(int totalPages = default(int), DateTimeOffset firstAvailableDateTime = default(DateTimeOffset), DateTimeOffset lastAvailableDateTime = default(DateTimeOffset))
        {
            this.TotalPages = totalPages;
            this.FirstAvailableDateTime = firstAvailableDateTime;
            this.LastAvailableDateTime = lastAvailableDateTime;
        }
        
        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="TotalPages", EmitDefaultValue=false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="FirstAvailableDateTime", EmitDefaultValue=false)]
        public DateTimeOffset FirstAvailableDateTime { get; set; }

        /// <summary>
        /// All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="LastAvailableDateTime", EmitDefaultValue=false)]
        public DateTimeOffset LastAvailableDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Meta {\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  FirstAvailableDateTime: ").Append(FirstAvailableDateTime).Append("\n");
            sb.Append("  LastAvailableDateTime: ").Append(LastAvailableDateTime).Append("\n");
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
            return this.Equals(input as Meta);
        }

        /// <summary>
        /// Returns true if Meta instances are equal
        /// </summary>
        /// <param name="input">Instance of Meta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Meta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
                ) && 
                (
                    this.FirstAvailableDateTime == input.FirstAvailableDateTime ||
                    (this.FirstAvailableDateTime != null &&
                    this.FirstAvailableDateTime.Equals(input.FirstAvailableDateTime))
                ) && 
                (
                    this.LastAvailableDateTime == input.LastAvailableDateTime ||
                    (this.LastAvailableDateTime != null &&
                    this.LastAvailableDateTime.Equals(input.LastAvailableDateTime))
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
                hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.FirstAvailableDateTime != null)
                    hashCode = hashCode * 59 + this.FirstAvailableDateTime.GetHashCode();
                if (this.LastAvailableDateTime != null)
                    hashCode = hashCode * 59 + this.LastAvailableDateTime.GetHashCode();
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
