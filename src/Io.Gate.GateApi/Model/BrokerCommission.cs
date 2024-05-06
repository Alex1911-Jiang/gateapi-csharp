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
    /// BrokerCommission
    /// </summary>
    [DataContract]
    public partial class BrokerCommission :  IEquatable<BrokerCommission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrokerCommission" /> class.
        /// </summary>
        /// <param name="total">Total.</param>
        /// <param name="list">List of comission history.</param>
        public BrokerCommission(long total = default(long), List<BrokerCommission1> list = default(List<BrokerCommission1>))
        {
            this.Total = total;
            this.List = list;
        }

        /// <summary>
        /// Total
        /// </summary>
        /// <value>Total</value>
        [DataMember(Name="total")]
        public long Total { get; set; }

        /// <summary>
        /// List of comission history
        /// </summary>
        /// <value>List of comission history</value>
        [DataMember(Name="list")]
        public List<BrokerCommission1> List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrokerCommission {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
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
            return this.Equals(input as BrokerCommission);
        }

        /// <summary>
        /// Returns true if BrokerCommission instances are equal
        /// </summary>
        /// <param name="input">Instance of BrokerCommission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrokerCommission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.List == input.List ||
                    this.List != null &&
                    input.List != null &&
                    this.List.SequenceEqual(input.List)
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
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
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
