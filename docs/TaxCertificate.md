
# Zuora.Model.TaxCertificate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_code** | **string** | Unique code that identifies a company account in Avalara. Use this field to calculate taxes based on country of origin and sold-to addresses in Avalara. | [optional] 
**id** | **string** | Identifier of the tax exemption certificate. | [optional] 
**start_date** | **DateTime** | The tax certificate start date. | [optional] 
**description** | **string** | Description of the tax exemption certificate. | [optional] 
**entity_use_code** | **string** | A unique entity use code used by Avalara to apply exemptions. This field is required only when you choose Avalara as your tax engine. See [Exempt Transactions](https://developer.avalara.com/avatax/handling-tax-exempt-customers/) for more information. | [optional] 
**end_date** | **DateTime** | The tax certificate end date. | [optional] 
**issuing_jurisdiction** | **string** | Typically, this is a state or government agency | [optional] 
**state** | **string** | Status of the tax exemption certificate, indication whether the certificate has been verified. | [optional] 
**tax_identifier** | **string** | Value Added Tax (VAT) ID. Each VAT ID must begin with the code of the country code and followed by a block of digits or characters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

