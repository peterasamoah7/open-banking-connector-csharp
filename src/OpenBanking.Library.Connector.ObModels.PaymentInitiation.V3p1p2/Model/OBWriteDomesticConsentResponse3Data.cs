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
using Newtonsoft.Json.Converters;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p2.Model
{
    /// <summary>
    /// OBWriteDomesticConsentResponse3Data
    /// </summary>
    [DataContract]
    public partial class OBWriteDomesticConsentResponse3Data :  IEquatable<OBWriteDomesticConsentResponse3Data>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="OBWriteDomesticConsentResponse3Data" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBWriteDomesticConsentResponse3Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteDomesticConsentResponse3Data" /> class.
        /// </summary>
        /// <param name="consentId">OB: Unique identification as assigned by the ASPSP to uniquely identify the consent resource. (required).</param>
        /// <param name="creationDateTime">Date and time at which the resource was created.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00 (required).</param>
        /// <param name="status">Specifies the status of consent resource in code form. (required).</param>
        /// <param name="statusUpdateDateTime">Date and time at which the resource status was updated.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00 (required).</param>
        /// <param name="cutOffDateTime">Specified cut-off date and time for the payment consent.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        /// <param name="expectedExecutionDateTime">Expected execution date and time for the payment resource.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        /// <param name="expectedSettlementDateTime">Expected settlement date and time for the payment resource.All dates in the JSON payloads are represented in ISO 8601 date-time format.  All date-time fields in responses must include the timezone. An example is below: 2017-04-05T10:43:07+00:00.</param>
        /// <param name="charges">charges.</param>
        /// <param name="initiation">initiation (required).</param>
        /// <param name="authorisation">authorisation.</param>
        /// <param name="sCASupportData">sCASupportData.</param>
        public OBWriteDomesticConsentResponse3Data(string consentId = default(string), DateTimeOffset creationDateTime = default(DateTimeOffset), StatusEnum status = default(StatusEnum), DateTimeOffset statusUpdateDateTime = default(DateTimeOffset), DateTimeOffset cutOffDateTime = default(DateTimeOffset), DateTimeOffset expectedExecutionDateTime = default(DateTimeOffset), DateTimeOffset expectedSettlementDateTime = default(DateTimeOffset), List<OBWriteDomesticConsentResponse3DataCharges> charges = default(List<OBWriteDomesticConsentResponse3DataCharges>), OBWriteDomestic2DataInitiation initiation = default(OBWriteDomestic2DataInitiation), OBWriteDomesticConsent3DataAuthorisation authorisation = default(OBWriteDomesticConsent3DataAuthorisation), OBWriteDomesticConsent3DataSCASupportData sCASupportData = default(OBWriteDomesticConsent3DataSCASupportData))
        {
            // to ensure "consentId" is required (not null)
            this.ConsentId = consentId ?? throw new ArgumentNullException("consentId is a required property for OBWriteDomesticConsentResponse3Data and cannot be null");
            this.CreationDateTime = creationDateTime;
            this.Status = status;
            this.StatusUpdateDateTime = statusUpdateDateTime;
            // to ensure "initiation" is required (not null)
            this.Initiation = initiation ?? throw new ArgumentNullException("initiation is a required property for OBWriteDomesticConsentResponse3Data and cannot be null");
            this.CutOffDateTime = cutOffDateTime;
            this.ExpectedExecutionDateTime = expectedExecutionDateTime;
            this.ExpectedSettlementDateTime = expectedSettlementDateTime;
            this.Charges = charges;
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
        public List<OBWriteDomesticConsentResponse3DataCharges> Charges { get; set; }

        /// <summary>
        /// Gets or Sets Initiation
        /// </summary>
        [DataMember(Name="Initiation", EmitDefaultValue=false)]
        public OBWriteDomestic2DataInitiation Initiation { get; set; }

        /// <summary>
        /// Gets or Sets Authorisation
        /// </summary>
        [DataMember(Name="Authorisation", EmitDefaultValue=false)]
        public OBWriteDomesticConsent3DataAuthorisation Authorisation { get; set; }

        /// <summary>
        /// Gets or Sets SCASupportData
        /// </summary>
        [DataMember(Name="SCASupportData", EmitDefaultValue=false)]
        public OBWriteDomesticConsent3DataSCASupportData SCASupportData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteDomesticConsentResponse3Data {\n");
            sb.Append("  ConsentId: ").Append(ConsentId).Append("\n");
            sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusUpdateDateTime: ").Append(StatusUpdateDateTime).Append("\n");
            sb.Append("  CutOffDateTime: ").Append(CutOffDateTime).Append("\n");
            sb.Append("  ExpectedExecutionDateTime: ").Append(ExpectedExecutionDateTime).Append("\n");
            sb.Append("  ExpectedSettlementDateTime: ").Append(ExpectedSettlementDateTime).Append("\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
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
            return this.Equals(input as OBWriteDomesticConsentResponse3Data);
        }

        /// <summary>
        /// Returns true if OBWriteDomesticConsentResponse3Data instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteDomesticConsentResponse3Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteDomesticConsentResponse3Data input)
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
                if (this.CutOffDateTime != null)
                    hashCode = hashCode * 59 + this.CutOffDateTime.GetHashCode();
                if (this.ExpectedExecutionDateTime != null)
                    hashCode = hashCode * 59 + this.ExpectedExecutionDateTime.GetHashCode();
                if (this.ExpectedSettlementDateTime != null)
                    hashCode = hashCode * 59 + this.ExpectedSettlementDateTime.GetHashCode();
                if (this.Charges != null)
                    hashCode = hashCode * 59 + this.Charges.GetHashCode();
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
