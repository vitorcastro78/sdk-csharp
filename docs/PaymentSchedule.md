
# Zuora.Model.PaymentSchedule

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
**account_number** | **string** | Account number of the customer account the payment schedule belongs to. | [optional] 
**amount** | **decimal** | The amount of each payment schedule item in the payment schedule. | [optional] 
**period** | **string** | Unit in which term duration is defined. One of week or month. | [optional] 
**billing_document** | [**PaymentScheduleBillingDocumentResponse**](PaymentScheduleBillingDocumentResponse.md) | The billing document with which the payment schedule is associated. Note: This field is optional. If you have the Standalone Payment feature enabled, you can leave this field blank and set standalone to true to create standalone payments. You can also choose to create unapplied payments by leaving this object blank and setting standalone to false. If Standalone Payment is not enabled, leaving this object unspecified will create unapplied payments. | [optional] 
**currency** | **string** | Currency of the payment schedule. Note: This field is optional. The default value is the account&#39;s default currency. This field will be ignored when items is specified. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**items** | [**List&lt;PaymentScheduleItem&gt;**](PaymentScheduleItem.md) |  | [optional] 
**number_of_payments** | **int** | The number of payment schedule items to be created for this payment schedule. | [optional] 
**payment_gateway_id** | **string** | ID of the payment gateway used to collect payments. Note: This field is optional. The default value is the account&#39;s default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant&#39;s default payment gateway ID. This field will be ignored when items is specified. | [optional] 
**payment_method_id** | **string** | ID of the payment method. Note: This field is optional. The default value is the account&#39;s default payment method ID. This field will be ignored when items is specified. | [optional] 
**payment_schedule_number** | **string** | Number of the payment schedule. | [optional] 
**run_hour** | **int** | At which hour in the day in the tenant&#39;s timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenantâ€™s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs. | [optional] 
**standalone** | **bool** | Indicates whether the payments created by the payment schedule are standalone payments or not.              When setting to &#x60;true&#x60;, standalone payments will be created.       When setting to &#x60;false&#x60;, you can either specify a billing document, or not specifying any billing documents.       In the latter case, unapplied payments will be created.       If set to &#x60;null&#x60;, standalone payments will be created.              **Note**: This parameter is only available if standalone payments are enabled in your tenant. The default value is &#x60;true&#x60; if standalone payments are enabled in your tenant. | [optional] 
**start_date** | **DateTime** | The date of the first scheduled payment collection. Note: This parameter is required when &#x60;items&#x60; is not specified. This parameter will be ignored when &#x60;items&#x60; is specified. | [optional] 
**total_amount** | **decimal** | The total amount to be collected by the payment schedule. | [optional] 
**custom** | **bool** | If it is set to &#x60;true&#x60;, the payment schedule is a custom payment schedule. | [optional] 
**next_payment_date** | **DateTime** | The date of the next scheduled payment. | [optional] 
**recent_payment_date** | **DateTime** | The date of the most recent scheduled payment. | [optional] 
**state** | **string** | The status of the payment schedule. active: there are unprocessed payment schedule items. canceled: the payment schedule has been canceled. complete: the payment schedule is complete and all items have been processed. | [optional] 
**total_payments_errored** | **int** | The total number of failed payments. | [optional] 
**total_payments_processed** | **int** | The total number of payments processed. | [optional] 
**payment_options** | [**List&lt;PaymentSchedulePaymentOptionRequest&gt;**](PaymentSchedulePaymentOptionRequest.md) | Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the gateway_options type is supported. Payment schedule payment_options take precedence over payment schedule item payment_options. | [optional] 
**prepayment** | **bool** | Indicates whether the payments created by the payment schedule will be used as reserved payments. This field will only be available if the prepaid cash drawdown permission is enabled. See &lt;a href&#x3D;\&quot;https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Bill_for_usage_or_prepaid_products/Advanced_Consumption_Billing/Prepaid_with_Drawdown\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Prepaid Cash with Drawdown for more information.&lt;/a&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

