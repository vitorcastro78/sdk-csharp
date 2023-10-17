
# Zuora.Model.TaxationItemCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**on_account_account** | **string** | An active account in your Zuora Chart of Accounts. | [optional] 
**amount_exempt** | **decimal** | The calculated tax amount excluded due to the exemption. | [optional] 
**invoice_item_id** | **string** | Unique identifier of the invoice item to which the taxation item applies. | 
**jurisdiction** | **string** | The jurisdiction that applies the tax or VAT. This value is typically a state, province, county, or city. | [optional] 
**location_code** | **string** | The identifier for the location based on the value of the &#x60;tax_code&#x60; field. | [optional] 
**name** | **string** | The name of the taxation item. | 
**amount** | **decimal** | The amount of the tax applied to the total price. | 
**tax_code** | **string** | A tax code identifier. If a &#x60;tax_code&#x60; of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly. | 
**tax_code_name** | **string** | The amount of the tax applied to the total price. | [optional] 
**tax_date** | **DateTime** | The date on which the tax is applied. | 
**tax_rate** | **decimal** | The amount of the tax applied to the total price. | 
**tax_rate_name** | **string** | The name of the tax rate, such as sales tax or GST. This name is displayed on billing documents. | [optional] 
**tax_rate_type** | **string** | Indicates whether the tax rate is an amount or a percentage. | [optional] 
**source_tax_item_id** | **string** | The ID of the taxation item of the invoice, from which the credit or debit memo is created. This field is only applicable when the &#x60;type&#x60; of the billing document is &#x60;credit_memo&#x60; and &#x60;debit_memo&#x60;. | [optional] 
**tax_inclusive** | **bool** | If set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

