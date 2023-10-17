
# Zuora.Model.PaymentMethodCreateRequest

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
**type** | **string** | The type of the payment method. An additional hash is included on the payment method with a name matching this value. It contains additional information specific to the payment method type. | 
**custom_type** | **string** | The custom type of the payment method from Universal Payment Connector. | [optional] 
**account_id** | **string** | A customer account identifier. | [optional] 
**account** | [**Account**](Account.md) | The customer account associated with this payment method. | [optional] [readonly] 
**billing_details** | [**BillingDetails**](BillingDetails.md) |  | [optional] 
**maximum_payment_attempts** | **decimal** | Maximum number of consecutive failed retry payment attempts using this payment method before retries are stopped. | [optional] 
**payment_retry_interval** | **int** | The retry interval in hours. | [optional] 
**device_session_id** | **string** | Identifier of the device browser session. | [optional] 
**ip_address** | **string** | The IP address from which the Mandate was accepted by the customer. | [optional] 
**bank_identification_number** | **string** | The first six or eight digits of the payment method&#39;s number, such as the credit card number or account number. Banks use this number to identify a payment method. | [optional] 
**card** | [**Card**](Card.md) |  | [optional] 
**paypal_express_native** | [**PaypalExpressNative**](PaypalExpressNative.md) |  | [optional] 
**paypal_express** | [**PaypalExpress**](PaypalExpress.md) |  | [optional] 
**paypal_adaptive** | [**PaypalAdaptive**](PaypalAdaptive.md) |  | [optional] 
**sepa_debit** | [**SepaDebit**](SepaDebit.md) |  | [optional] 
**cc_ref** | [**CcRef**](CcRef.md) |  | [optional] 
**apple_pay** | [**ApplePayCreate**](ApplePayCreate.md) |  | [optional] 
**google_pay** | [**GooglePayCreate**](GooglePayCreate.md) |  | [optional] 
**ach_debit** | [**AchDebit**](AchDebit.md) |  | [optional] 
**betalings_debit** | [**BetalingsDebit**](BetalingsDebit.md) |  | [optional] 
**autogiro_debit** | [**AutogiroDebit**](AutogiroDebit.md) |  | [optional] 
**bacs_debit** | [**BacsDebit**](BacsDebit.md) |  | [optional] 
**au_becs_debit** | [**AuBecsDebit**](AuBecsDebit.md) |  | [optional] 
**nz_becs_debit** | [**NzBecsDebit**](NzBecsDebit.md) |  | [optional] 
**pad_debit** | [**PadDebit**](PadDebit.md) |  | [optional] 
**account_number** | **string** | A human-readable customer account identifier. It can be user-supplied. | [optional] 
**is_default** | **bool** | Indicates whether it is the default payment method on the associated account. | [optional] 
**gateway_id** | **string** | Identifier of the payment gateway Zuora will use to authorize the payments that are made with this payment method. | [optional] 
**gateway_options** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

