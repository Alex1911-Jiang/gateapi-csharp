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
    /// Futures order details
    /// </summary>
    [DataContract]
    public partial class FuturesOrder :  IEquatable<FuturesOrder>, IValidatableObject
    {
        /// <summary>
        /// How the order is finished.  - filled: all filled - cancelled: manually cancelled - liquidated: cancelled because of liquidation - ioc: time in force is &#x60;IOC&#x60;, finish immediately - auto_deleveraged: finished by ADL - reduce_only: cancelled because of increasing position while &#x60;reduce-only&#x60; set
        /// </summary>
        /// <value>How the order is finished.  - filled: all filled - cancelled: manually cancelled - liquidated: cancelled because of liquidation - ioc: time in force is &#x60;IOC&#x60;, finish immediately - auto_deleveraged: finished by ADL - reduce_only: cancelled because of increasing position while &#x60;reduce-only&#x60; set</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FinishAsEnum
        {
            /// <summary>
            /// Enum Filled for value: filled
            /// </summary>
            [EnumMember(Value = "filled")]
            Filled = 1,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 2,

            /// <summary>
            /// Enum Liquidated for value: liquidated
            /// </summary>
            [EnumMember(Value = "liquidated")]
            Liquidated = 3,

            /// <summary>
            /// Enum Ioc for value: ioc
            /// </summary>
            [EnumMember(Value = "ioc")]
            Ioc = 4,

            /// <summary>
            /// Enum Autodeleveraged for value: auto_deleveraged
            /// </summary>
            [EnumMember(Value = "auto_deleveraged")]
            Autodeleveraged = 5,

            /// <summary>
            /// Enum Reduceonly for value: reduce_only
            /// </summary>
            [EnumMember(Value = "reduce_only")]
            Reduceonly = 6

        }

        /// <summary>
        /// How the order is finished.  - filled: all filled - cancelled: manually cancelled - liquidated: cancelled because of liquidation - ioc: time in force is &#x60;IOC&#x60;, finish immediately - auto_deleveraged: finished by ADL - reduce_only: cancelled because of increasing position while &#x60;reduce-only&#x60; set
        /// </summary>
        /// <value>How the order is finished.  - filled: all filled - cancelled: manually cancelled - liquidated: cancelled because of liquidation - ioc: time in force is &#x60;IOC&#x60;, finish immediately - auto_deleveraged: finished by ADL - reduce_only: cancelled because of increasing position while &#x60;reduce-only&#x60; set</value>
        [DataMember(Name="finish_as", EmitDefaultValue=false)]
        public FinishAsEnum? FinishAs { get; set; }
        /// <summary>
        /// Order status  - &#x60;open&#x60;: waiting to be traded - &#x60;finished&#x60;: finished
        /// </summary>
        /// <value>Order status  - &#x60;open&#x60;: waiting to be traded - &#x60;finished&#x60;: finished</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Finished for value: finished
            /// </summary>
            [EnumMember(Value = "finished")]
            Finished = 2

        }

        /// <summary>
        /// Order status  - &#x60;open&#x60;: waiting to be traded - &#x60;finished&#x60;: finished
        /// </summary>
        /// <value>Order status  - &#x60;open&#x60;: waiting to be traded - &#x60;finished&#x60;: finished</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Time in force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only - poc: PendingOrCancelled, reduce-only
        /// </summary>
        /// <value>Time in force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only - poc: PendingOrCancelled, reduce-only</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TifEnum
        {
            /// <summary>
            /// Enum Gtc for value: gtc
            /// </summary>
            [EnumMember(Value = "gtc")]
            Gtc = 1,

            /// <summary>
            /// Enum Ioc for value: ioc
            /// </summary>
            [EnumMember(Value = "ioc")]
            Ioc = 2,

            /// <summary>
            /// Enum Poc for value: poc
            /// </summary>
            [EnumMember(Value = "poc")]
            Poc = 3

        }

        /// <summary>
        /// Time in force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only - poc: PendingOrCancelled, reduce-only
        /// </summary>
        /// <value>Time in force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only - poc: PendingOrCancelled, reduce-only</value>
        [DataMember(Name="tif", EmitDefaultValue=false)]
        public TifEnum? Tif { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FuturesOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesOrder" /> class.
        /// </summary>
        /// <param name="contract">Futures contract (required).</param>
        /// <param name="size">Order size. Specify positive number to make a bid, and negative number to ask (required).</param>
        /// <param name="iceberg">Display size for iceberg order. 0 for non-iceberg. Note that you would pay the taker fee for the hidden size.</param>
        /// <param name="price">Order price. 0 for market order with &#x60;tif&#x60; set as &#x60;ioc&#x60;.</param>
        /// <param name="close">Set as &#x60;true&#x60; to close the position, with &#x60;size&#x60; set to 0 (default to false).</param>
        /// <param name="reduceOnly">Set as &#x60;true&#x60; to be reduce-only order (default to false).</param>
        /// <param name="tif">Time in force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only - poc: PendingOrCancelled, reduce-only (default to TifEnum.Gtc).</param>
        /// <param name="text">User defined information. If not empty, must follow the rules below:  1. prefixed with &#x60;t-&#x60; 2. no longer than 28 bytes without &#x60;t-&#x60; prefix 3. can only include 0-9, A-Z, a-z, underscore(_), hyphen(-) or dot(.) Besides user defined information, reserved contents are listed below, denoting how the order is created:  - web: from web - api: from API - app: from mobile phones - auto_deleveraging: from ADL - liquidation: from liquidation - insurance: from insurance .</param>
        public FuturesOrder(string contract = default(string), long size = default(long), long iceberg = default(long), string price = default(string), bool close = false, bool reduceOnly = false, TifEnum? tif = TifEnum.Gtc, string text = default(string))
        {
            // to ensure "contract" is required (not null)
            this.Contract = contract ?? throw new ArgumentNullException("contract", "contract is a required property for FuturesOrder and cannot be null");
            this.Size = size;
            this.Iceberg = iceberg;
            this.Price = price;
            this.Close = close;
            this.ReduceOnly = reduceOnly;
            this.Tif = tif;
            this.Text = text;
        }

        /// <summary>
        /// Futures order ID
        /// </summary>
        /// <value>Futures order ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; private set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int User { get; private set; }

        /// <summary>
        /// Order creation time
        /// </summary>
        /// <value>Order creation time</value>
        [DataMember(Name="create_time", EmitDefaultValue=false)]
        public decimal CreateTime { get; private set; }

        /// <summary>
        /// Order finished time. Not returned if order is open
        /// </summary>
        /// <value>Order finished time. Not returned if order is open</value>
        [DataMember(Name="finish_time", EmitDefaultValue=false)]
        public decimal FinishTime { get; private set; }

        /// <summary>
        /// Futures contract
        /// </summary>
        /// <value>Futures contract</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; set; }

        /// <summary>
        /// Order size. Specify positive number to make a bid, and negative number to ask
        /// </summary>
        /// <value>Order size. Specify positive number to make a bid, and negative number to ask</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long Size { get; set; }

        /// <summary>
        /// Display size for iceberg order. 0 for non-iceberg. Note that you would pay the taker fee for the hidden size
        /// </summary>
        /// <value>Display size for iceberg order. 0 for non-iceberg. Note that you would pay the taker fee for the hidden size</value>
        [DataMember(Name="iceberg", EmitDefaultValue=false)]
        public long Iceberg { get; set; }

        /// <summary>
        /// Order price. 0 for market order with &#x60;tif&#x60; set as &#x60;ioc&#x60;
        /// </summary>
        /// <value>Order price. 0 for market order with &#x60;tif&#x60; set as &#x60;ioc&#x60;</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }

        /// <summary>
        /// Set as &#x60;true&#x60; to close the position, with &#x60;size&#x60; set to 0
        /// </summary>
        /// <value>Set as &#x60;true&#x60; to close the position, with &#x60;size&#x60; set to 0</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public bool Close { get; set; }

        /// <summary>
        /// Is the order to close position
        /// </summary>
        /// <value>Is the order to close position</value>
        [DataMember(Name="is_close", EmitDefaultValue=false)]
        public bool IsClose { get; private set; }

        /// <summary>
        /// Set as &#x60;true&#x60; to be reduce-only order
        /// </summary>
        /// <value>Set as &#x60;true&#x60; to be reduce-only order</value>
        [DataMember(Name="reduce_only", EmitDefaultValue=false)]
        public bool ReduceOnly { get; set; }

        /// <summary>
        /// Is the order reduce-only
        /// </summary>
        /// <value>Is the order reduce-only</value>
        [DataMember(Name="is_reduce_only", EmitDefaultValue=false)]
        public bool IsReduceOnly { get; private set; }

        /// <summary>
        /// Is the order for liquidation
        /// </summary>
        /// <value>Is the order for liquidation</value>
        [DataMember(Name="is_liq", EmitDefaultValue=false)]
        public bool IsLiq { get; private set; }

        /// <summary>
        /// Size left to be traded
        /// </summary>
        /// <value>Size left to be traded</value>
        [DataMember(Name="left", EmitDefaultValue=false)]
        public long Left { get; private set; }

        /// <summary>
        /// Fill price of the order
        /// </summary>
        /// <value>Fill price of the order</value>
        [DataMember(Name="fill_price", EmitDefaultValue=false)]
        public string FillPrice { get; private set; }

        /// <summary>
        /// User defined information. If not empty, must follow the rules below:  1. prefixed with &#x60;t-&#x60; 2. no longer than 28 bytes without &#x60;t-&#x60; prefix 3. can only include 0-9, A-Z, a-z, underscore(_), hyphen(-) or dot(.) Besides user defined information, reserved contents are listed below, denoting how the order is created:  - web: from web - api: from API - app: from mobile phones - auto_deleveraging: from ADL - liquidation: from liquidation - insurance: from insurance 
        /// </summary>
        /// <value>User defined information. If not empty, must follow the rules below:  1. prefixed with &#x60;t-&#x60; 2. no longer than 28 bytes without &#x60;t-&#x60; prefix 3. can only include 0-9, A-Z, a-z, underscore(_), hyphen(-) or dot(.) Besides user defined information, reserved contents are listed below, denoting how the order is created:  - web: from web - api: from API - app: from mobile phones - auto_deleveraging: from ADL - liquidation: from liquidation - insurance: from insurance </value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Taker fee
        /// </summary>
        /// <value>Taker fee</value>
        [DataMember(Name="tkfr", EmitDefaultValue=false)]
        public string Tkfr { get; private set; }

        /// <summary>
        /// Maker fee
        /// </summary>
        /// <value>Maker fee</value>
        [DataMember(Name="mkfr", EmitDefaultValue=false)]
        public string Mkfr { get; private set; }

        /// <summary>
        /// Reference user ID
        /// </summary>
        /// <value>Reference user ID</value>
        [DataMember(Name="refu", EmitDefaultValue=false)]
        public int Refu { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  FinishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  FinishAs: ").Append(FinishAs).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Iceberg: ").Append(Iceberg).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  IsClose: ").Append(IsClose).Append("\n");
            sb.Append("  ReduceOnly: ").Append(ReduceOnly).Append("\n");
            sb.Append("  IsReduceOnly: ").Append(IsReduceOnly).Append("\n");
            sb.Append("  IsLiq: ").Append(IsLiq).Append("\n");
            sb.Append("  Tif: ").Append(Tif).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  FillPrice: ").Append(FillPrice).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Tkfr: ").Append(Tkfr).Append("\n");
            sb.Append("  Mkfr: ").Append(Mkfr).Append("\n");
            sb.Append("  Refu: ").Append(Refu).Append("\n");
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
            return this.Equals(input as FuturesOrder);
        }

        /// <summary>
        /// Returns true if FuturesOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.User == input.User ||
                    this.User.Equals(input.User)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.FinishTime == input.FinishTime ||
                    this.FinishTime.Equals(input.FinishTime)
                ) && 
                (
                    this.FinishAs == input.FinishAs ||
                    this.FinishAs.Equals(input.FinishAs)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Iceberg == input.Iceberg ||
                    this.Iceberg.Equals(input.Iceberg)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Close == input.Close ||
                    this.Close.Equals(input.Close)
                ) && 
                (
                    this.IsClose == input.IsClose ||
                    this.IsClose.Equals(input.IsClose)
                ) && 
                (
                    this.ReduceOnly == input.ReduceOnly ||
                    this.ReduceOnly.Equals(input.ReduceOnly)
                ) && 
                (
                    this.IsReduceOnly == input.IsReduceOnly ||
                    this.IsReduceOnly.Equals(input.IsReduceOnly)
                ) && 
                (
                    this.IsLiq == input.IsLiq ||
                    this.IsLiq.Equals(input.IsLiq)
                ) && 
                (
                    this.Tif == input.Tif ||
                    this.Tif.Equals(input.Tif)
                ) && 
                (
                    this.Left == input.Left ||
                    this.Left.Equals(input.Left)
                ) && 
                (
                    this.FillPrice == input.FillPrice ||
                    (this.FillPrice != null &&
                    this.FillPrice.Equals(input.FillPrice))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Tkfr == input.Tkfr ||
                    (this.Tkfr != null &&
                    this.Tkfr.Equals(input.Tkfr))
                ) && 
                (
                    this.Mkfr == input.Mkfr ||
                    (this.Mkfr != null &&
                    this.Mkfr.Equals(input.Mkfr))
                ) && 
                (
                    this.Refu == input.Refu ||
                    this.Refu.Equals(input.Refu)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.User.GetHashCode();
                hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                hashCode = hashCode * 59 + this.FinishAs.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.Iceberg.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Close.GetHashCode();
                hashCode = hashCode * 59 + this.IsClose.GetHashCode();
                hashCode = hashCode * 59 + this.ReduceOnly.GetHashCode();
                hashCode = hashCode * 59 + this.IsReduceOnly.GetHashCode();
                hashCode = hashCode * 59 + this.IsLiq.GetHashCode();
                hashCode = hashCode * 59 + this.Tif.GetHashCode();
                hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.FillPrice != null)
                    hashCode = hashCode * 59 + this.FillPrice.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Tkfr != null)
                    hashCode = hashCode * 59 + this.Tkfr.GetHashCode();
                if (this.Mkfr != null)
                    hashCode = hashCode * 59 + this.Mkfr.GetHashCode();
                hashCode = hashCode * 59 + this.Refu.GetHashCode();
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
