/* 
 * Payment Initiation API
 *
 * Swagger for Payment Initiation API Specification
 *
 * OpenAPI spec version: v3.1.1
 * Contact: ServiceDesk@openbanking.org.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModel.PaymentInitiation.V3p1p1.Model
{
    /// <summary>
    /// Specifies the status of resource in code form.
    /// </summary>
    /// <value>Specifies the status of resource in code form.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OBExternalStatus1Code
    {
        /// <summary>
        /// Enum InitiationCompleted for value: InitiationCompleted
        /// </summary>
        [EnumMember(Value = "InitiationCompleted")]
        InitiationCompleted = 1,

        /// <summary>
        /// Enum InitiationFailed for value: InitiationFailed
        /// </summary>
        [EnumMember(Value = "InitiationFailed")]
        InitiationFailed = 2,

        /// <summary>
        /// Enum InitiationPending for value: InitiationPending
        /// </summary>
        [EnumMember(Value = "InitiationPending")]
        InitiationPending = 3

    }

}
