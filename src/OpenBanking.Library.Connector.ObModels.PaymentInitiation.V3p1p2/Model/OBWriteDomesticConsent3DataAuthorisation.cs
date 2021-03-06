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
using Newtonsoft.Json.Converters;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p2.Model
{
    /// <summary>
    /// The authorisation type request from the TPP.
    /// </summary>
    [DataContract]
    public partial class OBWriteDomesticConsent3DataAuthorisation :  IEquatable<OBWriteDomesticConsent3DataAuthorisation>, IValidatableObject
    {
        /// <summary>
        /// Type of authorisation flow requested.
        /// </summary>
        /// <value>Type of authorisation flow requested.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthorisationTypeEnum
        {
            /// <summary>
            /// Enum Any for value: Any
            /// </summary>
            [EnumMember(Value = "Any")]
            Any = 1,

            /// <summary>
            /// Enum Single for value: Single
            /// </summary>
            [EnumMember(Value = "Single")]
            Single = 2

        }

        /// <summary>
        /// Type of authorisation flow requested.
        /// </summary>
        /// <value>Type of authorisation flow requested.</value>
        [DataMember(Name="AuthorisationType", EmitDefaultValue=false)]
        public AuthorisationTypeEnum AuthorisationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDomesticConsent3DataAuthorisation" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteDomesticConsent3DataAuthorisation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDomesticConsent3DataAuthorisation" /> class.
        /// </summary>
        /// <param name="authorisationType">Type of authorisation flow requested. (required).</param>
        /// <param name="completionDateTime">Date and time at which the requested authorisation flow must be completed.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        public OBWriteDomesticConsent3DataAuthorisation(AuthorisationTypeEnum authorisationType = default(AuthorisationTypeEnum), DateTimeOffset completionDateTime = default(DateTimeOffset))
        {
            this.AuthorisationType = authorisationType;
            this.CompletionDateTime = completionDateTime;
        }
        
        /// <summary>
        /// Date and time at which the requested authorisation flow must be completed.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Date and time at which the requested authorisation flow must be completed.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="CompletionDateTime", EmitDefaultValue=false)]
        public DateTimeOffset CompletionDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteDomesticConsent3DataAuthorisation {\n");
            sb.Append("  AuthorisationType: ").Append(AuthorisationType).Append("\n");
            sb.Append("  CompletionDateTime: ").Append(CompletionDateTime).Append("\n");
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
            return this.Equals(input as OBWriteDomesticConsent3DataAuthorisation);
        }

        /// <summary>
        /// Returns true if OBWriteDomesticConsent3DataAuthorisation instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteDomesticConsent3DataAuthorisation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteDomesticConsent3DataAuthorisation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorisationType == input.AuthorisationType ||
                    this.AuthorisationType.Equals(input.AuthorisationType)
                ) && 
                (
                    this.CompletionDateTime == input.CompletionDateTime ||
                    (this.CompletionDateTime != null &&
                    this.CompletionDateTime.Equals(input.CompletionDateTime))
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
                hashCode = hashCode * 59 + this.AuthorisationType.GetHashCode();
                if (this.CompletionDateTime != null)
                    hashCode = hashCode * 59 + this.CompletionDateTime.GetHashCode();
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
