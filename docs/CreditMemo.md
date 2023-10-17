
# Zuora.Model.CreditMemo

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
**account_id** | **string** | Identifier of the account that owns the credit memo. | [optional] 
**account_number** | **string** | Human-readable identifier of the account that owns the credit memo. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**document_date** | **DateTime** | The date when the credit memo takes effect. | [optional] 
**reason_code** | **string** | Reason for issuing this credit memo | [optional] 
**invoice_id** | **string** | The identifier of the invoice billing document from which this credit memo is created. | [optional] 
**transfer_to_accounting** | **bool** | Whether to transfer to an external accounting system. | [optional] 
**exclude_from_auto_apply_rules** | **bool** | Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. | [optional] 
**credit_memo_number** | **string** | A human-readable identifier for the billing document; may be user-supplied. | [optional] [readonly] 
**amount_refunded** | **decimal** | The amount this billing document refunded. | [optional] 
**state_transitions** | **Object** |  | [optional] 
**posted_by_id** | **string** | Identifier of the Zuora user who posted the billing document. | [optional] [readonly] 
**state** | **string** | The status of the billing document. | [optional] 
**account** | [**Account**](Account.md) | The account that owns the billing document. EXPANDABLE | [optional] 
**items** | [**CreditMemoItemListResponse**](CreditMemoItemListResponse.md) | List of billing document items. EXPANDABLE | [optional] [readonly] 
**total** | **decimal** | The total amount. | [optional] [readonly] 
**subtotal** | **decimal** | The total amount exclusive of tax. | [optional] [readonly] 
**tax** | **decimal** | The total tax amount. | [optional] [readonly] 
**balance** | **decimal** | The total balance remaining.  This field is deprecated. Use &#x60;remaining_balance&#x60; field. | [optional] [readonly] 
**remaining_balance** | **decimal** | The total balance remaining. | [optional] [readonly] 
**applied_to** | [**List&lt;CreditMemoAppliedToResponse&gt;**](CreditMemoAppliedToResponse.md) |  | [optional] [readonly] 
**bill_to_id** | **string** | ID of the bill-to contact. | [optional] 
**bill_to** | [**Contact**](Contact.md) | The billing address for the customer. | [optional] [readonly] 
**billing_document_settings** | [**FlexibleBillingDocumentSettings**](FlexibleBillingDocumentSettings.md) | The billing document settings for the customer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

