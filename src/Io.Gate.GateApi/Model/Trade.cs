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
    /// Trade
    /// </summary>
    [DataContract]
    public partial class Trade :  IEquatable<Trade>, IValidatableObject
    {
        /// <summary>
        /// Order side
        /// </summary>
        /// <value>Order side</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SideEnum
        {
            /// <summary>
            /// Enum Buy for value: buy
            /// </summary>
            [EnumMember(Value = "buy")]
            Buy = 1,

            /// <summary>
            /// Enum Sell for value: sell
            /// </summary>
            [EnumMember(Value = "sell")]
            Sell = 2

        }

        /// <summary>
        /// Order side
        /// </summary>
        /// <value>Order side</value>
        [DataMember(Name="side")]
        public SideEnum? Side { get; set; }
        /// <summary>
        /// Trade role. No value in public endpoints
        /// </summary>
        /// <value>Trade role. No value in public endpoints</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum Taker for value: taker
            /// </summary>
            [EnumMember(Value = "taker")]
            Taker = 1,

            /// <summary>
            /// Enum Maker for value: maker
            /// </summary>
            [EnumMember(Value = "maker")]
            Maker = 2

        }

        /// <summary>
        /// Trade role. No value in public endpoints
        /// </summary>
        /// <value>Trade role. No value in public endpoints</value>
        [DataMember(Name="role")]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trade" /> class.
        /// </summary>
        /// <param name="id">Trade ID.</param>
        /// <param name="createTime">Trading time.</param>
        /// <param name="createTimeMs">Trading time, with millisecond precision.</param>
        /// <param name="currencyPair">Currency pair.</param>
        /// <param name="side">Order side.</param>
        /// <param name="role">Trade role. No value in public endpoints.</param>
        /// <param name="amount">Trade amount.</param>
        /// <param name="price">Order price.</param>
        /// <param name="orderId">Related order ID. No value in public endpoints.</param>
        /// <param name="fee">Fee deducted. No value in public endpoints.</param>
        /// <param name="feeCurrency">Fee currency unit. No value in public endpoints.</param>
        /// <param name="pointFee">Points used to deduct fee. No value in public endpoints.</param>
        /// <param name="gtFee">GT used to deduct fee. No value in public endpoints.</param>
        /// <param name="amendText">The custom data that the user remarked when amending the order.</param>
        /// <param name="sequenceId">Represents a unique and consecutive trade ID within a single market. It is used to track and identify trades in the specific market.</param>
        /// <param name="text">User defined information. No value in public endpoints.</param>
        public Trade(string id = default(string), string createTime = default(string), string createTimeMs = default(string), string currencyPair = default(string), SideEnum? side = default(SideEnum?), RoleEnum? role = default(RoleEnum?), string amount = default(string), string price = default(string), string orderId = default(string), string fee = default(string), string feeCurrency = default(string), string pointFee = default(string), string gtFee = default(string), string amendText = default(string), string sequenceId = default(string), string text = default(string))
        {
            this.Id = id;
            this.CreateTime = createTime;
            this.CreateTimeMs = createTimeMs;
            this.CurrencyPair = currencyPair;
            this.Side = side;
            this.Role = role;
            this.Amount = amount;
            this.Price = price;
            this.OrderId = orderId;
            this.Fee = fee;
            this.FeeCurrency = feeCurrency;
            this.PointFee = pointFee;
            this.GtFee = gtFee;
            this.AmendText = amendText;
            this.SequenceId = sequenceId;
            this.Text = text;
        }

        /// <summary>
        /// Trade ID
        /// </summary>
        /// <value>Trade ID</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Trading time
        /// </summary>
        /// <value>Trading time</value>
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// Trading time, with millisecond precision
        /// </summary>
        /// <value>Trading time, with millisecond precision</value>
        [DataMember(Name="create_time_ms")]
        public string CreateTimeMs { get; set; }

        /// <summary>
        /// Currency pair
        /// </summary>
        /// <value>Currency pair</value>
        [DataMember(Name="currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Trade amount
        /// </summary>
        /// <value>Trade amount</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Order price
        /// </summary>
        /// <value>Order price</value>
        [DataMember(Name="price")]
        public string Price { get; set; }

        /// <summary>
        /// Related order ID. No value in public endpoints
        /// </summary>
        /// <value>Related order ID. No value in public endpoints</value>
        [DataMember(Name="order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// Fee deducted. No value in public endpoints
        /// </summary>
        /// <value>Fee deducted. No value in public endpoints</value>
        [DataMember(Name="fee")]
        public string Fee { get; set; }

        /// <summary>
        /// Fee currency unit. No value in public endpoints
        /// </summary>
        /// <value>Fee currency unit. No value in public endpoints</value>
        [DataMember(Name="fee_currency")]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// Points used to deduct fee. No value in public endpoints
        /// </summary>
        /// <value>Points used to deduct fee. No value in public endpoints</value>
        [DataMember(Name="point_fee")]
        public string PointFee { get; set; }

        /// <summary>
        /// GT used to deduct fee. No value in public endpoints
        /// </summary>
        /// <value>GT used to deduct fee. No value in public endpoints</value>
        [DataMember(Name="gt_fee")]
        public string GtFee { get; set; }

        /// <summary>
        /// The custom data that the user remarked when amending the order
        /// </summary>
        /// <value>The custom data that the user remarked when amending the order</value>
        [DataMember(Name="amend_text")]
        public string AmendText { get; set; }

        /// <summary>
        /// Represents a unique and consecutive trade ID within a single market. It is used to track and identify trades in the specific market
        /// </summary>
        /// <value>Represents a unique and consecutive trade ID within a single market. It is used to track and identify trades in the specific market</value>
        [DataMember(Name="sequence_id")]
        public string SequenceId { get; set; }

        /// <summary>
        /// User defined information. No value in public endpoints
        /// </summary>
        /// <value>User defined information. No value in public endpoints</value>
        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trade {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  CreateTimeMs: ").Append(CreateTimeMs).Append("\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FeeCurrency: ").Append(FeeCurrency).Append("\n");
            sb.Append("  PointFee: ").Append(PointFee).Append("\n");
            sb.Append("  GtFee: ").Append(GtFee).Append("\n");
            sb.Append("  AmendText: ").Append(AmendText).Append("\n");
            sb.Append("  SequenceId: ").Append(SequenceId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as Trade);
        }

        /// <summary>
        /// Returns true if Trade instances are equal
        /// </summary>
        /// <param name="input">Instance of Trade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trade input)
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
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.CreateTimeMs == input.CreateTimeMs ||
                    (this.CreateTimeMs != null &&
                    this.CreateTimeMs.Equals(input.CreateTimeMs))
                ) && 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
                ) && 
                (
                    this.Side == input.Side ||
                    this.Side.Equals(input.Side)
                ) && 
                (
                    this.Role == input.Role ||
                    this.Role.Equals(input.Role)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.FeeCurrency == input.FeeCurrency ||
                    (this.FeeCurrency != null &&
                    this.FeeCurrency.Equals(input.FeeCurrency))
                ) && 
                (
                    this.PointFee == input.PointFee ||
                    (this.PointFee != null &&
                    this.PointFee.Equals(input.PointFee))
                ) && 
                (
                    this.GtFee == input.GtFee ||
                    (this.GtFee != null &&
                    this.GtFee.Equals(input.GtFee))
                ) && 
                (
                    this.AmendText == input.AmendText ||
                    (this.AmendText != null &&
                    this.AmendText.Equals(input.AmendText))
                ) && 
                (
                    this.SequenceId == input.SequenceId ||
                    (this.SequenceId != null &&
                    this.SequenceId.Equals(input.SequenceId))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeMs != null)
                    hashCode = hashCode * 59 + this.CreateTimeMs.GetHashCode();
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
                hashCode = hashCode * 59 + this.Side.GetHashCode();
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.FeeCurrency != null)
                    hashCode = hashCode * 59 + this.FeeCurrency.GetHashCode();
                if (this.PointFee != null)
                    hashCode = hashCode * 59 + this.PointFee.GetHashCode();
                if (this.GtFee != null)
                    hashCode = hashCode * 59 + this.GtFee.GetHashCode();
                if (this.AmendText != null)
                    hashCode = hashCode * 59 + this.AmendText.GetHashCode();
                if (this.SequenceId != null)
                    hashCode = hashCode * 59 + this.SequenceId.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
