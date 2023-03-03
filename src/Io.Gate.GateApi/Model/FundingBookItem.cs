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
    /// FundingBookItem
    /// </summary>
    [DataContract]
    public partial class FundingBookItem :  IEquatable<FundingBookItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingBookItem" /> class.
        /// </summary>
        /// <param name="rate">Loan rate (daily rate).</param>
        /// <param name="amount">Borrowable amount.</param>
        /// <param name="days">The number of days till the loan repayment&#39;s dateline.</param>
        public FundingBookItem(string rate = default(string), string amount = default(string), int days = default(int))
        {
            this.Rate = rate;
            this.Amount = amount;
            this.Days = days;
        }

        /// <summary>
        /// Loan rate (daily rate)
        /// </summary>
        /// <value>Loan rate (daily rate)</value>
        [DataMember(Name="rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Borrowable amount
        /// </summary>
        /// <value>Borrowable amount</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The number of days till the loan repayment&#39;s dateline
        /// </summary>
        /// <value>The number of days till the loan repayment&#39;s dateline</value>
        [DataMember(Name="days")]
        public int Days { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundingBookItem {\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
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
            return this.Equals(input as FundingBookItem);
        }

        /// <summary>
        /// Returns true if FundingBookItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FundingBookItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundingBookItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Days == input.Days ||
                    this.Days.Equals(input.Days)
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
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.Days.GetHashCode();
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
