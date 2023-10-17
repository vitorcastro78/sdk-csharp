
# Zuora.Model.CancelSubscriptionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cancel_date** | **DateTime** | Date on which the subscription is canceled. | [optional] 
**cancel_at** | **string** | The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period. | [optional] 
**processing_options** | [**ProcessingOptions**](ProcessingOptions.md) | Processing options for the invoice or payment. | [optional] 
**refund_amount** | **decimal** | Amount to be refunded | [optional] 
**write_off** | **bool** | Indicates whether to write off the outstanding balance on the invoice after canceling the subscription. | [optional] [default to false]
**write_off_behavior** | [**WriteOffSuscriptionRequest**](WriteOffSuscriptionRequest.md) |  | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

