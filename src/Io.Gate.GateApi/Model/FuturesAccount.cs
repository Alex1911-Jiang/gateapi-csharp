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
    /// FuturesAccount
    /// </summary>
    [DataContract]
    public partial class FuturesAccount :  IEquatable<FuturesAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesAccount" /> class.
        /// </summary>
        /// <param name="total">total is the balance after the user&#39;s accumulated deposit, withdraw, profit and loss (including realized profit and loss, fund, fee and referral rebate), excluding unrealized profit and loss.  total &#x3D; SUM(history_dnw, history_pnl, history_fee, history_refr, history_fund).</param>
        /// <param name="unrealisedPnl">Unrealized PNL.</param>
        /// <param name="positionMargin">Position margin.</param>
        /// <param name="orderMargin">Order margin of unfinished orders.</param>
        /// <param name="available">The available balance for transferring or trading(including bonus.  Bonus can&#39;t be be withdrawn. The transfer amount needs to deduct the bonus).</param>
        /// <param name="point">POINT amount.</param>
        /// <param name="currency">Settle currency.</param>
        /// <param name="inDualMode">Whether dual mode is enabled.</param>
        /// <param name="enableCredit">Whether portfolio margin account mode is enabled.</param>
        /// <param name="positionInitialMargin">Initial margin position, applicable to the portfolio margin account model.</param>
        /// <param name="maintenanceMargin">Maintenance margin position, applicable to the portfolio margin account model.</param>
        /// <param name="bonus">Perpetual Contract Bonus.</param>
        /// <param name="enableEvolvedClassic">Classic account margin mode, true - enable new mode, false - revert to old mode..</param>
        /// <param name="history">history.</param>
        public FuturesAccount(string total = default(string), string unrealisedPnl = default(string), string positionMargin = default(string), string orderMargin = default(string), string available = default(string), string point = default(string), string currency = default(string), bool inDualMode = default(bool), bool enableCredit = default(bool), string positionInitialMargin = default(string), string maintenanceMargin = default(string), string bonus = default(string), bool enableEvolvedClassic = default(bool), FuturesAccountHistory history = default(FuturesAccountHistory))
        {
            this.Total = total;
            this.UnrealisedPnl = unrealisedPnl;
            this.PositionMargin = positionMargin;
            this.OrderMargin = orderMargin;
            this.Available = available;
            this.Point = point;
            this.Currency = currency;
            this.InDualMode = inDualMode;
            this.EnableCredit = enableCredit;
            this.PositionInitialMargin = positionInitialMargin;
            this.MaintenanceMargin = maintenanceMargin;
            this.Bonus = bonus;
            this.EnableEvolvedClassic = enableEvolvedClassic;
            this.History = history;
        }

        /// <summary>
        /// total is the balance after the user&#39;s accumulated deposit, withdraw, profit and loss (including realized profit and loss, fund, fee and referral rebate), excluding unrealized profit and loss.  total &#x3D; SUM(history_dnw, history_pnl, history_fee, history_refr, history_fund)
        /// </summary>
        /// <value>total is the balance after the user&#39;s accumulated deposit, withdraw, profit and loss (including realized profit and loss, fund, fee and referral rebate), excluding unrealized profit and loss.  total &#x3D; SUM(history_dnw, history_pnl, history_fee, history_refr, history_fund)</value>
        [DataMember(Name="total")]
        public string Total { get; set; }

        /// <summary>
        /// Unrealized PNL
        /// </summary>
        /// <value>Unrealized PNL</value>
        [DataMember(Name="unrealised_pnl")]
        public string UnrealisedPnl { get; set; }

        /// <summary>
        /// Position margin
        /// </summary>
        /// <value>Position margin</value>
        [DataMember(Name="position_margin")]
        public string PositionMargin { get; set; }

        /// <summary>
        /// Order margin of unfinished orders
        /// </summary>
        /// <value>Order margin of unfinished orders</value>
        [DataMember(Name="order_margin")]
        public string OrderMargin { get; set; }

        /// <summary>
        /// The available balance for transferring or trading(including bonus.  Bonus can&#39;t be be withdrawn. The transfer amount needs to deduct the bonus)
        /// </summary>
        /// <value>The available balance for transferring or trading(including bonus.  Bonus can&#39;t be be withdrawn. The transfer amount needs to deduct the bonus)</value>
        [DataMember(Name="available")]
        public string Available { get; set; }

        /// <summary>
        /// POINT amount
        /// </summary>
        /// <value>POINT amount</value>
        [DataMember(Name="point")]
        public string Point { get; set; }

        /// <summary>
        /// Settle currency
        /// </summary>
        /// <value>Settle currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether dual mode is enabled
        /// </summary>
        /// <value>Whether dual mode is enabled</value>
        [DataMember(Name="in_dual_mode")]
        public bool InDualMode { get; set; }

        /// <summary>
        /// Whether portfolio margin account mode is enabled
        /// </summary>
        /// <value>Whether portfolio margin account mode is enabled</value>
        [DataMember(Name="enable_credit")]
        public bool EnableCredit { get; set; }

        /// <summary>
        /// Initial margin position, applicable to the portfolio margin account model
        /// </summary>
        /// <value>Initial margin position, applicable to the portfolio margin account model</value>
        [DataMember(Name="position_initial_margin")]
        public string PositionInitialMargin { get; set; }

        /// <summary>
        /// Maintenance margin position, applicable to the portfolio margin account model
        /// </summary>
        /// <value>Maintenance margin position, applicable to the portfolio margin account model</value>
        [DataMember(Name="maintenance_margin")]
        public string MaintenanceMargin { get; set; }

        /// <summary>
        /// Perpetual Contract Bonus
        /// </summary>
        /// <value>Perpetual Contract Bonus</value>
        [DataMember(Name="bonus")]
        public string Bonus { get; set; }

        /// <summary>
        /// Classic account margin mode, true - enable new mode, false - revert to old mode.
        /// </summary>
        /// <value>Classic account margin mode, true - enable new mode, false - revert to old mode.</value>
        [DataMember(Name="enable_evolved_classic")]
        public bool EnableEvolvedClassic { get; set; }

        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name="history")]
        public FuturesAccountHistory History { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesAccount {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  UnrealisedPnl: ").Append(UnrealisedPnl).Append("\n");
            sb.Append("  PositionMargin: ").Append(PositionMargin).Append("\n");
            sb.Append("  OrderMargin: ").Append(OrderMargin).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Point: ").Append(Point).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  InDualMode: ").Append(InDualMode).Append("\n");
            sb.Append("  EnableCredit: ").Append(EnableCredit).Append("\n");
            sb.Append("  PositionInitialMargin: ").Append(PositionInitialMargin).Append("\n");
            sb.Append("  MaintenanceMargin: ").Append(MaintenanceMargin).Append("\n");
            sb.Append("  Bonus: ").Append(Bonus).Append("\n");
            sb.Append("  EnableEvolvedClassic: ").Append(EnableEvolvedClassic).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
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
            return this.Equals(input as FuturesAccount);
        }

        /// <summary>
        /// Returns true if FuturesAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.UnrealisedPnl == input.UnrealisedPnl ||
                    (this.UnrealisedPnl != null &&
                    this.UnrealisedPnl.Equals(input.UnrealisedPnl))
                ) && 
                (
                    this.PositionMargin == input.PositionMargin ||
                    (this.PositionMargin != null &&
                    this.PositionMargin.Equals(input.PositionMargin))
                ) && 
                (
                    this.OrderMargin == input.OrderMargin ||
                    (this.OrderMargin != null &&
                    this.OrderMargin.Equals(input.OrderMargin))
                ) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.Point == input.Point ||
                    (this.Point != null &&
                    this.Point.Equals(input.Point))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.InDualMode == input.InDualMode ||
                    this.InDualMode.Equals(input.InDualMode)
                ) && 
                (
                    this.EnableCredit == input.EnableCredit ||
                    this.EnableCredit.Equals(input.EnableCredit)
                ) && 
                (
                    this.PositionInitialMargin == input.PositionInitialMargin ||
                    (this.PositionInitialMargin != null &&
                    this.PositionInitialMargin.Equals(input.PositionInitialMargin))
                ) && 
                (
                    this.MaintenanceMargin == input.MaintenanceMargin ||
                    (this.MaintenanceMargin != null &&
                    this.MaintenanceMargin.Equals(input.MaintenanceMargin))
                ) && 
                (
                    this.Bonus == input.Bonus ||
                    (this.Bonus != null &&
                    this.Bonus.Equals(input.Bonus))
                ) && 
                (
                    this.EnableEvolvedClassic == input.EnableEvolvedClassic ||
                    this.EnableEvolvedClassic.Equals(input.EnableEvolvedClassic)
                ) && 
                (
                    this.History == input.History ||
                    (this.History != null &&
                    this.History.Equals(input.History))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.UnrealisedPnl != null)
                    hashCode = hashCode * 59 + this.UnrealisedPnl.GetHashCode();
                if (this.PositionMargin != null)
                    hashCode = hashCode * 59 + this.PositionMargin.GetHashCode();
                if (this.OrderMargin != null)
                    hashCode = hashCode * 59 + this.OrderMargin.GetHashCode();
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Point != null)
                    hashCode = hashCode * 59 + this.Point.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                hashCode = hashCode * 59 + this.InDualMode.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCredit.GetHashCode();
                if (this.PositionInitialMargin != null)
                    hashCode = hashCode * 59 + this.PositionInitialMargin.GetHashCode();
                if (this.MaintenanceMargin != null)
                    hashCode = hashCode * 59 + this.MaintenanceMargin.GetHashCode();
                if (this.Bonus != null)
                    hashCode = hashCode * 59 + this.Bonus.GetHashCode();
                hashCode = hashCode * 59 + this.EnableEvolvedClassic.GetHashCode();
                if (this.History != null)
                    hashCode = hashCode * 59 + this.History.GetHashCode();
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
