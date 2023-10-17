
# Zuora.Model.SubscriptionItem

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
**subscription_item_number** | **string** | Human-readable identifier of the subscription item. It can be user-supplied. | [optional] 
**name** | **string** | The name of the subscription item. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**product_id** | **string** | Identifier of the product with which this subscription is associated. | [optional] 
**charged_through_date** | **DateTime** | The date through which a customer has been billed for the subscription item. | [optional] 
**recurring** | [**Recurring**](Recurring.md) |  | [optional] 
**active** | **bool** | Indicates whether the price is active and can be used for new purchases. | [optional] 
**state** | **string** | Based on the current date to populate a state field with the enumeration: [inactive, active, expired] where inactive would represent charge segments with a start_date in the future and expired charge segments with an end_date in the past. | [optional] 
**start_event** | **string** | Specifies when to start billing your customer. | [optional] 
**tiers_mode** | **string** | Specifies the kind of tiering. | [optional] 
**tiers** | [**List&lt;ItemTier&gt;**](ItemTier.md) |  | [optional] 
**tax_code** | **string** | A tax code identifier. If the &#x60;tax_code&#x60; of a price is not provided when you create or override a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly. | [optional] 
**tax_inclusive** | **bool** | If this field is set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax. | [optional] 
**unit_of_measure** | **string** | A configured unit of measure. This field is required for per-unit prices. | [optional] 
**quantity** | **decimal** | Quantity of the product to which your customers subscribe. | [optional] 
**amount** | **decimal** | The amount of the price. Specify this field if you want to override the original price with a flat-fee price | [optional] 
**unit_amount** | **decimal** | The unit amount of the price. Specify this field if you want to override the original price with a per-unit price. | [optional] 
**discount_amount** | **decimal** | Discount amount. Specify this field if you offer an amount-based discount. | [optional] 
**discount_percent** | **decimal** | Discount percent. Specify this field if you offer a percentage-based discount. | [optional] 
**apply_discount_to** | **List&lt;string&gt;** | Any combination of one_time, recurring and plan. | [optional] 
**discount_level** | **string** | Specifies at what level a discount should be applied: one of account, subscription or plan. | [optional] 
**price_base_interval** | **string** | Specifies the base interval of the price the subscriber is subscribed to. If not provided, this field defaults to &#x60;billing_period&#x60;. | [optional] 
**overage** | [**Overage**](Overage.md) |  | [optional] 
**charge_model** | **string** | Charge model of the price. See [Charge models](https://knowledgecenter.zuora.com/Billing/Subscriptions/Product_Catalog/B_Charge_Models) for more information. | [optional] 
**charge_type** | **string** | Type of the charge. It can be one of the following types: one-time, recurring, or usage. | [optional] 
**price_id** | **string** | Identifier of the price. | [optional] 
**price** | [**Price**](Price.md) |  | [optional] 
**subscription_plan_id** | **string** | Identifier of the subscription plan this subscription item belongs to. | [optional] 
**subscription_plan** | [**SubscriptionPlan**](SubscriptionPlan.md) |  | [optional] 
**start_date** | **DateTime** | The date when the subscription item starts. | [optional] [readonly] 
**end_date** | **DateTime** | The date when the subscription item ends. | [optional] [readonly] 
**processed_through_date** | **DateTime** | The date until when charges are processed. When billing takes place in arrears, such as usage-based prices, this field value is the the same as the &#x60;ChargedThroughDate&#x60; value. This date is the earliest date when a charge can be amended. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

