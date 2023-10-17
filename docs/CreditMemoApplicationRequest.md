
# Zuora.Model.CreditMemoApplicationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | Identifier of the invoice or debit memo to which the credit memo is applied. | 
**type** | **string** | The type of billing document, one of invoice or debit_memo. | 
**amount** | **decimal** | The credit memo amount applied to this billing document. | 
**items** | [**List&lt;CreditMemoItemApplicationRequest&gt;**](CreditMemoItemApplicationRequest.md) | The billing document items (invoice items or debit memo items or taxation items) to which the credit memo is applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

