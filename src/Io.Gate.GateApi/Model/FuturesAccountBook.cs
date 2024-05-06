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
    /// FuturesAccountBook
    /// </summary>
    [DataContract]
    public partial class FuturesAccountBook :  IEquatable<FuturesAccountBook>, IValidatableObject
    {
        /// <summary>
        /// Changing Type：  - dnw: Deposit &amp; Withdraw - pnl: Profit &amp; Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: POINT Deposit &amp; Withdraw - point_fee: POINT Trading fee - point_refr: POINT Referrer rebate - bonus_offset: bouns deduction
        /// </summary>
        /// <value>Changing Type：  - dnw: Deposit &amp; Withdraw - pnl: Profit &amp; Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: POINT Deposit &amp; Withdraw - point_fee: POINT Trading fee - point_refr: POINT Referrer rebate - bonus_offset: bouns deduction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Dnw for value: dnw
            /// </summary>
            [EnumMember(Value = "dnw")]
            Dnw = 1,

            /// <summary>
            /// Enum Pnl for value: pnl
            /// </summary>
            [EnumMember(Value = "pnl")]
            Pnl = 2,

            /// <summary>
            /// Enum Fee for value: fee
            /// </summary>
            [EnumMember(Value = "fee")]
            Fee = 3,

            /// <summary>
            /// Enum Refr for value: refr
            /// </summary>
            [EnumMember(Value = "refr")]
            Refr = 4,

            /// <summary>
            /// Enum Fund for value: fund
            /// </summary>
            [EnumMember(Value = "fund")]
            Fund = 5,

            /// <summary>
            /// Enum Pointdnw for value: point_dnw
            /// </summary>
            [EnumMember(Value = "point_dnw")]
            Pointdnw = 6,

            /// <summary>
            /// Enum Pointfee for value: point_fee
            /// </summary>
            [EnumMember(Value = "point_fee")]
            Pointfee = 7,

            /// <summary>
            /// Enum Pointrefr for value: point_refr
            /// </summary>
            [EnumMember(Value = "point_refr")]
            Pointrefr = 8,

            /// <summary>
            /// Enum Bonusoffset for value: bonus_offset
            /// </summary>
            [EnumMember(Value = "bonus_offset")]
            Bonusoffset = 9

        }

        /// <summary>
        /// Changing Type：  - dnw: Deposit &amp; Withdraw - pnl: Profit &amp; Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: POINT Deposit &amp; Withdraw - point_fee: POINT Trading fee - point_refr: POINT Referrer rebate - bonus_offset: bouns deduction
        /// </summary>
        /// <value>Changing Type：  - dnw: Deposit &amp; Withdraw - pnl: Profit &amp; Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: POINT Deposit &amp; Withdraw - point_fee: POINT Trading fee - point_refr: POINT Referrer rebate - bonus_offset: bouns deduction</value>
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesAccountBook" /> class.
        /// </summary>
        /// <param name="time">Change time.</param>
        /// <param name="change">Change amount.</param>
        /// <param name="balance">Balance after change.</param>
        /// <param name="type">Changing Type：  - dnw: Deposit &amp; Withdraw - pnl: Profit &amp; Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: POINT Deposit &amp; Withdraw - point_fee: POINT Trading fee - point_refr: POINT Referrer rebate - bonus_offset: bouns deduction.</param>
        /// <param name="text">Comment.</param>
        /// <param name="contract">Futures contract, the field is only available for data after 2023-10-30..</param>
        /// <param name="tradeId">trade id.</param>
        public FuturesAccountBook(double time = default(double), string change = default(string), string balance = default(string), TypeEnum? type = default(TypeEnum?), string text = default(string), string contract = default(string), string tradeId = default(string))
        {
            this.Time = time;
            this.Change = change;
            this.Balance = balance;
            this.Type = type;
            this.Text = text;
            this.Contract = contract;
            this.TradeId = tradeId;
        }

        /// <summary>
        /// Change time
        /// </summary>
        /// <value>Change time</value>
        [DataMember(Name="time")]
        public double Time { get; set; }

        /// <summary>
        /// Change amount
        /// </summary>
        /// <value>Change amount</value>
        [DataMember(Name="change")]
        public string Change { get; set; }

        /// <summary>
        /// Balance after change
        /// </summary>
        /// <value>Balance after change</value>
        [DataMember(Name="balance")]
        public string Balance { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        /// <value>Comment</value>
        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Futures contract, the field is only available for data after 2023-10-30.
        /// </summary>
        /// <value>Futures contract, the field is only available for data after 2023-10-30.</value>
        [DataMember(Name="contract")]
        public string Contract { get; set; }

        /// <summary>
        /// trade id
        /// </summary>
        /// <value>trade id</value>
        [DataMember(Name="trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesAccountBook {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
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
            return this.Equals(input as FuturesAccountBook);
        }

        /// <summary>
        /// Returns true if FuturesAccountBook instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesAccountBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesAccountBook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.TradeId == input.TradeId ||
                    (this.TradeId != null &&
                    this.TradeId.Equals(input.TradeId))
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
                hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.TradeId != null)
                    hashCode = hashCode * 59 + this.TradeId.GetHashCode();
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
