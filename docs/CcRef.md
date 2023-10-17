
# Zuora.Model.CcRef

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**second_token** | **string** | A gateway unique identifier that replaces sensitive payment method data. This field is conditionally required only when &#x60;token&#x60; is being used to represent a gateway customer profile. | [optional] 
**token** | **string** | A gateway unique identifier that replaces sensitive payment method data or represents a gateway&#39;s unique customer profile. When &#x60;token&#x60; is used to represent a customer profile, &#x60;second_token&#x60; is conditionally required for representing the underlying tokenized payment method. | 
**mandate** | [**Mandate**](Mandate.md) |  | [optional] 
**card** | [**CcRefCard**](CcRefCard.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

