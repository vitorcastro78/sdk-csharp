
# Zuora.Model.PaymentMethodPatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**billing_details** | [**BillingDetails**](BillingDetails.md) |  | [optional] 
**account_id** | **string** | A customer account identifier. | [optional] 
**account_number** | **string** | A human-readable customer account identifier. It can be user-supplied. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**card** | [**CardUpdate**](CardUpdate.md) | Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora.js instead of interacting with this API directly. | [optional] 
**cc_ref** | [**CcRefUpdate**](CcRefUpdate.md) | Credit Card Reference Transaction. See Supported payment methods for payment gateways that support this type of payment method. | [optional] 
**mandate** | [**CcRefMandate**](CcRefMandate.md) |  | [optional] 
**ach_debit** | [**AchDebitUpdate**](AchDebitUpdate.md) | If this is an ach_debit payment method, this hash contains details about the ACH debit bank account. | [optional] 
**maximum_payment_attempts** | **decimal** | Maximum number of consecutive failed retry payment attempts using this payment method before retries are stopped. | [optional] 
**payment_retry_interval** | **int** | The retry interval in hours. | [optional] 
**device_session_id** | **string** | Identifier of the device browser session. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

