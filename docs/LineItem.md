
# Zuora.Model.LineItem

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
**unit_of_measure** | **string** | A configured unit of measure. This field is required for per-unit prices. | [optional] 
**unit_amount** | **decimal** | The unit amount of the price. Specify this field if you want to override the original price with a per-unit price. | [optional] 
**target_date** | **DateTime** | The target date for the order line item to be picked up by bill run for billing. | [optional] 
**deferred_revenue_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**revenue** | [**Revenue**](Revenue.md) |  | [optional] 
**discount_unit_amount** | **decimal** | Discount amount. Specify this field if you offer an amount-based discount. | [optional] 
**discount_percent** | **decimal** | Discount percent. Specify this field if you offer a percentage-based discount. | [optional] 
**category** | **string** | The category for the order line item, to indicate a product sale or return. | [optional] 
**state** | **string** | The state of an order line item. If you want to generate billing documents for order line items, you must set this field to &#x60;sent_to_billing&#x60;. For invoice preview, you do not need to set this field. | [optional] 
**type** | **string** | The type of the order line item. | [optional] 
**name** | **string** | Name of the order line item | [optional] 
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
**related_subscription_number** | **string** | Use this field to relate an order line item to an subscription. Specify this field to the subscription number of the subscription to relate. | [optional] 
**billing_rule** | **string** | The billing rule for the Order Line Item. | [optional] 
**total** | **string** | The total amount, including the total tax amount. | [optional] 
**subtotal** | **string** | The total amount exclusive of tax.  | [optional] 
**original_order_date** | **DateTime** | The date when the subscription item is created through an order. This field is to standardize the booking date information to increase audit ability and traceability of data between Zuora Billing and Zuora Revenue. It is mapped as the booking date for a sales order line in Zuora Revenue. | [optional] 
**accounting_code** | **string** | The accounting code for the order line item. | [optional] 
**adjustment_liability_account** | **string** | The accounting code on the Order Line Item object for customers using Zuora Billing - Revenue Integration. | [optional] 
**adjustment_revenue_account** | **string** | The accounting code on the Order Line Item object for customers using Zuora Billing - Revenue Integration. | [optional] 
**discount_total** | **string** | The total discount amount. | [optional] 
**list_price** | **string** | The extended list price for an order line item, calculated by the formula: listPrice &#x3D; listPricePerUnit * quantity | [optional] 
**original_sold_to_id** | **string** | The ID of a contact that belongs to the billing account of the order line item. Use this field to assign an existing account as the sold-to contact of an order line item. | [optional] 
**unbilled_receivables_account** | **string** | The accounting code on the Order Line Item object for customers using Zuora Billing - Revenue Integration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

