
# Zuora.Model.SubscriptionTermPatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**current_term** | [**Term**](Term.md) | Current term information for the subscription. | [optional] 
**renewal_term** | [**Term**](Term.md) | Renewal term information for the subscription. | [optional] 
**auto_renew** | **bool** | If true, the subscription automatically renews at the end of the current term. | [optional] 
**start_on** | [**StartOn**](StartOn.md) |  | [optional] 
**bill_to_id** | **string** | ID of the bill-to contact. | [optional] 
**payment_terms** | **string** | The name of payment term associated with the invoice. | [optional] 
**billing_document_settings** | [**FlexibleBillingDocumentSettings**](FlexibleBillingDocumentSettings.md) | The billing document settings for the customer. | [optional] 
**sold_to_id** | **string** | ID of the sold-to contact. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

