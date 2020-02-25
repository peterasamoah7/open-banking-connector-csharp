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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModel.PaymentInitiation.V3p1p1.Model
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [DataContract]
    public partial class OBPostalAddress6 :  IEquatable<OBPostalAddress6>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name="AddressType", EmitDefaultValue=false)]
        public OBAddressTypeCode? AddressType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OBPostalAddress6" /> class.
        /// </summary>
        /// <param name="addressType">addressType.</param>
        /// <param name="department">Identification of a division of a large organisation or building..</param>
        /// <param name="subDepartment">Identification of a sub-division of a large organisation or building..</param>
        /// <param name="streetName">Name of a street or thoroughfare..</param>
        /// <param name="buildingNumber">Number that identifies the position of a building on a street..</param>
        /// <param name="postCode">Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail..</param>
        /// <param name="townName">Name of a built-up area, with defined boundaries, and a local government..</param>
        /// <param name="countrySubDivision">Identifies a subdivision of a country such as state, region, county..</param>
        /// <param name="country">Nation with its own government..</param>
        /// <param name="addressLine">Information that locates and identifies a specific address, as defined by postal services, presented in free format text..</param>
        public OBPostalAddress6(OBAddressTypeCode? addressType = default(OBAddressTypeCode?), string department = default(string), string subDepartment = default(string), string streetName = default(string), string buildingNumber = default(string), string postCode = default(string), string townName = default(string), string countrySubDivision = default(string), string country = default(string), List<string> addressLine = default(List<string>))
        {
            this.AddressType = addressType;
            this.Department = department;
            this.SubDepartment = subDepartment;
            this.StreetName = streetName;
            this.BuildingNumber = buildingNumber;
            this.PostCode = postCode;
            this.TownName = townName;
            this.CountrySubDivision = countrySubDivision;
            this.Country = country;
            this.AddressLine = addressLine;
        }
        

        /// <summary>
        /// Identification of a division of a large organisation or building.
        /// </summary>
        /// <value>Identification of a division of a large organisation or building.</value>
        [DataMember(Name="Department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Identification of a sub-division of a large organisation or building.
        /// </summary>
        /// <value>Identification of a sub-division of a large organisation or building.</value>
        [DataMember(Name="SubDepartment", EmitDefaultValue=false)]
        public string SubDepartment { get; set; }

        /// <summary>
        /// Name of a street or thoroughfare.
        /// </summary>
        /// <value>Name of a street or thoroughfare.</value>
        [DataMember(Name="StreetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Number that identifies the position of a building on a street.
        /// </summary>
        /// <value>Number that identifies the position of a building on a street.</value>
        [DataMember(Name="BuildingNumber", EmitDefaultValue=false)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
        /// </summary>
        /// <value>Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.</value>
        [DataMember(Name="PostCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.
        /// </summary>
        /// <value>Name of a built-up area, with defined boundaries, and a local government.</value>
        [DataMember(Name="TownName", EmitDefaultValue=false)]
        public string TownName { get; set; }

        /// <summary>
        /// Identifies a subdivision of a country such as state, region, county.
        /// </summary>
        /// <value>Identifies a subdivision of a country such as state, region, county.</value>
        [DataMember(Name="CountrySubDivision", EmitDefaultValue=false)]
        public string CountrySubDivision { get; set; }

        /// <summary>
        /// Nation with its own government.
        /// </summary>
        /// <value>Nation with its own government.</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.
        /// </summary>
        /// <value>Information that locates and identifies a specific address, as defined by postal services, presented in free format text.</value>
        [DataMember(Name="AddressLine", EmitDefaultValue=false)]
        public List<string> AddressLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OBPostalAddress6 {\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  SubDepartment: ").Append(SubDepartment).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  TownName: ").Append(TownName).Append("\n");
            sb.Append("  CountrySubDivision: ").Append(CountrySubDivision).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
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
            return this.Equals(input as OBPostalAddress6);
        }

        /// <summary>
        /// Returns true if OBPostalAddress6 instances are equal
        /// </summary>
        /// <param name="input">Instance of OBPostalAddress6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OBPostalAddress6 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.SubDepartment == input.SubDepartment ||
                    (this.SubDepartment != null &&
                    this.SubDepartment.Equals(input.SubDepartment))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.BuildingNumber == input.BuildingNumber ||
                    (this.BuildingNumber != null &&
                    this.BuildingNumber.Equals(input.BuildingNumber))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.TownName == input.TownName ||
                    (this.TownName != null &&
                    this.TownName.Equals(input.TownName))
                ) && 
                (
                    this.CountrySubDivision == input.CountrySubDivision ||
                    (this.CountrySubDivision != null &&
                    this.CountrySubDivision.Equals(input.CountrySubDivision))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.AddressLine == input.AddressLine ||
                    this.AddressLine != null &&
                    this.AddressLine.SequenceEqual(input.AddressLine)
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
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.SubDepartment != null)
                    hashCode = hashCode * 59 + this.SubDepartment.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.BuildingNumber != null)
                    hashCode = hashCode * 59 + this.BuildingNumber.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.TownName != null)
                    hashCode = hashCode * 59 + this.TownName.GetHashCode();
                if (this.CountrySubDivision != null)
                    hashCode = hashCode * 59 + this.CountrySubDivision.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.AddressLine != null)
                    hashCode = hashCode * 59 + this.AddressLine.GetHashCode();
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
            // Department (string) maxLength
            if(this.Department != null && this.Department.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Department, length must be less than 70.", new [] { "Department" });
            }

            // Department (string) minLength
            if(this.Department != null && this.Department.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Department, length must be greater than 1.", new [] { "Department" });
            }

            // SubDepartment (string) maxLength
            if(this.SubDepartment != null && this.SubDepartment.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SubDepartment, length must be less than 70.", new [] { "SubDepartment" });
            }

            // SubDepartment (string) minLength
            if(this.SubDepartment != null && this.SubDepartment.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SubDepartment, length must be greater than 1.", new [] { "SubDepartment" });
            }

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

            // CountrySubDivision (string) maxLength
            if(this.CountrySubDivision != null && this.CountrySubDivision.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountrySubDivision, length must be less than 35.", new [] { "CountrySubDivision" });
            }

            // CountrySubDivision (string) minLength
            if(this.CountrySubDivision != null && this.CountrySubDivision.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountrySubDivision, length must be greater than 1.", new [] { "CountrySubDivision" });
            }

            // Country (string) pattern
            Regex regexCountry = new Regex(@"^[A-Z]{2,2}$", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new [] { "Country" });
            }

            yield break;
        }
    }

}
