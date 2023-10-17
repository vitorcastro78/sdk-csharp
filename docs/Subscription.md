
# Zuora.Model.Subscription

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
**subscription_number** | **string** | Human-readable identifier of the subscription. It can be user-supplied. | [optional] 
**state** | **string** | Status of the subscription. | [optional] 
**version** | **int** | The version of the subscription. This version can be used in the &#x60;filter[]&#x60; query parameter to filter subscriptions. | [optional] 
**account_id** | **string** | Identifier of the account associated with this subscription. | [optional] 
**account** | [**Account**](Account.md) | Information of the new account associated with the subscription. | [optional] 
**invoice_owner_account_id** | **string** | Identifier of the account that owns the invoice associated with this subscription. | [optional] 
**invoice_owner_account** | [**Account**](Account.md) | Identifier of the account that owns the subscription. | [optional] 
**auto_renew** | **bool** | If this field is set to &#x60;true&#x60;, the subscription automatically renews at the end of the current term. | [optional] 
**latest_version** | **bool** | If true, this is the latest version of the subscription | [optional] 
**initial_term** | [**Term**](Term.md) | Initial term information for the subscription. | [optional] 
**current_term** | [**Term**](Term.md) | Current term information for the subscription | [optional] 
**renewal_term** | [**Term**](Term.md) | Renewal term information for the subscription. | [optional] 
**start_date** | **DateTime** | Date when the subscription starts. | [optional] 
**end_date** | **DateTime** | Date when the subscription ends. | [optional] 
**description** | **string** | Description of the subscription. Often useful for displaying to users. | [optional] 
**contract_effective** | **DateTime** | Date when the subscriber contract is effective. | [optional] 
**service_activation** | **DateTime** | Date when the subscribed-to service is activated. | [optional] 
**customer_acceptance** | **DateTime** | Date when all the services or products in the subscription are accepted by the subscriber. | [optional] 
**invoice_separately** | **bool** | If true, the subscription is billed separately from other subscriptions. If false, the subscription is included with other subscriptions in the account invoice. The default is false. | [optional] 
**order_number** | **string** | The order number of the order created by Zuora. | [optional] 
**subscription_plans** | [**SubscriptionPlanListResponse**](SubscriptionPlanListResponse.md) | List of subscription plans. | [optional] [readonly] 
**invoice_items** | [**InvoiceItemListResponse**](InvoiceItemListResponse.md) | List of invoice items. | [optional] [readonly] 
**prepaid_balance** | [**List&lt;PrepaidBalance&gt;**](PrepaidBalance.md) | Total prepaid units available during a subscription. It is an aggregate of all funds under a subscription. | [optional] [readonly] 
**contracted_mrr** | **string** | Monthly recurring revenue of the subscription. | [optional] 
**bill_to_id** | **string** | ID of the bill-to contact. | [optional] 
**payment_terms** | **string** | The name of payment term associated with the invoice. | [optional] 
**bill_to** | [**Contact**](Contact.md) | The billing address for the customer. | [optional] [readonly] 
**billing_document_settings** | [**FlexibleBillingDocumentSettings**](FlexibleBillingDocumentSettings.md) | The billing document settings for the customer. | [optional] 
**sold_to_id** | **string** | ID of the sold-to contact. | [optional] 
**sold_to** | [**Contact**](Contact.md) | The selling address for the customer. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

