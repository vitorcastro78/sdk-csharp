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
    /// DebitMemo
    /// </summary>
    [DataContract]
    public partial class DebitMemo :  IEquatable<DebitMemo>, IValidatableObject
    {
        /// <summary>
        /// The status of the debit memo.
        /// </summary>
        /// <value>The status of the debit memo.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DebitMemoStateEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,

            /// <summary>
            /// Enum Posted for value: posted
            /// </summary>
            [EnumMember(Value = "posted")]
            Posted = 2,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 3,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 4

        }

        /// <summary>
        /// The status of the debit memo.
        /// </summary>
        /// <value>The status of the debit memo.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public DebitMemoStateEnum? state { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitMemo" /> class.
        /// </summary>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        /// <param name="accountId">Identifier of the account that owns the debit memo..</param>
        /// <param name="accountNumber">Human-readable identifier of the account that owns the debit memo..</param>
        /// <param name="description">An arbitrary string associated with the object. Often useful for displaying to users..</param>
        /// <param name="dueDate">The date on which payment for the billing document is due..</param>
        /// <param name="documentDate">The date when the debit memo takes effect..</param>
        /// <param name="reasonCode">Reason for issuing this debit memo. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60; or &#x60;debit_memo&#x60;..</param>
        /// <param name="invoiceId">The identifier of the invoice from which this credit memo or debit memo is created. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60; or &#x60;debit_memo&#x60;..</param>
        /// <param name="transferToAccounting">Whether to transfer to an external accounting system..</param>
        /// <param name="excludeFromAutoApplyRules">Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60;..</param>
        /// <param name="pay">Indicates whether this billing document is automatically picked up for processing in the corresponding payment run..</param>
        /// <param name="amountRefunded">The amount of this billing document item refunded..</param>
        /// <param name="stateTransitions">stateTransitions.</param>
        /// <param name="state">The status of the debit memo..</param>
        /// <param name="account">The account that owns the billing document. EXPANDABLE.</param>
        /// <param name="billToId">ID of the bill-to contact..</param>
        /// <param name="paymentTerms">The name of payment term associated with the invoice..</param>
        /// <param name="billingDocumentSettings">The billing document settings for the customer..</param>
        public DebitMemo(Dictionary<string, Object> customFields = default(Dictionary<string, Object>), string accountId = default(string), string accountNumber = default(string), string description = default(string), DateTime dueDate = default(DateTime), DateTime documentDate = default(DateTime), string reasonCode = default(string), string invoiceId = default(string), bool transferToAccounting = default(bool), bool excludeFromAutoApplyRules = default(bool), bool pay = default(bool), decimal amountRefunded = default(decimal), Object stateTransitions = default(Object), DebitMemoStateEnum? state = default(DebitMemoStateEnum?), Account account = default(Account), string billToId = default(string), string paymentTerms = default(string), FlexibleBillingDocumentSettings billingDocumentSettings = default(FlexibleBillingDocumentSettings))
        {
            this.state_transitions = stateTransitions;
            this.account = account;
            this.bill_to_id = billToId;
            this.payment_terms = paymentTerms;
            this.billing_document_settings = billingDocumentSettings;
            this.custom_fields = customFields;
            this.account_id = accountId;
            this.account_number = accountNumber;
            this.description = description;
            this.due_date = dueDate;
            this.document_date = documentDate;
            this.reason_code = reasonCode;
            this.invoice_id = invoiceId;
            this.transfer_to_accounting = transferToAccounting;
            this.exclude_from_auto_apply_rules = excludeFromAutoApplyRules;
            this.pay = pay;
            this.amount_refunded = amountRefunded;
            this.state_transitions = stateTransitions;
            this.state = state;
            this.account = account;
            this.bill_to_id = billToId;
            this.payment_terms = paymentTerms;
            this.billing_document_settings = billingDocumentSettings;
        }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; private set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name="updated_by_id", EmitDefaultValue=false)]
        public string updated_by_id { get; private set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name="updated_time", EmitDefaultValue=false)]
        public DateTime updated_time { get; private set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name="created_by_id", EmitDefaultValue=false)]
        public string created_by_id { get; private set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name="created_time", EmitDefaultValue=false)]
        public DateTime created_time { get; private set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields).
        /// </summary>
        /// <value>The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields).</value>
        [DataMember(Name="custom_objects", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_objects { get; private set; }

        /// <summary>
        /// Identifier of the account that owns the debit memo.
        /// </summary>
        /// <value>Identifier of the account that owns the debit memo.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string account_id { get; set; }

        /// <summary>
        /// Human-readable identifier of the account that owns the debit memo.
        /// </summary>
        /// <value>Human-readable identifier of the account that owns the debit memo.</value>
        [DataMember(Name="account_number", EmitDefaultValue=false)]
        public string account_number { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// The date on which payment for the billing document is due.
        /// </summary>
        /// <value>The date on which payment for the billing document is due.</value>
        [DataMember(Name="due_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime due_date { get; set; }

        /// <summary>
        /// The date when the debit memo takes effect.
        /// </summary>
        /// <value>The date when the debit memo takes effect.</value>
        [DataMember(Name="document_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime document_date { get; set; }

        /// <summary>
        /// Reason for issuing this debit memo. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60; or &#x60;debit_memo&#x60;.
        /// </summary>
        /// <value>Reason for issuing this debit memo. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60; or &#x60;debit_memo&#x60;.</value>
        [DataMember(Name="reason_code", EmitDefaultValue=false)]
        public string reason_code { get; set; }

        /// <summary>
        /// The identifier of the invoice from which this credit memo or debit memo is created. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60; or &#x60;debit_memo&#x60;.
        /// </summary>
        /// <value>The identifier of the invoice from which this credit memo or debit memo is created. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60; or &#x60;debit_memo&#x60;.</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public string invoice_id { get; set; }

        /// <summary>
        /// Whether to transfer to an external accounting system.
        /// </summary>
        /// <value>Whether to transfer to an external accounting system.</value>
        [DataMember(Name="transfer_to_accounting", EmitDefaultValue=false)]
        public bool transfer_to_accounting { get; set; }

        /// <summary>
        /// Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60;.
        /// </summary>
        /// <value>Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60;.</value>
        [DataMember(Name="exclude_from_auto_apply_rules", EmitDefaultValue=false)]
        public bool exclude_from_auto_apply_rules { get; set; }

        /// <summary>
        /// Indicates whether this billing document is automatically picked up for processing in the corresponding payment run.
        /// </summary>
        /// <value>Indicates whether this billing document is automatically picked up for processing in the corresponding payment run.</value>
        [DataMember(Name="pay", EmitDefaultValue=false)]
        public bool pay { get; set; }

        /// <summary>
        /// A human-readable identifier for the billing document; may be user-supplied.
        /// </summary>
        /// <value>A human-readable identifier for the billing document; may be user-supplied.</value>
        [DataMember(Name="debit_memo_number", EmitDefaultValue=false)]
        public string debit_memo_number { get; private set; }

        /// <summary>
        /// The amount of this billing document item refunded.
        /// </summary>
        /// <value>The amount of this billing document item refunded.</value>
        [DataMember(Name="amount_refunded", EmitDefaultValue=false)]
        public decimal amount_refunded { get; set; }

        /// <summary>
        /// Gets or Sets state_transitions
        /// </summary>
        [DataMember(Name="state_transitions", EmitDefaultValue=true)]
        public Object state_transitions { get; set; }

        /// <summary>
        /// Identifier of the Zuora user who posted the debit memo.
        /// </summary>
        /// <value>Identifier of the Zuora user who posted the debit memo.</value>
        [DataMember(Name="posted_by_id", EmitDefaultValue=false)]
        public string posted_by_id { get; private set; }


        /// <summary>
        /// The account that owns the billing document. EXPANDABLE
        /// </summary>
        /// <value>The account that owns the billing document. EXPANDABLE</value>
        [DataMember(Name="account", EmitDefaultValue=true)]
        public Account account { get; set; }

        /// <summary>
        /// List of debit memo items.
        /// </summary>
        /// <value>List of debit memo items.</value>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public BillingDocumentItemListResponse items { get; private set; }

        /// <summary>
        /// The total amount.
        /// </summary>
        /// <value>The total amount.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal total { get; private set; }

        /// <summary>
        /// The total amount exclusive of tax.
        /// </summary>
        /// <value>The total amount exclusive of tax.</value>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public decimal subtotal { get; private set; }

        /// <summary>
        /// The total tax amount.
        /// </summary>
        /// <value>The total tax amount.</value>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public decimal tax { get; private set; }

        /// <summary>
        /// The total balance remaining.  This field is deprecated. Use &#x60;remaining_balance&#x60; field.
        /// </summary>
        /// <value>The total balance remaining.  This field is deprecated. Use &#x60;remaining_balance&#x60; field.</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        [Obsolete]
        public decimal balance { get; private set; }

        /// <summary>
        /// The total balance remaining.
        /// </summary>
        /// <value>The total balance remaining.</value>
        [DataMember(Name="remaining_balance", EmitDefaultValue=false)]
        public decimal remaining_balance { get; private set; }

        /// <summary>
        /// The total amount paid.
        /// </summary>
        /// <value>The total amount paid.</value>
        [DataMember(Name="amount_paid", EmitDefaultValue=false)]
        public decimal amount_paid { get; private set; }

        /// <summary>
        /// Whether payment was successfully collected for this invoice. An invoice can be paid with a payment or a credit memo.
        /// </summary>
        /// <value>Whether payment was successfully collected for this invoice. An invoice can be paid with a payment or a credit memo.</value>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public bool paid { get; private set; }

        /// <summary>
        /// Whether payment is past due.
        /// </summary>
        /// <value>Whether payment is past due.</value>
        [DataMember(Name="past_due", EmitDefaultValue=false)]
        public bool past_due { get; private set; }

        /// <summary>
        /// ID of the bill-to contact.
        /// </summary>
        /// <value>ID of the bill-to contact.</value>
        [DataMember(Name="bill_to_id", EmitDefaultValue=true)]
        public string bill_to_id { get; set; }

        /// <summary>
        /// The name of payment term associated with the invoice.
        /// </summary>
        /// <value>The name of payment term associated with the invoice.</value>
        [DataMember(Name="payment_terms", EmitDefaultValue=true)]
        public string payment_terms { get; set; }

        /// <summary>
        /// The billing address for the customer.
        /// </summary>
        /// <value>The billing address for the customer.</value>
        [DataMember(Name="bill_to", EmitDefaultValue=true)]
        public Contact bill_to { get; private set; }

        /// <summary>
        /// The billing document settings for the customer.
        /// </summary>
        /// <value>The billing document settings for the customer.</value>
        [DataMember(Name="billing_document_settings", EmitDefaultValue=true)]
        public FlexibleBillingDocumentSettings billing_document_settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebitMemo {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  updated_by_id: ").Append(updated_by_id).Append("\n");
            sb.Append("  updated_time: ").Append(updated_time).Append("\n");
            sb.Append("  created_by_id: ").Append(created_by_id).Append("\n");
            sb.Append("  created_time: ").Append(created_time).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
            sb.Append("  custom_objects: ").Append(custom_objects).Append("\n");
            sb.Append("  account_id: ").Append(account_id).Append("\n");
            sb.Append("  account_number: ").Append(account_number).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  due_date: ").Append(due_date).Append("\n");
            sb.Append("  document_date: ").Append(document_date).Append("\n");
            sb.Append("  reason_code: ").Append(reason_code).Append("\n");
            sb.Append("  invoice_id: ").Append(invoice_id).Append("\n");
            sb.Append("  transfer_to_accounting: ").Append(transfer_to_accounting).Append("\n");
            sb.Append("  exclude_from_auto_apply_rules: ").Append(exclude_from_auto_apply_rules).Append("\n");
            sb.Append("  pay: ").Append(pay).Append("\n");
            sb.Append("  debit_memo_number: ").Append(debit_memo_number).Append("\n");
            sb.Append("  amount_refunded: ").Append(amount_refunded).Append("\n");
            sb.Append("  state_transitions: ").Append(state_transitions).Append("\n");
            sb.Append("  posted_by_id: ").Append(posted_by_id).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  account: ").Append(account).Append("\n");
            sb.Append("  items: ").Append(items).Append("\n");
            sb.Append("  total: ").Append(total).Append("\n");
            sb.Append("  subtotal: ").Append(subtotal).Append("\n");
            sb.Append("  tax: ").Append(tax).Append("\n");
            sb.Append("  balance: ").Append(balance).Append("\n");
            sb.Append("  remaining_balance: ").Append(remaining_balance).Append("\n");
            sb.Append("  amount_paid: ").Append(amount_paid).Append("\n");
            sb.Append("  paid: ").Append(paid).Append("\n");
            sb.Append("  past_due: ").Append(past_due).Append("\n");
            sb.Append("  bill_to_id: ").Append(bill_to_id).Append("\n");
            sb.Append("  payment_terms: ").Append(payment_terms).Append("\n");
            sb.Append("  bill_to: ").Append(bill_to).Append("\n");
            sb.Append("  billing_document_settings: ").Append(billing_document_settings).Append("\n");
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
            return this.Equals(input as DebitMemo);
        }

        /// <summary>
        /// Returns true if DebitMemo instances are equal
        /// </summary>
        /// <param name="input">Instance of DebitMemo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebitMemo input)
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
                    this.updated_by_id == input.updated_by_id ||
                    (this.updated_by_id != null &&
                    this.updated_by_id.Equals(input.updated_by_id))
                ) && 
                (
                    this.updated_time == input.updated_time ||
                    (this.updated_time != null &&
                    this.updated_time.Equals(input.updated_time))
                ) && 
                (
                    this.created_by_id == input.created_by_id ||
                    (this.created_by_id != null &&
                    this.created_by_id.Equals(input.created_by_id))
                ) && 
                (
                    this.created_time == input.created_time ||
                    (this.created_time != null &&
                    this.created_time.Equals(input.created_time))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
                ) && 
                (
                    this.custom_objects == input.custom_objects ||
                    this.custom_objects != null &&
                    input.custom_objects != null &&
                    this.custom_objects.SequenceEqual(input.custom_objects)
                ) && 
                (
                    this.account_id == input.account_id ||
                    (this.account_id != null &&
                    this.account_id.Equals(input.account_id))
                ) && 
                (
                    this.account_number == input.account_number ||
                    (this.account_number != null &&
                    this.account_number.Equals(input.account_number))
                ) && 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.due_date == input.due_date ||
                    (this.due_date != null &&
                    this.due_date.Equals(input.due_date))
                ) && 
                (
                    this.document_date == input.document_date ||
                    (this.document_date != null &&
                    this.document_date.Equals(input.document_date))
                ) && 
                (
                    this.reason_code == input.reason_code ||
                    (this.reason_code != null &&
                    this.reason_code.Equals(input.reason_code))
                ) && 
                (
                    this.invoice_id == input.invoice_id ||
                    (this.invoice_id != null &&
                    this.invoice_id.Equals(input.invoice_id))
                ) && 
                (
                    this.transfer_to_accounting == input.transfer_to_accounting ||
                    (this.transfer_to_accounting != null &&
                    this.transfer_to_accounting.Equals(input.transfer_to_accounting))
                ) && 
                (
                    this.exclude_from_auto_apply_rules == input.exclude_from_auto_apply_rules ||
                    (this.exclude_from_auto_apply_rules != null &&
                    this.exclude_from_auto_apply_rules.Equals(input.exclude_from_auto_apply_rules))
                ) && 
                (
                    this.pay == input.pay ||
                    (this.pay != null &&
                    this.pay.Equals(input.pay))
                ) && 
                (
                    this.debit_memo_number == input.debit_memo_number ||
                    (this.debit_memo_number != null &&
                    this.debit_memo_number.Equals(input.debit_memo_number))
                ) && 
                (
                    this.amount_refunded == input.amount_refunded ||
                    (this.amount_refunded != null &&
                    this.amount_refunded.Equals(input.amount_refunded))
                ) && 
                (
                    this.state_transitions == input.state_transitions ||
                    (this.state_transitions != null &&
                    this.state_transitions.Equals(input.state_transitions))
                ) && 
                (
                    this.posted_by_id == input.posted_by_id ||
                    (this.posted_by_id != null &&
                    this.posted_by_id.Equals(input.posted_by_id))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                ) && 
                (
                    this.account == input.account ||
                    (this.account != null &&
                    this.account.Equals(input.account))
                ) && 
                (
                    this.items == input.items ||
                    (this.items != null &&
                    this.items.Equals(input.items))
                ) && 
                (
                    this.total == input.total ||
                    (this.total != null &&
                    this.total.Equals(input.total))
                ) && 
                (
                    this.subtotal == input.subtotal ||
                    (this.subtotal != null &&
                    this.subtotal.Equals(input.subtotal))
                ) && 
                (
                    this.tax == input.tax ||
                    (this.tax != null &&
                    this.tax.Equals(input.tax))
                ) && 
                (
                    this.balance == input.balance ||
                    (this.balance != null &&
                    this.balance.Equals(input.balance))
                ) && 
                (
                    this.remaining_balance == input.remaining_balance ||
                    (this.remaining_balance != null &&
                    this.remaining_balance.Equals(input.remaining_balance))
                ) && 
                (
                    this.amount_paid == input.amount_paid ||
                    (this.amount_paid != null &&
                    this.amount_paid.Equals(input.amount_paid))
                ) && 
                (
                    this.paid == input.paid ||
                    (this.paid != null &&
                    this.paid.Equals(input.paid))
                ) && 
                (
                    this.past_due == input.past_due ||
                    (this.past_due != null &&
                    this.past_due.Equals(input.past_due))
                ) && 
                (
                    this.bill_to_id == input.bill_to_id ||
                    (this.bill_to_id != null &&
                    this.bill_to_id.Equals(input.bill_to_id))
                ) && 
                (
                    this.payment_terms == input.payment_terms ||
                    (this.payment_terms != null &&
                    this.payment_terms.Equals(input.payment_terms))
                ) && 
                (
                    this.bill_to == input.bill_to ||
                    (this.bill_to != null &&
                    this.bill_to.Equals(input.bill_to))
                ) && 
                (
                    this.billing_document_settings == input.billing_document_settings ||
                    (this.billing_document_settings != null &&
                    this.billing_document_settings.Equals(input.billing_document_settings))
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
                if (this.updated_by_id != null)
                    hashCode = hashCode * 59 + this.updated_by_id.GetHashCode();
                if (this.updated_time != null)
                    hashCode = hashCode * 59 + this.updated_time.GetHashCode();
                if (this.created_by_id != null)
                    hashCode = hashCode * 59 + this.created_by_id.GetHashCode();
                if (this.created_time != null)
                    hashCode = hashCode * 59 + this.created_time.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
                if (this.custom_objects != null)
                    hashCode = hashCode * 59 + this.custom_objects.GetHashCode();
                if (this.account_id != null)
                    hashCode = hashCode * 59 + this.account_id.GetHashCode();
                if (this.account_number != null)
                    hashCode = hashCode * 59 + this.account_number.GetHashCode();
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.due_date != null)
                    hashCode = hashCode * 59 + this.due_date.GetHashCode();
                if (this.document_date != null)
                    hashCode = hashCode * 59 + this.document_date.GetHashCode();
                if (this.reason_code != null)
                    hashCode = hashCode * 59 + this.reason_code.GetHashCode();
                if (this.invoice_id != null)
                    hashCode = hashCode * 59 + this.invoice_id.GetHashCode();
                if (this.transfer_to_accounting != null)
                    hashCode = hashCode * 59 + this.transfer_to_accounting.GetHashCode();
                if (this.exclude_from_auto_apply_rules != null)
                    hashCode = hashCode * 59 + this.exclude_from_auto_apply_rules.GetHashCode();
                if (this.pay != null)
                    hashCode = hashCode * 59 + this.pay.GetHashCode();
                if (this.debit_memo_number != null)
                    hashCode = hashCode * 59 + this.debit_memo_number.GetHashCode();
                if (this.amount_refunded != null)
                    hashCode = hashCode * 59 + this.amount_refunded.GetHashCode();
                if (this.state_transitions != null)
                    hashCode = hashCode * 59 + this.state_transitions.GetHashCode();
                if (this.posted_by_id != null)
                    hashCode = hashCode * 59 + this.posted_by_id.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.account != null)
                    hashCode = hashCode * 59 + this.account.GetHashCode();
                if (this.items != null)
                    hashCode = hashCode * 59 + this.items.GetHashCode();
                if (this.total != null)
                    hashCode = hashCode * 59 + this.total.GetHashCode();
                if (this.subtotal != null)
                    hashCode = hashCode * 59 + this.subtotal.GetHashCode();
                if (this.tax != null)
                    hashCode = hashCode * 59 + this.tax.GetHashCode();
                if (this.balance != null)
                    hashCode = hashCode * 59 + this.balance.GetHashCode();
                if (this.remaining_balance != null)
                    hashCode = hashCode * 59 + this.remaining_balance.GetHashCode();
                if (this.amount_paid != null)
                    hashCode = hashCode * 59 + this.amount_paid.GetHashCode();
                if (this.paid != null)
                    hashCode = hashCode * 59 + this.paid.GetHashCode();
                if (this.past_due != null)
                    hashCode = hashCode * 59 + this.past_due.GetHashCode();
                if (this.bill_to_id != null)
                    hashCode = hashCode * 59 + this.bill_to_id.GetHashCode();
                if (this.payment_terms != null)
                    hashCode = hashCode * 59 + this.payment_terms.GetHashCode();
                if (this.bill_to != null)
                    hashCode = hashCode * 59 + this.bill_to.GetHashCode();
                if (this.billing_document_settings != null)
                    hashCode = hashCode * 59 + this.billing_document_settings.GetHashCode();
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
