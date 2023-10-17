
# Zuora.Model.PaymentMethodVoidAuthorizationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **string** | A customer account identifier. Either &#x60;account_id&#x60; or &#x60;account_number&#x60; is required. | [optional] 
**account_number** | **string** | A Human-readable customer account identifier. Either &#x60;account_id&#x60; or &#x60;account_number&#x60; is required. | [optional] 
**gateway_id** | **string** | Identifier of the payment gateway that Zuora will use to authorize the payments that are made with this payment method. If you do not set this field, Zuora will use one of the following payment gateways instead: The default payment gateway of the customer account that owns the payment method, if the payment method is associated with a customer account or the default payment gateway of your Zuora tenant. | [optional] 
**gateway_options** | **Dictionary&lt;string, string&gt;** | A hash containing gateway-specific parameters. | [optional] 
**gateway_order_id** | **string** | A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the payment number will be passed in instead. Gateways check duplicates on the gateway order ID to ensure that the merchant do not accidentally enter the same transaction twice. This ID can also be used to do reconciliation and tie the payment to a natural key in external systems. The source of this ID varies by merchant. Some merchants use their shopping cart order IDs, and others use something different. Merchants use this ID to track transactions in their eCommerce systems. When you create a payment for capturing the authorized funds, it is highly recommended to pass in the &#x60;gateway_order_id&#x60; that you used when authorizing the funds by using the Create authorization operation, together with the &#x60;authorization_id&#x60; field. | 
**auth_transaction_id** | **string** | Identifier of the authorization transaction from the payment gateway. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

