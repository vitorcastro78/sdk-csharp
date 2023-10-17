
# Zuora.Model.Card

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_number** | **string** | The card number, as a string without any separators. | 
**brand** | **string** | Card brand. | 
**expiry_month** | **decimal** | One or two digit expiration month (1-12) of the credit card. | 
**expiry_year** | **decimal** | Two- or four-digit number representing the card&#39;s expiration year. | 
**security_code** | **string** | Card security code. It is highly recommended to always include this value. | [optional] 
**mandate** | [**CardMandate**](CardMandate.md) |  | [optional] 
**last_4** | **string** | The last four digits of the card number. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

