
# Zuora.Model.SubscriptionPlan

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
**subscription** | [**Subscription**](Subscription.md) | The subscription to which this subscription plan belongs. | [optional] 
**subscription_id** | **string** | Identifier of the subscription this subscription plan belongs to. | [optional] 
**product_id** | **string** | Identifier of the product associated with this subscription plan. | [optional] 
**plan_id** | **string** | Identifier of the plan associated with this subscription plan. | [optional] 
**plan** | [**Plan**](Plan.md) | The plan object associated with this subscription plan. | [optional] 
**product** | [**Product**](Product.md) | The product associated with the subscription plan. | [optional] 
**name** | **string** | The name of the subscription plan. | [optional] 
**subscription_items** | [**SubscriptionItemListResponse**](SubscriptionItemListResponse.md) | List of subscription items. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

