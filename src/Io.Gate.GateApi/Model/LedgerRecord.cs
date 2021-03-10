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
    /// LedgerRecord
    /// </summary>
    [DataContract]
    public partial class LedgerRecord :  IEquatable<LedgerRecord>, IValidatableObject
    {
        /// <summary>
        /// Record status.  - DONE: done - CANCEL: cancelled - REQUEST: requesting - MANUAL: waiting for manual approval - BCODE: GateCode operation
        /// </summary>
        /// <value>Record status.  - DONE: done - CANCEL: cancelled - REQUEST: requesting - MANUAL: waiting for manual approval - BCODE: GateCode operation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DONE for value: DONE
            /// </summary>
            [EnumMember(Value = "DONE")]
            DONE = 1,

            /// <summary>
            /// Enum CANCEL for value: CANCEL
            /// </summary>
            [EnumMember(Value = "CANCEL")]
            CANCEL = 2,

            /// <summary>
            /// Enum REQUEST for value: REQUEST
            /// </summary>
            [EnumMember(Value = "REQUEST")]
            REQUEST = 3,

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 4,

            /// <summary>
            /// Enum BCODE for value: BCODE
            /// </summary>
            [EnumMember(Value = "BCODE")]
            BCODE = 5

        }

        /// <summary>
        /// Record status.  - DONE: done - CANCEL: cancelled - REQUEST: requesting - MANUAL: waiting for manual approval - BCODE: GateCode operation
        /// </summary>
        /// <value>Record status.  - DONE: done - CANCEL: cancelled - REQUEST: requesting - MANUAL: waiting for manual approval - BCODE: GateCode operation</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgerRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LedgerRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgerRecord" /> class.
        /// </summary>
        /// <param name="amount">Currency amount (required).</param>
        /// <param name="currency">Currency name (required).</param>
        /// <param name="address">Withdrawal address. Required for withdrawals.</param>
        /// <param name="memo">Extra withdrawal memo.</param>
        /// <param name="chain">Name of the chain used in withdrawals.</param>
        public LedgerRecord(string amount = default(string), string currency = default(string), string address = default(string), string memo = default(string), string chain = default(string))
        {
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount", "amount is a required property for LedgerRecord and cannot be null");
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for LedgerRecord and cannot be null");
            this.Address = address;
            this.Memo = memo;
            this.Chain = chain;
        }

        /// <summary>
        /// Record ID
        /// </summary>
        /// <value>Record ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Hash record of the withdrawal
        /// </summary>
        /// <value>Hash record of the withdrawal</value>
        [DataMember(Name="txid", EmitDefaultValue=false)]
        public string Txid { get; private set; }

        /// <summary>
        /// Operation time
        /// </summary>
        /// <value>Operation time</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; private set; }

        /// <summary>
        /// Currency amount
        /// </summary>
        /// <value>Currency amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>Currency name</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Withdrawal address. Required for withdrawals
        /// </summary>
        /// <value>Withdrawal address. Required for withdrawals</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Extra withdrawal memo
        /// </summary>
        /// <value>Extra withdrawal memo</value>
        [DataMember(Name="memo", EmitDefaultValue=false)]
        public string Memo { get; set; }

        /// <summary>
        /// Name of the chain used in withdrawals
        /// </summary>
        /// <value>Name of the chain used in withdrawals</value>
        [DataMember(Name="chain", EmitDefaultValue=false)]
        public string Chain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LedgerRecord {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Txid: ").Append(Txid).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
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
            return this.Equals(input as LedgerRecord);
        }

        /// <summary>
        /// Returns true if LedgerRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of LedgerRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LedgerRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Txid == input.Txid ||
                    (this.Txid != null &&
                    this.Txid.Equals(input.Txid))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Txid != null)
                    hashCode = hashCode * 59 + this.Txid.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
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
