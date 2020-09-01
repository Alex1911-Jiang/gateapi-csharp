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
    /// FundingAccount
    /// </summary>
    [DataContract]
    public partial class FundingAccount :  IEquatable<FundingAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingAccount" /> class.
        /// </summary>
        /// <param name="currency">Currency name.</param>
        /// <param name="available">Available assets to lend, which is identical to spot account &#x60;available&#x60;.</param>
        /// <param name="locked">Locked amount. i.e. amount in &#x60;open&#x60; loans.</param>
        /// <param name="lent">Amount that is loaned but not repaid.</param>
        /// <param name="totalLent">Amount used for lending. total_lent &#x3D; lent + locked.</param>
        public FundingAccount(string currency = default(string), string available = default(string), string locked = default(string), string lent = default(string), string totalLent = default(string))
        {
            this.Currency = currency;
            this.Available = available;
            this.Locked = locked;
            this.Lent = lent;
            this.TotalLent = totalLent;
        }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>Currency name</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Available assets to lend, which is identical to spot account &#x60;available&#x60;
        /// </summary>
        /// <value>Available assets to lend, which is identical to spot account &#x60;available&#x60;</value>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public string Available { get; set; }

        /// <summary>
        /// Locked amount. i.e. amount in &#x60;open&#x60; loans
        /// </summary>
        /// <value>Locked amount. i.e. amount in &#x60;open&#x60; loans</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public string Locked { get; set; }

        /// <summary>
        /// Amount that is loaned but not repaid
        /// </summary>
        /// <value>Amount that is loaned but not repaid</value>
        [DataMember(Name="lent", EmitDefaultValue=false)]
        public string Lent { get; set; }

        /// <summary>
        /// Amount used for lending. total_lent &#x3D; lent + locked
        /// </summary>
        /// <value>Amount used for lending. total_lent &#x3D; lent + locked</value>
        [DataMember(Name="total_lent", EmitDefaultValue=false)]
        public string TotalLent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundingAccount {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Lent: ").Append(Lent).Append("\n");
            sb.Append("  TotalLent: ").Append(TotalLent).Append("\n");
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
            return this.Equals(input as FundingAccount);
        }

        /// <summary>
        /// Returns true if FundingAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of FundingAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundingAccount input)
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
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Lent == input.Lent ||
                    (this.Lent != null &&
                    this.Lent.Equals(input.Lent))
                ) && 
                (
                    this.TotalLent == input.TotalLent ||
                    (this.TotalLent != null &&
                    this.TotalLent.Equals(input.TotalLent))
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
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Lent != null)
                    hashCode = hashCode * 59 + this.Lent.GetHashCode();
                if (this.TotalLent != null)
                    hashCode = hashCode * 59 + this.TotalLent.GetHashCode();
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
