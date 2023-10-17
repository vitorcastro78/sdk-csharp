
# Zuora.Model.AccountContactCreateRequest

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
**address** | [**Address**](Address.md) |  | [optional] 
**first_name** | **string** | Customer first name. | 
**home_phone** | **string** | Customer home phone (including extension). | [optional] 
**last_name** | **string** | Customer last name. | 
**mobile_phone** | **string** | Customer phone (including extension). | [optional] 
**nickname** | **string** | Nickname for this contact. | [optional] 
**other_phone** | **string** | Other customer phone (including extension). | [optional] 
**email** | **string** | Customer email address. | [optional] 
**tax_region** | **string** | A region defined in your Zuora Tax rules. | [optional] 
**work_email** | **string** | Customer work email. | [optional] 
**work_phone** | **string** | Customer work phone. | [optional] 
**other_phone_type** | **string** | The type of the additional phone number. | [optional] 
**fax** | **string** | The contact&#39;s fax number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

