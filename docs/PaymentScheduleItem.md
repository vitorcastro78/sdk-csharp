
# Zuora.Model.PaymentScheduleItem

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
**account_id** | **string** | Unique identifier of the customer account the payment schedule belongs to. | [optional] 
**amount** | **decimal** | The amount to be collected by this payment schedule item. | [optional] 
**balance** | **decimal** | The remaining balance of payment schedule item. | [optional] 
**billing_document** | [**PaymentScheduleBillingDocumentResponse**](PaymentScheduleBillingDocumentResponse.md) | The billing document with which the payment schedule is associated. If you have the Standalone Payment feature enabled, you can leave this field blank and set standalone to true to create standalone payments. You can also choose to create unapplied payments by leaving this object blank and setting standalone to false. If Standalone Payment is not enabled, leaving this object unspecified will create unapplied payments. | [optional] 
**cancellation_reason** | **string** | The reason for the cancellation of payment schedule item. | [optional] 
**currency** | **string** | Currency of the payment schedule. The default value is the account&#39;s default currency. This field will be ignored when items is specified. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**payment_schedule_item_number** | **string** | Number of the payment schedule item. | [optional] 
**payment_gateway_id** | **string** | ID of the payment gateway used to collect payments. The default value is the account&#39;s default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant&#39;s default payment gateway ID. This field will be ignored when &#x60;items&#x60; is specified. | [optional] 
**payment_method_id** | **string** | ID of the payment method. The default value is the account&#39;s default payment method ID. This field will be ignored when &#x60;items&#x60; is specified. | [optional] 
**payment_option_id** | **string** | ID of the payment option. | [optional] 
**payment_schedule_id** | **string** | ID of the payment schedule. | [optional] 
**payment_schedule_number** | **string** | Number of the payment schedule. | [optional] 
**payments** | [**List&lt;PaymentScheduleItemPayments&gt;**](PaymentScheduleItemPayments.md) |  | [optional] 
**run_hour** | **int** | At which hour in the day in the tenant&#39;s timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenantâ€™s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs. | [optional] 
**scheduled_date** | **DateTime** | The scheduled date of collection. | [optional] 
**standalone** | **bool** | Indicates whether the payments created by the payment schedule are standalone payments or not. When setting to true, standalone payments will be created. When setting to false, you can either specify a billing document, or not specifying any billing documents. In the later case, unapplied payments will be created. If set to null, standalone payments will be created. Note: This parameter is only available if standalone payments are enabled in your tenant. Do not include this parameter if standalone payment have not been enabled in your tenant. If standalone payments are enabled, the default value is true. | [optional] 
**state** | **string** | The status of the payment schedule item. active: there are unprocessed payment schedule items. canceled: the payment schedule has been canceled. complete: the payment schedule is complete and all items have been processed. | [optional] 
**error_message** | **string** | An error message indicating why payment collection failed for this payment schedule item. | [optional] 
**payment** | [**Payment**](Payment.md) | List of customer payments. | [optional] [readonly] 
**payment_schedule** | [**PaymentSchedule**](PaymentSchedule.md) | Payment schedule record. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

