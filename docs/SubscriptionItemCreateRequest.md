
# Zuora.Model.SubscriptionItemCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**price_id** | **string** | Identifier of the price. | 
**subscription_item_number** | **string** | Human-readable identifier of the subscription item. It can be user-supplied. | [optional] 
**description** | **string** | Description of the price. Often useful for displaying to users. | [optional] 
**recurring** | [**Recurring**](Recurring.md) |  | [optional] 
**start_event** | **string** | Specifies when to start billing your customer. | [optional] 
**start_date** | **DateTime** | The date when the subscription item starts | [optional] 
**end_date** | **DateTime** | The date when the subscription item ends or ended. | [optional] 
**tiers_mode** | **string** | Specifies the mode of tiering. | [optional] 
**tiers** | [**List&lt;ItemTier&gt;**](ItemTier.md) | Information of all tiers if the price is a tiered price. | [optional] 
**quantity** | **decimal** | Quantity of the product to which your customers subscribe. | [optional] 
**amount** | **decimal** | The amount of the price. Specify this field if you want to override the original price with a flat-fee price | [optional] 
**unit_amount** | **decimal** | The unit amount of the price. Specify this field if you want to override the original price with a per-unit price. | [optional] 
**discount_amount** | **decimal** | Discount amount. Specify this field if you offer an amount-based discount. | [optional] 
**discount_percent** | **decimal** | Discount percent. Specify this field if you offer a percentage-based discount. | [optional] 
**price_base_interval** | **string** | Specifies the base interval of the price the subscriber is subscribed to. If not provided, this field defaults to &#x60;billing_period&#x60;. | [optional] 
**overage** | [**Overage**](Overage.md) |  | [optional] 
**unique_token** | **string** | Unique identifier for the price. This identifier enables you to refer to the price before the price has an internal identifier in Zuora. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**apply_discount_to** | **List&lt;string&gt;** | Any combination of one-time, recurring, and usage. | [optional] 
**discount_level** | **string** | Specifies at what level a discount should be applied: one of account, subscription or plan. | [optional] 
**prepayment** | [**SubscriptionItemPrepaymentField**](SubscriptionItemPrepaymentField.md) |  | [optional] 
**drawdown** | [**SubscriptionItemDrawdownField**](SubscriptionItemDrawdownField.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

