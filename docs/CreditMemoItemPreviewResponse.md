
# Zuora.Model.CreditMemoItemPreviewResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount** | **decimal** | The total amount of this credit memo item. | [optional] 
**subtotal** | **decimal** | The total amount of this credit memo item exclusive of tax. | [optional] 
**applied_to_item_id** | **string** | Identifier of an invoice item that this credit memo item is applied to. | [optional] 
**document_item_date** | **DateTime** | The date when the credit memo item takes effect. | [optional] 
**document_item_number** | **string** |  | [optional] 
**charge_type** | **string** | Type of the charge. It can be one of the following types: one-time, recurring, or usage. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**id** | **string** | Unique identifier of the object | [optional] 
**processing_type** | **string** |  | [optional] 
**quantity** | **decimal** | The number of units of this item. | [optional] 
**subscription_item_id** | **string** | The identifier the subscription item associated with this credit memo item. | [optional] 
**service_start_date** | **string** | The start date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**service_end_date** | **string** | The end date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**sku** | **string** | The unique SKU (stock keeping unit) of the product associated with this item. | [optional] 
**sku_name** | **string** | The name of the SKU associated with this item | [optional] 
**subscription_id** | **string** | The identifier of the subscription associated with the credit memo item. | [optional] 
**subscription_number** | **string** | Human-readable identifier of the subscription. It can be user-supplied. | [optional] 
**unit_of_measure** | **string** | Specifies the units used to measure usage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

