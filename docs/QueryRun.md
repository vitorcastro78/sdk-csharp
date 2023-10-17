
# Zuora.Model.QueryRun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**created_by_id** | **string** | Unique identifier of the Zuora user who created the object. | [optional] [readonly] 
**id** | **string** | Unique identifier for the object. | [optional] [readonly] 
**sql** | **string** | The SQL statement of the query. | [optional] 
**remaining_attempts** | **decimal** | The remaining number of times Zuora will attempt the query before terminating the query and setting the state to &#x60;failed&#x60;. | [optional] 
**updated_time** | **DateTime** | The date and time when the object was last updated in ISO-8601 UTC format. | [optional] [readonly] 
**file** | [**QueryRunFile**](QueryRunFile.md) |  | [optional] 
**number_of_rows** | **decimal** | The number of rows in the output file. | [optional] 
**processing_duration** | **decimal** | The time taken to process the query in milliseconds. | [optional] 
**state** | **string** | The query&#39;s execution state, which will be completed for successful runs. | [optional] 
**column_separator** | **string** | The character used as delimiter to separate values in the output file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

