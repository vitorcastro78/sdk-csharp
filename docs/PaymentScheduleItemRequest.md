
# Zuora.Model.PaymentScheduleItemRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount** | **decimal** | The amount to be collected by this payment schedule item. | [optional] 
**currency** | **string** | Three-letter ISO currency code. Once the currency is set for an account, it cannot be updated. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**gateway_id** | **string** |  | [optional] 
**payment_method_id** | **string** | Identifier of the payment method on the customer account. | [optional] 
**run_hour** | **int** | At which hour in the day in the tenant&#39;s timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenantâ€™s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time.       The default value is &#x60;0&#x60;. If the payment &#x60;run_hour&#x60; and &#x60;scheduled_date&#x60; are backdated, the system will collect the payment when the next &#x60;run_hour&#x60; occurs. | [optional] 
**scheduled_date** | **DateTime** | The scheduled date of the payment collection. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

