
# Zuora.Model.Account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | Unique identifier for the object. | [optional] [readonly] 
**updated_by_id** | **string** | Unique identifier of the Zuora user who last updated the object | [optional] [readonly] 
**updated_time** | **DateTime** | The date and time when the object was last updated in ISO 8601 UTC format. | [optional] [readonly] 
**created_by_id** | **string** | Unique identifier of the Zuora user who created the object | [optional] [readonly] 
**created_time** | **DateTime** | The date and time when the object was created in ISO 8601 UTC format. | [optional] [readonly] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**custom_objects** | **Dictionary&lt;string, Object&gt;** | The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields). | [optional] [readonly] 
**account_number** | **string** | Human-readable identifier of the account. It can be user-supplied. | [optional] 
**billing_document_settings** | [**BillingDocumentSettings**](BillingDocumentSettings.md) |  | [optional] 
**batch** | **string** | The identifier of a bill run batch. | [optional] 
**bill_cycle_day** | **int** | The day of the month on which your customer will be invoiced. For month-end specify 31. | [optional] 
**bill_to** | [**Contact**](Contact.md) | Customer billing address. | [optional] [readonly] 
**sold_to** | [**Contact**](Contact.md) | Customer address used for calculating tax. | [optional] [readonly] 
**communication_profile_id** | **string** | Identifier of the communication profile associated with this customer. | [optional] 
**crm_id** | **string** | CRM account identifier. | [optional] 
**default_payment_method_id** | **string** | Identifier of the default payment method on the customer account. | [optional] 
**name** | **string** | The name of the customer account. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**parent_account_id** | **string** | Identifier of this customer&#39;s parent account, if any. | [optional] 
**payment_gateway** | **string** | Payment gateway name. | [optional] 
**payment_terms** | **string** | Payment terms configured in **Billing Settings &gt; Payment Terms** of your Zuora tenant. | [optional] 
**sequence_set_id** | **string** | The identifier or the billing document sequence set that is assigned to the customer account. | [optional] 
**auto_pay** | **bool** | Controls whether future payments are automatically billed when they are due. | [optional] 
**tax_certificate** | [**TaxCertificate**](TaxCertificate.md) |  | [optional] 
**tax_identifier** | [**TaxIdentifier**](TaxIdentifier.md) |  | [optional] 
**currency** | **string** | Three-letter ISO currency code. Once the currency is set for an account, it cannot be updated. | [optional] 
**sales_rep** | **string** | The name of the sales representative associated with this account | [optional] 
**enabled** | **bool** | Usually used to disable the customer account. The default is true. If false, attempts to create subscriptions for the customer account will fail. | [optional] [readonly] 
**remaining_debit_memo_balance** | **decimal** | Total remaining balance of all posted debit memos. | [optional] [readonly] 
**remaining_invoice_balance** | **decimal** | Total remaining balance of all posted invoices. | [optional] [readonly] 
**remaining_credit_memo_balance** | **decimal** | Total remaining balance of all posted credit memos. | [optional] [readonly] 
**remaining_payment_balance** | **decimal** | Total remaining balance of all posted payments. | [optional] [readonly] 
**bill_to_id** | **string** | Customer billing address. | [optional] 
**sold_to_id** | **string** | Customer address used for calculating tax. | [optional] 
**default_payment_method** | [**PaymentMethod**](PaymentMethod.md) | The default payment method for the customer. | [optional] 
**billing_documents** | [**BillingDocumentListResponse**](BillingDocumentListResponse.md) | List of customer billing documents. | [optional] [readonly] 
**payments** | [**PaymentListResponse**](PaymentListResponse.md) | List of customer payments. | [optional] [readonly] 
**payment_methods** | [**PaymentMethodListResponse**](PaymentMethodListResponse.md) | List of customer payment methods. | [optional] [readonly] 
**subscriptions** | [**SubscriptionListResponse**](SubscriptionListResponse.md) | List of customer subscriptions. | [optional] [readonly] 
**usage_records** | [**ListUsageResponse**](ListUsageResponse.md) | List of customer usages. | [optional] [readonly] 
**credit_memos** | [**CreditMemoListResponse**](CreditMemoListResponse.md) | List of credit memo | [optional] [readonly] 
**debit_memos** | [**DebitMemoListResponse**](DebitMemoListResponse.md) | List of debit memo | [optional] [readonly] 
**invoices** | [**InvoiceListResponse**](InvoiceListResponse.md) | List of invoices | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

