
# Zuora.Model.PaymentSchedulePatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**currency** | **string** | Currency of the payment schedule. Note: This field is optional. The default value is the account&#39;s default currency. This field will be ignored when items is specified. | [optional] 
**number_of_payments** | **int** | The number of payment schedule items to be created for this payment schedule. | [optional] 
**payment_gateway_id** | **string** | ID of the payment gateway used to collect payments. Note: This field is optional. The default value is the account&#39;s default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant&#39;s default payment gateway ID. This field will be ignored when items is specified. | [optional] 
**payment_method_id** | **string** | ID of the payment method. Note: This field is optional. The default value is the account&#39;s default payment method ID. This field will be ignored when items is specified. | [optional] 
**payment_method_number** | **string** | The payment method number of the payment method to be used to collect payments. | [optional] 
**run_hour** | **int** | At which hour in the day in the tenant&#39;s timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenantâ€™s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time.       The default value is &#x60;0&#x60;. If the payment &#x60;run_hour&#x60; and &#x60;scheduled_date&#x60; are backdated, the system will collect the payment when the next &#x60;run_hour&#x60; occurs. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**payment_options** | [**List&lt;PaymentSchedulePaymentOptionRequest&gt;**](PaymentSchedulePaymentOptionRequest.md) | Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the gateway_options type is supported. Payment schedule payment_options take precedence over payment schedule item payment_options. | [optional] 
**start_date** | **DateTime** | The date of the first scheduled payment collection. Note: This parameter is required when &#x60;items&#x60; is not specified. This parameter will be ignored when &#x60;items&#x60; is specified. | [optional] 
**amount** | **decimal** | The amount of each payment schedule item in the payment schedule. | [optional] 
**period** | **string** | Unit in which term duration is defined. One of week or month. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

