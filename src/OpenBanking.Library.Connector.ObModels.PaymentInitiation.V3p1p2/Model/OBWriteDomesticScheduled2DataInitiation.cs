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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p2.Model
{
    /// <summary>
    /// The Initiation payload is sent by the initiating party to the ASPSP. It is used to request movement of funds from the debtor account to a creditor for a single scheduled domestic payment.
    /// </summary>
    [DataContract]
    public partial class OBWriteDomesticScheduled2DataInitiation :  IEquatable<OBWriteDomesticScheduled2DataInitiation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDomesticScheduled2DataInitiation" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteDomesticScheduled2DataInitiation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDomesticScheduled2DataInitiation" /> class.
        /// </summary>
        /// <param name="instructionIdentification">Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the instruction. Usage: the  instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction. (required).</param>
        /// <param name="endToEndIdentification">Unique identification assigned by the initiating party to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain. Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction. OB: The Faster Payments Scheme can only access 31 characters for the EndToEndIdentification field..</param>
        /// <param name="localInstrument">User community specific instrument. Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level..</param>
        /// <param name="requestedExecutionDateTime">Date at which the initiating party requests the clearing agent to process the payment.  Usage: This is the date on which the debtor&#39;s account is to be debited.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00 (required).</param>
        /// <param name="instructedAmount">instructedAmount (required).</param>
        /// <param name="debtorAccount">debtorAccount.</param>
        /// <param name="creditorAccount">creditorAccount (required).</param>
        /// <param name="creditorPostalAddress">creditorPostalAddress.</param>
        /// <param name="remittanceInformation">remittanceInformation.</param>
        /// <param name="supplementaryData">Additional information that can not be captured in the structured fields and/or any other specific block..</param>
        public OBWriteDomesticScheduled2DataInitiation(string instructionIdentification = default(string), string endToEndIdentification = default(string), string localInstrument = default(string), DateTimeOffset requestedExecutionDateTime = default(DateTimeOffset), OBWriteDomestic2DataInitiationInstructedAmount instructedAmount = default(OBWriteDomestic2DataInitiationInstructedAmount), OBWriteDomestic2DataInitiationDebtorAccount debtorAccount = default(OBWriteDomestic2DataInitiationDebtorAccount), OBWriteDomestic2DataInitiationCreditorAccount creditorAccount = default(OBWriteDomestic2DataInitiationCreditorAccount), OBPostalAddress6 creditorPostalAddress = default(OBPostalAddress6), OBWriteDomestic2DataInitiationRemittanceInformation remittanceInformation = default(OBWriteDomestic2DataInitiationRemittanceInformation), Dictionary<string, Object> supplementaryData = default(Dictionary<string, Object>))
        {
            // to ensure "instructionIdentification" is required (not null)
            this.InstructionIdentification = instructionIdentification ?? throw new ArgumentNullException("instructionIdentification is a required property for OBWriteDomesticScheduled2DataInitiation and cannot be null");
            this.RequestedExecutionDateTime = requestedExecutionDateTime;
            // to ensure "instructedAmount" is required (not null)
            this.InstructedAmount = instructedAmount ?? throw new ArgumentNullException("instructedAmount is a required property for OBWriteDomesticScheduled2DataInitiation and cannot be null");
            // to ensure "creditorAccount" is required (not null)
            this.CreditorAccount = creditorAccount ?? throw new ArgumentNullException("creditorAccount is a required property for OBWriteDomesticScheduled2DataInitiation and cannot be null");
            this.EndToEndIdentification = endToEndIdentification;
            this.LocalInstrument = localInstrument;
            this.DebtorAccount = debtorAccount;
            this.CreditorPostalAddress = creditorPostalAddress;
            this.RemittanceInformation = remittanceInformation;
            this.SupplementaryData = supplementaryData;
        }
        
        /// <summary>
        /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the instruction. Usage: the  instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
        /// </summary>
        /// <value>Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the instruction. Usage: the  instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.</value>
        [DataMember(Name="InstructionIdentification", EmitDefaultValue=false)]
        public string InstructionIdentification { get; set; }

        /// <summary>
        /// Unique identification assigned by the initiating party to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain. Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction. OB: The Faster Payments Scheme can only access 31 characters for the EndToEndIdentification field.
        /// </summary>
        /// <value>Unique identification assigned by the initiating party to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain. Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction. OB: The Faster Payments Scheme can only access 31 characters for the EndToEndIdentification field.</value>
        [DataMember(Name="EndToEndIdentification", EmitDefaultValue=false)]
        public string EndToEndIdentification { get; set; }

        /// <summary>
        /// User community specific instrument. Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
        /// </summary>
        /// <value>User community specific instrument. Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.</value>
        [DataMember(Name="LocalInstrument", EmitDefaultValue=false)]
        public string LocalInstrument { get; set; }

        /// <summary>
        /// Date at which the initiating party requests the clearing agent to process the payment.  Usage: This is the date on which the debtor&#39;s account is to be debited.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Date at which the initiating party requests the clearing agent to process the payment.  Usage: This is the date on which the debtor&#39;s account is to be debited.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="RequestedExecutionDateTime", EmitDefaultValue=false)]
        public DateTimeOffset RequestedExecutionDateTime { get; set; }

        /// <summary>
        /// Gets or Sets InstructedAmount
        /// </summary>
        [DataMember(Name="InstructedAmount", EmitDefaultValue=false)]
        public OBWriteDomestic2DataInitiationInstructedAmount InstructedAmount { get; set; }

        /// <summary>
        /// Gets or Sets DebtorAccount
        /// </summary>
        [DataMember(Name="DebtorAccount", EmitDefaultValue=false)]
        public OBWriteDomestic2DataInitiationDebtorAccount DebtorAccount { get; set; }

        /// <summary>
        /// Gets or Sets CreditorAccount
        /// </summary>
        [DataMember(Name="CreditorAccount", EmitDefaultValue=false)]
        public OBWriteDomestic2DataInitiationCreditorAccount CreditorAccount { get; set; }

        /// <summary>
        /// Gets or Sets CreditorPostalAddress
        /// </summary>
        [DataMember(Name="CreditorPostalAddress", EmitDefaultValue=false)]
        public OBPostalAddress6 CreditorPostalAddress { get; set; }

        /// <summary>
        /// Gets or Sets RemittanceInformation
        /// </summary>
        [DataMember(Name="RemittanceInformation", EmitDefaultValue=false)]
        public OBWriteDomestic2DataInitiationRemittanceInformation RemittanceInformation { get; set; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        /// <value>Additional information that can not be captured in the structured fields and/or any other specific block.</value>
        [DataMember(Name="SupplementaryData", EmitDefaultValue=false)]
        public Dictionary<string, Object> SupplementaryData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteDomesticScheduled2DataInitiation {\n");
            sb.Append("  InstructionIdentification: ").Append(InstructionIdentification).Append("\n");
            sb.Append("  EndToEndIdentification: ").Append(EndToEndIdentification).Append("\n");
            sb.Append("  LocalInstrument: ").Append(LocalInstrument).Append("\n");
            sb.Append("  RequestedExecutionDateTime: ").Append(RequestedExecutionDateTime).Append("\n");
            sb.Append("  InstructedAmount: ").Append(InstructedAmount).Append("\n");
            sb.Append("  DebtorAccount: ").Append(DebtorAccount).Append("\n");
            sb.Append("  CreditorAccount: ").Append(CreditorAccount).Append("\n");
            sb.Append("  CreditorPostalAddress: ").Append(CreditorPostalAddress).Append("\n");
            sb.Append("  RemittanceInformation: ").Append(RemittanceInformation).Append("\n");
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
            return this.Equals(input as OBWriteDomesticScheduled2DataInitiation);
        }

        /// <summary>
        /// Returns true if OBWriteDomesticScheduled2DataInitiation instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteDomesticScheduled2DataInitiation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteDomesticScheduled2DataInitiation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstructionIdentification == input.InstructionIdentification ||
                    (this.InstructionIdentification != null &&
                    this.InstructionIdentification.Equals(input.InstructionIdentification))
                ) && 
                (
                    this.EndToEndIdentification == input.EndToEndIdentification ||
                    (this.EndToEndIdentification != null &&
                    this.EndToEndIdentification.Equals(input.EndToEndIdentification))
                ) && 
                (
                    this.LocalInstrument == input.LocalInstrument ||
                    (this.LocalInstrument != null &&
                    this.LocalInstrument.Equals(input.LocalInstrument))
                ) && 
                (
                    this.RequestedExecutionDateTime == input.RequestedExecutionDateTime ||
                    (this.RequestedExecutionDateTime != null &&
                    this.RequestedExecutionDateTime.Equals(input.RequestedExecutionDateTime))
                ) && 
                (
                    this.InstructedAmount == input.InstructedAmount ||
                    (this.InstructedAmount != null &&
                    this.InstructedAmount.Equals(input.InstructedAmount))
                ) && 
                (
                    this.DebtorAccount == input.DebtorAccount ||
                    (this.DebtorAccount != null &&
                    this.DebtorAccount.Equals(input.DebtorAccount))
                ) && 
                (
                    this.CreditorAccount == input.CreditorAccount ||
                    (this.CreditorAccount != null &&
                    this.CreditorAccount.Equals(input.CreditorAccount))
                ) && 
                (
                    this.CreditorPostalAddress == input.CreditorPostalAddress ||
                    (this.CreditorPostalAddress != null &&
                    this.CreditorPostalAddress.Equals(input.CreditorPostalAddress))
                ) && 
                (
                    this.RemittanceInformation == input.RemittanceInformation ||
                    (this.RemittanceInformation != null &&
                    this.RemittanceInformation.Equals(input.RemittanceInformation))
                ) && 
                (
                    this.SupplementaryData == input.SupplementaryData ||
                    this.SupplementaryData != null &&
                    input.SupplementaryData != null &&
                    this.SupplementaryData.SequenceEqual(input.SupplementaryData)
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
                if (this.InstructionIdentification != null)
                    hashCode = hashCode * 59 + this.InstructionIdentification.GetHashCode();
                if (this.EndToEndIdentification != null)
                    hashCode = hashCode * 59 + this.EndToEndIdentification.GetHashCode();
                if (this.LocalInstrument != null)
                    hashCode = hashCode * 59 + this.LocalInstrument.GetHashCode();
                if (this.RequestedExecutionDateTime != null)
                    hashCode = hashCode * 59 + this.RequestedExecutionDateTime.GetHashCode();
                if (this.InstructedAmount != null)
                    hashCode = hashCode * 59 + this.InstructedAmount.GetHashCode();
                if (this.DebtorAccount != null)
                    hashCode = hashCode * 59 + this.DebtorAccount.GetHashCode();
                if (this.CreditorAccount != null)
                    hashCode = hashCode * 59 + this.CreditorAccount.GetHashCode();
                if (this.CreditorPostalAddress != null)
                    hashCode = hashCode * 59 + this.CreditorPostalAddress.GetHashCode();
                if (this.RemittanceInformation != null)
                    hashCode = hashCode * 59 + this.RemittanceInformation.GetHashCode();
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
            // InstructionIdentification (string) maxLength
            if(this.InstructionIdentification != null && this.InstructionIdentification.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstructionIdentification, length must be less than 35.", new [] { "InstructionIdentification" });
            }

            // InstructionIdentification (string) minLength
            if(this.InstructionIdentification != null && this.InstructionIdentification.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstructionIdentification, length must be greater than 1.", new [] { "InstructionIdentification" });
            }

            // EndToEndIdentification (string) maxLength
            if(this.EndToEndIdentification != null && this.EndToEndIdentification.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndToEndIdentification, length must be less than 35.", new [] { "EndToEndIdentification" });
            }

            // EndToEndIdentification (string) minLength
            if(this.EndToEndIdentification != null && this.EndToEndIdentification.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndToEndIdentification, length must be greater than 1.", new [] { "EndToEndIdentification" });
            }

            yield break;
        }
    }

}
