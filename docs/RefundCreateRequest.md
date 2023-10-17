
# Zuora.Model.RefundCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount** | **decimal** | Refund amount. | 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**gateway_options** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**refund_date** | **DateTime** | The date when the refund takes effect. | [optional] 
**refund_method_type** | **string** |  | [optional] 
**payment_id** | **string** | Identifier for the payment, either &#x60;payment_number&#x60; or &#x60;payment_id. | [optional] [readonly] 
**reason_code** | **string** | User-provided reason for the refund. | [optional] 
**statement_descriptor** | **string** | A payment gateway-specific field used by Orbital, Vantiv and Verifi. | [optional] 
**statement_descriptor_phone** | **string** | A payment gateway-specific field used by Orbital, Vantiv and Verifi. | [optional] 
**external** | **bool** | If true, indicates that this refund is not handled by Zuora. | [optional] 
**reference_id** | **string** | Transaction identifier returned by the payment gateway. You may use this field to reconcile refunds between your payment gateway and Zuora Payments. | [optional] 
**second_reference_id** | **string** | A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments. | [optional] 
**bank_account_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**on_account_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**unapplied_payment_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**payment_method_id** | **string** | Identifier of the payment method used to create this refund. | [optional] [readonly] 
**credit_memo** | [**RefundCreditMemoRequest**](RefundCreditMemoRequest.md) | The related credit memo. | [optional] 
**billing_documents** | [**List&lt;BillingDocumentPaymentApplicationRequest&gt;**](BillingDocumentPaymentApplicationRequest.md) | Indicates to which billing documents (invoices or debit memos) is the refund applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

