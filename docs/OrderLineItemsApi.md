# Zuora.Api.OrderLineItemsApi

All URIs are relative to *https://rest.sandbox.na.zuora.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderLineItem**](OrderLineItemsApi.md#getorderlineitem) | **GET** /order_line_items/{order_line_item_id} | Retrieve an order line item
[**PatchOrderLineItem**](OrderLineItemsApi.md#patchorderlineitem) | **PATCH** /order_line_items/{order_line_item_id} | Update an order line item



## GetOrderLineItem

> OrderLineItem GetOrderLineItem (string orderLineItemId, List<string> fields = null, List<string> lineItemFields = null, List<string> invoiceItemsFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Retrieve an order line item

Use this operation to retrieve the detailed information about a specific order line item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetOrderLineItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderLineItemsApi(Configuration.Default);
            var orderLineItemId = orderLineItemId_example;  // string | Identifier for the order line item.
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var expand = new List<string>(); // List<string> | Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var filter = new List<string>(); // List<string> | A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \"Retrieve a billing document\" operaiton, you can use the `filter[]` parameter on the related objects such as `filter[]=items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63` (optional) 
            var pageSize = 56;  // int? | The maximum number of results to return in a single page. If the specified `page_size` is less than 1 or greater than 99, Zuora will return a 400 error. (optional) 
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // Retrieve an order line item
                OrderLineItem result = apiInstance.GetOrderLineItem(orderLineItemId, fields, lineItemFields, invoiceItemsFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrderLineItemsApi.GetOrderLineItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineItemId** | **string**| Identifier for the order line item. | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **expand** | [**List&lt;string&gt;**](string.md)| Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
 **filter** | [**List&lt;string&gt;**](string.md)| A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operaiton, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63&#x60; | [optional] 
 **pageSize** | **int?**| The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error. | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**OrderLineItem**](OrderLineItem.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  * ratelimit-limit - The request limit quota for the time window closest to exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * ratelimit-remaining - The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * ratelimit-reset - The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * zuora-request-id - Zuoraâ€™s internal identifier for this request. <br>  * zuora-track-id - A user-supplied identifier for this request. If you supply a &#x60;zuora-track-id&#x60; as a request header, Zuora returns the &#x60;zuora-track-id&#x60; as a response header.  <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **502** | Bad Gateway |  -  |
| **503** | Service Unavailable |  -  |
| **504** | Gateway Timeout |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchOrderLineItem

> OrderLineItem PatchOrderLineItem (string orderLineItemId, LineItemPatchRequest lineItemPatchRequest, List<string> fields = null, List<string> lineItemFields = null, List<string> invoiceItemsFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Update an order line item

Use this operation to update the information of a specific order line item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class PatchOrderLineItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderLineItemsApi(Configuration.Default);
            var orderLineItemId = orderLineItemId_example;  // string | Identifier for the order line item.
            var lineItemPatchRequest = new LineItemPatchRequest(); // LineItemPatchRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var expand = new List<string>(); // List<string> | Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var filter = new List<string>(); // List<string> | A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \"Retrieve a billing document\" operaiton, you can use the `filter[]` parameter on the related objects such as `filter[]=items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63` (optional) 
            var pageSize = 56;  // int? | The maximum number of results to return in a single page. If the specified `page_size` is less than 1 or greater than 99, Zuora will return a 400 error. (optional) 
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var async = true;  // bool? | Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. (optional)  (default to false)
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // Update an order line item
                OrderLineItem result = apiInstance.PatchOrderLineItem(orderLineItemId, lineItemPatchRequest, fields, lineItemFields, invoiceItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrderLineItemsApi.PatchOrderLineItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderLineItemId** | **string**| Identifier for the order line item. | 
 **lineItemPatchRequest** | [**LineItemPatchRequest**](LineItemPatchRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **expand** | [**List&lt;string&gt;**](string.md)| Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
 **filter** | [**List&lt;string&gt;**](string.md)| A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operaiton, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63&#x60; | [optional] 
 **pageSize** | **int?**| The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error. | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **async** | **bool?**| Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#39;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. | [optional] [default to false]
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**OrderLineItem**](OrderLineItem.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  * ratelimit-limit - The request limit quota for the time window closest to exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * ratelimit-remaining - The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * ratelimit-reset - The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * zuora-request-id - Zuoraâ€™s internal identifier for this request. <br>  * zuora-track-id - A user-supplied identifier for this request. If you supply a &#x60;zuora-track-id&#x60; as a request header, Zuora returns the &#x60;zuora-track-id&#x60; as a response header.  <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **502** | Bad Gateway |  -  |
| **503** | Service Unavailable |  -  |
| **504** | Gateway Timeout |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

