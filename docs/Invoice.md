
# Zuora.Model.Invoice

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
**account_id** | **string** | Identifier of the account that owns the invoice. | [optional] 
**account_number** | **string** | Human-readable identifier of the account that owns the invoice. | [optional] 
**description** | **string** | An arbitrary string associated with the object. Often useful for displaying to users. | [optional] 
**due_date** | **DateTime** | The date on which payment for the invoice is due. | [optional] 
**document_date** | **DateTime** | The date when the invoice takes effect. | [optional] 
**transfer_to_accounting** | **bool** | Whether to transfer to an external accounting system. | [optional] 
**pay** | **bool** | Indicates whether the invoice is automatically picked up for processing in the corresponding payment run. | [optional] 
**invoice_number** | **string** | A human-readable identifier for the invoice; may be user-supplied. | [optional] [readonly] 
**state_transitions** | **Object** |  | [optional] 
**posted_by_id** | **string** | Identifier of the Zuora user who posted the invoice. | [optional] [readonly] 
**state** | **string** | The status of the invoice. | [optional] 
**account** | [**Account**](Account.md) | The account that owns the invoice. EXPANDABLE | [optional] 
**items** | [**InvoiceItemListResponse**](InvoiceItemListResponse.md) | List of invoice items. | [optional] [readonly] 
**total** | **decimal** | The total amount. | [optional] [readonly] 
**subtotal** | **decimal** | The total amount exclusive of tax. | [optional] [readonly] 
**tax** | **decimal** | The total tax amount. | [optional] [readonly] 
**balance** | **decimal** | The total balance remaining.  This field is deprecated. Use &#x60;remaining_balance&#x60; field. | [optional] [readonly] 
**remaining_balance** | **decimal** | The total balance remaining. | [optional] [readonly] 
**paid** | **bool** | Whether payment was successfully collected for this invoice. An invoice can be paid with a payment or a credit memo. | [optional] [readonly] 
**past_due** | **bool** | Whether payment is past due. | [optional] [readonly] 
**bill_to_id** | **string** | ID of the bill-to contact. | [optional] 
**payment_terms** | **string** | The name of payment term associated with the invoice. | [optional] 
**bill_to** | [**Contact**](Contact.md) | The billing address for the customer. | [optional] [readonly] 
**billing_document_settings** | [**FlexibleBillingDocumentSettings**](FlexibleBillingDocumentSettings.md) | The billing document settings for the customer. | [optional] 
**sold_to_id** | **string** | ID of the sold-to contact. | [optional] 
**sold_to** | [**Contact**](Contact.md) | The selling address for the customer. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

