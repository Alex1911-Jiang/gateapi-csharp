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
    /// SubAccountToSubAccount
    /// </summary>
    [DataContract]
    public partial class SubAccountToSubAccount :  IEquatable<SubAccountToSubAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountToSubAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubAccountToSubAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountToSubAccount" /> class.
        /// </summary>
        /// <param name="currency">Transfer currency name (required).</param>
        /// <param name="subAccountType">Transfer from the account. (deprecate, use &#x60;sub_account_from_type&#x60; and &#x60;sub_account_to_type&#x60; instead).</param>
        /// <param name="subAccountFrom">Transfer from the user id of the sub-account (required).</param>
        /// <param name="subAccountFromType">The sub-account&#39;s outgoing trading account, spot - spot account, futures - perpetual contract account, delivery - delivery contract account, cross_margin - cross-margin account.\&quot; (required).</param>
        /// <param name="subAccountTo">Transfer to the user id of the sub-account (required).</param>
        /// <param name="subAccountToType">The sub-account&#39;s incoming trading account, spot - spot account, futures - perpetual contract account, delivery - delivery contract account, cross_margin - cross-margin account. (required).</param>
        /// <param name="amount">Transfer amount (required).</param>
        public SubAccountToSubAccount(string currency = default(string), string subAccountType = default(string), string subAccountFrom = default(string), string subAccountFromType = default(string), string subAccountTo = default(string), string subAccountToType = default(string), string amount = default(string))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for SubAccountToSubAccount and cannot be null");
            // to ensure "subAccountFrom" is required (not null)
            this.SubAccountFrom = subAccountFrom ?? throw new ArgumentNullException("subAccountFrom", "subAccountFrom is a required property for SubAccountToSubAccount and cannot be null");
            // to ensure "subAccountFromType" is required (not null)
            this.SubAccountFromType = subAccountFromType ?? throw new ArgumentNullException("subAccountFromType", "subAccountFromType is a required property for SubAccountToSubAccount and cannot be null");
            // to ensure "subAccountTo" is required (not null)
            this.SubAccountTo = subAccountTo ?? throw new ArgumentNullException("subAccountTo", "subAccountTo is a required property for SubAccountToSubAccount and cannot be null");
            // to ensure "subAccountToType" is required (not null)
            this.SubAccountToType = subAccountToType ?? throw new ArgumentNullException("subAccountToType", "subAccountToType is a required property for SubAccountToSubAccount and cannot be null");
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount", "amount is a required property for SubAccountToSubAccount and cannot be null");
            this.SubAccountType = subAccountType;
        }

        /// <summary>
        /// Transfer currency name
        /// </summary>
        /// <value>Transfer currency name</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Transfer from the account. (deprecate, use &#x60;sub_account_from_type&#x60; and &#x60;sub_account_to_type&#x60; instead)
        /// </summary>
        /// <value>Transfer from the account. (deprecate, use &#x60;sub_account_from_type&#x60; and &#x60;sub_account_to_type&#x60; instead)</value>
        [DataMember(Name="sub_account_type")]
        public string SubAccountType { get; set; }

        /// <summary>
        /// Transfer from the user id of the sub-account
        /// </summary>
        /// <value>Transfer from the user id of the sub-account</value>
        [DataMember(Name="sub_account_from")]
        public string SubAccountFrom { get; set; }

        /// <summary>
        /// The sub-account&#39;s outgoing trading account, spot - spot account, futures - perpetual contract account, delivery - delivery contract account, cross_margin - cross-margin account.\&quot;
        /// </summary>
        /// <value>The sub-account&#39;s outgoing trading account, spot - spot account, futures - perpetual contract account, delivery - delivery contract account, cross_margin - cross-margin account.\&quot;</value>
        [DataMember(Name="sub_account_from_type")]
        public string SubAccountFromType { get; set; }

        /// <summary>
        /// Transfer to the user id of the sub-account
        /// </summary>
        /// <value>Transfer to the user id of the sub-account</value>
        [DataMember(Name="sub_account_to")]
        public string SubAccountTo { get; set; }

        /// <summary>
        /// The sub-account&#39;s incoming trading account, spot - spot account, futures - perpetual contract account, delivery - delivery contract account, cross_margin - cross-margin account.
        /// </summary>
        /// <value>The sub-account&#39;s incoming trading account, spot - spot account, futures - perpetual contract account, delivery - delivery contract account, cross_margin - cross-margin account.</value>
        [DataMember(Name="sub_account_to_type")]
        public string SubAccountToType { get; set; }

        /// <summary>
        /// Transfer amount
        /// </summary>
        /// <value>Transfer amount</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccountToSubAccount {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SubAccountType: ").Append(SubAccountType).Append("\n");
            sb.Append("  SubAccountFrom: ").Append(SubAccountFrom).Append("\n");
            sb.Append("  SubAccountFromType: ").Append(SubAccountFromType).Append("\n");
            sb.Append("  SubAccountTo: ").Append(SubAccountTo).Append("\n");
            sb.Append("  SubAccountToType: ").Append(SubAccountToType).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as SubAccountToSubAccount);
        }

        /// <summary>
        /// Returns true if SubAccountToSubAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of SubAccountToSubAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubAccountToSubAccount input)
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
                    this.SubAccountType == input.SubAccountType ||
                    (this.SubAccountType != null &&
                    this.SubAccountType.Equals(input.SubAccountType))
                ) && 
                (
                    this.SubAccountFrom == input.SubAccountFrom ||
                    (this.SubAccountFrom != null &&
                    this.SubAccountFrom.Equals(input.SubAccountFrom))
                ) && 
                (
                    this.SubAccountFromType == input.SubAccountFromType ||
                    (this.SubAccountFromType != null &&
                    this.SubAccountFromType.Equals(input.SubAccountFromType))
                ) && 
                (
                    this.SubAccountTo == input.SubAccountTo ||
                    (this.SubAccountTo != null &&
                    this.SubAccountTo.Equals(input.SubAccountTo))
                ) && 
                (
                    this.SubAccountToType == input.SubAccountToType ||
                    (this.SubAccountToType != null &&
                    this.SubAccountToType.Equals(input.SubAccountToType))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.SubAccountType != null)
                    hashCode = hashCode * 59 + this.SubAccountType.GetHashCode();
                if (this.SubAccountFrom != null)
                    hashCode = hashCode * 59 + this.SubAccountFrom.GetHashCode();
                if (this.SubAccountFromType != null)
                    hashCode = hashCode * 59 + this.SubAccountFromType.GetHashCode();
                if (this.SubAccountTo != null)
                    hashCode = hashCode * 59 + this.SubAccountTo.GetHashCode();
                if (this.SubAccountToType != null)
                    hashCode = hashCode * 59 + this.SubAccountToType.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
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
