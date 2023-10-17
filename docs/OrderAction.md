
# Zuora.Model.OrderAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**action_id** | **string** | Identifier of the action. | [optional] 
**type** | **string** | The action associated with this metric. | [optional] 
**sequence** | **int** | The sequence number of the action. | [optional] 
**start_on** | [**StartOnResponse**](StartOnResponse.md) |  | [optional] 
**subscription_plans** | [**SubscriptionPlanListResponse**](SubscriptionPlanListResponse.md) | Specify this field to add new plans to the new subscription. | [optional] 
**add_subscription_plan** | [**SubscriptionAddPlanPatchResponse**](SubscriptionAddPlanPatchResponse.md) | Specify this field to add subscription plans to existing subscriptions. | [optional] 
**remove_subscription_plan** | [**SubscriptionRemovePlanPatchResponse**](SubscriptionRemovePlanPatchResponse.md) | Specify this field to remove subscription plans from existing subscriptions. | [optional] 
**update_subscription_plan** | [**SubscriptionUpdatePlanPatchResponse**](SubscriptionUpdatePlanPatchResponse.md) | Specify this field to update subscription plans on the existing subscriptions. | [optional] 
**replace_subscription_plan** | [**SubscriptionReplacePlanPatchResponse**](SubscriptionReplacePlanPatchResponse.md) | Specify this field to replace existing subscription plans with new plans. | [optional] 
**renew** | [**SubscriptionRenewPatchResponse**](SubscriptionRenewPatchResponse.md) | Specify this field to renew an existing subscription. | [optional] 
**terms** | [**SubscriptionTermPatchResponse**](SubscriptionTermPatchResponse.md) |  | [optional] 
**cancel** | [**SubscriptionCancelPatchResponse**](SubscriptionCancelPatchResponse.md) | Specify this field to cancel an existing subscription. | [optional] 
**pause** | [**SubscriptionPausePatchResponse**](SubscriptionPausePatchResponse.md) | Specify this field to pause an existing subscription. | [optional] 
**resume** | [**SubscriptionResumePatchResponse**](SubscriptionResumePatchResponse.md) | Specify this field to resume a paused subscription. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

