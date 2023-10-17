
# Zuora.Model.FulfillmentCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**processing_options** | [**FulfillmentProcessingOption**](FulfillmentProcessingOption.md) |  | [optional] 
**order_line_item_id** | **string** | The unique identifier of the associated order line item. | 
**carrier** | **string** | The name of the shipping carrier for this fulfillment. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**revenue** | [**Revenue**](Revenue.md) |  | [optional] 
**external_id** | **string** | An external identifier for the fulfillment | [optional] 
**fulfillment_date** | **DateTime** | The date of the fulfillment. | 
**location** | **string** | The fulfillment location of the fulfillment. | [optional] 
**fulfillment_system** | **string** | The fulfillment system for the fulfillment. | [optional] 
**type** | **string** | The type of fulfillment. | [optional] 
**quantity** | **decimal** | The number of units of this item. | 
**state** | **string** | The status of the invoice. | [optional] 
**tracking_number** | **string** | The tracking number of the fulfillment. | [optional] 
**items** | [**List&lt;FulfillmentItemCreateRequestForFulfillmentPost&gt;**](FulfillmentItemCreateRequestForFulfillmentPost.md) | Information of all fulfillment items. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

