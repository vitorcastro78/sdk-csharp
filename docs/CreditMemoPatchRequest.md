
# Zuora.Model.CreditMemoPatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**apply** | **bool** | Whether to automatically apply the billing document upon posting. | [optional] 
**document_date** | **DateTime** | The date when the credit memo is applied | [optional] 
**reason_code** | **string** | Reason for issuing this credit memo | [optional] 
**transfer_to_accounting** | **bool** | Whether to transfer to an external accounting system. | [optional] 
**exclude_from_auto_apply_rules** | **bool** | Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

