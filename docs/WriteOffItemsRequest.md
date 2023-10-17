
# Zuora.Model.WriteOffItemsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**deferred_revenue_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**on_account_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**recognized_revenue_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**revenue_recognition_rule_name** | **string** | The name of the revenue recognition rule governing the revenue schedule. | [optional] 
**service_end** | **DateTime** | The end date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item. | [optional] 
**service_start** | **DateTime** | The start date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item. | [optional] 
**sku** | **string** | The unique SKU (stock keeping unit) of the product associated with this item. | [optional] 
**unit_of_measure** | **string** | Specifies the units used to measure usage. | [optional] 
**id** | **string** | The unique identifier of the invoice item. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

