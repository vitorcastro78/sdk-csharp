
# Zuora.Model.SubscriptionResumePatchResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**extend_term** | **bool** | If this field is set to &#x60;true&#x60;, the subscription term is extended by the length of time the subscription is paused. | [optional] [default to false]
**resume_date** | **DateTime** | Date on which the paused subscription is resumed. | [optional] 
**resume_at** | **string** | You can use this field to resume a paused subscription from the pause date. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

