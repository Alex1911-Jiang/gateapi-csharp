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
    /// Spot order details
    /// </summary>
    [DataContract]
    public partial class OrderPatch :  IEquatable<OrderPatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPatch" /> class.
        /// </summary>
        /// <param name="amount">New order amount. &#x60;amount&#x60; and &#x60;price&#x60; must specify one of them.</param>
        /// <param name="price">New order price. &#x60;amount&#x60; and &#x60;Price&#x60; must specify one of them\&quot;.</param>
        /// <param name="amendText">Custom info during amending order.</param>
        /// <param name="actionMode">Processing Mode: When placing an order, different fields are returned based on action_mode. This field is only valid during the request and is not included in the response result ACK: Asynchronous mode, only returns key order fields RESULT: No clearing information FULL: Full mode (default).</param>
        public OrderPatch(string amount = default(string), string price = default(string), string amendText = default(string), string actionMode = default(string))
        {
            this.Amount = amount;
            this.Price = price;
            this.AmendText = amendText;
            this.ActionMode = actionMode;
        }

        /// <summary>
        /// New order amount. &#x60;amount&#x60; and &#x60;price&#x60; must specify one of them
        /// </summary>
        /// <value>New order amount. &#x60;amount&#x60; and &#x60;price&#x60; must specify one of them</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// New order price. &#x60;amount&#x60; and &#x60;Price&#x60; must specify one of them\&quot;
        /// </summary>
        /// <value>New order price. &#x60;amount&#x60; and &#x60;Price&#x60; must specify one of them\&quot;</value>
        [DataMember(Name="price")]
        public string Price { get; set; }

        /// <summary>
        /// Custom info during amending order
        /// </summary>
        /// <value>Custom info during amending order</value>
        [DataMember(Name="amend_text")]
        public string AmendText { get; set; }

        /// <summary>
        /// Processing Mode: When placing an order, different fields are returned based on action_mode. This field is only valid during the request and is not included in the response result ACK: Asynchronous mode, only returns key order fields RESULT: No clearing information FULL: Full mode (default)
        /// </summary>
        /// <value>Processing Mode: When placing an order, different fields are returned based on action_mode. This field is only valid during the request and is not included in the response result ACK: Asynchronous mode, only returns key order fields RESULT: No clearing information FULL: Full mode (default)</value>
        [DataMember(Name="action_mode")]
        public string ActionMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPatch {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  AmendText: ").Append(AmendText).Append("\n");
            sb.Append("  ActionMode: ").Append(ActionMode).Append("\n");
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
            return this.Equals(input as OrderPatch);
        }

        /// <summary>
        /// Returns true if OrderPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.AmendText == input.AmendText ||
                    (this.AmendText != null &&
                    this.AmendText.Equals(input.AmendText))
                ) && 
                (
                    this.ActionMode == input.ActionMode ||
                    (this.ActionMode != null &&
                    this.ActionMode.Equals(input.ActionMode))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.AmendText != null)
                    hashCode = hashCode * 59 + this.AmendText.GetHashCode();
                if (this.ActionMode != null)
                    hashCode = hashCode * 59 + this.ActionMode.GetHashCode();
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
            // AmendText (string) maxLength
            if(this.AmendText != null && this.AmendText.Length > 31)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmendText, length must be less than 31.", new [] { "AmendText" });
            }

            yield break;
        }
    }

}
