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

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p2.Model
{
    /// <summary>
    /// Result of a funds availability check.
    /// </summary>
    [DataContract]
    public partial class OBWriteFundsConfirmationResponse1DataFundsAvailableResult :  IEquatable<OBWriteFundsConfirmationResponse1DataFundsAvailableResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteFundsConfirmationResponse1DataFundsAvailableResult" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteFundsConfirmationResponse1DataFundsAvailableResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteFundsConfirmationResponse1DataFundsAvailableResult" /> class.
        /// </summary>
        /// <param name="fundsAvailableDateTime">Date and time at which the funds availability check was generated.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00 (required).</param>
        /// <param name="fundsAvailable">Flag to indicate the availability of funds given the Amount in the consent request. (required).</param>
        public OBWriteFundsConfirmationResponse1DataFundsAvailableResult(DateTime? fundsAvailableDateTime = default(DateTime?), bool? fundsAvailable = default(bool?))
        {
            // to ensure "fundsAvailableDateTime" is required (not null)
            if (fundsAvailableDateTime == null)
            {
                throw new InvalidDataException("fundsAvailableDateTime is a required property for OBWriteFundsConfirmationResponse1DataFundsAvailableResult and cannot be null");
            }
            else
            {
                this.FundsAvailableDateTime = fundsAvailableDateTime;
            }
            // to ensure "fundsAvailable" is required (not null)
            if (fundsAvailable == null)
            {
                throw new InvalidDataException("fundsAvailable is a required property for OBWriteFundsConfirmationResponse1DataFundsAvailableResult and cannot be null");
            }
            else
            {
                this.FundsAvailable = fundsAvailable;
            }
        }
        
        /// <summary>
        /// Date and time at which the funds availability check was generated.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Date and time at which the funds availability check was generated.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="FundsAvailableDateTime", EmitDefaultValue=false)]
        public DateTime? FundsAvailableDateTime { get; set; }

        /// <summary>
        /// Flag to indicate the availability of funds given the Amount in the consent request.
        /// </summary>
        /// <value>Flag to indicate the availability of funds given the Amount in the consent request.</value>
        [DataMember(Name="FundsAvailable", EmitDefaultValue=false)]
        public bool? FundsAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteFundsConfirmationResponse1DataFundsAvailableResult {\n");
            sb.Append("  FundsAvailableDateTime: ").Append(FundsAvailableDateTime).Append("\n");
            sb.Append("  FundsAvailable: ").Append(FundsAvailable).Append("\n");
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
            return this.Equals(input as OBWriteFundsConfirmationResponse1DataFundsAvailableResult);
        }

        /// <summary>
        /// Returns true if OBWriteFundsConfirmationResponse1DataFundsAvailableResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteFundsConfirmationResponse1DataFundsAvailableResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteFundsConfirmationResponse1DataFundsAvailableResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FundsAvailableDateTime == input.FundsAvailableDateTime ||
                    (this.FundsAvailableDateTime != null &&
                    this.FundsAvailableDateTime.Equals(input.FundsAvailableDateTime))
                ) && 
                (
                    this.FundsAvailable == input.FundsAvailable ||
                    (this.FundsAvailable != null &&
                    this.FundsAvailable.Equals(input.FundsAvailable))
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
                if (this.FundsAvailableDateTime != null)
                    hashCode = hashCode * 59 + this.FundsAvailableDateTime.GetHashCode();
                if (this.FundsAvailable != null)
                    hashCode = hashCode * 59 + this.FundsAvailable.GetHashCode();
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