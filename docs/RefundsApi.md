# Zuora.Api.RefundsApi

All URIs are relative to *https://rest.sandbox.na.zuora.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelRefund**](RefundsApi.md#cancelrefund) | **POST** /refunds/{refund_id}/cancel | Cancel a refund
[**CreateRefund**](RefundsApi.md#createrefund) | **POST** /refunds | Create a refund
[**DeleteRefund**](RefundsApi.md#deleterefund) | **DELETE** /refunds/{refund_id} | Delete a refund
[**GetRefund**](RefundsApi.md#getrefund) | **GET** /refunds/{refund_id} | Retrieve a refund
[**GetRefunds**](RefundsApi.md#getrefunds) | **GET** /refunds | List refunds
[**UpdateRefund**](RefundsApi.md#updaterefund) | **PATCH** /refunds/{refund_id} | Update a refund



## CancelRefund

> Refund CancelRefund (string refundId, List<string> fields = null, List<string> accountFields = null, List<string> paymentMethodFields = null, List<string> appliedToFields = null, List<string> refundAppliedToItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityId = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Cancel a refund

Cancels an unapplied refund.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CancelRefundExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi(Configuration.Default);
            var refundId = refundId_example;  // string | Identifier for the payment, either `refund_number` or `refund_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `refund_date`, `external`, `gateway_id`, `gateway_reconciliation_reason`, `gateway_reconciliation_status`, `gateway_response`, `gateway_response_code`, `gateway_state`, `comment`, `payment_method_id`, `payout_id`, `reason_code`, `reference_id`, `refund_method_type`, `refund_number`, `statement_descriptor`, `statement_descriptor_phone`, `state`, `state_transitions`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var paymentMethodFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `type`, `account_id`, `bank_identification_number`, `device_session_id`, `ip_address`, `maximum_payment_attempts`, `payment_retry_interval`, `state`, `use_default_retry_rule`, `existing_mandate`, `last_failed_sale_transaction_time`, `last_transaction_time`, `last_transaction_status`, `number_of_consecutive_failures`, `total_number_of_processed_payments`, `total_number_of_error_payments`, `billing_details`, `card`, `apple_pay`, `google_pay`, `ach_debit`, `cc_ref`, `paypal_adaptive`, `paypal_express_native`, `paypal_express`, `sepa_debit`, `betalings_debit`, `autogiro_debit`, `bacs_debit`, `au_becs_debit`, `nz_becs_debit`, `pad_debit`          </details> (optional) 
            var appliedToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `billing_document_id`, `billing_document_type`          </details> (optional) 
            var refundAppliedToItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `credit_memo_item_id`, `taxation_item_id`          </details> (optional) 
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
                // Cancel a refund
                Refund result = apiInstance.CancelRefund(refundId, fields, accountFields, paymentMethodFields, appliedToFields, refundAppliedToItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RefundsApi.CancelRefund: " + e.Message );
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
 **refundId** | **string**| Identifier for the payment, either &#x60;refund_number&#x60; or &#x60;refund_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;refund_date&#x60;, &#x60;external&#x60;, &#x60;gateway_id&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;comment&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reason_code&#x60;, &#x60;reference_id&#x60;, &#x60;refund_method_type&#x60;, &#x60;refund_number&#x60;, &#x60;statement_descriptor&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **paymentMethodFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt; | [optional] 
 **appliedToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;          &lt;/details&gt; | [optional] 
 **refundAppliedToItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;credit_memo_item_id&#x60;, &#x60;taxation_item_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Refund**](Refund.md)

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


## CreateRefund

> Refund CreateRefund (RefundCreateRequest refundCreateRequest, List<string> fields = null, List<string> accountFields = null, List<string> paymentMethodFields = null, List<string> appliedToFields = null, List<string> refundAppliedToItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Create a refund

Creates a new refund object.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CreateRefundExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi(Configuration.Default);
            var refundCreateRequest = new RefundCreateRequest(); // RefundCreateRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `refund_date`, `external`, `gateway_id`, `gateway_reconciliation_reason`, `gateway_reconciliation_status`, `gateway_response`, `gateway_response_code`, `gateway_state`, `comment`, `payment_method_id`, `payout_id`, `reason_code`, `reference_id`, `refund_method_type`, `refund_number`, `statement_descriptor`, `statement_descriptor_phone`, `state`, `state_transitions`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var paymentMethodFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `type`, `account_id`, `bank_identification_number`, `device_session_id`, `ip_address`, `maximum_payment_attempts`, `payment_retry_interval`, `state`, `use_default_retry_rule`, `existing_mandate`, `last_failed_sale_transaction_time`, `last_transaction_time`, `last_transaction_status`, `number_of_consecutive_failures`, `total_number_of_processed_payments`, `total_number_of_error_payments`, `billing_details`, `card`, `apple_pay`, `google_pay`, `ach_debit`, `cc_ref`, `paypal_adaptive`, `paypal_express_native`, `paypal_express`, `sepa_debit`, `betalings_debit`, `autogiro_debit`, `bacs_debit`, `au_becs_debit`, `nz_becs_debit`, `pad_debit`          </details> (optional) 
            var appliedToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `billing_document_id`, `billing_document_type`          </details> (optional) 
            var refundAppliedToItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `credit_memo_item_id`, `taxation_item_id`          </details> (optional) 
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
                // Create a refund
                Refund result = apiInstance.CreateRefund(refundCreateRequest, fields, accountFields, paymentMethodFields, appliedToFields, refundAppliedToItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RefundsApi.CreateRefund: " + e.Message );
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
 **refundCreateRequest** | [**RefundCreateRequest**](RefundCreateRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;refund_date&#x60;, &#x60;external&#x60;, &#x60;gateway_id&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;comment&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reason_code&#x60;, &#x60;reference_id&#x60;, &#x60;refund_method_type&#x60;, &#x60;refund_number&#x60;, &#x60;statement_descriptor&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **paymentMethodFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt; | [optional] 
 **appliedToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;          &lt;/details&gt; | [optional] 
 **refundAppliedToItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;credit_memo_item_id&#x60;, &#x60;taxation_item_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Refund**](Refund.md)

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


## DeleteRefund

> void DeleteRefund (string refundId, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Delete a refund

Permanently deletes a refund. Note that once you have deleted a refund, it cannot be undone.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class DeleteRefundExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi(Configuration.Default);
            var refundId = refundId_example;  // string | Identifier for the payment, either `refund_number` or `refund_id`
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var async = true;  // bool? | Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. (optional)  (default to false)
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // Delete a refund
                apiInstance.DeleteRefund(refundId, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RefundsApi.DeleteRefund: " + e.Message );
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
 **refundId** | **string**| Identifier for the payment, either &#x60;refund_number&#x60; or &#x60;refund_id&#x60; | 
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


## GetRefund

> Refund GetRefund (string refundId, List<string> fields = null, List<string> accountFields = null, List<string> paymentMethodFields = null, List<string> appliedToFields = null, List<string> refundAppliedToItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Retrieve a refund

Retrieves the refund with the given ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetRefundExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi(Configuration.Default);
            var refundId = refundId_example;  // string | Identifier for the payment, either `refund_number` or `refund_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `refund_date`, `external`, `gateway_id`, `gateway_reconciliation_reason`, `gateway_reconciliation_status`, `gateway_response`, `gateway_response_code`, `gateway_state`, `comment`, `payment_method_id`, `payout_id`, `reason_code`, `reference_id`, `refund_method_type`, `refund_number`, `statement_descriptor`, `statement_descriptor_phone`, `state`, `state_transitions`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var paymentMethodFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `type`, `account_id`, `bank_identification_number`, `device_session_id`, `ip_address`, `maximum_payment_attempts`, `payment_retry_interval`, `state`, `use_default_retry_rule`, `existing_mandate`, `last_failed_sale_transaction_time`, `last_transaction_time`, `last_transaction_status`, `number_of_consecutive_failures`, `total_number_of_processed_payments`, `total_number_of_error_payments`, `billing_details`, `card`, `apple_pay`, `google_pay`, `ach_debit`, `cc_ref`, `paypal_adaptive`, `paypal_express_native`, `paypal_express`, `sepa_debit`, `betalings_debit`, `autogiro_debit`, `bacs_debit`, `au_becs_debit`, `nz_becs_debit`, `pad_debit`          </details> (optional) 
            var appliedToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `billing_document_id`, `billing_document_type`          </details> (optional) 
            var refundAppliedToItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `credit_memo_item_id`, `taxation_item_id`          </details> (optional) 
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
                // Retrieve a refund
                Refund result = apiInstance.GetRefund(refundId, fields, accountFields, paymentMethodFields, appliedToFields, refundAppliedToItemFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RefundsApi.GetRefund: " + e.Message );
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
 **refundId** | **string**| Identifier for the payment, either &#x60;refund_number&#x60; or &#x60;refund_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;refund_date&#x60;, &#x60;external&#x60;, &#x60;gateway_id&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;comment&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reason_code&#x60;, &#x60;reference_id&#x60;, &#x60;refund_method_type&#x60;, &#x60;refund_number&#x60;, &#x60;statement_descriptor&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **paymentMethodFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt; | [optional] 
 **appliedToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;          &lt;/details&gt; | [optional] 
 **refundAppliedToItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;credit_memo_item_id&#x60;, &#x60;taxation_item_id&#x60;          &lt;/details&gt; | [optional] 
 **expand** | [**List&lt;string&gt;**](string.md)| Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
 **filter** | [**List&lt;string&gt;**](string.md)| A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operaiton, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63&#x60; | [optional] 
 **pageSize** | **int?**| The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error. | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**Refund**](Refund.md)

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


## GetRefunds

> RefundListResponse GetRefunds (string cursor = null, List<string> expand = null, List<string> filter = null, List<string> sort = null, int? pageSize = null, List<string> fields = null, List<string> accountFields = null, List<string> paymentMethodFields = null, List<string> appliedToFields = null, List<string> refundAppliedToItemFields = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

List refunds

Returns a dictionary with a data property that contains an array of refunds, starting after cursor. Each entry in the array is a separate  object. If no more  are available, the resulting array will be empty. This request should never return an error.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetRefundsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi(Configuration.Default);
            var cursor = cursor_example;  // string | A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with `next_page=W3sib3JkZXJ=`, your subsequent call can include `cursor=W3sib3JkZXJ=` in order to fetch the next page of the list. (optional) 
            var expand = new List<string>(); // List<string> | Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var filter = new List<string>(); // List<string> | A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var sort = new List<string>(); // List<string> | A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. `account_number.asc`) or descending (e.g. `account_number.desc`). You cannot sort on properties that are arrays. If the array-type properties are specified for the `sort[]` parameter, they are ignored. (optional) 
            var pageSize = 56;  // int? | The maximum number of results to return in a single page. If the specified `page_size` is less than 1 or greater than 99, Zuora will return a 400 error. (optional) 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `refund_date`, `external`, `gateway_id`, `gateway_reconciliation_reason`, `gateway_reconciliation_status`, `gateway_response`, `gateway_response_code`, `gateway_state`, `comment`, `payment_method_id`, `payout_id`, `reason_code`, `reference_id`, `refund_method_type`, `refund_number`, `statement_descriptor`, `statement_descriptor_phone`, `state`, `state_transitions`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var paymentMethodFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `type`, `account_id`, `bank_identification_number`, `device_session_id`, `ip_address`, `maximum_payment_attempts`, `payment_retry_interval`, `state`, `use_default_retry_rule`, `existing_mandate`, `last_failed_sale_transaction_time`, `last_transaction_time`, `last_transaction_status`, `number_of_consecutive_failures`, `total_number_of_processed_payments`, `total_number_of_error_payments`, `billing_details`, `card`, `apple_pay`, `google_pay`, `ach_debit`, `cc_ref`, `paypal_adaptive`, `paypal_express_native`, `paypal_express`, `sepa_debit`, `betalings_debit`, `autogiro_debit`, `bacs_debit`, `au_becs_debit`, `nz_becs_debit`, `pad_debit`          </details> (optional) 
            var appliedToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `billing_document_id`, `billing_document_type`          </details> (optional) 
            var refundAppliedToItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `credit_memo_item_id`, `taxation_item_id`          </details> (optional) 
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // List refunds
                RefundListResponse result = apiInstance.GetRefunds(cursor, expand, filter, sort, pageSize, fields, accountFields, paymentMethodFields, appliedToFields, refundAppliedToItemFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RefundsApi.GetRefunds: " + e.Message );
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
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;refund_date&#x60;, &#x60;external&#x60;, &#x60;gateway_id&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;comment&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reason_code&#x60;, &#x60;reference_id&#x60;, &#x60;refund_method_type&#x60;, &#x60;refund_number&#x60;, &#x60;statement_descriptor&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **paymentMethodFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt; | [optional] 
 **appliedToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;          &lt;/details&gt; | [optional] 
 **refundAppliedToItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;credit_memo_item_id&#x60;, &#x60;taxation_item_id&#x60;          &lt;/details&gt; | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**RefundListResponse**](RefundListResponse.md)

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


## UpdateRefund

> Refund UpdateRefund (string refundId, RefundPatchRequest refundPatchRequest, List<string> fields = null, List<string> accountFields = null, List<string> paymentMethodFields = null, List<string> appliedToFields = null, List<string> refundAppliedToItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Update a refund

Updates the specified refund by setting the values of the parameters passed. Any parameters not provided will be left unchanged.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class UpdateRefundExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefundsApi(Configuration.Default);
            var refundId = refundId_example;  // string | Identifier for the payment, either `refund_number` or `refund_id`
            var refundPatchRequest = new RefundPatchRequest(); // RefundPatchRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `amount`, `refund_date`, `external`, `gateway_id`, `gateway_reconciliation_reason`, `gateway_reconciliation_status`, `gateway_response`, `gateway_response_code`, `gateway_state`, `comment`, `payment_method_id`, `payout_id`, `reason_code`, `reference_id`, `refund_method_type`, `refund_number`, `statement_descriptor`, `statement_descriptor_phone`, `state`, `state_transitions`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var paymentMethodFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `type`, `account_id`, `bank_identification_number`, `device_session_id`, `ip_address`, `maximum_payment_attempts`, `payment_retry_interval`, `state`, `use_default_retry_rule`, `existing_mandate`, `last_failed_sale_transaction_time`, `last_transaction_time`, `last_transaction_status`, `number_of_consecutive_failures`, `total_number_of_processed_payments`, `total_number_of_error_payments`, `billing_details`, `card`, `apple_pay`, `google_pay`, `ach_debit`, `cc_ref`, `paypal_adaptive`, `paypal_express_native`, `paypal_express`, `sepa_debit`, `betalings_debit`, `autogiro_debit`, `bacs_debit`, `au_becs_debit`, `nz_becs_debit`, `pad_debit`          </details> (optional) 
            var appliedToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `billing_document_id`, `billing_document_type`          </details> (optional) 
            var refundAppliedToItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `credit_memo_item_id`, `taxation_item_id`          </details> (optional) 
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
                // Update a refund
                Refund result = apiInstance.UpdateRefund(refundId, refundPatchRequest, fields, accountFields, paymentMethodFields, appliedToFields, refundAppliedToItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RefundsApi.UpdateRefund: " + e.Message );
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
 **refundId** | **string**| Identifier for the payment, either &#x60;refund_number&#x60; or &#x60;refund_id&#x60; | 
 **refundPatchRequest** | [**RefundPatchRequest**](RefundPatchRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;refund_date&#x60;, &#x60;external&#x60;, &#x60;gateway_id&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;comment&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reason_code&#x60;, &#x60;reference_id&#x60;, &#x60;refund_method_type&#x60;, &#x60;refund_number&#x60;, &#x60;statement_descriptor&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;state_transitions&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **paymentMethodFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt; | [optional] 
 **appliedToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;          &lt;/details&gt; | [optional] 
 **refundAppliedToItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;credit_memo_item_id&#x60;, &#x60;taxation_item_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Refund**](Refund.md)

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

