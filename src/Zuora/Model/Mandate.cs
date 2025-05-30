/*
 * Quickstart API Reference
 *
 * Zuora Quickstart API is recommended for new customers and integrators, allowing new integrators to swiftly integrate with Zuora. It supports essential business use cases.   To use the Quickstart API, you must have the following features enabled on your tenant:   * [Orders](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders) or [Orders Harmonization](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders/Orders_Harmonization)  * [Invoice Settlement](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/Invoice_Settlement)  To find the latest changes made to the Zuora Quickstart API, check the [Quickstart API Changelog](https://www.zuora.com/developer/quickstart-api/changelog/2022q4-changelog/).  We recommend that you subscribe to [Developers Community](https://community.zuora.com/communities/community-home?communitykey=e2a932b4-50c4-4019-a3e8-362e38714df3) to get notifications when a new version is released.  
 *
 * The version of the OpenAPI document: 2023-09-25
 * 
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
using OpenAPIDateConverter = Zuora.Client.OpenAPIDateConverter;

namespace Zuora.Model
{
    /// <summary>
    /// The mandate information for the Credit Card, Credit Card Reference Transaction, ACH, or Bank Transfer payment method.
    /// </summary>
    [DataContract]
    public partial class Mandate :  IEquatable<Mandate>, IValidatableObject
    {
        /// <summary>
        /// The status of the mandate, which indicates whether it can be used to initiate a payment.
        /// </summary>
        /// <value>The status of the mandate, which indicates whether it can be used to initiate a payment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MandateStateEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 2,

            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 3,

            /// <summary>
            /// Enum Agreed for value: agreed
            /// </summary>
            [EnumMember(Value = "agreed")]
            Agreed = 4

        }

        /// <summary>
        /// The status of the mandate, which indicates whether it can be used to initiate a payment.
        /// </summary>
        /// <value>The status of the mandate, which indicates whether it can be used to initiate a payment.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public MandateStateEnum? state { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mandate" /> class.
        /// </summary>
        /// <param name="id">Identifier of the single- or multi-use mandate generated by the payment gateway..</param>
        /// <param name="reason">Reason for the mandate..</param>
        public Mandate(string id = default(string), string reason = default(string))
        {
            this.id = id;
            this.reason = reason;
        }

        /// <summary>
        /// Identifier of the single- or multi-use mandate generated by the payment gateway.
        /// </summary>
        /// <value>Identifier of the single- or multi-use mandate generated by the payment gateway.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; set; }

        /// <summary>
        /// Reason for the mandate.
        /// </summary>
        /// <value>Reason for the mandate.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mandate {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  reason: ").Append(reason).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Mandate);
        }

        /// <summary>
        /// Returns true if Mandate instances are equal
        /// </summary>
        /// <param name="input">Instance of Mandate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mandate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.reason == input.reason ||
                    (this.reason != null &&
                    this.reason.Equals(input.reason))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
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
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.reason != null)
                    hashCode = hashCode * 59 + this.reason.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
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
