
# Zuora.Model.Fulfillment

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
**order_line_item_id** | **string** | The unique identifier of the associated order line item. | [optional] 
**fulfillment_number** | **string** | Human-readable identifier for the object. It can be user-supplied. | [optional] 
**fulfillment_date** | **DateTime** | The date of the fulfillment. | [optional] 
**type** | **string** | The type of fulfillment. | [optional] 
**quantity** | **decimal** | The number of units of this item. | [optional] 
**state** | **string** | The status of the invoice. | [optional] 
**target_date** | **DateTime** | All order line items associated with this fulfillment that were unbilled on or before this date are included in future bill runs. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**tracking_number** | **string** | The tracking number of the fulfillment. | [optional] 
**carrier** | **string** | The name of the shipping carrier for this fulfillment. | [optional] 
**fulfillment_system** | **string** | The fulfillment system for the fulfillment. | [optional] 
**external_id** | **string** | An external identifier for the fulfillment. | [optional] 
**revenue** | [**Revenue**](Revenue.md) |  | [optional] 
**location** | **Dictionary&lt;string, Object&gt;** | The fulfillment location of the fulfillment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

