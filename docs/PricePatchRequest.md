
# Zuora.Model.PricePatchRequest

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
**name** | **string** | The name of the price. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**recognized_revenue_accounting_code** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**deferred_revenue_accounting_code** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**recurring** | [**Recurring**](Recurring.md) |  | [optional] 
**start_event** | **string** | Specifies when to start billing your customer. | [optional] 
**tiers_mode** | **string** | Specifies the mode for tiered prices. | [optional] 
**apply_discount_to** | **List&lt;string&gt;** | Any combination of one_time, recurring and plan. | [optional] 
**tiers** | [**List&lt;Tier&gt;**](Tier.md) | Price information for different tiers. When creating or updating tiered prices, you must specify this field and the &#x60;tiers_mode&#x60; field. | [optional] 
**tax_code** | **string** | A tax code identifier. If a &#x60;tax_code&#x60; of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly. | [optional] 
**tax_inclusive** | **bool** | If this field is set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax. | [optional] 
**unit_of_measure** | **string** | A configured unit of measure. This field is required for per-unit prices. | [optional] 
**quantity** | **decimal** | Quantity of the product to which your customers subscribe. | [optional] 
**min_quantity** | **decimal** | The minimum quantity for a price. Specify this field and the &#x60;max_quantity&#x60; field to create a range of quantities allowed in a price. | [optional] 
**max_quantity** | **decimal** | The maximum quantity for a price. Specify this field and the &#x60;min_quantity&#x60; field to create a range of quantities allowed in a price. | [optional] 
**discount_level** | **string** | Specifies at what level a discount should be applied: account, subscription, or plan. | [optional] 
**revenue_recognition_rule** | **string** | Determines when to recognize the revenue for this charge. You can choose to recognize upon invoicing or daily over time. | [optional] 
**stacked_discount** | **bool** | This field is only applicable for the Percentage Discount price. This field indicates whether the discount is to be calculated as stacked discount. Possible values are as follows:        &lt;ul&gt;       &lt;li&gt;&#x60;true&#x60;: This is a stacked discount, which should be calculated by stacking with other discounts.&lt;/li&gt;       &lt;li&gt; &#x60;false&#x60;: This is not a stacked discount, which should be calculated in sequence with other discounts.&lt;/li&gt;&lt;/ul&gt; For more information, see &lt;a href&#x3D;&#39;https://knowledgecenter.zuora.com/Zuora_Billing/Products/Product_Catalog/B_Charge_Models/B_Discount_Charge_Models&#39; target&#x3D;&#39;_blank&#39;&gt;Stacked discounts&lt;/a&gt; | [optional] 
**amounts** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 
**unit_amounts** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 
**discount_amounts** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 
**discount_percent** | **decimal** | Discount percent. Specify this field if you offer a percentage-based discount. | [optional] 
**price_base_interval** | **string** | Specifies the base interval of a price. If not provided, this field defaults to &#x60;billing_period&#x60;. | [optional] 
**overage** | [**Overage**](Overage.md) |  | [optional] 
**revenue** | [**Revenue**](Revenue.md) |  | [optional] 
**accounting_code** | **string** | An active accounting code defined in **Finance Settings &gt; Configure Accounting Codes** in your Zuora tenant. | [optional] 
**prepayment** | [**Prepayment**](Prepayment.md) |  | [optional] 
**drawdown** | [**Drawdown**](Drawdown.md) |  | [optional] 
**taxable** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

