/*
 * Gate API v4
 *
 * Welcome to Gate.io API  APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
 *
 * Contact: support@mail.gate.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Io.Gate.GateApi.Client.OpenAPIDateConverter;

namespace Io.Gate.GateApi.Model
{
    /// <summary>
    /// AutoRepaySetting
    /// </summary>
    [DataContract]
    public partial class AutoRepaySetting :  IEquatable<AutoRepaySetting>, IValidatableObject
    {
        /// <summary>
        /// Auto repayment status. &#x60;on&#x60; - enabled, &#x60;off&#x60; - disabled
        /// </summary>
        /// <value>Auto repayment status. &#x60;on&#x60; - enabled, &#x60;off&#x60; - disabled</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum True for value: true
            /// </summary>
            [EnumMember(Value = "true")]
            True = 1,

            /// <summary>
            /// Enum False for value: false
            /// </summary>
            [EnumMember(Value = "false")]
            False = 2

        }

        /// <summary>
        /// Auto repayment status. &#x60;on&#x60; - enabled, &#x60;off&#x60; - disabled
        /// </summary>
        /// <value>Auto repayment status. &#x60;on&#x60; - enabled, &#x60;off&#x60; - disabled</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRepaySetting" /> class.
        /// </summary>
        /// <param name="status">Auto repayment status. &#x60;on&#x60; - enabled, &#x60;off&#x60; - disabled.</param>
        public AutoRepaySetting(StatusEnum? status = default(StatusEnum?))
        {
            this.Status = status;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoRepaySetting {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AutoRepaySetting);
        }

        /// <summary>
        /// Returns true if AutoRepaySetting instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoRepaySetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoRepaySetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            yield break;
        }
    }

}
