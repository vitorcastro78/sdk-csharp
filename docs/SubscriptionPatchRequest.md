
# Zuora.Model.SubscriptionPatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**description** | **string** | Description of the subscription. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**terms** | [**SubscriptionTermPatchRequest**](SubscriptionTermPatchRequest.md) |  | [optional] 
**invoice_owner_account_id** | **string** | Identifier of the account that owns the invoice associated with this subscription. | [optional] 
**invoice_owner_account_number** | **string** | Identifier of the account that owns the invoice associated with this subscription. | [optional] 
**account_id** | **string** | Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. | [optional] 
**account_number** | **string** | Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. | [optional] 
**add_subscription_plans** | [**List&lt;SubscriptionAddPlanPatchRequest&gt;**](SubscriptionAddPlanPatchRequest.md) | Specify this field if you want to add one or multiple subscription plans to this subscription. | [optional] 
**remove_subscription_plans** | [**List&lt;SubscriptionRemovePlanPatchRequest&gt;**](SubscriptionRemovePlanPatchRequest.md) | Specify this field if you want to remove one or multiple subscription plans from this subscription. | [optional] 
**replace_subscription_plans** | [**List&lt;SubscriptionReplacePlanPatchRequest&gt;**](SubscriptionReplacePlanPatchRequest.md) | Specify this field if you want to replace one or multiple subscription plans to this subscription. &lt;br /&gt;            **Note**: This field is currently not supported if you have Billing - Revenue Integration enabled. When Billing - Revenue Integration is enabled, the replace subscription plan type of order action will no longer be applicable in Zuora Billing.  | [optional] 
**update_subscription_plans** | [**List&lt;SubscriptionUpdatePlanPatchRequest&gt;**](SubscriptionUpdatePlanPatchRequest.md) |  | [optional] 
**renew** | [**SubscriptionRenewPatchRequest**](SubscriptionRenewPatchRequest.md) |  | [optional] 
**cancel** | [**CancelSubscriptionRequest**](CancelSubscriptionRequest.md) |  | [optional] 
**pause** | [**PauseSubscriptionRequest**](PauseSubscriptionRequest.md) |  | [optional] 
**resume** | [**ResumeSubscriptionRequest**](ResumeSubscriptionRequest.md) |  | [optional] 
**bill_to_id** | **string** | ID of the bill-to contact. | [optional] 
**payment_terms** | **string** | The name of payment term associated with the invoice. | [optional] 
**billing_document_settings** | [**FlexibleBillingDocumentSettings**](FlexibleBillingDocumentSettings.md) | The billing document settings for the customer. | [optional] 
**sold_to_id** | **string** | ID of the sold-to contact. | [optional] 
**invoice_separately** | **bool** | Separates a single subscription from other subscriptions and creates an invoice for this subscription. If the value is &#x60;true&#x60;, the subscription is billed separately from other subscriptions. If the value is &#x60;false&#x60;, the subscription is included with other subscriptions in the account invoice. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

