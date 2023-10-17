
# Zuora.Model.ApplePayCreate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | The Merchant ID that was configured for use with Apple Pay in the Apple iOS Developer Center. | [optional] 
**customer_token** | **Dictionary&lt;string, Object&gt;** | The complete JSON Object representing the encrypted payment token payload returned in the response from the Apple Pay session. | 
**collect_payment** | **bool** | A boolean flag to control whether a payment should be processed       after creating payment method. The payment amount will be equivalent to       the amount the merchant supplied in the ApplePay session. Default is false.        If this field is set to &#x60;true&#x60;, you must specify the &#x60;gateway_id&#x60;       field with the payment gateway instance name.  If this field is set       to &#x60;false&#x60;:   - The default payment gateway of your Zuora customer account       will be used no matter whether a payment gateway instance is specified       in the &#x60;gateway_id&#x60; field.    - You must select the **Verify new       credit card** check box on the gateway instance settings page. Otherwise,       the cryptogram will not be sent to the gateway.   - A separate subscribe       or payment API call is required after this payment method creation call.  | [optional] 
**invoice_id** | **string** | The id of invoice this payment will apply to.      Note: When &#x60;collect_payment&#x60; is true, this field is required.      Only one invoice can be paid; for scenarios where you want to pay for multiple invoices, set collect_payment to false and use [Create Payment](#operation/createPayment) API separately. | [optional] 
**mandate** | [**Mandate**](Mandate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

