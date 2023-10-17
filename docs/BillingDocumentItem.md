
# Zuora.Model.BillingDocumentItem

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
**amount** | **decimal** | The total amount of this billing document item. | [optional] 
**subtotal** | **decimal** | The total amount of this billing document item exclusive of tax. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**deferred_revenue_account** | **string** | The accounting code for the deferred revenue, such as Monthly Recurring Liability. | [optional] 
**on_account_account** | **string** | The accounting code that maps to an on account in your accounting system. | [optional] 
**recognized_revenue_account** | **string** | The accounting code for the recognized revenue, such as Monthly Recurring Charges or Overage Charges. | [optional] 
**billing_document** | [**BillingDocument**](BillingDocument.md) | The related billing document. | [optional] 
**billing_document_id** | **string** | The related billing document id. | [optional] 
**revenue_recognition_rule_name** | **string** | The name of the revenue recognition rule governing the revenue schedule. | [optional] 
**quantity** | **decimal** | The number of units of this item. | [optional] 
**service_end** | **string** | The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**accounts_receivable_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**discount_item** | **bool** | If true, indicates that the item is a discount item. | [optional] 
**applied_to_item_id** | **string** | Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to. | [optional] 
**service_start** | **string** | The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**accounting_code** | **string** |  | [optional] 
**sku** | **string** | The unique SKU (stock keeping unit) of the product associated with this item. | [optional] 
**product_name** | **string** | The name of the product associated with this item. | [optional] 
**subscription_id** | **string** | The identifier of the subscription associated with the billing document item. | [optional] 
**subscription** | [**Subscription**](Subscription.md) | The expandable subscription associated with the billing document item. | [optional] 
**tax_inclusive** | **bool** | This specifies if the billing document item amount is inclusive or exclusive of tax. | [optional] 
**remaining_balance** | **decimal** | The remaining balance of this billing document item. | [optional] 
**unit_of_measure** | **string** | Specifies the units used to measure usage. | [optional] 
**unit_amount** | **decimal** | Unit amount (in the currency specified) of the billing document item. | [optional] 
**booking_reference** | **string** | The booking reference for this billing document item. | [optional] 
**price_description** | **string** | The description of the price this billing document item is associated with. | [optional] 
**name** | **string** | Name of the billing document item displayed to customers on the billing document. | [optional] 
**price_id** | **string** | The identifier of the price this billing document item is associated with. | [optional] 
**purchase_order_number** | **string** | The purchase order number associated with this billing document item. | [optional] 
**tax** | **decimal** | The amount of tax applied to the billing document item. | [optional] 
**tax_code** | **string** | The designated tax code. | [optional] 
**subscription_item_id** | **string** | The identifier the subscription item associated with this billing document item. | [optional] 
**subscription_item** | [**SubscriptionItem**](SubscriptionItem.md) | The expandable subscription item associated with this billing document item. | [optional] 
**invoice_item_id** | **string** | The identifier of the invoice item associated with this billing document item. | [optional] 
**document_item_date** | **DateTime** | The date when the billing document item takes effect. | [optional] 
**taxation_items** | [**TaxationItemListResponse**](TaxationItemListResponse.md) | List of taxation items. | [optional] 
**type** | **string** | The type of billing document, one of credit_memo, debit_memo or invoice. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

