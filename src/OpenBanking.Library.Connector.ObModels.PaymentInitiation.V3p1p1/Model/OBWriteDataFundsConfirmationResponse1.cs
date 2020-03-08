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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p1.Model
{
    /// <summary>
    /// OBWriteDataFundsConfirmationResponse1
    /// </summary>
    [DataContract]
    public partial class OBWriteDataFundsConfirmationResponse1 :  IEquatable<OBWriteDataFundsConfirmationResponse1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDataFundsConfirmationResponse1" /> class.
        /// </summary>
        /// <param name="fundsAvailableResult">fundsAvailableResult.</param>
        /// <param name="supplementaryData">supplementaryData.</param>
        public OBWriteDataFundsConfirmationResponse1(OBFundsAvailableResult1 fundsAvailableResult = default(OBFundsAvailableResult1), OBSupplementaryData1 supplementaryData = default(OBSupplementaryData1))
        {
            this.FundsAvailableResult = fundsAvailableResult;
            this.SupplementaryData = supplementaryData;
        }
        
        /// <summary>
        /// Gets or Sets FundsAvailableResult
        /// </summary>
        [DataMember(Name="FundsAvailableResult", EmitDefaultValue=false)]
        public OBFundsAvailableResult1 FundsAvailableResult { get; set; }

        /// <summary>
        /// Gets or Sets SupplementaryData
        /// </summary>
        [DataMember(Name="SupplementaryData", EmitDefaultValue=false)]
        public OBSupplementaryData1 SupplementaryData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteDataFundsConfirmationResponse1 {\n");
            sb.Append("  FundsAvailableResult: ").Append(FundsAvailableResult).Append("\n");
            sb.Append("  SupplementaryData: ").Append(SupplementaryData).Append("\n");
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
            return this.Equals(input as OBWriteDataFundsConfirmationResponse1);
        }

        /// <summary>
        /// Returns true if OBWriteDataFundsConfirmationResponse1 instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteDataFundsConfirmationResponse1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteDataFundsConfirmationResponse1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FundsAvailableResult == input.FundsAvailableResult ||
                    (this.FundsAvailableResult != null &&
                    this.FundsAvailableResult.Equals(input.FundsAvailableResult))
                ) && 
                (
                    this.SupplementaryData == input.SupplementaryData ||
                    (this.SupplementaryData != null &&
                    this.SupplementaryData.Equals(input.SupplementaryData))
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
                if (this.FundsAvailableResult != null)
                    hashCode = hashCode * 59 + this.FundsAvailableResult.GetHashCode();
                if (this.SupplementaryData != null)
                    hashCode = hashCode * 59 + this.SupplementaryData.GetHashCode();
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