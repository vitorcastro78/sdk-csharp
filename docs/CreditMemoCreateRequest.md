
# Zuora.Model.CreditMemoCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **string** | Identifier of the account that owns the credit memo. | [optional] 
**account_number** | **string** | Human-readable identifier of the account that owns the credit memo. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**document_date** | **DateTime** | The date when the credit memo takes effect. | [optional] 
**reason_code** | **string** | Reason for issuing this credit memo | [optional] 
**invoice_id** | **string** | The identifier of the invoice billing document from which this credit memo is created. | [optional] 
**transfer_to_accounting** | **bool** | Whether to transfer to an external accounting system. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**exclude_from_auto_apply_rules** | **bool** | Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. | [optional] 
**items** | [**List&lt;CreditMemoItemCreateRequest&gt;**](CreditMemoItemCreateRequest.md) | Information of all credit memo items. | [optional] 
**apply** | **bool** | Whether to automatically apply the billing document upon posting. | [optional] 
**post** | **bool** | Whether to automatically post a billing document after it is created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

