
# Zuora.Model.InvoiceCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **string** | Identifier of the account that owns the invoice. | [optional] 
**account_number** | **string** | Human-readable identifier of the account that owns the invoice. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**due_date** | **DateTime** | The date on which payment for the invoice is due. | [optional] 
**document_date** | **DateTime** | The date when the invoice takes effect. | [optional] 
**transfer_to_accounting** | **bool** | Whether to transfer to an external accounting system. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**pay** | **bool** | Indicates whether the invoice is automatically picked up for processing in the corresponding payment run. | [optional] 
**items** | [**List&lt;InvoiceItemCreateRequest&gt;**](InvoiceItemCreateRequest.md) | Information of all invoice items. | [optional] 
**post** | **bool** | Whether to automatically post an invoice after it is created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

