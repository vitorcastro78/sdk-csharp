
# Zuora.Model.CreditMemoItem

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
**amount** | **decimal** | The total amount of this credit memo item. | [optional] 
**subtotal** | **decimal** | The total amount of this credit memo item exclusive of tax. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**deferred_revenue_account** | **string** | The accounting code for the deferred revenue, such as Monthly Recurring Liability. | [optional] 
**on_account_account** | **string** | The accounting code that maps to an on account in your accounting system. | [optional] 
**recognized_revenue_account** | **string** | The accounting code for the recognized revenue, such as Monthly Recurring Charges or Overage Charges. | [optional] 
**credit_memo** | [**CreditMemo**](CreditMemo.md) | The related credit memo. | [optional] 
**credit_memo_id** | **string** | The related credit memo id. | [optional] 
**revenue_recognition_rule_name** | **string** | The name of the revenue recognition rule governing the revenue schedule. | [optional] 
**quantity** | **decimal** | The number of units of this item. | [optional] 
**service_end** | **string** | The end date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**service_start** | **string** | The start date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**accounts_receivable_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**discount_item** | **bool** | If true, indicates that the item is a discount item. | [optional] 
**applied_to_item_id** | **string** | Identifier of an invoice item that this credit memo item is applied to. | [optional] 
**accounting_code** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**sku** | **string** | The unique SKU (stock keeping unit) of the product associated with this item. | [optional] 
**tax_inclusive** | **bool** | This specifies if the credit memo item amount is inclusive or exclusive of tax. | [optional] 
**remaining_balance** | **decimal** | The remaining balance of this credit memo item. | [optional] 
**unit_of_measure** | **string** | Specifies the units used to measure usage. | [optional] 
**unit_amount** | **decimal** | Unit amount of the credit memo item. | [optional] 
**name** | **string** | Name of the credit memo item displayed to customers on the billing document. | [optional] 
**price_id** | **string** | The identifier of the price this credit memo item is associated with. | [optional] 
**purchase_order_number** | **string** | The purchase order number associated with this credit memo item. | [optional] 
**tax** | **decimal** | The amount of tax applied to the credit memo item. | [optional] 
**tax_code** | **string** | The designated tax code. | [optional] 
**subscription_id** | **string** | The identifier of the subscription associated with the credit memo item. | [optional] 
**subscription_item_id** | **string** | The identifier the subscription item associated with this credit memo item. | [optional] 
**invoice_item_id** | **string** | The identifier of the invoice item associated with this credit memo item. | [optional] 
**document_item_date** | **DateTime** | The date when the credit memo item takes effect. | [optional] 
**taxation_items** | [**TaxationItemListResponse**](TaxationItemListResponse.md) |  | [optional] 
**subscription** | [**Subscription**](Subscription.md) | List of customer subscriptions. | [optional] [readonly] 
**subscription_item** | [**SubscriptionItem**](SubscriptionItem.md) | The expandable subscription item associated with this billing document item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

