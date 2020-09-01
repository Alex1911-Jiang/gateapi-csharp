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
    /// data point in every timestamp
    /// </summary>
    [DataContract]
    public partial class FuturesCandlestick :  IEquatable<FuturesCandlestick>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesCandlestick" /> class.
        /// </summary>
        /// <param name="t">Unix timestamp in seconds.</param>
        /// <param name="v">size volume. Only returned if &#x60;contract&#x60; is not prefixed.</param>
        /// <param name="c">Close price.</param>
        /// <param name="h">Highest price.</param>
        /// <param name="l">Lowest price.</param>
        /// <param name="o">Open price.</param>
        public FuturesCandlestick(decimal t = default(decimal), long v = default(long), string c = default(string), string h = default(string), string l = default(string), string o = default(string))
        {
            this.T = t;
            this.V = v;
            this.C = c;
            this.H = h;
            this.L = l;
            this.O = o;
        }

        /// <summary>
        /// Unix timestamp in seconds
        /// </summary>
        /// <value>Unix timestamp in seconds</value>
        [DataMember(Name="t", EmitDefaultValue=false)]
        public decimal T { get; set; }

        /// <summary>
        /// size volume. Only returned if &#x60;contract&#x60; is not prefixed
        /// </summary>
        /// <value>size volume. Only returned if &#x60;contract&#x60; is not prefixed</value>
        [DataMember(Name="v", EmitDefaultValue=false)]
        public long V { get; set; }

        /// <summary>
        /// Close price
        /// </summary>
        /// <value>Close price</value>
        [DataMember(Name="c", EmitDefaultValue=false)]
        public string C { get; set; }

        /// <summary>
        /// Highest price
        /// </summary>
        /// <value>Highest price</value>
        [DataMember(Name="h", EmitDefaultValue=false)]
        public string H { get; set; }

        /// <summary>
        /// Lowest price
        /// </summary>
        /// <value>Lowest price</value>
        [DataMember(Name="l", EmitDefaultValue=false)]
        public string L { get; set; }

        /// <summary>
        /// Open price
        /// </summary>
        /// <value>Open price</value>
        [DataMember(Name="o", EmitDefaultValue=false)]
        public string O { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesCandlestick {\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  L: ").Append(L).Append("\n");
            sb.Append("  O: ").Append(O).Append("\n");
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
            return this.Equals(input as FuturesCandlestick);
        }

        /// <summary>
        /// Returns true if FuturesCandlestick instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesCandlestick to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesCandlestick input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.T == input.T ||
                    this.T.Equals(input.T)
                ) && 
                (
                    this.V == input.V ||
                    this.V.Equals(input.V)
                ) && 
                (
                    this.C == input.C ||
                    (this.C != null &&
                    this.C.Equals(input.C))
                ) && 
                (
                    this.H == input.H ||
                    (this.H != null &&
                    this.H.Equals(input.H))
                ) && 
                (
                    this.L == input.L ||
                    (this.L != null &&
                    this.L.Equals(input.L))
                ) && 
                (
                    this.O == input.O ||
                    (this.O != null &&
                    this.O.Equals(input.O))
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
                hashCode = hashCode * 59 + this.T.GetHashCode();
                hashCode = hashCode * 59 + this.V.GetHashCode();
                if (this.C != null)
                    hashCode = hashCode * 59 + this.C.GetHashCode();
                if (this.H != null)
                    hashCode = hashCode * 59 + this.H.GetHashCode();
                if (this.L != null)
                    hashCode = hashCode * 59 + this.L.GetHashCode();
                if (this.O != null)
                    hashCode = hashCode * 59 + this.O.GetHashCode();
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
