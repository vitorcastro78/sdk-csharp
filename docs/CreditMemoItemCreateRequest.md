
# Zuora.Model.CreditMemoItemCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount** | **decimal** | Amount of the credit memo item. This should always be equal to unit_amount * quantity. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**deferred_revenue_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**on_account_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**recognized_revenue_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**revenue_recognition_rule_name** | **string** | The name of the revenue recognition rule governing the revenue schedule. | [optional] 
**quantity** | **decimal** | The number of units of this item. | [optional] 
**service_end** | **DateTime** | The end date of the service period associated with this credit memo item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item. | [optional] 
**service_start** | **DateTime** | The start date of the service period associated with this credit memo item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item. | 
**sku** | **string** | The unique SKU (stock keeping unit) of the product associated with this item. | [optional] 
**tax_inclusive** | **bool** | Indicates whether the credit memo item amount is inclusive or exclusive of tax. | [optional] 
**unit_of_measure** | **string** | Specifies the units used to measure usage. | [optional] 
**taxation_items** | [**List&lt;TaxationItemCreateRequest&gt;**](TaxationItemCreateRequest.md) | List of taxation items. | [optional] 
**unit_amount** | **decimal** | Unit amount of the credit memo item. | [optional] 
**price_id** | **string** | The identifier of the price this credit memo item is associated with. | [optional] 
**purchase_order_number** | **string** | The purchase order number associated with this billing document item. | [optional] 
**tax_code** | **string** | The designated tax code. | [optional] 
**name** | **string** | Name of the billing document item displayed to customers on the billing document. | [optional] 
**invoice_item_id** | **string** | The identifier of the invoice item associated with this credit memo item. | [optional] 
**accounting_code** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

