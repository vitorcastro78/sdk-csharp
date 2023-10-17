
# Zuora.Model.InvoiceItemPreviewResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount** | **decimal** | The total amount of this invoice item. | [optional] 
**applied_to_item_id** | **string** | Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to. | [optional] 
**document_date** | **DateTime** |  | [optional] 
**subscription_item_description** | **string** |  | [optional] 
**subscription_item_id** | **string** | The identifier the subscription item associated with this invoice item. | [optional] 
**subscription_item_name** | **string** |  | [optional] 
**subscription_item_number** | **string** | Human-readable identifier of the subscription item. It can be user-supplied. | [optional] 
**charge_type** | **string** | Type of the charge. It can be one of the following types: one-time, recurring, or usage. | [optional] 
**id** | **string** | Unique identifier of the object | [optional] 
**processing_type** | **string** |  | [optional] 
**product_name** | **string** |  | [optional] 
**quantity** | **decimal** | The number of units of this item. | [optional] 
**service_start_date** | **string** | The start date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**service_end_date** | **string** | The end date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**subscription_id** | **string** | The identifier of the subscription associated with the invoice item. | [optional] 
**subscription_number** | **string** | The subscription number of the subscription associated with this item. | [optional] 
**subscription_name** | **string** | The name of the subscription associated with this item. | [optional] 
**tax** | **decimal** | The amount of tax applied to the invoice item. | [optional] 
**unit_of_measure** | **string** | Specifies the units used to measure usage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

