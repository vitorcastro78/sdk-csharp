
# Zuora.Model.BillRunPreview

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
**assume_renewal** | **string** | Indicates whether to generate a preview of future invoice items and credit memo items with the assumption that the subscriptions are renewed. **all**: The assumption is applied to all the subscriptions. Zuora generates preview invoice item data and credit memo item data from the first day of the customer&#39;s next billing period to the target date. **auto_renew_only**: The assumption is applied to the subscriptions that have auto_renew enabled. Zuora generates preview invoice item data and credit memo item data from the first day of the customer&#39;s next billing period to the target date. | [optional] 
**batches** | **List&lt;string&gt;** | Identifiers of the customer account batches to be included in this bill run preview. | [optional] 
**charges_excluded** | **List&lt;string&gt;** | Charge type or types to be excluded from this bill run preview. | [optional] 
**include_draft_items** | **bool** | If true, draft items will be included in this bill run preview. | [optional] 
**include_evergreen_subscriptions** | **bool** | If true, evergreen subscriptions will be included in this bill run preview. | [optional] 
**target_date** | **DateTime** | All unbilled items on or before this date are included in this bill run. | [optional] 
**state_transitions** | [**BillRunPreviewStateTransitions**](BillRunPreviewStateTransitions.md) |  | [optional] 
**file** | [**BillRunPreviewFile**](BillRunPreviewFile.md) |  | [optional] 
**billing_preview_run_number** | **string** | Human-readable identifier for this object. | [optional] 
**state** | **string** | The state of the bill run preview. | [optional] 
**number_of_accounts_succeeded** | **decimal** | The number of the customer accounts whose bill run preview job succeeded. | [optional] 
**number_of_accounts** | **decimal** | The number of the customer accounts included in the bill run preview job. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

