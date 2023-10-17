
# Zuora.Model.PaymentsAppliedToResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**billing_document_id** | **string** | Identifier of an invoice or a debit memo. | [optional] 
**id** | **string** | Identifier of the payment application. | [optional] 
**amount** | **decimal** | The amount of the payment that is applied to the specific billing document item or taxation item. | [optional] 
**billing_document** | [**BillingDocument**](BillingDocument.md) | The related billing document. | [optional] 
**billing_document_type** | **string** | The type of billing document. Can be one of the debit memo or invoice. | [optional] 
**state** | **string** |  | [optional] [readonly] 
**items** | [**List&lt;PaymentAppliedToBillingItemResponse&gt;**](PaymentAppliedToBillingItemResponse.md) | The related billing document item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

