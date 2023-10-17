
# Zuora.Model.SubscriptionPreviewExistingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**description** | **string** | Description of the subscription. | [optional] 
**account_id** | **string** | Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. | [optional] 
**account_number** | **string** | Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. | [optional] 
**account_data** | [**SubscriptionPreviewAccountRequest**](SubscriptionPreviewAccountRequest.md) |  | [optional] 
**number_of_periods** | **int** | Specifies how many billing periods you want to preview. | [optional] 
**term_end** | **bool** | Indicates whether to preview the subscription till the end of the current term. | [optional] 
**metrics** | **List&lt;string&gt;** | Specifies the metrics you want to preview.    You can preview metrics of billing documents, the order delta metrics, or both. | [optional] 
**end_date** | **DateTime** | End date of the period for which you want to preview the subscription | [optional] 
**add_subscription_plans** | [**List&lt;SubscriptionAddPlanPatchRequest&gt;**](SubscriptionAddPlanPatchRequest.md) | Specify this field if you want to add one or multiple subscription plans to this subscription. | [optional] 
**replace_subscription_plans** | [**List&lt;SubscriptionReplacePlanPatchRequest&gt;**](SubscriptionReplacePlanPatchRequest.md) | Specify this field if you want to replace one or multiple subscription plans to this subscription. &lt;br /&gt;            **Note**: This field is currently not supported if you have Billing - Revenue Integration enabled. When Billing - Revenue Integration is enabled, the replace subscription plan type of order action will no longer be applicable in Zuora Billing.  | [optional] 
**update_subscription_plans** | [**List&lt;SubscriptionUpdatePlanPatchRequest&gt;**](SubscriptionUpdatePlanPatchRequest.md) |  | [optional] 
**remove_subscription_plans** | [**List&lt;SubscriptionRemovePlanPatchRequest&gt;**](SubscriptionRemovePlanPatchRequest.md) | Specify this field if you want to remove one or multiple subscription plans from this subscription. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

