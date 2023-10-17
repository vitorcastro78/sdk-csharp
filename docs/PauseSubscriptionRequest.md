
# Zuora.Model.PauseSubscriptionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pause_date** | **DateTime** | Date on which the subscription is paused. | [optional] 
**pause_at** | **string** | Can be either the end of the current billing period or a specific date. | [optional] 
**pause_interval_count** | **decimal** | The number of intervals in a duration where the subscription is paused. For example, pause_interval&#x3D;year and pause_interval_count&#x3D;1 represents a 1-year pause. | [optional] 
**pause_interval** | **string** | Unit in which the pause duration is defined. One of day, week, month or year. | [optional] 
**resume_behavior** | [**ResumeSubscriptionRequest**](ResumeSubscriptionRequest.md) |  | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

