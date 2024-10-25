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
    /// SubAccountKeyPerms
    /// </summary>
    [DataContract]
    public partial class SubAccountKeyPerms :  IEquatable<SubAccountKeyPerms>, IValidatableObject
    {
        /// <summary>
        /// Permission name (all permissions will be removed if no value is passed)  - wallet: wallet - spot: spot/margin - futures: perpetual contract - delivery: delivery - earn: earn - options: options\\m- account: Account - unified: unified - loan: Loan
        /// </summary>
        /// <value>Permission name (all permissions will be removed if no value is passed)  - wallet: wallet - spot: spot/margin - futures: perpetual contract - delivery: delivery - earn: earn - options: options\\m- account: Account - unified: unified - loan: Loan</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum Wallet for value: wallet
            /// </summary>
            [EnumMember(Value = "wallet")]
            Wallet = 1,

            /// <summary>
            /// Enum Spot for value: spot
            /// </summary>
            [EnumMember(Value = "spot")]
            Spot = 2,

            /// <summary>
            /// Enum Futures for value: futures
            /// </summary>
            [EnumMember(Value = "futures")]
            Futures = 3,

            /// <summary>
            /// Enum Delivery for value: delivery
            /// </summary>
            [EnumMember(Value = "delivery")]
            Delivery = 4,

            /// <summary>
            /// Enum Earn for value: earn
            /// </summary>
            [EnumMember(Value = "earn")]
            Earn = 5,

            /// <summary>
            /// Enum Options for value: options
            /// </summary>
            [EnumMember(Value = "options")]
            Options = 6,

            /// <summary>
            /// Enum Account for value: account
            /// </summary>
            [EnumMember(Value = "account")]
            Account = 7,

            /// <summary>
            /// Enum Unified for value: unified
            /// </summary>
            [EnumMember(Value = "unified")]
            Unified = 8,

            /// <summary>
            /// Enum Loan for value: loan
            /// </summary>
            [EnumMember(Value = "loan")]
            Loan = 9

        }

        /// <summary>
        /// Permission name (all permissions will be removed if no value is passed)  - wallet: wallet - spot: spot/margin - futures: perpetual contract - delivery: delivery - earn: earn - options: options\\m- account: Account - unified: unified - loan: Loan
        /// </summary>
        /// <value>Permission name (all permissions will be removed if no value is passed)  - wallet: wallet - spot: spot/margin - futures: perpetual contract - delivery: delivery - earn: earn - options: options\\m- account: Account - unified: unified - loan: Loan</value>
        [DataMember(Name="name")]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountKeyPerms" /> class.
        /// </summary>
        /// <param name="name">Permission name (all permissions will be removed if no value is passed)  - wallet: wallet - spot: spot/margin - futures: perpetual contract - delivery: delivery - earn: earn - options: options\\m- account: Account - unified: unified - loan: Loan.</param>
        /// <param name="readOnly">read only.</param>
        public SubAccountKeyPerms(NameEnum? name = default(NameEnum?), bool readOnly = default(bool))
        {
            this.Name = name;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// read only
        /// </summary>
        /// <value>read only</value>
        [DataMember(Name="read_only")]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccountKeyPerms {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
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
            return this.Equals(input as SubAccountKeyPerms);
        }

        /// <summary>
        /// Returns true if SubAccountKeyPerms instances are equal
        /// </summary>
        /// <param name="input">Instance of SubAccountKeyPerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubAccountKeyPerms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    this.ReadOnly.Equals(input.ReadOnly)
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
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
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