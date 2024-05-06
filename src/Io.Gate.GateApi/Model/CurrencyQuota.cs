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
    /// Currency Quota
    /// </summary>
    [DataContract]
    public partial class CurrencyQuota :  IEquatable<CurrencyQuota>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyQuota" /> class.
        /// </summary>
        /// <param name="currency">Currency.</param>
        /// <param name="indexPrice">Currency Index Price.</param>
        /// <param name="minQuota">Minimum borrowing/collateral quota for the currency.</param>
        /// <param name="leftQuota">Remaining borrowing/collateral limit for the currency.</param>
        /// <param name="leftQuoteUsdt">Remaining currency limit converted to USDT.</param>
        public CurrencyQuota(string currency = default(string), string indexPrice = default(string), string minQuota = default(string), string leftQuota = default(string), string leftQuoteUsdt = default(string))
        {
            this.Currency = currency;
            this.IndexPrice = indexPrice;
            this.MinQuota = minQuota;
            this.LeftQuota = leftQuota;
            this.LeftQuoteUsdt = leftQuoteUsdt;
        }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Currency Index Price
        /// </summary>
        /// <value>Currency Index Price</value>
        [DataMember(Name="index_price")]
        public string IndexPrice { get; set; }

        /// <summary>
        /// Minimum borrowing/collateral quota for the currency
        /// </summary>
        /// <value>Minimum borrowing/collateral quota for the currency</value>
        [DataMember(Name="min_quota")]
        public string MinQuota { get; set; }

        /// <summary>
        /// Remaining borrowing/collateral limit for the currency
        /// </summary>
        /// <value>Remaining borrowing/collateral limit for the currency</value>
        [DataMember(Name="left_quota")]
        public string LeftQuota { get; set; }

        /// <summary>
        /// Remaining currency limit converted to USDT
        /// </summary>
        /// <value>Remaining currency limit converted to USDT</value>
        [DataMember(Name="left_quote_usdt")]
        public string LeftQuoteUsdt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyQuota {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  IndexPrice: ").Append(IndexPrice).Append("\n");
            sb.Append("  MinQuota: ").Append(MinQuota).Append("\n");
            sb.Append("  LeftQuota: ").Append(LeftQuota).Append("\n");
            sb.Append("  LeftQuoteUsdt: ").Append(LeftQuoteUsdt).Append("\n");
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
            return this.Equals(input as CurrencyQuota);
        }

        /// <summary>
        /// Returns true if CurrencyQuota instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyQuota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyQuota input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.IndexPrice == input.IndexPrice ||
                    (this.IndexPrice != null &&
                    this.IndexPrice.Equals(input.IndexPrice))
                ) && 
                (
                    this.MinQuota == input.MinQuota ||
                    (this.MinQuota != null &&
                    this.MinQuota.Equals(input.MinQuota))
                ) && 
                (
                    this.LeftQuota == input.LeftQuota ||
                    (this.LeftQuota != null &&
                    this.LeftQuota.Equals(input.LeftQuota))
                ) && 
                (
                    this.LeftQuoteUsdt == input.LeftQuoteUsdt ||
                    (this.LeftQuoteUsdt != null &&
                    this.LeftQuoteUsdt.Equals(input.LeftQuoteUsdt))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.IndexPrice != null)
                    hashCode = hashCode * 59 + this.IndexPrice.GetHashCode();
                if (this.MinQuota != null)
                    hashCode = hashCode * 59 + this.MinQuota.GetHashCode();
                if (this.LeftQuota != null)
                    hashCode = hashCode * 59 + this.LeftQuota.GetHashCode();
                if (this.LeftQuoteUsdt != null)
                    hashCode = hashCode * 59 + this.LeftQuoteUsdt.GetHashCode();
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
