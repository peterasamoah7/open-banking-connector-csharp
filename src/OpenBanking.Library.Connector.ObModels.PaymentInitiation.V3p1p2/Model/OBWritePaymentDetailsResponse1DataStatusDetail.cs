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
    /// Payment status details as per underlying Payment Rail.
    /// </summary>
    [DataContract]
    public partial class OBWritePaymentDetailsResponse1DataStatusDetail :  IEquatable<OBWritePaymentDetailsResponse1DataStatusDetail>, IValidatableObject
    {
        /// <summary>
        /// Reason Code provided for the status of a transfer.
        /// </summary>
        /// <value>Reason Code provided for the status of a transfer.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusReasonEnum
        {
            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 1,

            /// <summary>
            /// Enum PendingFailingSettlement for value: PendingFailingSettlement
            /// </summary>
            [EnumMember(Value = "PendingFailingSettlement")]
            PendingFailingSettlement = 2,

            /// <summary>
            /// Enum PendingSettlement for value: PendingSettlement
            /// </summary>
            [EnumMember(Value = "PendingSettlement")]
            PendingSettlement = 3,

            /// <summary>
            /// Enum Proprietary for value: Proprietary
            /// </summary>
            [EnumMember(Value = "Proprietary")]
            Proprietary = 4,

            /// <summary>
            /// Enum ProprietaryRejection for value: ProprietaryRejection
            /// </summary>
            [EnumMember(Value = "ProprietaryRejection")]
            ProprietaryRejection = 5,

            /// <summary>
            /// Enum Suspended for value: Suspended
            /// </summary>
            [EnumMember(Value = "Suspended")]
            Suspended = 6,

            /// <summary>
            /// Enum Unmatched for value: Unmatched
            /// </summary>
            [EnumMember(Value = "Unmatched")]
            Unmatched = 7

        }

        /// <summary>
        /// Reason Code provided for the status of a transfer.
        /// </summary>
        /// <value>Reason Code provided for the status of a transfer.</value>
        [DataMember(Name="StatusReason", EmitDefaultValue=false)]
        public StatusReasonEnum? StatusReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWritePaymentDetailsResponse1DataStatusDetail" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWritePaymentDetailsResponse1DataStatusDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWritePaymentDetailsResponse1DataStatusDetail" /> class.
        /// </summary>
        /// <param name="localInstrument">User community specific instrument. Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level..</param>
        /// <param name="status">Status of a transfer, as assigned by the transaction administrator. (required).</param>
        /// <param name="statusReason">Reason Code provided for the status of a transfer..</param>
        /// <param name="statusReasonDescription">Reason provided for the status of a transfer..</param>
        public OBWritePaymentDetailsResponse1DataStatusDetail(string localInstrument = default(string), string status = default(string), StatusReasonEnum? statusReason = default(StatusReasonEnum?), string statusReasonDescription = default(string))
        {
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for OBWritePaymentDetailsResponse1DataStatusDetail and cannot be null");
            this.LocalInstrument = localInstrument;
            this.StatusReason = statusReason;
            this.StatusReasonDescription = statusReasonDescription;
        }
        
        /// <summary>
        /// User community specific instrument. Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
        /// </summary>
        /// <value>User community specific instrument. Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.</value>
        [DataMember(Name="LocalInstrument", EmitDefaultValue=false)]
        public string LocalInstrument { get; set; }

        /// <summary>
        /// Status of a transfer, as assigned by the transaction administrator.
        /// </summary>
        /// <value>Status of a transfer, as assigned by the transaction administrator.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Reason provided for the status of a transfer.
        /// </summary>
        /// <value>Reason provided for the status of a transfer.</value>
        [DataMember(Name="StatusReasonDescription", EmitDefaultValue=false)]
        public string StatusReasonDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWritePaymentDetailsResponse1DataStatusDetail {\n");
            sb.Append("  LocalInstrument: ").Append(LocalInstrument).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
            sb.Append("  StatusReasonDescription: ").Append(StatusReasonDescription).Append("\n");
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
            return this.Equals(input as OBWritePaymentDetailsResponse1DataStatusDetail);
        }

        /// <summary>
        /// Returns true if OBWritePaymentDetailsResponse1DataStatusDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWritePaymentDetailsResponse1DataStatusDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWritePaymentDetailsResponse1DataStatusDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocalInstrument == input.LocalInstrument ||
                    (this.LocalInstrument != null &&
                    this.LocalInstrument.Equals(input.LocalInstrument))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusReason == input.StatusReason ||
                    this.StatusReason.Equals(input.StatusReason)
                ) && 
                (
                    this.StatusReasonDescription == input.StatusReasonDescription ||
                    (this.StatusReasonDescription != null &&
                    this.StatusReasonDescription.Equals(input.StatusReasonDescription))
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
                if (this.LocalInstrument != null)
                    hashCode = hashCode * 59 + this.LocalInstrument.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.StatusReason.GetHashCode();
                if (this.StatusReasonDescription != null)
                    hashCode = hashCode * 59 + this.StatusReasonDescription.GetHashCode();
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
            // Status (string) maxLength
            if(this.Status != null && this.Status.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be less than 128.", new [] { "Status" });
            }

            // Status (string) minLength
            if(this.Status != null && this.Status.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            // StatusReasonDescription (string) maxLength
            if(this.StatusReasonDescription != null && this.StatusReasonDescription.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusReasonDescription, length must be less than 256.", new [] { "StatusReasonDescription" });
            }

            // StatusReasonDescription (string) minLength
            if(this.StatusReasonDescription != null && this.StatusReasonDescription.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusReasonDescription, length must be greater than 1.", new [] { "StatusReasonDescription" });
            }

            yield break;
        }
    }

}
