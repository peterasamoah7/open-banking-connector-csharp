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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModel.PaymentInitiation.V3p1p2.Model
{
    /// <summary>
    /// OBWriteFundsConfirmationResponse1Data
    /// </summary>
    [DataContract]
    public partial class OBWriteFundsConfirmationResponse1Data :  IEquatable<OBWriteFundsConfirmationResponse1Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteFundsConfirmationResponse1Data" /> class.
        /// </summary>
        /// <param name="supplementaryData">supplementaryData.</param>
        /// <param name="fundsAvailableResult">fundsAvailableResult.</param>
        public OBWriteFundsConfirmationResponse1Data(OBSupplementaryData1 supplementaryData = default(OBSupplementaryData1), OBWriteFundsConfirmationResponse1DataFundsAvailableResult fundsAvailableResult = default(OBWriteFundsConfirmationResponse1DataFundsAvailableResult))
        {
            this.SupplementaryData = supplementaryData;
            this.FundsAvailableResult = fundsAvailableResult;
        }
        
        /// <summary>
        /// Gets or Sets SupplementaryData
        /// </summary>
        [DataMember(Name="SupplementaryData", EmitDefaultValue=false)]
        public OBSupplementaryData1 SupplementaryData { get; set; }

        /// <summary>
        /// Gets or Sets FundsAvailableResult
        /// </summary>
        [DataMember(Name="FundsAvailableResult", EmitDefaultValue=false)]
        public OBWriteFundsConfirmationResponse1DataFundsAvailableResult FundsAvailableResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteFundsConfirmationResponse1Data {\n");
            sb.Append("  SupplementaryData: ").Append(SupplementaryData).Append("\n");
            sb.Append("  FundsAvailableResult: ").Append(FundsAvailableResult).Append("\n");
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
            return this.Equals(input as OBWriteFundsConfirmationResponse1Data);
        }

        /// <summary>
        /// Returns true if OBWriteFundsConfirmationResponse1Data instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteFundsConfirmationResponse1Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteFundsConfirmationResponse1Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupplementaryData == input.SupplementaryData ||
                    (this.SupplementaryData != null &&
                    this.SupplementaryData.Equals(input.SupplementaryData))
                ) && 
                (
                    this.FundsAvailableResult == input.FundsAvailableResult ||
                    (this.FundsAvailableResult != null &&
                    this.FundsAvailableResult.Equals(input.FundsAvailableResult))
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
                if (this.SupplementaryData != null)
                    hashCode = hashCode * 59 + this.SupplementaryData.GetHashCode();
                if (this.FundsAvailableResult != null)
                    hashCode = hashCode * 59 + this.FundsAvailableResult.GetHashCode();
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
