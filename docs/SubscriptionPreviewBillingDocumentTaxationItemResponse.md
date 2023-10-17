
# Zuora.Model.SubscriptionPreviewBillingDocumentTaxationItemResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount_exempt** | **decimal** | The calculated tax amount excluded due to the exemption. | [optional] 
**id** | **string** | Identifier of the taxation item related to the invoice. Only applicable for credit memos created from invoices. | [optional] 
**jurisdiction** | **string** | The jurisdiction that applies the tax or VAT. This value is typically a state, province, county, or city. | [optional] 
**location_code** | **string** | The identifier for the location based on the value of the &#x60;tax_code&#x60; field. | [optional] 
**name** | **string** | The name of the taxation item. | [optional] 
**amount** | **decimal** | The amount of the tax applied to the total price. | [optional] 
**tax_code** | **string** | A tax code identifier. If a &#x60;tax_code&#x60; of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly. | [optional] 
**tax_code_name** | **string** | The amount of the tax applied to the total price. | [optional] 
**date** | **DateTime** | The date on which the tax is applied. | [optional] 
**tax_rate** | **decimal** | The amount of the tax applied to the total price. | [optional] 
**tax_rate_name** | **string** | The name of the tax rate, such as sales tax or GST. This name is displayed on billing documents. | [optional] 
**tax_rate_type** | **string** | Indicates whether the tax rate is an amount or a percentage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

