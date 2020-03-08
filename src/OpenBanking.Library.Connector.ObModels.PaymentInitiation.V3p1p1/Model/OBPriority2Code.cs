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

namespace FinnovationLabs.OpenBanking.Library.Connector.ObModels.PaymentInitiation.V3p1p1.Model
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    /// <value>Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OBPriority2Code
    {
        /// <summary>
        /// Enum Normal for value: Normal
        /// </summary>
        [EnumMember(Value = "Normal")]
        Normal = 1,

        /// <summary>
        /// Enum Urgent for value: Urgent
        /// </summary>
        [EnumMember(Value = "Urgent")]
        Urgent = 2

    }

}