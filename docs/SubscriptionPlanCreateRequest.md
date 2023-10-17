
# Zuora.Model.SubscriptionPlanCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**plan_id** | **string** | Identifier of the plan associated with this subscription plan. | [optional] 
**plan_number** | **string** | Human-readable identifier of the plan associated with this subscription plan. | [optional] 
**prices** | [**List&lt;SubscriptionItemCreateRequest&gt;**](SubscriptionItemCreateRequest.md) | Price information within the subscription plan. | [optional] 
**unique_token** | **string** | Unique identifier for the subscription plan. This identifier enables you to refer to the subscription plan before the subscription plan has an internal identifier in Zuora. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

