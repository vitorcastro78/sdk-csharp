
# Zuora.Model.SubscriptionItemPatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | Identifier of the subscription item. | [optional] 
**recurring** | [**Recurring**](Recurring.md) |  | [optional] 
**subscription_item_number** | **string** | Human-readable identifier of the subscription. It can be user-supplied. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**start_date** | **DateTime** | The date when the subscription item starts | [optional] 
**end_date** | **DateTime** | The date when the subscription item ends or ended. | [optional] 
**apply_discount_to** | **List&lt;string&gt;** | Any combination of one-time, recurring, or usage prices. | [optional] 
**discount_level** | **string** | Specifies at what level a discount should be applied. | [optional] 
**start_event** | **string** | Specifies when to start billing your customer. | [optional] 
**discount_percent** | **decimal** | Discount percent. Specify this field if you want to override with a discount-based discount price. | [optional] 
**quantity** | **decimal** | Quantity of the product to which your customers subscribe. | [optional] 
**amount** | **decimal** | The amount of the price. Specify this field if you want to override the original price with a flat-fee price | [optional] 
**unit_amount** | **decimal** | The unit amount of the price. Specify this field if you want to override the orignial price with a per-unit price. | [optional] 
**tiers** | [**List&lt;ItemTier&gt;**](ItemTier.md) | Information of all tiers if you want to override the original price with a tiered price. | [optional] 
**overage** | [**Overage**](Overage.md) |  | [optional] 
**unique_token** | **string** | Unique identifier for the price. This identifier enables you to refer to the price before the price has an internal identifier in Zuora. | [optional] 
**prepayment** | [**SubscriptionItemPrepaymentField**](SubscriptionItemPrepaymentField.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

