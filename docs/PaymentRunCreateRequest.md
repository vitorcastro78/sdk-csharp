
# Zuora.Model.PaymentRunCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**apply_credit_memos** | **bool** | If true, any posted credit memos are applied first. | [optional] 
**apply_unapplied_payments** | **bool** | If true, any unapplied payments are applied first. | [optional] 
**batch** | **string** | Identifier of the customer account batch to be included in this payment run. | [optional] 
**bill_cycle_day** | **string** | The day of the month to bill multiple customer accounts. | [optional] 
**bill_run_id** | **string** | The unique identifier of a bill run. | [optional] 
**collect_payment** | **bool** | Indicates whether to process electronic payments during the execution of payment runs.       If the Payment user permission \&quot;Process Electronic Payment\&quot; is disabled, this field will be ignored. | [optional] 
**currency** | **string** | Three-letter ISO currency code. | [optional] 
**consolidated_payment** | **bool** | If true, a single payment will be collected for all receivables due on an account. | [optional] 
**gateway_id** | **string** | Unique identifier for the payment gateway. | [optional] 
**payment_run_date** | **DateTime** | The date and time when the scheduled payment run is to be executed, in &#x60;yyyy-mm-dd hh:mm:ss&#x60; format. The backend will ignore mintues and seconds in the field value. For example, if you specify &#x60;2017-03-01 11:30:37&#x60; for this value, this payment run will be run at 2017-03-01 11:00:00.      &lt;br /&gt;       You must specify either the &#x60;payment_run_date&#x60; field or the &#x60;target_date&#x60; field in the request body.      If you specify the &#x60;payment_run_date&#x60; field, the scheduced payment run is to be executed on the specified payment run date. If you specify the &#x60;target_date&#x60; field, the payment run is executed immediately after it is created. | [optional] 
**target_date** | **DateTime** | The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

