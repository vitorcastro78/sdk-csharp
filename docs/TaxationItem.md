
# Zuora.Model.TaxationItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | Identifier of the taxation item related to the invoice. Only applicable for credit memos created from invoices. | [optional] 
**updated_by_id** | **string** | Unique identifier of the Zuora user who last updated the object | [optional] [readonly] 
**updated_time** | **DateTime** | The date and time when the object was last updated in ISO 8601 UTC format. | [optional] [readonly] 
**created_by_id** | **string** | Unique identifier of the Zuora user who created the object | [optional] [readonly] 
**created_time** | **DateTime** | The date and time when the object was created in ISO 8601 UTC format. | [optional] [readonly] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**custom_objects** | **Dictionary&lt;string, Object&gt;** | The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields). | [optional] [readonly] 
**jurisdiction** | **string** | The jurisdiction that applies the tax or VAT. This value is typically a state, province, county, or city. | [optional] 
**location_code** | **string** | The identifier for the location based on the value of the &#x60;tax_code&#x60; field. | [optional] 
**name** | **string** | The name of the taxation item. | [optional] 
**amount** | **decimal** | The amount of the tax applied to the total price. | [optional] 
**tax_code** | **string** | A tax code identifier. If a &#x60;tax_code&#x60; of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly. | [optional] 
**tax_code_name** | **string** | The amount of the tax applied to the total price. | [optional] 
**tax_date** | **DateTime** | The date on which the tax is applied. | [optional] 
**tax_rate** | **decimal** | The amount of the tax applied to the total price. | [optional] 
**tax_rate_name** | **string** | The name of the tax rate, such as sales tax or GST. This name is displayed on billing documents. | [optional] 
**amount_exempt** | **decimal** | The calculated tax amount excluded due to the exemption. | [optional] 
**source_tax_item_id** | **string** | The ID of the taxation item of the invoice, from which the credit or debit memo is created. This field is only applicable when the &#x60;type&#x60; of the billing document is &#x60;credit_memo&#x60; and &#x60;debit_memo&#x60;. | [optional] 
**remaining_balance** | **decimal** | The remaining balance of the taxation item. | [optional] [readonly] 
**amount_credited** | **decimal** | The credit memo amount applied to the taxation item. | [optional] [readonly] 
**amount_paid** | **decimal** | The payment amount applied to the taxation item. | [optional] [readonly] 
**amount_refunded** | **decimal** | The refund amount applied to the taxation item. | [optional] [readonly] 
**amount_applied** | **decimal** | The credit memo item amount applied to the taxation item. | [optional] [readonly] 
**sales_tax_payable_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**on_account_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**tax_inclusive** | **bool** | If set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax. | [optional] 
**tax_rate_type** | **string** | Indicates whether the tax rate is an amount or a percentage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

