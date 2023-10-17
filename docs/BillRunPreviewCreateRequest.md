
# Zuora.Model.BillRunPreviewCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**assume_renewal** | **string** | Indicates whether to generate a preview of future invoice items and credit memo items with the assumption that the subscriptions are renewed. **all**: The assumption is applied to all the subscriptions. Zuora generates preview invoice item data and credit memo item data from the first day of the customer&#39;s next billing period to the target date. **auto_renew_only**: The assumption is applied to the subscriptions that have auto_renew enabled. Zuora generates preview invoice item data and credit memo item data from the first day of the customer&#39;s next billing period to the target date. | [optional] 
**batches** | **List&lt;string&gt;** | Identifiers of the customer account batches to be included in this bill run preview. | [optional] 
**charges_excluded** | **List&lt;string&gt;** | Charge type or types to be excluded from this bill run preview. | [optional] 
**include_draft_items** | **bool** | If true, draft items will be included in this bill run preview. | [optional] 
**include_evergreen_subscriptions** | **bool** | If true, evergreen subscriptions will be included in this bill run preview. | [optional] 
**target_date** | **DateTime** | All unbilled items on or before this date are included in this bill run. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

