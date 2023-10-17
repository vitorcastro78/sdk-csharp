
# Zuora.Model.SubscriptionPreviewBillingDocumentItemResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**subscription_item_description** | **string** |  | [optional] 
**subscription_item_name** | **string** |  | [optional] 
**subscription_item_number** | **string** |  | [optional] 
**processing_type** | **string** |  | [optional] 
**product_name** | **string** |  | [optional] 
**price_id** | **string** | The identifier of the price this billing document item is associated with. | [optional] 
**service_end_date** | **string** | The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**service_start_date** | **string** | The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge. | [optional] 
**tax** | **decimal** | The amount of tax applied to the billing document item. | [optional] 
**quantity** | **decimal** | The number of units of this item. | [optional] 
**unit_of_measure** | **string** | Specifies the units used to measure usage. | [optional] 
**subtotal** | **decimal** | The total amount of this billing document item exclusive of tax. | [optional] 
**total** | **decimal** | The total amount of this billing document item. | [optional] 
**taxation_items** | [**List&lt;SubscriptionPreviewBillingDocumentTaxationItemResponse&gt;**](SubscriptionPreviewBillingDocumentTaxationItemResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

