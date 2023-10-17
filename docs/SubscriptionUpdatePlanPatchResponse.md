
# Zuora.Model.SubscriptionUpdatePlanPatchResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**unique_token** | **string** | A unique string to represent the subscription plan in the order. The unique token is used to perform multiple actions against a newly added subscription plan. For example, if you want to add and update a product in the same order, assign a unique token to the newly added subscription plan and use that token in future order actions. | [optional] 
**plan_id** | **string** | The id of the subscription plan to be updated. It can be the latest version or any history version id. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**subscription_items** | [**List&lt;SubscriptionItem&gt;**](SubscriptionItem.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

