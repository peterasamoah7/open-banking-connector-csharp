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
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account. This is the servicer of the beneficiary account.
    /// </summary>
    [DataContract]
    public partial class OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent :  IEquatable<OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent" /> class.
        /// </summary>
        /// <param name="postalAddress">postalAddress.</param>
        /// <param name="schemeName">Name of the identification scheme, in a coded form as published in an external list..</param>
        /// <param name="identification">Unique and unambiguous identification of the servicing institution..</param>
        /// <param name="name">Name by which an agent is known and which is usually used to identify that agent..</param>
        public OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent(OBPostalAddress6 postalAddress = default(OBPostalAddress6), string schemeName = default(string), string identification = default(string), string name = default(string))
        {
            this.PostalAddress = postalAddress;
            this.SchemeName = schemeName;
            this.Identification = identification;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name="PostalAddress", EmitDefaultValue=false)]
        public OBPostalAddress6 PostalAddress { get; set; }

        /// <summary>
        /// Name of the identification scheme, in a coded form as published in an external list.
        /// </summary>
        /// <value>Name of the identification scheme, in a coded form as published in an external list.</value>
        [DataMember(Name="SchemeName", EmitDefaultValue=false)]
        public string SchemeName { get; set; }

        /// <summary>
        /// Unique and unambiguous identification of the servicing institution.
        /// </summary>
        /// <value>Unique and unambiguous identification of the servicing institution.</value>
        [DataMember(Name="Identification", EmitDefaultValue=false)]
        public string Identification { get; set; }

        /// <summary>
        /// Name by which an agent is known and which is usually used to identify that agent.
        /// </summary>
        /// <value>Name by which an agent is known and which is usually used to identify that agent.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent {\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent);
        }

        /// <summary>
        /// Returns true if OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent instances are equal
        /// </summary>
        /// <param name="input">Instance of OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBWriteInternationalStandingOrderConsent4DataInitiationCreditorAgent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
                ) && 
                (
                    this.SchemeName == input.SchemeName ||
                    (this.SchemeName != null &&
                    this.SchemeName.Equals(input.SchemeName))
                ) && 
                (
                    this.Identification == input.Identification ||
                    (this.Identification != null &&
                    this.Identification.Equals(input.Identification))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
                if (this.SchemeName != null)
                    hashCode = hashCode * 59 + this.SchemeName.GetHashCode();
                if (this.Identification != null)
                    hashCode = hashCode * 59 + this.Identification.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
            // Identification (string) maxLength
            if(this.Identification != null && this.Identification.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identification, length must be less than 35.", new [] { "Identification" });
            }

            // Identification (string) minLength
            if(this.Identification != null && this.Identification.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identification, length must be greater than 1.", new [] { "Identification" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 140)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 140.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
