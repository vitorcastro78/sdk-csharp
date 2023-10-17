
# Zuora.Model.OrderLineItem

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
**revenue** | [**OrderLineItemRevenue**](OrderLineItemRevenue.md) |  | [optional] 
**unit_of_measure** | **string** | A configured unit of measure. | [optional] 
**accounting_code** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**adjustment_liability_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**unit_amount** | **decimal** | The unit amount to be charged. | [optional] 
**target_date** | **DateTime** | All order line items that were unbilled on or before this date are included in future bill runs. | [optional] 
**billing_rule** | **string** | The billing rule for the order line item. | [optional] 
**contract_asset_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**contract_liability_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**discount_unit_amount** | **decimal** | Discount amount per unit. | [optional] 
**discount_percent** | **decimal** | Discount percent. | [optional] 
**category** | **string** | The category for the order line item, to indicate a product sale or return. | [optional] 
**name** | **string** | The name of the order line item. | [optional] 
**type** | **string** | The type of the order line item. | [optional] 
**list_unit_price** | **decimal** | The list price per unit for the order line item. | [optional] 
**product_code** | **string** | The product code for the order line item. | [optional] 
**purchase_order_number** | **string** | Used by customers to specify the Purchase Order Number provided by the buyer. | [optional] 
**quantity** | **decimal** | The quantity of the product ordered. | [optional] 
**related_subscription_number** | **string** | Use this field to relate an order line item to an subscription. | [optional] 
**sold_to_id** | **string** | The unique identifier of a contact belonging to the billing account of the order line item. Use this field to assign and existing contact as the sold to contact of an order line item. | [optional] 
**tax_code** | **string** | The tax code for the order line item. | [optional] 
**unbilled_receivables_account** | **string** | An active accounting code in your Zuora chart of accounts.. | [optional] 
**state** | **string** | The state of an order line item. If you want to generate billing documents for order line items, you must set this field to &#x60;sent_to_billing&#x60;. For invoice preview, you do not need to set this field. | [optional] 
**item_number** | **string** | Human-readable identifier of the order item. It can be user-supplied. | [optional] 
**start_date** | **DateTime** | The date a transaction starts. The default value of this field is the order date. | [optional] 
**end_date** | **DateTime** | The date the order line item transitions to complete. | [optional] 
**price_id** | **string** | Identifier of the price. | [optional] 
**quantity_available_for_return** | **decimal** | The quantity of the product ordered available for return. | [optional] 
**tax_inclusive** | **bool** | If this field is set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax. | [optional] 
**invoice_items** | [**InvoiceItemListResponse**](InvoiceItemListResponse.md) | List of invoice items. EXPANDABLE | [optional] [readonly] 
**order_id** | **string** | The unique identifier for the order associated with this order line item. | [optional] 
**total** | **decimal** | Total after discounts and taxes. | [optional] 
**subtotal** | **decimal** | Total before discounts and taxes are applied. | [optional] 
**quantity_fulfilled** | **decimal** | The quantity fulfilled. | [optional] 
**quantity_pending_fulfillment** | **decimal** | The quantity pending fulfillment. | [optional] 
**requires_fulfillment** | **bool** | If true, a fulfillment is required to trigger billing. | [optional] 
**original_order_date** | **DateTime** | The date when the subscription item is created through an order. This field is to standardize the booking date information to increase audit ability and traceability of data between Zuora Billing and Zuora Revenue. It is mapped as the booking date for a sales order line in Zuora Revenue. | [optional] 
**original_order_id** | **string** | The unique identifier of the original sales order for a return order line item. | [optional] 
**original_order_line_item_id** | **string** | The unique identifier of the original sales order line item for a return order line item. | [optional] 
**original_order_line_item_number** | **string** | The number of the original sales order line item for a return order line item. | [optional] 
**original_order_number** | **string** | The number of the original sales order for a return order line item. | [optional] 
**discount_total** | **decimal** | Total discount amount. | [optional] 
**list_price** | **decimal** | The extended list price for an order line item, calculated by the formula: listPrice &#x3D; listPricePerUnit * quantity | [optional] 
**original_sold_to_id** | **string** | The unique identifier of a contact belonging to the billing account of the order line item that was the original sold to contact when the order line item was created.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

