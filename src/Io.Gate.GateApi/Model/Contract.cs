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
    /// Futures contract details
    /// </summary>
    [DataContract]
    public partial class Contract :  IEquatable<Contract>, IValidatableObject
    {
        /// <summary>
        /// Futures contract type
        /// </summary>
        /// <value>Futures contract type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Inverse for value: inverse
            /// </summary>
            [EnumMember(Value = "inverse")]
            Inverse = 1,

            /// <summary>
            /// Enum Direct for value: direct
            /// </summary>
            [EnumMember(Value = "direct")]
            Direct = 2

        }

        /// <summary>
        /// Futures contract type
        /// </summary>
        /// <value>Futures contract type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Mark price type, internal - based on internal trading, index - based on external index price
        /// </summary>
        /// <value>Mark price type, internal - based on internal trading, index - based on external index price</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarkTypeEnum
        {
            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 1,

            /// <summary>
            /// Enum Index for value: index
            /// </summary>
            [EnumMember(Value = "index")]
            Index = 2

        }

        /// <summary>
        /// Mark price type, internal - based on internal trading, index - based on external index price
        /// </summary>
        /// <value>Mark price type, internal - based on internal trading, index - based on external index price</value>
        [DataMember(Name="mark_type", EmitDefaultValue=false)]
        public MarkTypeEnum? MarkType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class.
        /// </summary>
        /// <param name="name">Futures contract.</param>
        /// <param name="type">Futures contract type.</param>
        /// <param name="quantoMultiplier">Multiplier used in converting from invoicing to settlement currency in quanto futures.</param>
        /// <param name="leverageMin">Minimum leverage.</param>
        /// <param name="leverageMax">Maximum leverage.</param>
        /// <param name="maintenanceRate">Maintenance rate of margin.</param>
        /// <param name="markType">Mark price type, internal - based on internal trading, index - based on external index price.</param>
        /// <param name="markPrice">Current mark price.</param>
        /// <param name="indexPrice">Current index price.</param>
        /// <param name="lastPrice">Last trading price.</param>
        /// <param name="makerFeeRate">Maker fee rate, where negative means rebate.</param>
        /// <param name="takerFeeRate">Taker fee rate.</param>
        /// <param name="orderPriceRound">Minimum order price increment.</param>
        /// <param name="markPriceRound">Minimum mark price increment.</param>
        /// <param name="fundingRate">Current funding rate.</param>
        /// <param name="fundingInterval">Funding application interval, unit in seconds.</param>
        /// <param name="fundingNextApply">Next funding time.</param>
        /// <param name="riskLimitBase">Risk limit base.</param>
        /// <param name="riskLimitStep">Step of adjusting risk limit.</param>
        /// <param name="riskLimitMax">Maximum risk limit the contract allowed.</param>
        /// <param name="orderSizeMin">Minimum order size the contract allowed.</param>
        /// <param name="orderSizeMax">Maximum order size the contract allowed.</param>
        /// <param name="orderPriceDeviate">deviation between order price and current index price. If price of an order is denoted as order_price, it must meet the following condition:      abs(order_price - mark_price) &lt;&#x3D; mark_price * order_price_deviate.</param>
        /// <param name="refDiscountRate">Referral fee rate discount.</param>
        /// <param name="refRebateRate">Referrer commission rate.</param>
        /// <param name="orderbookId">Current orderbook ID.</param>
        /// <param name="tradeId">Current trade ID.</param>
        /// <param name="tradeSize">Historical accumulation trade size.</param>
        /// <param name="positionSize">Current total long position size.</param>
        /// <param name="configChangeTime">Configuration&#39;s last changed time.</param>
        /// <param name="inDelisting">Contract is delisting.</param>
        /// <param name="ordersLimit">Maximum number of open orders.</param>
        public Contract(string name = default(string), TypeEnum? type = default(TypeEnum?), string quantoMultiplier = default(string), string leverageMin = default(string), string leverageMax = default(string), string maintenanceRate = default(string), MarkTypeEnum? markType = default(MarkTypeEnum?), string markPrice = default(string), string indexPrice = default(string), string lastPrice = default(string), string makerFeeRate = default(string), string takerFeeRate = default(string), string orderPriceRound = default(string), string markPriceRound = default(string), string fundingRate = default(string), int fundingInterval = default(int), double fundingNextApply = default(double), string riskLimitBase = default(string), string riskLimitStep = default(string), string riskLimitMax = default(string), long orderSizeMin = default(long), long orderSizeMax = default(long), string orderPriceDeviate = default(string), string refDiscountRate = default(string), string refRebateRate = default(string), long orderbookId = default(long), long tradeId = default(long), long tradeSize = default(long), long positionSize = default(long), double configChangeTime = default(double), bool inDelisting = default(bool), int ordersLimit = default(int))
        {
            this.Name = name;
            this.Type = type;
            this.QuantoMultiplier = quantoMultiplier;
            this.LeverageMin = leverageMin;
            this.LeverageMax = leverageMax;
            this.MaintenanceRate = maintenanceRate;
            this.MarkType = markType;
            this.MarkPrice = markPrice;
            this.IndexPrice = indexPrice;
            this.LastPrice = lastPrice;
            this.MakerFeeRate = makerFeeRate;
            this.TakerFeeRate = takerFeeRate;
            this.OrderPriceRound = orderPriceRound;
            this.MarkPriceRound = markPriceRound;
            this.FundingRate = fundingRate;
            this.FundingInterval = fundingInterval;
            this.FundingNextApply = fundingNextApply;
            this.RiskLimitBase = riskLimitBase;
            this.RiskLimitStep = riskLimitStep;
            this.RiskLimitMax = riskLimitMax;
            this.OrderSizeMin = orderSizeMin;
            this.OrderSizeMax = orderSizeMax;
            this.OrderPriceDeviate = orderPriceDeviate;
            this.RefDiscountRate = refDiscountRate;
            this.RefRebateRate = refRebateRate;
            this.OrderbookId = orderbookId;
            this.TradeId = tradeId;
            this.TradeSize = tradeSize;
            this.PositionSize = positionSize;
            this.ConfigChangeTime = configChangeTime;
            this.InDelisting = inDelisting;
            this.OrdersLimit = ordersLimit;
        }

        /// <summary>
        /// Futures contract
        /// </summary>
        /// <value>Futures contract</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Multiplier used in converting from invoicing to settlement currency in quanto futures
        /// </summary>
        /// <value>Multiplier used in converting from invoicing to settlement currency in quanto futures</value>
        [DataMember(Name="quanto_multiplier", EmitDefaultValue=false)]
        public string QuantoMultiplier { get; set; }

        /// <summary>
        /// Minimum leverage
        /// </summary>
        /// <value>Minimum leverage</value>
        [DataMember(Name="leverage_min", EmitDefaultValue=false)]
        public string LeverageMin { get; set; }

        /// <summary>
        /// Maximum leverage
        /// </summary>
        /// <value>Maximum leverage</value>
        [DataMember(Name="leverage_max", EmitDefaultValue=false)]
        public string LeverageMax { get; set; }

        /// <summary>
        /// Maintenance rate of margin
        /// </summary>
        /// <value>Maintenance rate of margin</value>
        [DataMember(Name="maintenance_rate", EmitDefaultValue=false)]
        public string MaintenanceRate { get; set; }

        /// <summary>
        /// Current mark price
        /// </summary>
        /// <value>Current mark price</value>
        [DataMember(Name="mark_price", EmitDefaultValue=false)]
        public string MarkPrice { get; set; }

        /// <summary>
        /// Current index price
        /// </summary>
        /// <value>Current index price</value>
        [DataMember(Name="index_price", EmitDefaultValue=false)]
        public string IndexPrice { get; set; }

        /// <summary>
        /// Last trading price
        /// </summary>
        /// <value>Last trading price</value>
        [DataMember(Name="last_price", EmitDefaultValue=false)]
        public string LastPrice { get; set; }

        /// <summary>
        /// Maker fee rate, where negative means rebate
        /// </summary>
        /// <value>Maker fee rate, where negative means rebate</value>
        [DataMember(Name="maker_fee_rate", EmitDefaultValue=false)]
        public string MakerFeeRate { get; set; }

        /// <summary>
        /// Taker fee rate
        /// </summary>
        /// <value>Taker fee rate</value>
        [DataMember(Name="taker_fee_rate", EmitDefaultValue=false)]
        public string TakerFeeRate { get; set; }

        /// <summary>
        /// Minimum order price increment
        /// </summary>
        /// <value>Minimum order price increment</value>
        [DataMember(Name="order_price_round", EmitDefaultValue=false)]
        public string OrderPriceRound { get; set; }

        /// <summary>
        /// Minimum mark price increment
        /// </summary>
        /// <value>Minimum mark price increment</value>
        [DataMember(Name="mark_price_round", EmitDefaultValue=false)]
        public string MarkPriceRound { get; set; }

        /// <summary>
        /// Current funding rate
        /// </summary>
        /// <value>Current funding rate</value>
        [DataMember(Name="funding_rate", EmitDefaultValue=false)]
        public string FundingRate { get; set; }

        /// <summary>
        /// Funding application interval, unit in seconds
        /// </summary>
        /// <value>Funding application interval, unit in seconds</value>
        [DataMember(Name="funding_interval", EmitDefaultValue=false)]
        public int FundingInterval { get; set; }

        /// <summary>
        /// Next funding time
        /// </summary>
        /// <value>Next funding time</value>
        [DataMember(Name="funding_next_apply", EmitDefaultValue=false)]
        public double FundingNextApply { get; set; }

        /// <summary>
        /// Risk limit base
        /// </summary>
        /// <value>Risk limit base</value>
        [DataMember(Name="risk_limit_base", EmitDefaultValue=false)]
        public string RiskLimitBase { get; set; }

        /// <summary>
        /// Step of adjusting risk limit
        /// </summary>
        /// <value>Step of adjusting risk limit</value>
        [DataMember(Name="risk_limit_step", EmitDefaultValue=false)]
        public string RiskLimitStep { get; set; }

        /// <summary>
        /// Maximum risk limit the contract allowed
        /// </summary>
        /// <value>Maximum risk limit the contract allowed</value>
        [DataMember(Name="risk_limit_max", EmitDefaultValue=false)]
        public string RiskLimitMax { get; set; }

        /// <summary>
        /// Minimum order size the contract allowed
        /// </summary>
        /// <value>Minimum order size the contract allowed</value>
        [DataMember(Name="order_size_min", EmitDefaultValue=false)]
        public long OrderSizeMin { get; set; }

        /// <summary>
        /// Maximum order size the contract allowed
        /// </summary>
        /// <value>Maximum order size the contract allowed</value>
        [DataMember(Name="order_size_max", EmitDefaultValue=false)]
        public long OrderSizeMax { get; set; }

        /// <summary>
        /// deviation between order price and current index price. If price of an order is denoted as order_price, it must meet the following condition:      abs(order_price - mark_price) &lt;&#x3D; mark_price * order_price_deviate
        /// </summary>
        /// <value>deviation between order price and current index price. If price of an order is denoted as order_price, it must meet the following condition:      abs(order_price - mark_price) &lt;&#x3D; mark_price * order_price_deviate</value>
        [DataMember(Name="order_price_deviate", EmitDefaultValue=false)]
        public string OrderPriceDeviate { get; set; }

        /// <summary>
        /// Referral fee rate discount
        /// </summary>
        /// <value>Referral fee rate discount</value>
        [DataMember(Name="ref_discount_rate", EmitDefaultValue=false)]
        public string RefDiscountRate { get; set; }

        /// <summary>
        /// Referrer commission rate
        /// </summary>
        /// <value>Referrer commission rate</value>
        [DataMember(Name="ref_rebate_rate", EmitDefaultValue=false)]
        public string RefRebateRate { get; set; }

        /// <summary>
        /// Current orderbook ID
        /// </summary>
        /// <value>Current orderbook ID</value>
        [DataMember(Name="orderbook_id", EmitDefaultValue=false)]
        public long OrderbookId { get; set; }

        /// <summary>
        /// Current trade ID
        /// </summary>
        /// <value>Current trade ID</value>
        [DataMember(Name="trade_id", EmitDefaultValue=false)]
        public long TradeId { get; set; }

        /// <summary>
        /// Historical accumulation trade size
        /// </summary>
        /// <value>Historical accumulation trade size</value>
        [DataMember(Name="trade_size", EmitDefaultValue=false)]
        public long TradeSize { get; set; }

        /// <summary>
        /// Current total long position size
        /// </summary>
        /// <value>Current total long position size</value>
        [DataMember(Name="position_size", EmitDefaultValue=false)]
        public long PositionSize { get; set; }

        /// <summary>
        /// Configuration&#39;s last changed time
        /// </summary>
        /// <value>Configuration&#39;s last changed time</value>
        [DataMember(Name="config_change_time", EmitDefaultValue=false)]
        public double ConfigChangeTime { get; set; }

        /// <summary>
        /// Contract is delisting
        /// </summary>
        /// <value>Contract is delisting</value>
        [DataMember(Name="in_delisting", EmitDefaultValue=false)]
        public bool InDelisting { get; set; }

        /// <summary>
        /// Maximum number of open orders
        /// </summary>
        /// <value>Maximum number of open orders</value>
        [DataMember(Name="orders_limit", EmitDefaultValue=false)]
        public int OrdersLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contract {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  QuantoMultiplier: ").Append(QuantoMultiplier).Append("\n");
            sb.Append("  LeverageMin: ").Append(LeverageMin).Append("\n");
            sb.Append("  LeverageMax: ").Append(LeverageMax).Append("\n");
            sb.Append("  MaintenanceRate: ").Append(MaintenanceRate).Append("\n");
            sb.Append("  MarkType: ").Append(MarkType).Append("\n");
            sb.Append("  MarkPrice: ").Append(MarkPrice).Append("\n");
            sb.Append("  IndexPrice: ").Append(IndexPrice).Append("\n");
            sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
            sb.Append("  MakerFeeRate: ").Append(MakerFeeRate).Append("\n");
            sb.Append("  TakerFeeRate: ").Append(TakerFeeRate).Append("\n");
            sb.Append("  OrderPriceRound: ").Append(OrderPriceRound).Append("\n");
            sb.Append("  MarkPriceRound: ").Append(MarkPriceRound).Append("\n");
            sb.Append("  FundingRate: ").Append(FundingRate).Append("\n");
            sb.Append("  FundingInterval: ").Append(FundingInterval).Append("\n");
            sb.Append("  FundingNextApply: ").Append(FundingNextApply).Append("\n");
            sb.Append("  RiskLimitBase: ").Append(RiskLimitBase).Append("\n");
            sb.Append("  RiskLimitStep: ").Append(RiskLimitStep).Append("\n");
            sb.Append("  RiskLimitMax: ").Append(RiskLimitMax).Append("\n");
            sb.Append("  OrderSizeMin: ").Append(OrderSizeMin).Append("\n");
            sb.Append("  OrderSizeMax: ").Append(OrderSizeMax).Append("\n");
            sb.Append("  OrderPriceDeviate: ").Append(OrderPriceDeviate).Append("\n");
            sb.Append("  RefDiscountRate: ").Append(RefDiscountRate).Append("\n");
            sb.Append("  RefRebateRate: ").Append(RefRebateRate).Append("\n");
            sb.Append("  OrderbookId: ").Append(OrderbookId).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  TradeSize: ").Append(TradeSize).Append("\n");
            sb.Append("  PositionSize: ").Append(PositionSize).Append("\n");
            sb.Append("  ConfigChangeTime: ").Append(ConfigChangeTime).Append("\n");
            sb.Append("  InDelisting: ").Append(InDelisting).Append("\n");
            sb.Append("  OrdersLimit: ").Append(OrdersLimit).Append("\n");
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
            return this.Equals(input as Contract);
        }

        /// <summary>
        /// Returns true if Contract instances are equal
        /// </summary>
        /// <param name="input">Instance of Contract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.QuantoMultiplier == input.QuantoMultiplier ||
                    (this.QuantoMultiplier != null &&
                    this.QuantoMultiplier.Equals(input.QuantoMultiplier))
                ) && 
                (
                    this.LeverageMin == input.LeverageMin ||
                    (this.LeverageMin != null &&
                    this.LeverageMin.Equals(input.LeverageMin))
                ) && 
                (
                    this.LeverageMax == input.LeverageMax ||
                    (this.LeverageMax != null &&
                    this.LeverageMax.Equals(input.LeverageMax))
                ) && 
                (
                    this.MaintenanceRate == input.MaintenanceRate ||
                    (this.MaintenanceRate != null &&
                    this.MaintenanceRate.Equals(input.MaintenanceRate))
                ) && 
                (
                    this.MarkType == input.MarkType ||
                    this.MarkType.Equals(input.MarkType)
                ) && 
                (
                    this.MarkPrice == input.MarkPrice ||
                    (this.MarkPrice != null &&
                    this.MarkPrice.Equals(input.MarkPrice))
                ) && 
                (
                    this.IndexPrice == input.IndexPrice ||
                    (this.IndexPrice != null &&
                    this.IndexPrice.Equals(input.IndexPrice))
                ) && 
                (
                    this.LastPrice == input.LastPrice ||
                    (this.LastPrice != null &&
                    this.LastPrice.Equals(input.LastPrice))
                ) && 
                (
                    this.MakerFeeRate == input.MakerFeeRate ||
                    (this.MakerFeeRate != null &&
                    this.MakerFeeRate.Equals(input.MakerFeeRate))
                ) && 
                (
                    this.TakerFeeRate == input.TakerFeeRate ||
                    (this.TakerFeeRate != null &&
                    this.TakerFeeRate.Equals(input.TakerFeeRate))
                ) && 
                (
                    this.OrderPriceRound == input.OrderPriceRound ||
                    (this.OrderPriceRound != null &&
                    this.OrderPriceRound.Equals(input.OrderPriceRound))
                ) && 
                (
                    this.MarkPriceRound == input.MarkPriceRound ||
                    (this.MarkPriceRound != null &&
                    this.MarkPriceRound.Equals(input.MarkPriceRound))
                ) && 
                (
                    this.FundingRate == input.FundingRate ||
                    (this.FundingRate != null &&
                    this.FundingRate.Equals(input.FundingRate))
                ) && 
                (
                    this.FundingInterval == input.FundingInterval ||
                    this.FundingInterval.Equals(input.FundingInterval)
                ) && 
                (
                    this.FundingNextApply == input.FundingNextApply ||
                    this.FundingNextApply.Equals(input.FundingNextApply)
                ) && 
                (
                    this.RiskLimitBase == input.RiskLimitBase ||
                    (this.RiskLimitBase != null &&
                    this.RiskLimitBase.Equals(input.RiskLimitBase))
                ) && 
                (
                    this.RiskLimitStep == input.RiskLimitStep ||
                    (this.RiskLimitStep != null &&
                    this.RiskLimitStep.Equals(input.RiskLimitStep))
                ) && 
                (
                    this.RiskLimitMax == input.RiskLimitMax ||
                    (this.RiskLimitMax != null &&
                    this.RiskLimitMax.Equals(input.RiskLimitMax))
                ) && 
                (
                    this.OrderSizeMin == input.OrderSizeMin ||
                    this.OrderSizeMin.Equals(input.OrderSizeMin)
                ) && 
                (
                    this.OrderSizeMax == input.OrderSizeMax ||
                    this.OrderSizeMax.Equals(input.OrderSizeMax)
                ) && 
                (
                    this.OrderPriceDeviate == input.OrderPriceDeviate ||
                    (this.OrderPriceDeviate != null &&
                    this.OrderPriceDeviate.Equals(input.OrderPriceDeviate))
                ) && 
                (
                    this.RefDiscountRate == input.RefDiscountRate ||
                    (this.RefDiscountRate != null &&
                    this.RefDiscountRate.Equals(input.RefDiscountRate))
                ) && 
                (
                    this.RefRebateRate == input.RefRebateRate ||
                    (this.RefRebateRate != null &&
                    this.RefRebateRate.Equals(input.RefRebateRate))
                ) && 
                (
                    this.OrderbookId == input.OrderbookId ||
                    this.OrderbookId.Equals(input.OrderbookId)
                ) && 
                (
                    this.TradeId == input.TradeId ||
                    this.TradeId.Equals(input.TradeId)
                ) && 
                (
                    this.TradeSize == input.TradeSize ||
                    this.TradeSize.Equals(input.TradeSize)
                ) && 
                (
                    this.PositionSize == input.PositionSize ||
                    this.PositionSize.Equals(input.PositionSize)
                ) && 
                (
                    this.ConfigChangeTime == input.ConfigChangeTime ||
                    this.ConfigChangeTime.Equals(input.ConfigChangeTime)
                ) && 
                (
                    this.InDelisting == input.InDelisting ||
                    this.InDelisting.Equals(input.InDelisting)
                ) && 
                (
                    this.OrdersLimit == input.OrdersLimit ||
                    this.OrdersLimit.Equals(input.OrdersLimit)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.QuantoMultiplier != null)
                    hashCode = hashCode * 59 + this.QuantoMultiplier.GetHashCode();
                if (this.LeverageMin != null)
                    hashCode = hashCode * 59 + this.LeverageMin.GetHashCode();
                if (this.LeverageMax != null)
                    hashCode = hashCode * 59 + this.LeverageMax.GetHashCode();
                if (this.MaintenanceRate != null)
                    hashCode = hashCode * 59 + this.MaintenanceRate.GetHashCode();
                hashCode = hashCode * 59 + this.MarkType.GetHashCode();
                if (this.MarkPrice != null)
                    hashCode = hashCode * 59 + this.MarkPrice.GetHashCode();
                if (this.IndexPrice != null)
                    hashCode = hashCode * 59 + this.IndexPrice.GetHashCode();
                if (this.LastPrice != null)
                    hashCode = hashCode * 59 + this.LastPrice.GetHashCode();
                if (this.MakerFeeRate != null)
                    hashCode = hashCode * 59 + this.MakerFeeRate.GetHashCode();
                if (this.TakerFeeRate != null)
                    hashCode = hashCode * 59 + this.TakerFeeRate.GetHashCode();
                if (this.OrderPriceRound != null)
                    hashCode = hashCode * 59 + this.OrderPriceRound.GetHashCode();
                if (this.MarkPriceRound != null)
                    hashCode = hashCode * 59 + this.MarkPriceRound.GetHashCode();
                if (this.FundingRate != null)
                    hashCode = hashCode * 59 + this.FundingRate.GetHashCode();
                hashCode = hashCode * 59 + this.FundingInterval.GetHashCode();
                hashCode = hashCode * 59 + this.FundingNextApply.GetHashCode();
                if (this.RiskLimitBase != null)
                    hashCode = hashCode * 59 + this.RiskLimitBase.GetHashCode();
                if (this.RiskLimitStep != null)
                    hashCode = hashCode * 59 + this.RiskLimitStep.GetHashCode();
                if (this.RiskLimitMax != null)
                    hashCode = hashCode * 59 + this.RiskLimitMax.GetHashCode();
                hashCode = hashCode * 59 + this.OrderSizeMin.GetHashCode();
                hashCode = hashCode * 59 + this.OrderSizeMax.GetHashCode();
                if (this.OrderPriceDeviate != null)
                    hashCode = hashCode * 59 + this.OrderPriceDeviate.GetHashCode();
                if (this.RefDiscountRate != null)
                    hashCode = hashCode * 59 + this.RefDiscountRate.GetHashCode();
                if (this.RefRebateRate != null)
                    hashCode = hashCode * 59 + this.RefRebateRate.GetHashCode();
                hashCode = hashCode * 59 + this.OrderbookId.GetHashCode();
                hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                hashCode = hashCode * 59 + this.TradeSize.GetHashCode();
                hashCode = hashCode * 59 + this.PositionSize.GetHashCode();
                hashCode = hashCode * 59 + this.ConfigChangeTime.GetHashCode();
                hashCode = hashCode * 59 + this.InDelisting.GetHashCode();
                hashCode = hashCode * 59 + this.OrdersLimit.GetHashCode();
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
