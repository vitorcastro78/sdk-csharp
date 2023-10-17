
# Zuora.Model.PaymentRun

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
**apply_credit_memos** | **bool** | If true, any posted credit memos are applied first. | [optional] 
**apply_unapplied_payments** | **bool** | If true, any unapplied payments are applied first. | [optional] 
**batch** | **string** | Identifier of the customer account batch to be included in this payment run. | [optional] 
**consolidate_payment** | **bool** | If true, a single payment will be collected for all receivables due on an account. | [optional] 
**bill_cycle_day** | **int** | The day of the month to bill multiple customer accounts. | [optional] 
**bill_run_id** | **string** | The unique identifier of a bill run. | [optional] 
**collect_payment** | **bool** | Indicates whether to process electronic payments during the execution of payment runs. | [optional] 
**currency** | **string** | Three-letter ISO currency code. | [optional] 
**state_transitions** | **Object** | The date and time when the payment run executed, in the &#x60;yyyy-mm-dd hh:mm:ss&#x60; format. | [optional] 
**payment_gateway_id** | **string** | Unique identifier for the payment gateway. | [optional] 
**payment_collection_date** | **DateTime** |  | [optional] [readonly] 
**payment_run_number** | **string** | Human-readable identifier for this object. | [optional] 
**payment_run_date** | **DateTime** | The date and time when the scheduled payment run is to be executed, in &#x60;yyyy-mm-dd hh:mm:ss&#x60; format. | [optional] 
**target_date** | **DateTime** | The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date. | [optional] 
**state** | **string** | Status of the payment run. | [optional] 
**summary** | [**PaymentRunSummary**](PaymentRunSummary.md) | Summary of the payment run. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

