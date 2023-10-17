
# Zuora.Model.Usage

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
**account_number** | **string** | Human-readable identifier of the account. It can be user-supplied. Either &#x60;account_number&#x60; or &#x60;account_id&#x60; is required. | [optional] 
**account_id** | **string** | Identifier of the account associated with this subscription. Either &#x60;account_id&#x60; or &#x60;account_number&#x60; is required. | [optional] 
**subscription_item_id** | **string** | Identifier of the subscription item. | [optional] 
**subscription_item_number** | **string** | Human-readable identifier of the subscription item. It can be user-supplied. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**end_time** | **DateTime** | The end time for which usage is recorded. | [optional] 
**quantity** | **decimal** | The number of units of this item. | [optional] 
**start_time** | **DateTime** | The start time for which usage is recorded. | [optional] 
**subscription_id** | **string** | The identifier of the subscription associated with the billing document item. | [optional] 
**subscription_number** | **string** | Human-readable identifier of the subscription. It can be user-supplied. | [optional] 
**unit_of_measure** | **string** | Specifies the units to measure usage. Units of measure are configured in Zuora Central. Your values depend on your configuration in Billing Settings. | [optional] 
**state** | **string** |  | [optional] 
**account** | [**Account**](Account.md) | The account that owns the usages. EXPANDABLE | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

