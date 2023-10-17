
# Zuora.Model.Refund

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** |  | [optional] 
**updated_by_id** | **string** | Unique identifier of the Zuora user who last updated the object | [optional] [readonly] 
**updated_time** | **DateTime** | The date and time when the object was last updated in ISO 8601 UTC format. | [optional] [readonly] 
**created_by_id** | **string** | Unique identifier of the Zuora user who created the object | [optional] [readonly] 
**created_time** | **DateTime** | The date and time when the object was created in ISO 8601 UTC format. | [optional] [readonly] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**custom_objects** | **Dictionary&lt;string, Object&gt;** | The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields). | [optional] [readonly] 
**amount** | **decimal** | Refund amount. | [optional] 
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
**payment_method_id** | **string** | Identifier of the payment method used to create this refund. | [optional] [readonly] 
**credit_memo** | [**RefundCreditMemoRequest**](RefundCreditMemoRequest.md) | The related credit memo. | [optional] 
**account_id** | **string** | Identifier of the customer this refund is for, if one exists. | [optional] 
**account** | [**Account**](Account.md) | The account that owns the refund | [optional] 
**gateway_id** | **string** | Identifier of the payment gateway that Zuora will use to authorize the payments that are made with this payment method. If you do not set this field, Zuora will use one of the following payment gateways instead: The default payment gateway of the customer account that owns the payment method, if the payment method is associated with a customer account or the default payment gateway of your Zuora tenant. | [optional] 
**comment** | **string** | Comments about the refund. | [optional] 
**gateway_response** | **string** | Message returned by the payment gateway for this refund. | [optional] [readonly] 
**gateway_response_code** | **string** | Code returned by the payment gateway for this refund. | [optional] [readonly] 
**gateway_state** | **string** | The payment gateway state of the refund. | [optional] [readonly] 
**payment_method** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**refund_number** | **string** | Human-readable identifier for this object; may be user-supplied. | [optional] 
**state_transitions** | [**RefundStateTransitions**](RefundStateTransitions.md) |  | [optional] 
**state** | **string** | The state of the refund. | [optional] [readonly] 
**gateway_reconciliation_reason** | **string** | Gateway reconciliation reason. | [optional] [readonly] 
**gateway_reconciliation_status** | **string** | Gateway reconciliation state. | [optional] [readonly] 
**payout_id** | **string** | Identifier of the payout from the payment gateway. | [optional] [readonly] 
**applied_to** | [**List&lt;RefundsAppliedToResponse&gt;**](RefundsAppliedToResponse.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

