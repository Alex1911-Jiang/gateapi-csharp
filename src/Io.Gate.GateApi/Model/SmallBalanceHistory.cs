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
    /// Convert Small Balance
    /// </summary>
    [DataContract]
    public partial class SmallBalanceHistory :  IEquatable<SmallBalanceHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmallBalanceHistory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SmallBalanceHistory()
        {
        }

        /// <summary>
        /// Order ID
        /// </summary>
        /// <value>Order ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// amount
        /// </summary>
        /// <value>amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; private set; }

        /// <summary>
        /// GT amount
        /// </summary>
        /// <value>GT amount</value>
        [DataMember(Name="gt_amount", EmitDefaultValue=false)]
        public string GtAmount { get; private set; }

        /// <summary>
        /// Exchange time (in seconds)
        /// </summary>
        /// <value>Exchange time (in seconds)</value>
        [DataMember(Name="create_time", EmitDefaultValue=false)]
        public long CreateTime { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmallBalanceHistory {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  GtAmount: ").Append(GtAmount).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
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
            return this.Equals(input as SmallBalanceHistory);
        }

        /// <summary>
        /// Returns true if SmallBalanceHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of SmallBalanceHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmallBalanceHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.GtAmount == input.GtAmount ||
                    (this.GtAmount != null &&
                    this.GtAmount.Equals(input.GtAmount))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.GtAmount != null)
                    hashCode = hashCode * 59 + this.GtAmount.GetHashCode();
                hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
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
