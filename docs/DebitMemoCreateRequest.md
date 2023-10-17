
# Zuora.Model.DebitMemoCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **string** | Identifier of the account that owns the debit memo. | [optional] 
**account_number** | **string** | Human-readable identifier of the account that owns the debit memo. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**due_date** | **DateTime** | The date on which payment for the debit memo is due. | [optional] 
**document_date** | **DateTime** | The date when the debit memo takes effect. | [optional] 
**reason_code** | **string** | Reason for issuing this debit memo. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60; or &#x60;debit_memo&#x60;. | [optional] 
**invoice_id** | **string** | The identifier of the invoice from which this credit memo or debit memo is created. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60; or &#x60;debit_memo&#x60;. | [optional] 
**transfer_to_accounting** | **bool** | Whether to transfer to an external accounting system. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**exclude_from_auto_apply_rules** | **bool** | Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;credit_memo&#x60;. | [optional] 
**pay** | **bool** | Indicates whether this billing document is automatically picked up for processing in the corresponding payment run. | [optional] 
**items** | [**List&lt;BillingDocumentItemCreateRequest&gt;**](BillingDocumentItemCreateRequest.md) | Information of all billing document items. | [optional] 
**apply** | **bool** | Whether to automatically apply the billing document upon posting. | [optional] 
**post** | **bool** | Whether to automatically post a billing document after it is created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

