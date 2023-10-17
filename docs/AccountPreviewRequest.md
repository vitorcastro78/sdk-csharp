
# Zuora.Model.AccountPreviewRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**exclude** | **string** | Any combination of one-time, recurring, and usage. | [optional] 
**include_draft_items** | **bool** | Indicates whether to include items in the draft status. | [optional] 
**include_evergreen_subscriptions** | **bool** | Indicates whether to include evergreen subscriptions. | [optional] 
**target_date** | **DateTime** | The target date is used to determine which charges to bill. All unbilled charges as of or prior to the target date are included. Zuora automatically keeps track of all charges that need to be billed and that have not been billed prior to the target date. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

