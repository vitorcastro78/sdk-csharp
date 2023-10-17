
# Zuora.Model.LineItemPatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**revenue** | [**OrderLineItemRevenue**](OrderLineItemRevenue.md) |  | [optional] 
**unit_of_measure** | **string** | A configured unit of measure. | [optional] 
**accounting_code** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**adjustment_liability_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**unit_amount** | **decimal** | The unit amount to be charged. | [optional] 
**target_date** | **DateTime** | All order line items that were unbilled on or before this date are included in future bill runs. | [optional] 
**billing_rule** | **string** | The billing rule for the order line item. | [optional] 
**contract_asset_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**contract_liability_account** | **string** | An active accounting code in your Zuora chart of accounts. | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**discount_unit_amount** | **decimal** | Discount amount per unit. | [optional] 
**discount_percent** | **decimal** | Discount percent. | [optional] 
**category** | **string** | Category of the order line item. | [optional] 
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

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

