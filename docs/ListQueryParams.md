
# Zuora.Model.ListQueryParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cursor** | **string** | A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list. | [optional] 
**expand** | **List&lt;string&gt;** | Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
**filter** | **List&lt;string&gt;** | A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
**sort** | **List&lt;string&gt;** | A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored. | [optional] 
**page_size** | **int** | The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

