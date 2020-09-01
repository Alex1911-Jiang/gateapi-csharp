/*
 * Gate API v4
 *
 * APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
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
    /// FuturesPriceTrigger
    /// </summary>
    [DataContract]
    public partial class FuturesPriceTrigger :  IEquatable<FuturesPriceTrigger>, IValidatableObject
    {
        /// <summary>
        /// How the order will be triggered   - &#x60;0&#x60;: by price, which means order will be triggered on price condition satisfied  - &#x60;1&#x60;: by price gap, which means order will be triggered on gap of recent two prices of specified &#x60;price_type&#x60; satisfied.  Only &#x60;0&#x60; is supported currently
        /// </summary>
        /// <value>How the order will be triggered   - &#x60;0&#x60;: by price, which means order will be triggered on price condition satisfied  - &#x60;1&#x60;: by price gap, which means order will be triggered on gap of recent two prices of specified &#x60;price_type&#x60; satisfied.  Only &#x60;0&#x60; is supported currently</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrategyTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1

        }

        /// <summary>
        /// How the order will be triggered   - &#x60;0&#x60;: by price, which means order will be triggered on price condition satisfied  - &#x60;1&#x60;: by price gap, which means order will be triggered on gap of recent two prices of specified &#x60;price_type&#x60; satisfied.  Only &#x60;0&#x60; is supported currently
        /// </summary>
        /// <value>How the order will be triggered   - &#x60;0&#x60;: by price, which means order will be triggered on price condition satisfied  - &#x60;1&#x60;: by price gap, which means order will be triggered on gap of recent two prices of specified &#x60;price_type&#x60; satisfied.  Only &#x60;0&#x60; is supported currently</value>
        [DataMember(Name="strategy_type", EmitDefaultValue=false)]
        public StrategyTypeEnum? StrategyType { get; set; }
        /// <summary>
        /// Price type. 0 - latest deal price, 1 - mark price, 2 - index price
        /// </summary>
        /// <value>Price type. 0 - latest deal price, 1 - mark price, 2 - index price</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriceTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2

        }

        /// <summary>
        /// Price type. 0 - latest deal price, 1 - mark price, 2 - index price
        /// </summary>
        /// <value>Price type. 0 - latest deal price, 1 - mark price, 2 - index price</value>
        [DataMember(Name="price_type", EmitDefaultValue=false)]
        public PriceTypeEnum? PriceType { get; set; }
        /// <summary>
        /// Trigger condition type  - &#x60;1&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &gt;&#x3D; &#x60;price&#x60; - &#x60;2&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &lt;&#x3D; &#x60;price&#x60;
        /// </summary>
        /// <value>Trigger condition type  - &#x60;1&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &gt;&#x3D; &#x60;price&#x60; - &#x60;2&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &lt;&#x3D; &#x60;price&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RuleEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2

        }

        /// <summary>
        /// Trigger condition type  - &#x60;1&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &gt;&#x3D; &#x60;price&#x60; - &#x60;2&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &lt;&#x3D; &#x60;price&#x60;
        /// </summary>
        /// <value>Trigger condition type  - &#x60;1&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &gt;&#x3D; &#x60;price&#x60; - &#x60;2&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &lt;&#x3D; &#x60;price&#x60;</value>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public RuleEnum? Rule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesPriceTrigger" /> class.
        /// </summary>
        /// <param name="strategyType">How the order will be triggered   - &#x60;0&#x60;: by price, which means order will be triggered on price condition satisfied  - &#x60;1&#x60;: by price gap, which means order will be triggered on gap of recent two prices of specified &#x60;price_type&#x60; satisfied.  Only &#x60;0&#x60; is supported currently.</param>
        /// <param name="priceType">Price type. 0 - latest deal price, 1 - mark price, 2 - index price.</param>
        /// <param name="price">Value of price on price triggered, or price gap on price gap triggered.</param>
        /// <param name="rule">Trigger condition type  - &#x60;1&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &gt;&#x3D; &#x60;price&#x60; - &#x60;2&#x60;: calculated price based on &#x60;strategy_type&#x60; and &#x60;price_type&#x60; &lt;&#x3D; &#x60;price&#x60;.</param>
        /// <param name="expiration">How many seconds will the order wait for the condition being triggered. Order will be cancelled on timed out.</param>
        public FuturesPriceTrigger(StrategyTypeEnum? strategyType = default(StrategyTypeEnum?), PriceTypeEnum? priceType = default(PriceTypeEnum?), string price = default(string), RuleEnum? rule = default(RuleEnum?), int expiration = default(int))
        {
            this.StrategyType = strategyType;
            this.PriceType = priceType;
            this.Price = price;
            this.Rule = rule;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Value of price on price triggered, or price gap on price gap triggered
        /// </summary>
        /// <value>Value of price on price triggered, or price gap on price gap triggered</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }

        /// <summary>
        /// How many seconds will the order wait for the condition being triggered. Order will be cancelled on timed out
        /// </summary>
        /// <value>How many seconds will the order wait for the condition being triggered. Order will be cancelled on timed out</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public int Expiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesPriceTrigger {\n");
            sb.Append("  StrategyType: ").Append(StrategyType).Append("\n");
            sb.Append("  PriceType: ").Append(PriceType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(input as FuturesPriceTrigger);
        }

        /// <summary>
        /// Returns true if FuturesPriceTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesPriceTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesPriceTrigger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StrategyType == input.StrategyType ||
                    this.StrategyType.Equals(input.StrategyType)
                ) && 
                (
                    this.PriceType == input.PriceType ||
                    this.PriceType.Equals(input.PriceType)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Rule == input.Rule ||
                    this.Rule.Equals(input.Rule)
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    this.Expiration.Equals(input.Expiration)
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
                hashCode = hashCode * 59 + this.StrategyType.GetHashCode();
                hashCode = hashCode * 59 + this.PriceType.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Rule.GetHashCode();
                hashCode = hashCode * 59 + this.Expiration.GetHashCode();
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
