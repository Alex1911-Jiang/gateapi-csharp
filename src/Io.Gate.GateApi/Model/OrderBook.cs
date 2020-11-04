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
    /// OrderBook
    /// </summary>
    [DataContract]
    public partial class OrderBook :  IEquatable<OrderBook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderBook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBook" /> class.
        /// </summary>
        /// <param name="id">Order book ID, which is updated whenever the order book is changed. Valid only when &#x60;with_id&#x60; is set to &#x60;true&#x60;.</param>
        /// <param name="asks">Asks order depth (required).</param>
        /// <param name="bids">Bids order depth (required).</param>
        public OrderBook(long id = default(long), List<List<string>> asks = default(List<List<string>>), List<List<string>> bids = default(List<List<string>>))
        {
            // to ensure "asks" is required (not null)
            this.Asks = asks ?? throw new ArgumentNullException("asks", "asks is a required property for OrderBook and cannot be null");
            // to ensure "bids" is required (not null)
            this.Bids = bids ?? throw new ArgumentNullException("bids", "bids is a required property for OrderBook and cannot be null");
            this.Id = id;
        }

        /// <summary>
        /// Order book ID, which is updated whenever the order book is changed. Valid only when &#x60;with_id&#x60; is set to &#x60;true&#x60;
        /// </summary>
        /// <value>Order book ID, which is updated whenever the order book is changed. Valid only when &#x60;with_id&#x60; is set to &#x60;true&#x60;</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Asks order depth
        /// </summary>
        /// <value>Asks order depth</value>
        [DataMember(Name="asks", EmitDefaultValue=false)]
        public List<List<string>> Asks { get; set; }

        /// <summary>
        /// Bids order depth
        /// </summary>
        /// <value>Bids order depth</value>
        [DataMember(Name="bids", EmitDefaultValue=false)]
        public List<List<string>> Bids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderBook {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Asks: ").Append(Asks).Append("\n");
            sb.Append("  Bids: ").Append(Bids).Append("\n");
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
            return this.Equals(input as OrderBook);
        }

        /// <summary>
        /// Returns true if OrderBook instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderBook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Asks == input.Asks ||
                    this.Asks != null &&
                    input.Asks != null &&
                    this.Asks.SequenceEqual(input.Asks)
                ) && 
                (
                    this.Bids == input.Bids ||
                    this.Bids != null &&
                    input.Bids != null &&
                    this.Bids.SequenceEqual(input.Bids)
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
                if (this.Asks != null)
                    hashCode = hashCode * 59 + this.Asks.GetHashCode();
                if (this.Bids != null)
                    hashCode = hashCode * 59 + this.Bids.GetHashCode();
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
