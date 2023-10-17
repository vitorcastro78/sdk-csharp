# Zuora.Api.PaymentSchedulesApi

All URIs are relative to *https://rest.sandbox.na.zuora.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPaymentSchedule**](PaymentSchedulesApi.md#cancelpaymentschedule) | **POST** /payment_schedules/{payment_schedule_id}/cancel | Cancel a payment schedule
[**CreatePaymentSchedule**](PaymentSchedulesApi.md#createpaymentschedule) | **POST** /payment_schedules | Create a payment schedule
[**GetPaymentSchedule**](PaymentSchedulesApi.md#getpaymentschedule) | **GET** /payment_schedules/{payment_schedule_id} | Retrieve a payment schedule
[**UpdatePaymentSchedule**](PaymentSchedulesApi.md#updatepaymentschedule) | **PATCH** /payment_schedules/{payment_schedule_id} | Update a payment schedule



## CancelPaymentSchedule

> PaymentSchedule CancelPaymentSchedule (string paymentScheduleId, PaymentScheduleCancel paymentScheduleCancel, List<string> fields = null, List<string> paymentScheduleItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Cancel a payment schedule

Cancels the payment schedule with the given ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CancelPaymentScheduleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentSchedulesApi(Configuration.Default);
            var paymentScheduleId = paymentScheduleId_example;  // string | Identifier for the payment schedule. Can be either `payment_schedule_number` or `payment_schedule_id`
            var paymentScheduleCancel = new PaymentScheduleCancel(); // PaymentScheduleCancel | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `description`, `next_payment_date`, `payment_schedule_number`, `number_of_payments`, `prepayment`, `start_date`, `run_hour`, `state`, `recent_payment_date`, `total_payments_errored`, `total_payments_processed`, `total_amount`, `debit_memo_id`, `invoice_id`          </details> (optional) 
            var paymentScheduleItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `balance`, `currency`, `debit_memo_id`, `invoice_id`, `payment_id`, `payment_method_id`, `description`, `prepayment`, `payment_gateway_id`, `run_hour`, `state`, `scheduled_date`, `payment_schedule_item_number`, `payment_schedule_id`, `cancellation_reason`, `error_message`, `payment_option_id`          </details> (optional) 
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
                // Cancel a payment schedule
                PaymentSchedule result = apiInstance.CancelPaymentSchedule(paymentScheduleId, paymentScheduleCancel, fields, paymentScheduleItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentSchedulesApi.CancelPaymentSchedule: " + e.Message );
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
 **paymentScheduleId** | **string**| Identifier for the payment schedule. Can be either &#x60;payment_schedule_number&#x60; or &#x60;payment_schedule_id&#x60; | 
 **paymentScheduleCancel** | [**PaymentScheduleCancel**](PaymentScheduleCancel.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt; | [optional] 
 **paymentScheduleItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt; | [optional] 
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

[**PaymentSchedule**](PaymentSchedule.md)

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


## CreatePaymentSchedule

> PaymentSchedule CreatePaymentSchedule (PaymentScheduleCreateRequest paymentScheduleCreateRequest, List<string> fields = null, List<string> paymentScheduleItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Create a payment schedule

Creates a new Payment Schedule object.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CreatePaymentScheduleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentSchedulesApi(Configuration.Default);
            var paymentScheduleCreateRequest = new PaymentScheduleCreateRequest(); // PaymentScheduleCreateRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `description`, `next_payment_date`, `payment_schedule_number`, `number_of_payments`, `prepayment`, `start_date`, `run_hour`, `state`, `recent_payment_date`, `total_payments_errored`, `total_payments_processed`, `total_amount`, `debit_memo_id`, `invoice_id`          </details> (optional) 
            var paymentScheduleItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `balance`, `currency`, `debit_memo_id`, `invoice_id`, `payment_id`, `payment_method_id`, `description`, `prepayment`, `payment_gateway_id`, `run_hour`, `state`, `scheduled_date`, `payment_schedule_item_number`, `payment_schedule_id`, `cancellation_reason`, `error_message`, `payment_option_id`          </details> (optional) 
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
                // Create a payment schedule
                PaymentSchedule result = apiInstance.CreatePaymentSchedule(paymentScheduleCreateRequest, fields, paymentScheduleItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentSchedulesApi.CreatePaymentSchedule: " + e.Message );
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
 **paymentScheduleCreateRequest** | [**PaymentScheduleCreateRequest**](PaymentScheduleCreateRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt; | [optional] 
 **paymentScheduleItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt; | [optional] 
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

[**PaymentSchedule**](PaymentSchedule.md)

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


## GetPaymentSchedule

> PaymentSchedule GetPaymentSchedule (string paymentScheduleId, List<string> fields = null, List<string> paymentScheduleItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Retrieve a payment schedule

Retrieves the payment schedule with the given ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetPaymentScheduleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentSchedulesApi(Configuration.Default);
            var paymentScheduleId = paymentScheduleId_example;  // string | Identifier for the payment schedule. Can be either `payment_schedule_number` or `payment_schedule_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `description`, `next_payment_date`, `payment_schedule_number`, `number_of_payments`, `prepayment`, `start_date`, `run_hour`, `state`, `recent_payment_date`, `total_payments_errored`, `total_payments_processed`, `total_amount`, `debit_memo_id`, `invoice_id`          </details> (optional) 
            var paymentScheduleItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `balance`, `currency`, `debit_memo_id`, `invoice_id`, `payment_id`, `payment_method_id`, `description`, `prepayment`, `payment_gateway_id`, `run_hour`, `state`, `scheduled_date`, `payment_schedule_item_number`, `payment_schedule_id`, `cancellation_reason`, `error_message`, `payment_option_id`          </details> (optional) 
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
                // Retrieve a payment schedule
                PaymentSchedule result = apiInstance.GetPaymentSchedule(paymentScheduleId, fields, paymentScheduleItemFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentSchedulesApi.GetPaymentSchedule: " + e.Message );
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
 **paymentScheduleId** | **string**| Identifier for the payment schedule. Can be either &#x60;payment_schedule_number&#x60; or &#x60;payment_schedule_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt; | [optional] 
 **paymentScheduleItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt; | [optional] 
 **expand** | [**List&lt;string&gt;**](string.md)| Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
 **filter** | [**List&lt;string&gt;**](string.md)| A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operaiton, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63&#x60; | [optional] 
 **pageSize** | **int?**| The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error. | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**PaymentSchedule**](PaymentSchedule.md)

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


## UpdatePaymentSchedule

> PaymentSchedule UpdatePaymentSchedule (string paymentScheduleId, PaymentSchedulePatchRequest paymentSchedulePatchRequest, List<string> fields = null, List<string> paymentScheduleItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Update a payment schedule

Updates the specified payment schedule by setting the values of the parameters passed. Any parameters not provided will remain unchanged.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class UpdatePaymentScheduleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentSchedulesApi(Configuration.Default);
            var paymentScheduleId = paymentScheduleId_example;  // string | Identifier for the payment schedule. Can be either `payment_schedule_number` or `payment_schedule_id`
            var paymentSchedulePatchRequest = new PaymentSchedulePatchRequest(); // PaymentSchedulePatchRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `description`, `next_payment_date`, `payment_schedule_number`, `number_of_payments`, `prepayment`, `start_date`, `run_hour`, `state`, `recent_payment_date`, `total_payments_errored`, `total_payments_processed`, `total_amount`, `debit_memo_id`, `invoice_id`          </details> (optional) 
            var paymentScheduleItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `balance`, `currency`, `debit_memo_id`, `invoice_id`, `payment_id`, `payment_method_id`, `description`, `prepayment`, `payment_gateway_id`, `run_hour`, `state`, `scheduled_date`, `payment_schedule_item_number`, `payment_schedule_id`, `cancellation_reason`, `error_message`, `payment_option_id`          </details> (optional) 
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
                // Update a payment schedule
                PaymentSchedule result = apiInstance.UpdatePaymentSchedule(paymentScheduleId, paymentSchedulePatchRequest, fields, paymentScheduleItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentSchedulesApi.UpdatePaymentSchedule: " + e.Message );
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
 **paymentScheduleId** | **string**| Identifier for the payment schedule. Can be either &#x60;payment_schedule_number&#x60; or &#x60;payment_schedule_id&#x60; | 
 **paymentSchedulePatchRequest** | [**PaymentSchedulePatchRequest**](PaymentSchedulePatchRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt; | [optional] 
 **paymentScheduleItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt; | [optional] 
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

[**PaymentSchedule**](PaymentSchedule.md)

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

