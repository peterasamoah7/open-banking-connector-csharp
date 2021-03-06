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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p4.Model
{
    /// <summary>
    /// OBWriteInternationalScheduledConsentResponse5Data
    /// </summary>
    [DataContract]
    public partial class OBWriteInternationalScheduledConsentResponse5Data :  IEquatable<OBWriteInternationalScheduledConsentResponse5Data>, IValidatableObject
    {
        /// <summary>
        /// Specifies the status of consent resource in code form.
        /// </summary>
        /// <value>Specifies the status of consent resource in code form.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Authorised for value: Authorised
            /// </summary>
            [EnumMember(Value = "Authorised")]
            Authorised = 1,

            /// <summary>
            /// Enum AwaitingAuthorisation for value: AwaitingAuthorisation
            /// </summary>
            [EnumMember(Value = "AwaitingAuthorisation")]
            AwaitingAuthorisation = 2,

            /// <summary>
            /// Enum Consumed for value: Consumed
            /// </summary>
            [EnumMember(Value = "Consumed")]
            Consumed = 3,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 4

        }

        /// <summary>
        /// Specifies the status of consent resource in code form.
        /// </summary>
        /// <value>Specifies the status of consent resource in code form.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Specifies the Open Banking service request types.
        /// </summary>
        /// <value>Specifies the Open Banking service request types.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionEnum
        {
            /// <summary>
            /// Enum Create for value: Create
            /// </summary>
            [EnumMember(Value = "Create")]
            Create = 1

        }

        /// <summary>
        /// Specifies the Open Banking service request types.
        /// </summary>
        /// <value>Specifies the Open Banking service request types.</value>
        [DataMember(Name="Permission", EmitDefaultValue=false)]
        public PermissionEnum Permission { get; set; }
        /// <summary>
        /// Specifies to share the refund account details with PISP
        /// </summary>
        /// <value>Specifies to share the refund account details with PISP</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReadRefundAccountEnum
        {
            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 1,

            /// <summary>
            /// Enum Yes for value: Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes = 2

        }

        /// <summary>
        /// Specifies to share the refund account details with PISP
        /// </summary>
        /// <value>Specifies to share the refund account details with PISP</value>
        [DataMember(Name="ReadRefundAccount", EmitDefaultValue=false)]
        public ReadRefundAccountEnum? ReadRefundAccount { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalScheduledConsentResponse5Data" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteInternationalScheduledConsentResponse5Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalScheduledConsentResponse5Data" /> class.
        /// </summary>
        /// <param name="consentId">OB: Unique identification as assigned by the ASPSP to uniquely identify the consent resource. (required).</param>
        /// <param name="creationDateTime">Date and time at which the resource was created.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00 (required).</param>
        /// <param name="status">Specifies the status of consent resource in code form. (required).</param>
        /// <param name="statusUpdateDateTime">Date and time at which the resource status was updated.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00 (required).</param>
        /// <param name="permission">Specifies the Open Banking service request types. (required).</param>
        /// <param name="readRefundAccount">Specifies to share the refund account details with PISP.</param>
        /// <param name="cutOffDateTime">Specified cut-off date and time for the payment consent.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        /// <param name="expectedExecutionDateTime">Expected execution date and time for the payment resource.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        /// <param name="expectedSettlementDateTime">Expected settlement date and time for the payment resource.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        /// <param name="charges">charges.</param>
        /// <param name="exchangeRateInformation">exchangeRateInformation.</param>
        /// <param name="initiation">initiation (required).</param>
        /// <param name="authorisation">authorisation.</param>
        /// <param name="sCASupportData">sCASupportData.</param>
        public OBWriteInternationalScheduledConsentResponse5Data(string consentId = default(string), DateTimeOffset creationDateTime = default(DateTimeOffset), StatusEnum status = default(StatusEnum), DateTimeOffset statusUpdateDateTime = default(DateTimeOffset), PermissionEnum permission = default(PermissionEnum), ReadRefundAccountEnum? readRefundAccount = default(ReadRefundAccountEnum?), DateTimeOffset cutOffDateTime = default(DateTimeOffset), DateTimeOffset expectedExecutionDateTime = default(DateTimeOffset), DateTimeOffset expectedSettlementDateTime = default(DateTimeOffset), List<OBWriteDomesticConsentResponse4DataCharges> charges = default(List<OBWriteDomesticConsentResponse4DataCharges>), OBWriteInternationalConsentResponse5DataExchangeRateInformation exchangeRateInformation = default(OBWriteInternationalConsentResponse5DataExchangeRateInformation), OBWriteInternationalScheduled3DataInitiation initiation = default(OBWriteInternationalScheduled3DataInitiation), OBWriteDomesticConsent4DataAuthorisation authorisation = default(OBWriteDomesticConsent4DataAuthorisation), OBWriteDomesticConsent4DataSCASupportData sCASupportData = default(OBWriteDomesticConsent4DataSCASupportData))
        {
            // to ensure "consentId" is required (not null)
            this.ConsentId = consentId ?? throw new ArgumentNullException("consentId is a required property for OBWriteInternationalScheduledConsentResponse5Data and cannot be null");
            this.CreationDateTime = creationDateTime;
            this.Status = status;
            this.StatusUpdateDateTime = statusUpdateDateTime;
            this.Permission = permission;
            // to ensure "initiation" is required (not null)
            this.Initiation = initiation ?? throw new ArgumentNullException("initiation is a required property for OBWriteInternationalScheduledConsentResponse5Data and cannot be null");
            this.ReadRefundAccount = readRefundAccount;
            this.CutOffDateTime = cutOffDateTime;
            this.ExpectedExecutionDateTime = expectedExecutionDateTime;
            this.ExpectedSettlementDateTime = expectedSettlementDateTime;
            this.Charges = charges;
            this.ExchangeRateInformation = exchangeRateInformation;
            this.Authorisation = authorisation;
            this.SCASupportData = sCASupportData;
        }
        
        /// <summary>
        /// OB: Unique identification as assigned by the ASPSP to uniquely identify the consent resource.
        /// </summary>
        /// <value>OB: Unique identification as assigned by the ASPSP to uniquely identify the consent resource.</value>
        [DataMember(Name="ConsentId", EmitDefaultValue=false)]
        public string ConsentId { get; set; }

        /// <summary>
        /// Date and time at which the resource was created.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Date and time at which the resource was created.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="CreationDateTime", EmitDefaultValue=false)]
        public DateTimeOffset CreationDateTime { get; set; }

        /// <summary>
        /// Date and time at which the resource status was updated.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Date and time at which the resource status was updated.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="StatusUpdateDateTime", EmitDefaultValue=false)]
        public DateTimeOffset StatusUpdateDateTime { get; set; }

        /// <summary>
        /// Specified cut-off date and time for the payment consent.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Specified cut-off date and time for the payment consent.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="CutOffDateTime", EmitDefaultValue=false)]
        public DateTimeOffset CutOffDateTime { get; set; }

        /// <summary>
        /// Expected execution date and time for the payment resource.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Expected execution date and time for the payment resource.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="ExpectedExecutionDateTime", EmitDefaultValue=false)]
        public DateTimeOffset ExpectedExecutionDateTime { get; set; }

        /// <summary>
        /// Expected settlement date and time for the payment resource.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00
        /// </summary>
        /// <value>Expected settlement date and time for the payment resource.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00</value>
        [DataMember(Name="ExpectedSettlementDateTime", EmitDefaultValue=false)]
        public DateTimeOffset ExpectedSettlementDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Charges
        /// </summary>
        [DataMember(Name="Charges", EmitDefaultValue=false)]
        public List<OBWriteDomesticConsentResponse4DataCharges> Charges { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRateInformation
        /// </summary>
        [DataMember(Name="ExchangeRateInformation", EmitDefaultValue=false)]
        public OBWriteInternationalConsentResponse5DataExchangeRateInformation ExchangeRateInformation { get; set; }

        /// <summary>
        /// Gets or Sets Initiation
        /// </summary>
        [DataMember(Name="Initiation", EmitDefaultValue=false)]
        public OBWriteInternationalScheduled3DataInitiation Initiation { get; set; }

        /// <summary>
        /// Gets or Sets Authorisation
        /// </summary>
        [DataMember(Name="Authorisation", EmitDefaultValue=false)]
        public OBWriteDomesticConsent4DataAuthorisation Authorisation { get; set; }

        /// <summary>
        /// Gets or Sets SCASupportData
        /// </summary>
        [DataMember(Name="SCASupportData", EmitDefaultValue=false)]
        public OBWriteDomesticConsent4DataSCASupportData SCASupportData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteInternationalScheduledConsentResponse5Data {\n");
            sb.Append("  ConsentId: ").Append(ConsentId).Append("\n");
            sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusUpdateDateTime: ").Append(StatusUpdateDateTime).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  ReadRefundAccount: ").Append(ReadRefundAccount).Append("\n");
            sb.Append("  CutOffDateTime: ").Append(CutOffDateTime).Append("\n");
            sb.Append("  ExpectedExecutionDateTime: ").Append(ExpectedExecutionDateTime).Append("\n");
            sb.Append("  ExpectedSettlementDateTime: ").Append(ExpectedSettlementDateTime).Append("\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
            sb.Append("  ExchangeRateInformation: ").Append(ExchangeRateInformation).Append("\n");
            sb.Append("  Initiation: ").Append(Initiation).Append("\n");
            sb.Append("  Authorisation: ").Append(Authorisation).Append("\n");
            sb.Append("  SCASupportData: ").Append(SCASupportData).Append("\n");
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
            return this.Equals(input as OBWriteInternationalScheduledConsentResponse5Data);
        }

        /// <summary>
        /// Returns true if OBWriteInternationalScheduledConsentResponse5Data instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteInternationalScheduledConsentResponse5Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteInternationalScheduledConsentResponse5Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsentId == input.ConsentId ||
                    (this.ConsentId != null &&
                    this.ConsentId.Equals(input.ConsentId))
                ) && 
                (
                    this.CreationDateTime == input.CreationDateTime ||
                    (this.CreationDateTime != null &&
                    this.CreationDateTime.Equals(input.CreationDateTime))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusUpdateDateTime == input.StatusUpdateDateTime ||
                    (this.StatusUpdateDateTime != null &&
                    this.StatusUpdateDateTime.Equals(input.StatusUpdateDateTime))
                ) && 
                (
                    this.Permission == input.Permission ||
                    this.Permission.Equals(input.Permission)
                ) && 
                (
                    this.ReadRefundAccount == input.ReadRefundAccount ||
                    this.ReadRefundAccount.Equals(input.ReadRefundAccount)
                ) && 
                (
                    this.CutOffDateTime == input.CutOffDateTime ||
                    (this.CutOffDateTime != null &&
                    this.CutOffDateTime.Equals(input.CutOffDateTime))
                ) && 
                (
                    this.ExpectedExecutionDateTime == input.ExpectedExecutionDateTime ||
                    (this.ExpectedExecutionDateTime != null &&
                    this.ExpectedExecutionDateTime.Equals(input.ExpectedExecutionDateTime))
                ) && 
                (
                    this.ExpectedSettlementDateTime == input.ExpectedSettlementDateTime ||
                    (this.ExpectedSettlementDateTime != null &&
                    this.ExpectedSettlementDateTime.Equals(input.ExpectedSettlementDateTime))
                ) && 
                (
                    this.Charges == input.Charges ||
                    this.Charges != null &&
                    input.Charges != null &&
                    this.Charges.SequenceEqual(input.Charges)
                ) && 
                (
                    this.ExchangeRateInformation == input.ExchangeRateInformation ||
                    (this.ExchangeRateInformation != null &&
                    this.ExchangeRateInformation.Equals(input.ExchangeRateInformation))
                ) && 
                (
                    this.Initiation == input.Initiation ||
                    (this.Initiation != null &&
                    this.Initiation.Equals(input.Initiation))
                ) && 
                (
                    this.Authorisation == input.Authorisation ||
                    (this.Authorisation != null &&
                    this.Authorisation.Equals(input.Authorisation))
                ) && 
                (
                    this.SCASupportData == input.SCASupportData ||
                    (this.SCASupportData != null &&
                    this.SCASupportData.Equals(input.SCASupportData))
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
                if (this.ConsentId != null)
                    hashCode = hashCode * 59 + this.ConsentId.GetHashCode();
                if (this.CreationDateTime != null)
                    hashCode = hashCode * 59 + this.CreationDateTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusUpdateDateTime != null)
                    hashCode = hashCode * 59 + this.StatusUpdateDateTime.GetHashCode();
                hashCode = hashCode * 59 + this.Permission.GetHashCode();
                hashCode = hashCode * 59 + this.ReadRefundAccount.GetHashCode();
                if (this.CutOffDateTime != null)
                    hashCode = hashCode * 59 + this.CutOffDateTime.GetHashCode();
                if (this.ExpectedExecutionDateTime != null)
                    hashCode = hashCode * 59 + this.ExpectedExecutionDateTime.GetHashCode();
                if (this.ExpectedSettlementDateTime != null)
                    hashCode = hashCode * 59 + this.ExpectedSettlementDateTime.GetHashCode();
                if (this.Charges != null)
                    hashCode = hashCode * 59 + this.Charges.GetHashCode();
                if (this.ExchangeRateInformation != null)
                    hashCode = hashCode * 59 + this.ExchangeRateInformation.GetHashCode();
                if (this.Initiation != null)
                    hashCode = hashCode * 59 + this.Initiation.GetHashCode();
                if (this.Authorisation != null)
                    hashCode = hashCode * 59 + this.Authorisation.GetHashCode();
                if (this.SCASupportData != null)
                    hashCode = hashCode * 59 + this.SCASupportData.GetHashCode();
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
            // ConsentId (string) maxLength
            if(this.ConsentId != null && this.ConsentId.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConsentId, length must be less than 128.", new [] { "ConsentId" });
            }

            // ConsentId (string) minLength
            if(this.ConsentId != null && this.ConsentId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConsentId, length must be greater than 1.", new [] { "ConsentId" });
            }

            yield break;
        }
    }

}
