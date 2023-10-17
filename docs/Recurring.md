
# Zuora.Model.Recurring

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**recurring_on** | **string** | Specifies on which day or the month or day of the week a customer shall be billed. | [optional] 
**on** | **string** | Specifies on which day or the month or day of the week a customer shall be billed. | [optional] 
**usage** | **bool** | Indicates that this is a usage price. | [optional] 
**interval** | **string** | Specifies the billing frequency. One of &#x60;week&#x60;, &#x60;month&#x60; or &#x60;year&#x60;. | [optional] 
**interval_count** | **int** | The number of intervals (specified in the interval attribute) between subscription billings. For example, interval&#x3D;month and intervalCount&#x3D;3 bills every 3 months. | [optional] 
**alignment_behavior** | **string** | Specifies how to align billing for recurring (subscription) products that start on different days. | [optional] 
**timing** | **string** | You can choose to bill in_advance or in_arrears for recurring prices. The field is not used with one-time or usage-based prices. | [optional] 
**formula** | **string** | You can choose to bill in_advance or in_arrears for recurring prices. The field is not used with one-time or usage-based prices. | [optional] [readonly] 
**duration_interval** | **string** | Specifies the duration frequency. One of day, week, month or year. | [optional] 
**duration_interval_count** | **int** | Specifies how long a customer shall be charged if this is less than the duration of the subscription | [optional] 
**rating_group** | **string** | A rating group based on which usage records are rated. Only applicable to usage prices. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

