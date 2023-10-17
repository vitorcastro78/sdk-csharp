# Zuora.Api.OrdersApi

All URIs are relative to *https://rest.sandbox.na.zuora.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateOrder**](OrdersApi.md#activateorder) | **POST** /orders/{order_id}/activate | Activate an order
[**CancelOrder**](OrdersApi.md#cancelorder) | **POST** /orders/{order_id}/cancel | Cancel an order
[**CreateOrder**](OrdersApi.md#createorder) | **POST** /orders | Create an order
[**CreateOrderPreview**](OrdersApi.md#createorderpreview) | **POST** /orders/preview | Preview an order
[**DeleteOrder**](OrdersApi.md#deleteorder) | **DELETE** /orders/{order_id} | Delete an order
[**GetOrder**](OrdersApi.md#getorder) | **GET** /orders/{order_id} | Retrieve an order
[**GetOrders**](OrdersApi.md#getorders) | **GET** /orders | List orders



## ActivateOrder

> Order ActivateOrder (string orderId, List<string> fields = null, List<string> orderActionsFields = null, List<string> subscriptionsFields = null, List<string> lineItemsFields = null, List<string> subscriptionPlansFields = null, List<string> subscriptionItemsFields = null, List<string> invoiceItemsFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityId = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Activate an order

Activates a draft order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class ActivateOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(Configuration.Default);
            var orderId = orderId_example;  // string | Identifier for the order, either `order_number` or `order_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `order_number`, `order_date`, `state`, `category`, `description`, `line_items`, `subscriptions`          </details> (optional) 
            var orderActionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `type`, `action_id`, `sequence`, `start_on`, `subscription_plans`, `renew`, `terms`, `cancel`, `pause`, `resume`, `order`          </details> (optional) 
            var subscriptionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `subscription_number`, `state`, `account_id`, `invoice_owner_account_id`, `auto_renew`, `version`, `initial_term`, `current_term`, `renewal_term`, `start_date`, `end_date`, `description`, `contract_effective`, `service_activation`, `customer_acceptance`, `invoice_separately`, `latest_version`, `payment_terms`, `billing_document_settings`, `bill_to_id`, `sold_to_id`, `contracted_mrr`, `actions`          </details> (optional) 
            var lineItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var subscriptionPlansFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `name`, `plan_id`, `subscription_id`, `product_id`, `subscription_items`          </details> (optional) 
            var subscriptionItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `start_date`, `end_date`, `charge_model`, `charge_type`, `tiers`, `subscription_item_number`, `name`, `description`, `charged_through_date`, `recurring`, `price_id`, `start_event`, `tax_code`, `tax_inclusive`, `unit_of_measure`, `quantity`, `price_base_interval`, `overage`, `subscription_plan_id`, `tiers_mode`, `processed_through_date`, `active`, `state`, `unit_amount`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var expand = new List<string>(); // List<string> | Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var filter = new List<string>(); // List<string> | A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \"Retrieve a billing document\" operaiton, you can use the `filter[]` parameter on the related objects such as `filter[]=items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63` (optional) 
            var pageSize = 56;  // int? | The maximum number of results to return in a single page. If the specified `page_size` is less than 1 or greater than 99, Zuora will return a 400 error. (optional) 
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var async = true;  // bool? | Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. (optional) 
            var zuoraEntityId = zuoraEntityId_example;  // string | An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // Activate an order
                Order result = apiInstance.ActivateOrder(orderId, fields, orderActionsFields, subscriptionsFields, lineItemsFields, subscriptionPlansFields, subscriptionItemsFields, invoiceItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersApi.ActivateOrder: " + e.Message );
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
 **orderId** | **string**| Identifier for the order, either &#x60;order_number&#x60; or &#x60;order_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;order_number&#x60;, &#x60;order_date&#x60;, &#x60;state&#x60;, &#x60;category&#x60;, &#x60;description&#x60;, &#x60;line_items&#x60;, &#x60;subscriptions&#x60;          &lt;/details&gt; | [optional] 
 **orderActionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;type&#x60;, &#x60;action_id&#x60;, &#x60;sequence&#x60;, &#x60;start_on&#x60;, &#x60;subscription_plans&#x60;, &#x60;renew&#x60;, &#x60;terms&#x60;, &#x60;cancel&#x60;, &#x60;pause&#x60;, &#x60;resume&#x60;, &#x60;order&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;subscription_number&#x60;, &#x60;state&#x60;, &#x60;account_id&#x60;, &#x60;invoice_owner_account_id&#x60;, &#x60;auto_renew&#x60;, &#x60;version&#x60;, &#x60;initial_term&#x60;, &#x60;current_term&#x60;, &#x60;renewal_term&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;description&#x60;, &#x60;contract_effective&#x60;, &#x60;service_activation&#x60;, &#x60;customer_acceptance&#x60;, &#x60;invoice_separately&#x60;, &#x60;latest_version&#x60;, &#x60;payment_terms&#x60;, &#x60;billing_document_settings&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;contracted_mrr&#x60;, &#x60;actions&#x60;          &lt;/details&gt; | [optional] 
 **lineItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionPlansFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;name&#x60;, &#x60;plan_id&#x60;, &#x60;subscription_id&#x60;, &#x60;product_id&#x60;, &#x60;subscription_items&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;tiers&#x60;, &#x60;subscription_item_number&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;charged_through_date&#x60;, &#x60;recurring&#x60;, &#x60;price_id&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;overage&#x60;, &#x60;subscription_plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;processed_through_date&#x60;, &#x60;active&#x60;, &#x60;state&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **expand** | [**List&lt;string&gt;**](string.md)| Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
 **filter** | [**List&lt;string&gt;**](string.md)| A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operaiton, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63&#x60; | [optional] 
 **pageSize** | **int?**| The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error. | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **async** | **bool?**| Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#39;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. | [optional] 
 **zuoraEntityId** | **string**| An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default Response |  -  |
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


## CancelOrder

> Order CancelOrder (string orderId, OrderCancellationRequest orderCancellationRequest, List<string> fields = null, List<string> orderActionsFields = null, List<string> subscriptionsFields = null, List<string> lineItemsFields = null, List<string> subscriptionPlansFields = null, List<string> subscriptionItemsFields = null, List<string> invoiceItemsFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Cancel an order

Cancels a draft order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(Configuration.Default);
            var orderId = orderId_example;  // string | Identifier for the order, either `order_number` or `order_id`
            var orderCancellationRequest = new OrderCancellationRequest(); // OrderCancellationRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `order_number`, `order_date`, `state`, `category`, `description`, `line_items`, `subscriptions`          </details> (optional) 
            var orderActionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `type`, `action_id`, `sequence`, `start_on`, `subscription_plans`, `renew`, `terms`, `cancel`, `pause`, `resume`, `order`          </details> (optional) 
            var subscriptionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `subscription_number`, `state`, `account_id`, `invoice_owner_account_id`, `auto_renew`, `version`, `initial_term`, `current_term`, `renewal_term`, `start_date`, `end_date`, `description`, `contract_effective`, `service_activation`, `customer_acceptance`, `invoice_separately`, `latest_version`, `payment_terms`, `billing_document_settings`, `bill_to_id`, `sold_to_id`, `contracted_mrr`, `actions`          </details> (optional) 
            var lineItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var subscriptionPlansFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `name`, `plan_id`, `subscription_id`, `product_id`, `subscription_items`          </details> (optional) 
            var subscriptionItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `start_date`, `end_date`, `charge_model`, `charge_type`, `tiers`, `subscription_item_number`, `name`, `description`, `charged_through_date`, `recurring`, `price_id`, `start_event`, `tax_code`, `tax_inclusive`, `unit_of_measure`, `quantity`, `price_base_interval`, `overage`, `subscription_plan_id`, `tiers_mode`, `processed_through_date`, `active`, `state`, `unit_amount`          </details> (optional) 
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
                // Cancel an order
                Order result = apiInstance.CancelOrder(orderId, orderCancellationRequest, fields, orderActionsFields, subscriptionsFields, lineItemsFields, subscriptionPlansFields, subscriptionItemsFields, invoiceItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersApi.CancelOrder: " + e.Message );
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
 **orderId** | **string**| Identifier for the order, either &#x60;order_number&#x60; or &#x60;order_id&#x60; | 
 **orderCancellationRequest** | [**OrderCancellationRequest**](OrderCancellationRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;order_number&#x60;, &#x60;order_date&#x60;, &#x60;state&#x60;, &#x60;category&#x60;, &#x60;description&#x60;, &#x60;line_items&#x60;, &#x60;subscriptions&#x60;          &lt;/details&gt; | [optional] 
 **orderActionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;type&#x60;, &#x60;action_id&#x60;, &#x60;sequence&#x60;, &#x60;start_on&#x60;, &#x60;subscription_plans&#x60;, &#x60;renew&#x60;, &#x60;terms&#x60;, &#x60;cancel&#x60;, &#x60;pause&#x60;, &#x60;resume&#x60;, &#x60;order&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;subscription_number&#x60;, &#x60;state&#x60;, &#x60;account_id&#x60;, &#x60;invoice_owner_account_id&#x60;, &#x60;auto_renew&#x60;, &#x60;version&#x60;, &#x60;initial_term&#x60;, &#x60;current_term&#x60;, &#x60;renewal_term&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;description&#x60;, &#x60;contract_effective&#x60;, &#x60;service_activation&#x60;, &#x60;customer_acceptance&#x60;, &#x60;invoice_separately&#x60;, &#x60;latest_version&#x60;, &#x60;payment_terms&#x60;, &#x60;billing_document_settings&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;contracted_mrr&#x60;, &#x60;actions&#x60;          &lt;/details&gt; | [optional] 
 **lineItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionPlansFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;name&#x60;, &#x60;plan_id&#x60;, &#x60;subscription_id&#x60;, &#x60;product_id&#x60;, &#x60;subscription_items&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;tiers&#x60;, &#x60;subscription_item_number&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;charged_through_date&#x60;, &#x60;recurring&#x60;, &#x60;price_id&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;overage&#x60;, &#x60;subscription_plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;processed_through_date&#x60;, &#x60;active&#x60;, &#x60;state&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt; | [optional] 
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

[**Order**](Order.md)

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


## CreateOrder

> Order CreateOrder (OrderCreateRequest orderCreateRequest, List<string> fields = null, List<string> orderActionsFields = null, List<string> subscriptionsFields = null, List<string> lineItemsFields = null, List<string> subscriptionPlansFields = null, List<string> subscriptionItemsFields = null, List<string> invoiceItemsFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Create an order

You can use this operation to create subscriptions and make changes to existing subscriptions. You can also use this operation to create order line items.      <p> Note that the following limitations apply to this operation:      <ul>       <li>Up to 50 subscriptions are allowed in a single call.</li>      <li>Up to 100 order line items are allowed in an order.</li>       <li>Up to 1000 orders are allowed on a subscription.</li>      </ul>

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(Configuration.Default);
            var orderCreateRequest = new OrderCreateRequest(); // OrderCreateRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `order_number`, `order_date`, `state`, `category`, `description`, `line_items`, `subscriptions`          </details> (optional) 
            var orderActionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `type`, `action_id`, `sequence`, `start_on`, `subscription_plans`, `renew`, `terms`, `cancel`, `pause`, `resume`, `order`          </details> (optional) 
            var subscriptionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `subscription_number`, `state`, `account_id`, `invoice_owner_account_id`, `auto_renew`, `version`, `initial_term`, `current_term`, `renewal_term`, `start_date`, `end_date`, `description`, `contract_effective`, `service_activation`, `customer_acceptance`, `invoice_separately`, `latest_version`, `payment_terms`, `billing_document_settings`, `bill_to_id`, `sold_to_id`, `contracted_mrr`, `actions`          </details> (optional) 
            var lineItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var subscriptionPlansFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `name`, `plan_id`, `subscription_id`, `product_id`, `subscription_items`          </details> (optional) 
            var subscriptionItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `start_date`, `end_date`, `charge_model`, `charge_type`, `tiers`, `subscription_item_number`, `name`, `description`, `charged_through_date`, `recurring`, `price_id`, `start_event`, `tax_code`, `tax_inclusive`, `unit_of_measure`, `quantity`, `price_base_interval`, `overage`, `subscription_plan_id`, `tiers_mode`, `processed_through_date`, `active`, `state`, `unit_amount`          </details> (optional) 
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
                // Create an order
                Order result = apiInstance.CreateOrder(orderCreateRequest, fields, orderActionsFields, subscriptionsFields, lineItemsFields, subscriptionPlansFields, subscriptionItemsFields, invoiceItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrder: " + e.Message );
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
 **orderCreateRequest** | [**OrderCreateRequest**](OrderCreateRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;order_number&#x60;, &#x60;order_date&#x60;, &#x60;state&#x60;, &#x60;category&#x60;, &#x60;description&#x60;, &#x60;line_items&#x60;, &#x60;subscriptions&#x60;          &lt;/details&gt; | [optional] 
 **orderActionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;type&#x60;, &#x60;action_id&#x60;, &#x60;sequence&#x60;, &#x60;start_on&#x60;, &#x60;subscription_plans&#x60;, &#x60;renew&#x60;, &#x60;terms&#x60;, &#x60;cancel&#x60;, &#x60;pause&#x60;, &#x60;resume&#x60;, &#x60;order&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;subscription_number&#x60;, &#x60;state&#x60;, &#x60;account_id&#x60;, &#x60;invoice_owner_account_id&#x60;, &#x60;auto_renew&#x60;, &#x60;version&#x60;, &#x60;initial_term&#x60;, &#x60;current_term&#x60;, &#x60;renewal_term&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;description&#x60;, &#x60;contract_effective&#x60;, &#x60;service_activation&#x60;, &#x60;customer_acceptance&#x60;, &#x60;invoice_separately&#x60;, &#x60;latest_version&#x60;, &#x60;payment_terms&#x60;, &#x60;billing_document_settings&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;contracted_mrr&#x60;, &#x60;actions&#x60;          &lt;/details&gt; | [optional] 
 **lineItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionPlansFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;name&#x60;, &#x60;plan_id&#x60;, &#x60;subscription_id&#x60;, &#x60;product_id&#x60;, &#x60;subscription_items&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;tiers&#x60;, &#x60;subscription_item_number&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;charged_through_date&#x60;, &#x60;recurring&#x60;, &#x60;price_id&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;overage&#x60;, &#x60;subscription_plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;processed_through_date&#x60;, &#x60;active&#x60;, &#x60;state&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt; | [optional] 
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

[**Order**](Order.md)

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


## CreateOrderPreview

> OrderPreviewResponse CreateOrderPreview (OrderPreviewCreateRequest orderPreviewCreateRequest, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Preview an order

Retrieves the preview of the order delta metrics and invoice items of a specified order. Preview for subscriptions and order line items are both supported. This operation is only an order preview and no order is created.       <p> Note that the following limitations apply to this operation:      <ul>       <li>Up to 50 subscriptions are allowed in a single call.</li>       <li>Up to 100 order line items are allowed in an order preview.</li>       </ul>

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CreateOrderPreviewExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(Configuration.Default);
            var orderPreviewCreateRequest = new OrderPreviewCreateRequest(); // OrderPreviewCreateRequest | 
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var async = true;  // bool? | Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. (optional)  (default to false)
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // Preview an order
                OrderPreviewResponse result = apiInstance.CreateOrderPreview(orderPreviewCreateRequest, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrderPreview: " + e.Message );
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
 **orderPreviewCreateRequest** | [**OrderPreviewCreateRequest**](OrderPreviewCreateRequest.md)|  | 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **async** | **bool?**| Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#39;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. | [optional] [default to false]
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**OrderPreviewResponse**](OrderPreviewResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Default Response |  * ratelimit-limit - The request limit quota for the time window closest to exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * ratelimit-remaining - The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * ratelimit-reset - The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * zuora-request-id - Zuoraâ€™s internal identifier for this request. <br>  * zuora-track-id - A user-supplied identifier for this request. If you supply a &#x60;zuora-track-id&#x60; as a request header, Zuora returns the &#x60;zuora-track-id&#x60; as a response header.  <br>  |
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


## DeleteOrder

> void DeleteOrder (string orderId, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Delete an order

Deletes an order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class DeleteOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(Configuration.Default);
            var orderId = orderId_example;  // string | Identifier for the order, either `order_number` or `order_id`
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var async = true;  // bool? | Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. (optional)  (default to false)
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // Delete an order
                apiInstance.DeleteOrder(orderId, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersApi.DeleteOrder: " + e.Message );
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
 **orderId** | **string**| Identifier for the order, either &#x60;order_number&#x60; or &#x60;order_id&#x60; | 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **async** | **bool?**| Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#39;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. | [optional] [default to false]
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Default Response |  * ratelimit-limit - The request limit quota for the time window closest to exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * ratelimit-remaining - The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * ratelimit-reset - The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. <br>  * zuora-request-id - Zuoraâ€™s internal identifier for this request. <br>  * zuora-track-id - A user-supplied identifier for this request. If you supply a &#x60;zuora-track-id&#x60; as a request header, Zuora returns the &#x60;zuora-track-id&#x60; as a response header.  <br>  |
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


## GetOrder

> Order GetOrder (string orderId, List<string> fields = null, List<string> orderActionsFields = null, List<string> subscriptionsFields = null, List<string> lineItemsFields = null, List<string> subscriptionPlansFields = null, List<string> subscriptionItemsFields = null, List<string> invoiceItemsFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Retrieve an order

Use this operation to retrieve the detailed information about a specific order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(Configuration.Default);
            var orderId = orderId_example;  // string | Identifier for the order, either `order_number` or `order_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `order_number`, `order_date`, `state`, `category`, `description`, `line_items`, `subscriptions`          </details> (optional) 
            var orderActionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `type`, `action_id`, `sequence`, `start_on`, `subscription_plans`, `renew`, `terms`, `cancel`, `pause`, `resume`, `order`          </details> (optional) 
            var subscriptionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `subscription_number`, `state`, `account_id`, `invoice_owner_account_id`, `auto_renew`, `version`, `initial_term`, `current_term`, `renewal_term`, `start_date`, `end_date`, `description`, `contract_effective`, `service_activation`, `customer_acceptance`, `invoice_separately`, `latest_version`, `payment_terms`, `billing_document_settings`, `bill_to_id`, `sold_to_id`, `contracted_mrr`, `actions`          </details> (optional) 
            var lineItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var subscriptionPlansFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `name`, `plan_id`, `subscription_id`, `product_id`, `subscription_items`          </details> (optional) 
            var subscriptionItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `start_date`, `end_date`, `charge_model`, `charge_type`, `tiers`, `subscription_item_number`, `name`, `description`, `charged_through_date`, `recurring`, `price_id`, `start_event`, `tax_code`, `tax_inclusive`, `unit_of_measure`, `quantity`, `price_base_interval`, `overage`, `subscription_plan_id`, `tiers_mode`, `processed_through_date`, `active`, `state`, `unit_amount`          </details> (optional) 
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
                // Retrieve an order
                Order result = apiInstance.GetOrder(orderId, fields, orderActionsFields, subscriptionsFields, lineItemsFields, subscriptionPlansFields, subscriptionItemsFields, invoiceItemsFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrder: " + e.Message );
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
 **orderId** | **string**| Identifier for the order, either &#x60;order_number&#x60; or &#x60;order_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;order_number&#x60;, &#x60;order_date&#x60;, &#x60;state&#x60;, &#x60;category&#x60;, &#x60;description&#x60;, &#x60;line_items&#x60;, &#x60;subscriptions&#x60;          &lt;/details&gt; | [optional] 
 **orderActionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;type&#x60;, &#x60;action_id&#x60;, &#x60;sequence&#x60;, &#x60;start_on&#x60;, &#x60;subscription_plans&#x60;, &#x60;renew&#x60;, &#x60;terms&#x60;, &#x60;cancel&#x60;, &#x60;pause&#x60;, &#x60;resume&#x60;, &#x60;order&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;subscription_number&#x60;, &#x60;state&#x60;, &#x60;account_id&#x60;, &#x60;invoice_owner_account_id&#x60;, &#x60;auto_renew&#x60;, &#x60;version&#x60;, &#x60;initial_term&#x60;, &#x60;current_term&#x60;, &#x60;renewal_term&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;description&#x60;, &#x60;contract_effective&#x60;, &#x60;service_activation&#x60;, &#x60;customer_acceptance&#x60;, &#x60;invoice_separately&#x60;, &#x60;latest_version&#x60;, &#x60;payment_terms&#x60;, &#x60;billing_document_settings&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;contracted_mrr&#x60;, &#x60;actions&#x60;          &lt;/details&gt; | [optional] 
 **lineItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionPlansFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;name&#x60;, &#x60;plan_id&#x60;, &#x60;subscription_id&#x60;, &#x60;product_id&#x60;, &#x60;subscription_items&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;tiers&#x60;, &#x60;subscription_item_number&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;charged_through_date&#x60;, &#x60;recurring&#x60;, &#x60;price_id&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;overage&#x60;, &#x60;subscription_plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;processed_through_date&#x60;, &#x60;active&#x60;, &#x60;state&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt; | [optional] 
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

[**Order**](Order.md)

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


## GetOrders

> OrderListResponse GetOrders (string cursor = null, List<string> expand = null, List<string> filter = null, List<string> sort = null, int? pageSize = null, List<string> fields = null, List<string> orderActionsFields = null, List<string> subscriptionsFields = null, List<string> lineItemsFields = null, List<string> subscriptionPlansFields = null, List<string> subscriptionItemsFields = null, List<string> invoiceItemsFields = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

List orders

Lists all or a subset of orders in your tenant.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetOrdersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(Configuration.Default);
            var cursor = cursor_example;  // string | A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with `next_page=W3sib3JkZXJ=`, your subsequent call can include `cursor=W3sib3JkZXJ=` in order to fetch the next page of the list. (optional) 
            var expand = new List<string>(); // List<string> | Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var filter = new List<string>(); // List<string> | A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var sort = new List<string>(); // List<string> | A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. `account_number.asc`) or descending (e.g. `account_number.desc`). You cannot sort on properties that are arrays. If the array-type properties are specified for the `sort[]` parameter, they are ignored. (optional) 
            var pageSize = 56;  // int? | The maximum number of results to return in a single page. If the specified `page_size` is less than 1 or greater than 99, Zuora will return a 400 error. (optional) 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `order_number`, `order_date`, `state`, `category`, `description`, `line_items`, `subscriptions`          </details> (optional) 
            var orderActionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `type`, `action_id`, `sequence`, `start_on`, `subscription_plans`, `renew`, `terms`, `cancel`, `pause`, `resume`, `order`          </details> (optional) 
            var subscriptionsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `subscription_number`, `state`, `account_id`, `invoice_owner_account_id`, `auto_renew`, `version`, `initial_term`, `current_term`, `renewal_term`, `start_date`, `end_date`, `description`, `contract_effective`, `service_activation`, `customer_acceptance`, `invoice_separately`, `latest_version`, `payment_terms`, `billing_document_settings`, `bill_to_id`, `sold_to_id`, `contracted_mrr`, `actions`          </details> (optional) 
            var lineItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var subscriptionPlansFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `name`, `plan_id`, `subscription_id`, `product_id`, `subscription_items`          </details> (optional) 
            var subscriptionItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `start_date`, `end_date`, `charge_model`, `charge_type`, `tiers`, `subscription_item_number`, `name`, `description`, `charged_through_date`, `recurring`, `price_id`, `start_event`, `tax_code`, `tax_inclusive`, `unit_of_measure`, `quantity`, `price_base_interval`, `overage`, `subscription_plan_id`, `tiers_mode`, `processed_through_date`, `active`, `state`, `unit_amount`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // List orders
                OrderListResponse result = apiInstance.GetOrders(cursor, expand, filter, sort, pageSize, fields, orderActionsFields, subscriptionsFields, lineItemsFields, subscriptionPlansFields, subscriptionItemsFields, invoiceItemsFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrders: " + e.Message );
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
 **cursor** | **string**| A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list. | [optional] 
 **expand** | [**List&lt;string&gt;**](string.md)| Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
 **filter** | [**List&lt;string&gt;**](string.md)| A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored. | [optional] 
 **pageSize** | **int?**| The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error. | [optional] 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;order_number&#x60;, &#x60;order_date&#x60;, &#x60;state&#x60;, &#x60;category&#x60;, &#x60;description&#x60;, &#x60;line_items&#x60;, &#x60;subscriptions&#x60;          &lt;/details&gt; | [optional] 
 **orderActionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;type&#x60;, &#x60;action_id&#x60;, &#x60;sequence&#x60;, &#x60;start_on&#x60;, &#x60;subscription_plans&#x60;, &#x60;renew&#x60;, &#x60;terms&#x60;, &#x60;cancel&#x60;, &#x60;pause&#x60;, &#x60;resume&#x60;, &#x60;order&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;subscription_number&#x60;, &#x60;state&#x60;, &#x60;account_id&#x60;, &#x60;invoice_owner_account_id&#x60;, &#x60;auto_renew&#x60;, &#x60;version&#x60;, &#x60;initial_term&#x60;, &#x60;current_term&#x60;, &#x60;renewal_term&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;description&#x60;, &#x60;contract_effective&#x60;, &#x60;service_activation&#x60;, &#x60;customer_acceptance&#x60;, &#x60;invoice_separately&#x60;, &#x60;latest_version&#x60;, &#x60;payment_terms&#x60;, &#x60;billing_document_settings&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;contracted_mrr&#x60;, &#x60;actions&#x60;          &lt;/details&gt; | [optional] 
 **lineItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionPlansFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;name&#x60;, &#x60;plan_id&#x60;, &#x60;subscription_id&#x60;, &#x60;product_id&#x60;, &#x60;subscription_items&#x60;          &lt;/details&gt; | [optional] 
 **subscriptionItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;tiers&#x60;, &#x60;subscription_item_number&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;charged_through_date&#x60;, &#x60;recurring&#x60;, &#x60;price_id&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;overage&#x60;, &#x60;subscription_plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;processed_through_date&#x60;, &#x60;active&#x60;, &#x60;state&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**OrderListResponse**](OrderListResponse.md)

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

