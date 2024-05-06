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
    /// Risk unit
    /// </summary>
    [DataContract]
    public partial class MockRiskUnit :  IEquatable<MockRiskUnit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MockRiskUnit" /> class.
        /// </summary>
        /// <param name="symbol">Risk unit name.</param>
        /// <param name="spotInUse">Spot usage.</param>
        /// <param name="maintainMargin">Maintenance margin.</param>
        /// <param name="initialMargin">Initial margin.</param>
        /// <param name="marginResult">Margin result.</param>
        /// <param name="delta">Total Delta of risk unit.</param>
        /// <param name="gamma">Total Gamma of risk unit.</param>
        /// <param name="theta">Total Theta of risk unit.</param>
        /// <param name="vega">Total Vega of risk unit.</param>
        public MockRiskUnit(string symbol = default(string), string spotInUse = default(string), string maintainMargin = default(string), string initialMargin = default(string), List<MockMarginResult> marginResult = default(List<MockMarginResult>), string delta = default(string), string gamma = default(string), string theta = default(string), string vega = default(string))
        {
            this.Symbol = symbol;
            this.SpotInUse = spotInUse;
            this.MaintainMargin = maintainMargin;
            this.InitialMargin = initialMargin;
            this.MarginResult = marginResult;
            this.Delta = delta;
            this.Gamma = gamma;
            this.Theta = theta;
            this.Vega = vega;
        }

        /// <summary>
        /// Risk unit name
        /// </summary>
        /// <value>Risk unit name</value>
        [DataMember(Name="symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Spot usage
        /// </summary>
        /// <value>Spot usage</value>
        [DataMember(Name="spot_in_use")]
        public string SpotInUse { get; set; }

        /// <summary>
        /// Maintenance margin
        /// </summary>
        /// <value>Maintenance margin</value>
        [DataMember(Name="maintain_margin")]
        public string MaintainMargin { get; set; }

        /// <summary>
        /// Initial margin
        /// </summary>
        /// <value>Initial margin</value>
        [DataMember(Name="initial_margin")]
        public string InitialMargin { get; set; }

        /// <summary>
        /// Margin result
        /// </summary>
        /// <value>Margin result</value>
        [DataMember(Name="margin_result")]
        public List<MockMarginResult> MarginResult { get; set; }

        /// <summary>
        /// Total Delta of risk unit
        /// </summary>
        /// <value>Total Delta of risk unit</value>
        [DataMember(Name="delta")]
        public string Delta { get; set; }

        /// <summary>
        /// Total Gamma of risk unit
        /// </summary>
        /// <value>Total Gamma of risk unit</value>
        [DataMember(Name="gamma")]
        public string Gamma { get; set; }

        /// <summary>
        /// Total Theta of risk unit
        /// </summary>
        /// <value>Total Theta of risk unit</value>
        [DataMember(Name="theta")]
        public string Theta { get; set; }

        /// <summary>
        /// Total Vega of risk unit
        /// </summary>
        /// <value>Total Vega of risk unit</value>
        [DataMember(Name="vega")]
        public string Vega { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MockRiskUnit {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  SpotInUse: ").Append(SpotInUse).Append("\n");
            sb.Append("  MaintainMargin: ").Append(MaintainMargin).Append("\n");
            sb.Append("  InitialMargin: ").Append(InitialMargin).Append("\n");
            sb.Append("  MarginResult: ").Append(MarginResult).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  Gamma: ").Append(Gamma).Append("\n");
            sb.Append("  Theta: ").Append(Theta).Append("\n");
            sb.Append("  Vega: ").Append(Vega).Append("\n");
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
            return this.Equals(input as MockRiskUnit);
        }

        /// <summary>
        /// Returns true if MockRiskUnit instances are equal
        /// </summary>
        /// <param name="input">Instance of MockRiskUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MockRiskUnit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.SpotInUse == input.SpotInUse ||
                    (this.SpotInUse != null &&
                    this.SpotInUse.Equals(input.SpotInUse))
                ) && 
                (
                    this.MaintainMargin == input.MaintainMargin ||
                    (this.MaintainMargin != null &&
                    this.MaintainMargin.Equals(input.MaintainMargin))
                ) && 
                (
                    this.InitialMargin == input.InitialMargin ||
                    (this.InitialMargin != null &&
                    this.InitialMargin.Equals(input.InitialMargin))
                ) && 
                (
                    this.MarginResult == input.MarginResult ||
                    this.MarginResult != null &&
                    input.MarginResult != null &&
                    this.MarginResult.SequenceEqual(input.MarginResult)
                ) && 
                (
                    this.Delta == input.Delta ||
                    (this.Delta != null &&
                    this.Delta.Equals(input.Delta))
                ) && 
                (
                    this.Gamma == input.Gamma ||
                    (this.Gamma != null &&
                    this.Gamma.Equals(input.Gamma))
                ) && 
                (
                    this.Theta == input.Theta ||
                    (this.Theta != null &&
                    this.Theta.Equals(input.Theta))
                ) && 
                (
                    this.Vega == input.Vega ||
                    (this.Vega != null &&
                    this.Vega.Equals(input.Vega))
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.SpotInUse != null)
                    hashCode = hashCode * 59 + this.SpotInUse.GetHashCode();
                if (this.MaintainMargin != null)
                    hashCode = hashCode * 59 + this.MaintainMargin.GetHashCode();
                if (this.InitialMargin != null)
                    hashCode = hashCode * 59 + this.InitialMargin.GetHashCode();
                if (this.MarginResult != null)
                    hashCode = hashCode * 59 + this.MarginResult.GetHashCode();
                if (this.Delta != null)
                    hashCode = hashCode * 59 + this.Delta.GetHashCode();
                if (this.Gamma != null)
                    hashCode = hashCode * 59 + this.Gamma.GetHashCode();
                if (this.Theta != null)
                    hashCode = hashCode * 59 + this.Theta.GetHashCode();
                if (this.Vega != null)
                    hashCode = hashCode * 59 + this.Vega.GetHashCode();
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
