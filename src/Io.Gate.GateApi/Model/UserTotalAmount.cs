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
    /// Total borrowed amount and pledged collateral amount by the user
    /// </summary>
    [DataContract]
    public partial class UserTotalAmount :  IEquatable<UserTotalAmount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTotalAmount" /> class.
        /// </summary>
        /// <param name="borrowAmount">Total borrowing amount, calculated in USDT.</param>
        /// <param name="collateralAmount">Total collateral amount, calculated in USDT.</param>
        public UserTotalAmount(string borrowAmount = default(string), string collateralAmount = default(string))
        {
            this.BorrowAmount = borrowAmount;
            this.CollateralAmount = collateralAmount;
        }

        /// <summary>
        /// Total borrowing amount, calculated in USDT
        /// </summary>
        /// <value>Total borrowing amount, calculated in USDT</value>
        [DataMember(Name="borrow_amount")]
        public string BorrowAmount { get; set; }

        /// <summary>
        /// Total collateral amount, calculated in USDT
        /// </summary>
        /// <value>Total collateral amount, calculated in USDT</value>
        [DataMember(Name="collateral_amount")]
        public string CollateralAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserTotalAmount {\n");
            sb.Append("  BorrowAmount: ").Append(BorrowAmount).Append("\n");
            sb.Append("  CollateralAmount: ").Append(CollateralAmount).Append("\n");
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
            return this.Equals(input as UserTotalAmount);
        }

        /// <summary>
        /// Returns true if UserTotalAmount instances are equal
        /// </summary>
        /// <param name="input">Instance of UserTotalAmount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTotalAmount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BorrowAmount == input.BorrowAmount ||
                    (this.BorrowAmount != null &&
                    this.BorrowAmount.Equals(input.BorrowAmount))
                ) && 
                (
                    this.CollateralAmount == input.CollateralAmount ||
                    (this.CollateralAmount != null &&
                    this.CollateralAmount.Equals(input.CollateralAmount))
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
                if (this.BorrowAmount != null)
                    hashCode = hashCode * 59 + this.BorrowAmount.GetHashCode();
                if (this.CollateralAmount != null)
                    hashCode = hashCode * 59 + this.CollateralAmount.GetHashCode();
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