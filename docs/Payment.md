
# Zuora.Model.Payment

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
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**reference_id** | **string** | Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments. | [optional] 
**account_id** | **string** | Identifier of the customer account associated with this payment. | [optional] 
**account_number** | **string** | Human-readable identifier of the account associated with this payment. It can be user-supplied. | [optional] 
**amount** | **decimal** | The total amount of the payment. | [optional] 
**authorization_id** | **string** | Identifier of the authorization transaction from the payment gateway. | [optional] 
**payment_date** | **DateTime** | The date and time when the payment takes effect. | [optional] 
**payment_method_id** | **string** | Identifier of the payment method used to create this payment. | [optional] 
**gateway_id** | **string** | Identifier of the payment gateway that Zuora will use to authorize this payment. | [optional] 
**gateway_order_id** | **string** | A merchant-specified natural key value that can be passed to the payment gateway when a payment is created. If not specified, the payment number will be passed in instead. | [optional] 
**second_reference_id** | **string** | A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments. | [optional] 
**gateway_options** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**statement_descriptor** | **string** | A payment gateway-specific field used by Orbital, Vantiv and Verifi. | [optional] 
**statement_descriptor_phone** | **string** | A payment gateway-specific field used by Orbital, Vantiv and Verifi. | [optional] 
**external** | **bool** | If true, indicates that this payment is not handled by Zuora. | [optional] 
**currency** | **string** | 3-letter ISO 4217 currency code. | [optional] 
**account** | [**Account**](Account.md) | The customer account associated with this payment. | [optional] 
**amount_applied** | **decimal** | The total amount applied. | [optional] 
**remaining_balance** | **decimal** | The total remaining balance. | [optional] 
**amount_refunded** | **decimal** | The total amount refunded. | [optional] 
**state** | **string** | The state of the payment. | [optional] [readonly] 
**payout_id** | **string** | Identifier of the payout associated with this payment. | [optional] 
**payment_number** | **string** | Human-readable identifier for this object; may be user-supplied. | [optional] 
**gateway_response_code** | **string** | Code returned by the payment gateway for this payment. | [optional] 
**payment_method** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**gateway_response** | **string** | Message returned by the payment gateway for this payment. | [optional] 
**gateway_reconciliation_status** | **string** | Gateway reconciliation state. | [optional] 
**gateway_reconciliation_reason** | **string** | Gateway reconciliation reason. | [optional] 
**gateway_state** | **string** | The payment gateway state of the payment. | [optional] [readonly] 
**applied_to** | [**List&lt;PaymentsAppliedToResponse&gt;**](PaymentsAppliedToResponse.md) |  | [optional] [readonly] 
**state_transitions** | [**PaymentStateTransitions**](PaymentStateTransitions.md) |  | [optional] 
**gateway_state_transitions** | [**GatewayStateTransitions**](GatewayStateTransitions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

