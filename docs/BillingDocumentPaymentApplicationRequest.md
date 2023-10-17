
# Zuora.Model.BillingDocumentPaymentApplicationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | Identifier of the billing document to which the credit memo, payment, or refund is applied. | 
**type** | **string** | The type of billing document. | 
**amount** | **decimal** | The amount applied to this billing document. | 
**billing_document_number** | **string** | A human-readable identifier for the billing document; may be user-supplied. | [optional] [readonly] 
**items** | [**List&lt;BillingDocumentItemPaymentApplicationRequest&gt;**](BillingDocumentItemPaymentApplicationRequest.md) | The billing document items (invoice items or debit memo items or taxation items) to which the payment is applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

