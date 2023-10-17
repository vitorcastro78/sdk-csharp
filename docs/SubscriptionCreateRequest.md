
# Zuora.Model.SubscriptionCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**invoice_owner_account_id** | **string** | Identifier of the account that owns the invoice associated with this subscription. If you specify this field, do not specify &#x60;invoice_owner_account_data&#x60;. | [optional] 
**invoice_owner_account_number** | **string** | Identifier of the account that owns the invoice associated with this subscription. If you specify this field, do not specify &#x60;invoice_owner_account_data&#x60;. | [optional] 
**invoice_owner_account_data** | [**AccountCreateRequest**](AccountCreateRequest.md) | The information of the new account that owns the invoice associated with this subscription. If you specify this field, do not specify &#x60;invoice_owner_account_id&#x60;. | [optional] 
**account_id** | **string** | Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify &#x60;account_data&#x60;. | [optional] 
**account_number** | **string** | Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify &#x60;account_data&#x60;. | [optional] 
**account_data** | [**AccountCreateRequest**](AccountCreateRequest.md) | The information of the new account that owns the subscription. The subscription owner account can be different from the invoice owner account. If you specify this field, do not specify &#x60;account_id&#x60;. | [optional] 
**auto_renew** | **bool** | If true, the subscription automatically renews at the end of the current term. | [optional] 
**subscription_number** | **string** | Human-readable identifier of the subscription; maybe user-supplied. | [optional] 
**initial_term** | [**Term**](Term.md) | Initial term information for the subscription. | [optional] 
**renewal_term** | [**Term**](Term.md) | Renewal term information for the subscription | [optional] 
**start_on** | [**StartOn**](StartOn.md) |  | [optional] 
**description** | **string** | Description of the subscription. Often useful for displaying to users. | [optional] 
**invoice_separately** | **bool** | Separates a single subscription from other subscriptions and creates an invoice for this subscription. If the value is &#x60;true&#x60;, the subscription is billed separately from other subscriptions. If the value is &#x60;false&#x60;, the subscription is included with other subscriptions in the account invoice. | [optional] 
**processing_options** | [**ProcessingOptions**](ProcessingOptions.md) |  | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**subscription_plans** | [**List&lt;SubscriptionPlanCreateRequest&gt;**](SubscriptionPlanCreateRequest.md) | The plans associated with the new subscription. | [optional] 
**bill_to_id** | **string** | ID of the bill-to contact. | [optional] 
**payment_terms** | **string** | The name of payment term associated with the invoice. | [optional] 
**bill_to** | [**Contact**](Contact.md) | The billing address for the customer. | [optional] [readonly] 
**billing_document_settings** | [**FlexibleBillingDocumentSettings**](FlexibleBillingDocumentSettings.md) | The billing document settings for the customer. | [optional] 
**sold_to_id** | **string** | ID of the sold-to contact. | [optional] 
**sold_to** | [**Contact**](Contact.md) | The selling address for the customer. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

