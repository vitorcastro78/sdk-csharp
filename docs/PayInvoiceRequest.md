
# Zuora.Model.PayInvoiceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount** | **decimal** | The amount of the payment. | [optional] 
**account_id** | **string** | Identifier of the account that owns the invoice. Either &#x60;account_id&#x60; or &#x60;account_number&#x60; is required. | [optional] 
**account_number** | **string** | Human-readable identifier of the account that owns the invoice. Either &#x60;account_number&#x60; or &#x60;account_id&#x60; is required. | [optional] 
**authorization_id** | **string** | Identifier of the authorization transaction from the payment gateway. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**currency** | **string** | 3-letter ISO 4217 currency code. | 
**bank_account_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**payment_date** | **DateTime** | The date and time when the payment takes effect. | [optional] 
**payment_method_id** | **string** | Identifier of the payment method used to create this payment. | [optional] 
**gateway_id** | **string** | Identifier of the payment gateway that Zuora will use to authorize this payment. | [optional] 
**gateway_order_id** | **string** | A merchant-specified natural key value that can be passed to the payment gateway when a payment is created. If not specified, the payment number will be passed in instead. | [optional] 
**reference_id** | **string** | A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments. | [optional] 
**gateway_options** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**statement_descriptor** | **string** | A payment gateway-specific field used by Orbital, Vantiv and Verifi. | [optional] 
**statement_descriptor_phone** | **string** | A payment gateway-specific field used by Orbital, Vantiv and Verifi. | [optional] 
**external** | **bool** | If true, indicates that this payment is not handled by Zuora. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

