
# Zuora.Model.Order

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
**order_number** | **string** | The order number of the new order. If not provided, system will auto-generate a number for this order.     Note: Ensure that the order number does not contain a slash. | [optional] 
**order_date** | **DateTime** | The date when the order is signed. All the order actions under this order will use this order date as the contract effective date if the contract effective date field is skipped or its value is left as null. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**category** | **string** | Category of the order to indicate a product sale or return. Default value is &#x60;sale&#x60;. | [optional] 
**account_id** | **string** | Identifier of the account associated with this subscription. | [optional] 
**account** | [**Account**](Account.md) | Information of the new account associated with the subscription. | [optional] 
**line_items** | [**LineItemListResponse**](LineItemListResponse.md) |  | [optional] 
**subscriptions** | [**List&lt;PostSubscriptionOrderResponse&gt;**](PostSubscriptionOrderResponse.md) | Based on the intended order action, each item should include specific fields.     For example, to create a new subscription for a new account, you must specify the &#x60;account_data&#x60; and &#x60;subscription_plans&#x60; fields at a minimum. | [optional] 
**state** | **string** | The status of the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

