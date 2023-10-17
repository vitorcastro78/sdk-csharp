
# Zuora.Model.SubscriptionPreviewAccountRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**sold_to** | [**AccountContactCreateRequest**](AccountContactCreateRequest.md) | Customer address used for calculating tax. | [optional] 
**tax_certificate** | [**TaxCertificate**](TaxCertificate.md) |  | [optional] 
**bill_cycle_day** | **int** | The day of the month on which your customer will be invoiced. For month-end specify 31. | 
**currency** | **string** | Three-letter ISO currency code. Once the currency is set for an account, it cannot be updated. | 
**tax_identifier** | [**TaxIdentifier**](TaxIdentifier.md) |  | [optional] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

