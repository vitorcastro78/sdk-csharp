
# Zuora.Model.PaymentScheduleItemCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_schedule_id** | **string** | ID of a payment schedule. | 
**payment_schedule_number** | **string** | Number of the payment schedule. | [optional] 
**account_id** | **string** | Unique identifier of the customer account the payment schedule belongs to. | [optional] 
**amount** | **decimal** | The amount to be collected by this payment schedule item. | [optional] 
**currency** | **string** | Currency of the payment schedule. The default value is the account&#39;s default currency. This field will be ignored when items is specified. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**payment_gateway_id** | **string** | ID of the payment gateway used to collect payments. The default value is the account&#39;s default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant&#39;s default payment gateway ID. This field will be ignored when &#x60;items&#x60; is specified. | [optional] 
**payment_method_id** | **string** | ID of the payment method. The default value is the account&#39;s default payment method ID. This field will be ignored when &#x60;items&#x60; is specified. | [optional] 
**scheduled_date** | **DateTime** | The scheduled date of collection. | [optional] 
**run_hour** | **int** | At which hour in the day in the tenant&#39;s timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenantâ€™s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**payment_options** | [**List&lt;PaymentScheduleItemPaymentOption&gt;**](PaymentScheduleItemPaymentOption.md) | Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the &#x60;gateway_options&#x60; type is supported. Payment schedule &#x60;payment_options&#x60; take precedence over payment schedule item &#x60;payment_options&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

