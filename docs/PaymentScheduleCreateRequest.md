
# Zuora.Model.PaymentScheduleCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **string** | Unique identifier of the customer account the payment schedule belongs to. | [optional] 
**account_number** | **string** | Account number of the customer account the payment schedule belongs to. | [optional] 
**billing_document** | [**PaymentScheduleBillingDocumentRequest**](PaymentScheduleBillingDocumentRequest.md) | The billing document with which the payment schedule is associated. Note: This field is optional. If you have the Standalone Payment feature enabled, you can leave this field blank and set standalone to true to create standalone payments. You can also choose to create unapplied payments by leaving this object blank and setting standalone to false. If Standalone Payment is not enabled, leaving this object unspecified will create unapplied payments. | [optional] 
**currency** | **string** | Currency of the payment schedule. Note: This field is optional. The default value is the account&#39;s default currency. This field will be ignored when items is specified. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**items** | [**List&lt;PaymentScheduleItemRequest&gt;**](PaymentScheduleItemRequest.md) | Container for payment schedule items. | [optional] 
**payment_gateway_id** | **string** | ID of the payment gateway used to collect payments. Note: This field is optional. The default value is the account&#39;s default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant&#39;s default payment gateway ID. This field will be ignored when items is specified. | [optional] 
**payment_gateway_number** | **string** | The payment gateway number of the payment gateway used to collect scheduled payments. | [optional] 
**payment_method_number** | **string** | The payment method number of the payment method to be used to collect payments. | [optional] 
**payment_method_id** | **string** | ID of the payment method. Note: This field is optional. The default value is the account&#39;s default payment method ID. This field will be ignored when items is specified. | [optional] 
**payment_schedule_number** | **string** | Number of the payment schedule. | [optional] 
**payment_options** | [**List&lt;PaymentSchedulePaymentOptionRequest&gt;**](PaymentSchedulePaymentOptionRequest.md) | Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the gateway_options type is supported. Payment schedule payment_options take precedence over payment schedule item payment_options. | [optional] 
**standalone** | **bool** | Indicates whether the payments created by the payment schedule are standalone payments or not.              When setting to &#x60;true&#x60;, standalone payments will be created.       When setting to &#x60;false&#x60;, you can either specify a billing document, or not specifying any billing documents.       In the latter case, unapplied payments will be created.       If set to &#x60;null&#x60;, standalone payments will be created.              **Note**: This parameter is only available if standalone payments are enabled in your tenant. The default value is &#x60;true&#x60; if standalone payments are enabled in your tenant. | [optional] 
**start_date** | **DateTime** | The date of the first scheduled payment collection. Note: This parameter is required when &#x60;items&#x60; is not specified. This parameter will be ignored when &#x60;items&#x60; is specified. | [optional] 
**prepayment** | **bool** | Indicates whether the payments created by the payment schedule will be used as reserved payments. This field will only be available if the prepaid cash drawdown permission is enabled. See &lt;a href&#x3D;\&quot;https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Bill_for_usage_or_prepaid_products/Advanced_Consumption_Billing/Prepaid_with_Drawdown\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Prepaid Cash with Drawdown for more information.&lt;/a&gt; | [optional] 
**period** | **string** | Unit in which term duration is defined. One of week or month. | [optional] 
**amount** | **decimal** | The amount of each payment schedule item in the payment schedule. | [optional] 
**total_amount** | **decimal** | The total amount to be collected by the payment schedule. | [optional] 
**number_of_payments** | **int** | The number of payment schedule items to be created for this payment schedule. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

