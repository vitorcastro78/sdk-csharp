
# Zuora.Model.LineItemCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**unit_of_measure** | **string** | A configured unit of measure. This field is required for per-unit prices. | [optional] 
**unit_amount** | **decimal** | The unit amount of the price. Specify this field if you want to override the original price with a per-unit price. | [optional] 
**target_date** | **DateTime** | The target date for the order line item to be picked up by bill run for billing. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**deferred_revenue_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**revenue** | [**Revenue**](Revenue.md) |  | [optional] 
**discount_unit_amount** | **decimal** | Discount amount. Specify this field if you offer an amount-based discount. | [optional] 
**discount_percent** | **decimal** | Discount percent. Specify this field if you offer a percentage-based discount. | [optional] 
**category** | **string** | The category for the order line item, to indicate a product sale or return. | [optional] 
**state** | **string** | The state of an order line item. If you want to generate billing documents for order line items, you must set this field to &#x60;sent_to_billing&#x60;. For invoice preview, you do not need to set this field. | [optional] 
**type** | **string** | The type of the order line item. | 
**name** | **string** | The name of the order line item. | 
**item_number** | **string** | Human-readable identifier of the order item. It can be user-supplied. | [optional] 
**list_unit_price** | **decimal** | The list price per unit for the order line item. | [optional] 
**product_code** | **string** | The product code for the order line item. | [optional] 
**price_id** | **string** | Identifier of the price. | [optional] 
**purchase_order_number** | **string** | Used by customers to specify the Purchase Order Number provided by the buyer. | [optional] 
**quantity** | **decimal** | The quantity of units, such as the number of authors in a hosted wiki service. | [optional] 
**recognized_revenue_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**revenue_recognition_rule_name** | **string** | The revenue recognition rule for the order line item. | [optional] 
**sold_to_id** | **string** | Customer address used for calculating tax. | [optional] 
**tax_code** | **string** | A tax code identifier. If a &#x60;tax_code&#x60; of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly. | [optional] 
**tax_inclusive** | **bool** | If this field is set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax. | [optional] 
**start_date** | **DateTime** | The date a transaction starts. The default value of this field is the order date. | [optional] 
**end_date** | **DateTime** | The date a transaction is completed. The default value of this field is the transaction start date. Also, the value of this field should always equal or be later than the value of the &#x60;start_date&#x60; field. | [optional] 
**invoice_items** | [**InvoiceItemListResponse**](InvoiceItemListResponse.md) | List of invoice items. EXPANDABLE | [optional] [readonly] 
**related_subscription_number** | **string** | Relates an order line item to a subscription when you create the order line item. | [optional] 
**billing_rule** | **string** | The billing rule for the Order Line Item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

