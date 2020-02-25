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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModel.PaymentInitiation.V3p1p1.Model
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services or in free format text.
    /// </summary>
    [DataContract]
    public partial class OBRisk1DeliveryAddress :  IEquatable<OBRisk1DeliveryAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OBRisk1DeliveryAddress" /> class.
        /// </summary>
        [JsonConstructor]
        protected OBRisk1DeliveryAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBRisk1DeliveryAddress" /> class.
        /// </summary>
        /// <param name="streetName">Name of a street or thoroughfare..</param>
        /// <param name="countrySubDivision">Identifies a subdivision of a country, for instance state, region, county..</param>
        /// <param name="addressLine">Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text..</param>
        /// <param name="buildingNumber">Number that identifies the position of a building on a street..</param>
        /// <param name="townName">Name of a built-up area, with defined boundaries, and a local government. (required).</param>
        /// <param name="country">Nation with its own government, occupying a particular territory. (required).</param>
        /// <param name="postCode">Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail..</param>
        public OBRisk1DeliveryAddress(string streetName = default(string), List<string> countrySubDivision = default(List<string>), List<string> addressLine = default(List<string>), string buildingNumber = default(string), string townName = default(string), string country = default(string), string postCode = default(string))
        {
            // to ensure "townName" is required (not null)
            if (townName == null)
            {
                throw new InvalidDataException("townName is a required property for OBRisk1DeliveryAddress and cannot be null");
            }
            else
            {
                this.TownName = townName;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for OBRisk1DeliveryAddress and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            this.StreetName = streetName;
            this.CountrySubDivision = countrySubDivision;
            this.AddressLine = addressLine;
            this.BuildingNumber = buildingNumber;
            this.PostCode = postCode;
        }
        
        /// <summary>
        /// Name of a street or thoroughfare.
        /// </summary>
        /// <value>Name of a street or thoroughfare.</value>
        [DataMember(Name="StreetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Identifies a subdivision of a country, for instance state, region, county.
        /// </summary>
        /// <value>Identifies a subdivision of a country, for instance state, region, county.</value>
        [DataMember(Name="CountrySubDivision", EmitDefaultValue=false)]
        public List<string> CountrySubDivision { get; set; }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
        /// </summary>
        /// <value>Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.</value>
        [DataMember(Name="AddressLine", EmitDefaultValue=false)]
        public List<string> AddressLine { get; set; }

        /// <summary>
        /// Number that identifies the position of a building on a street.
        /// </summary>
        /// <value>Number that identifies the position of a building on a street.</value>
        [DataMember(Name="BuildingNumber", EmitDefaultValue=false)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.
        /// </summary>
        /// <value>Name of a built-up area, with defined boundaries, and a local government.</value>
        [DataMember(Name="TownName", EmitDefaultValue=false)]
        public string TownName { get; set; }

        /// <summary>
        /// Nation with its own government, occupying a particular territory.
        /// </summary>
        /// <value>Nation with its own government, occupying a particular territory.</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
        /// </summary>
        /// <value>Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.</value>
        [DataMember(Name="PostCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBRisk1DeliveryAddress {\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  CountrySubDivision: ").Append(CountrySubDivision).Append("\n");
            sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
            sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
            sb.Append("  TownName: ").Append(TownName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
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
            return this.Equals(input as OBRisk1DeliveryAddress);
        }

        /// <summary>
        /// Returns true if OBRisk1DeliveryAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of OBRisk1DeliveryAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBRisk1DeliveryAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.CountrySubDivision == input.CountrySubDivision ||
                    this.CountrySubDivision != null &&
                    this.CountrySubDivision.SequenceEqual(input.CountrySubDivision)
                ) && 
                (
                    this.AddressLine == input.AddressLine ||
                    this.AddressLine != null &&
                    this.AddressLine.SequenceEqual(input.AddressLine)
                ) && 
                (
                    this.BuildingNumber == input.BuildingNumber ||
                    (this.BuildingNumber != null &&
                    this.BuildingNumber.Equals(input.BuildingNumber))
                ) && 
                (
                    this.TownName == input.TownName ||
                    (this.TownName != null &&
                    this.TownName.Equals(input.TownName))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
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
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.CountrySubDivision != null)
                    hashCode = hashCode * 59 + this.CountrySubDivision.GetHashCode();
                if (this.AddressLine != null)
                    hashCode = hashCode * 59 + this.AddressLine.GetHashCode();
                if (this.BuildingNumber != null)
                    hashCode = hashCode * 59 + this.BuildingNumber.GetHashCode();
                if (this.TownName != null)
                    hashCode = hashCode * 59 + this.TownName.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
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
            // StreetName (string) maxLength
            if(this.StreetName != null && this.StreetName.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetName, length must be less than 70.", new [] { "StreetName" });
            }

            // StreetName (string) minLength
            if(this.StreetName != null && this.StreetName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetName, length must be greater than 1.", new [] { "StreetName" });
            }

            // BuildingNumber (string) maxLength
            if(this.BuildingNumber != null && this.BuildingNumber.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuildingNumber, length must be less than 16.", new [] { "BuildingNumber" });
            }

            // BuildingNumber (string) minLength
            if(this.BuildingNumber != null && this.BuildingNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuildingNumber, length must be greater than 1.", new [] { "BuildingNumber" });
            }

            // TownName (string) maxLength
            if(this.TownName != null && this.TownName.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TownName, length must be less than 35.", new [] { "TownName" });
            }

            // TownName (string) minLength
            if(this.TownName != null && this.TownName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TownName, length must be greater than 1.", new [] { "TownName" });
            }

            // Country (string) pattern
            Regex regexCountry = new Regex(@"^[A-Z]{2,2}$", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new [] { "Country" });
            }

            // PostCode (string) maxLength
            if(this.PostCode != null && this.PostCode.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostCode, length must be less than 16.", new [] { "PostCode" });
            }

            // PostCode (string) minLength
            if(this.PostCode != null && this.PostCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostCode, length must be greater than 1.", new [] { "PostCode" });
            }

            yield break;
        }
    }

}
