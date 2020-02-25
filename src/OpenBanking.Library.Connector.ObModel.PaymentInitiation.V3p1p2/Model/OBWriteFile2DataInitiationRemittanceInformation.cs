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
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&#39; receivable system.
    /// </summary>
    [DataContract]
    public partial class OBWriteFile2DataInitiationRemittanceInformation :  IEquatable<OBWriteFile2DataInitiationRemittanceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteFile2DataInitiationRemittanceInformation" /> class.
        /// </summary>
        /// <param name="unstructured">Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&#39; receivable system, in an unstructured form..</param>
        /// <param name="reference">Unique reference, as assigned by the creditor, to unambiguously refer to the payment transaction. Usage: If available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the amount of money. If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor&#39;s reference or payment remittance identification should be quoted in the end-to-end transaction identification. OB: The Faster Payments Scheme can only accept 18 characters for the ReferenceInformation field - which is where this ISO field will be mapped..</param>
        public OBWriteFile2DataInitiationRemittanceInformation(string unstructured = default(string), string reference = default(string))
        {
            this.Unstructured = unstructured;
            this.Reference = reference;
        }
        
        /// <summary>
        /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&#39; receivable system, in an unstructured form.
        /// </summary>
        /// <value>Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&#39; receivable system, in an unstructured form.</value>
        [DataMember(Name="Unstructured", EmitDefaultValue=false)]
        public string Unstructured { get; set; }

        /// <summary>
        /// Unique reference, as assigned by the creditor, to unambiguously refer to the payment transaction. Usage: If available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the amount of money. If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor&#39;s reference or payment remittance identification should be quoted in the end-to-end transaction identification. OB: The Faster Payments Scheme can only accept 18 characters for the ReferenceInformation field - which is where this ISO field will be mapped.
        /// </summary>
        /// <value>Unique reference, as assigned by the creditor, to unambiguously refer to the payment transaction. Usage: If available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the amount of money. If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor&#39;s reference or payment remittance identification should be quoted in the end-to-end transaction identification. OB: The Faster Payments Scheme can only accept 18 characters for the ReferenceInformation field - which is where this ISO field will be mapped.</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteFile2DataInitiationRemittanceInformation {\n");
            sb.Append("  Unstructured: ").Append(Unstructured).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as OBWriteFile2DataInitiationRemittanceInformation);
        }

        /// <summary>
        /// Returns true if OBWriteFile2DataInitiationRemittanceInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteFile2DataInitiationRemittanceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteFile2DataInitiationRemittanceInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Unstructured == input.Unstructured ||
                    (this.Unstructured != null &&
                    this.Unstructured.Equals(input.Unstructured))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.Unstructured != null)
                    hashCode = hashCode * 59 + this.Unstructured.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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
            // Unstructured (string) maxLength
            if(this.Unstructured != null && this.Unstructured.Length > 140)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Unstructured, length must be less than 140.", new [] { "Unstructured" });
            }

            // Unstructured (string) minLength
            if(this.Unstructured != null && this.Unstructured.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Unstructured, length must be greater than 1.", new [] { "Unstructured" });
            }

            // Reference (string) maxLength
            if(this.Reference != null && this.Reference.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 35.", new [] { "Reference" });
            }

            // Reference (string) minLength
            if(this.Reference != null && this.Reference.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be greater than 1.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
