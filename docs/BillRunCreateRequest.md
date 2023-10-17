
# Zuora.Model.BillRunCreateRequest

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
**account_id** | **string** | Identifier of the customer account to bill. Specify this field or &#x60;account_number&#x60; if you want to create a bill run for a single customer. | [optional] 
**account_number** | **string** | Human-readable identifier of the account to bill. Specify this field or &#x60;account_id&#x60; if you want to create a bill run for a single customer. | [optional] 
**email** | **bool** | If set to &#x60;true&#x60;, invoices will be automatically emailed to customers. | [optional] 
**post** | **bool** | Indicates whether to automatically post a billing document after it is created. | [optional] 
**renew** | **bool** | If set to &#x60;true&#x60;, subscriptions will be automatically renewed. | [optional] 
**day_of_month** | **string** | The day of the month on which the multiple customer accounts are billed. | [optional] 
**batches** | **List&lt;string&gt;** | Identifier of the customer account batch to be included in this bill run. | [optional] 
**invoice_date** | **DateTime** | The date displayed on the invoice. | 
**target_date** | **DateTime** | All unbilled items on or before this date are included in this bill run. | 
**email_zero_amount_invoices** | **bool** | If it is set to &#x60;false&#x60;, invoices for zero amounts will not be emailed to customers.  | [optional] [default to true]
**charges_excluded** | **List&lt;string&gt;** | Type of the charge to be excluded from the bill run. | [optional] 
**name** | **string** | The name of the bill run. | [optional] 
**type** | **string** | The type of the bill run. This field is only available if you have the &lt;a href&#x3D;\&quot;https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Automate_billing_document_generation/Bill_runs/Z_Catch-Up_Bill_Run\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Catch-Up Bill Run&lt;/a&gt; feature enabled in your tenant. | [optional] 
**subscription_ids** | **List&lt;string&gt;** | The target subscriptions for this bill run. Note that all these subscriptions must belong to the same account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

