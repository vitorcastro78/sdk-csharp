
# Zuora.Model.QueryRunCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**column_separator** | **string** | The character used as delimiter to separate values in the output file. | [optional] 
**content_encoding** | **string** | If supplied, Zuora with compress the output file using the specified compression algorithm. | [optional] 
**encryption_key** | **string** | Base64-encoded public key of a 1024-bit RSA key-pair. If you set this field, Zuora will encrypt the query results using the provided public key. You must use the corresponding private key to decrypt the query results. | [optional] 
**content_type** | **string** | The type of the file returned. | 
**sql** | **string** | The SQL statement of the query. | 
**read_deleted** | **bool** | If set to &#x60;true&#x60;, any deleted records are included in the response. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

