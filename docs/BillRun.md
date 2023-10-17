
# Zuora.Model.BillRun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | Unique identifier for this object. | [optional] 
**updated_by_id** | **string** | Unique identifier of the Zuora user who last updated the object | [optional] [readonly] 
**updated_time** | **DateTime** | The date and time when the object was last updated in ISO 8601 UTC format. | [optional] [readonly] 
**created_by_id** | **string** | Unique identifier of the Zuora user who created the object | [optional] [readonly] 
**created_time** | **DateTime** | The date and time when the object was created in ISO 8601 UTC format. | [optional] [readonly] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**custom_objects** | **Dictionary&lt;string, Object&gt;** | The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields). | [optional] [readonly] 
**account_id** | **string** | Identifier of the customer account to bill. | [optional] 
**email** | **bool** | If set to &#x60;true&#x60;, invoices will be automatically emailed to customers. | [optional] 
**post** | **bool** | Indicates whether to automatically post a billing document after it is created. | [optional] 
**renew** | **bool** | If set to &#x60;true&#x60;, subscriptions will be automatically renewed. | [optional] 
**day_of_month** | **string** | The day of the month to bill multiple customer accounts. | [optional] 
**bill_run_number** | **string** | Human-readable identifier for this object. | [optional] 
**bill_run_time** | **DateTime** | The date and time on which this bill run starts. | [optional] 
**invoice_date** | **DateTime** | The date displayed on the invoice. | [optional] 
**target_date** | **DateTime** | All unbilled items on or before this date are included in this bill run. | [optional] 
**state** | **string** | Status of the bill run. | [optional] 
**batches** | **string** | Identifier of the customer account batch to be included in this bill run. | [optional] 
**charges_excluded** | **string** | Type of the charge to be excluded from the bill run. | [optional] 
**email_zero_amount_invoices** | **bool** | If set to &#x60;false&#x60;, invoices for zero amounts will not be emailed to customers. | [optional] 
**invoices_sent** | **bool** | Indicates whether the invoices have been automatically sent to customers. | [optional] 
**last_invoice_sent_time** | **DateTime** | The date when the last invoice was sent. | [optional] 
**accounts_processed** | **int** | Number of accounts billed from this bill run. | [optional] 
**invoices_generated** | **int** | Number of invoices generated from this bill run. | [optional] 
**credit_memos_generated** | **int** | Number of credit memos generated from this bill run. | [optional] 
**name** | **string** | The name of the bill run. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

