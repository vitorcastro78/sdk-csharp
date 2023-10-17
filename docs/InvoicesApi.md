# Zuora.Api.InvoicesApi

All URIs are relative to *https://rest.sandbox.na.zuora.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelInvoice**](InvoicesApi.md#cancelinvoice) | **POST** /invoices/{invoice_id}/cancel | Cancel an invoice
[**CreateInvoice**](InvoicesApi.md#createinvoice) | **POST** /invoices | Create an invoice
[**DeleteInvoice**](InvoicesApi.md#deleteinvoice) | **DELETE** /invoices/{invoice_id} | Delete an invoice
[**EmailInvoice**](InvoicesApi.md#emailinvoice) | **POST** /invoices/{invoice_id}/email | Email an invoice
[**GetInvoice**](InvoicesApi.md#getinvoice) | **GET** /invoices/{invoice_id} | Retrieve an invoice
[**GetInvoiceItems**](InvoicesApi.md#getinvoiceitems) | **GET** /invoice_items | List invoice items
[**GetInvoices**](InvoicesApi.md#getinvoices) | **GET** /invoices | List invoices
[**PatchInvoice**](InvoicesApi.md#patchinvoice) | **PATCH** /invoices/{invoice_id} | Update an invoice
[**PayInvoice**](InvoicesApi.md#payinvoice) | **POST** /invoices/{invoice_id}/pay | Pay an invoice
[**PostInvoice**](InvoicesApi.md#postinvoice) | **POST** /invoices/{invoice_id}/post | Post an invoice
[**ReverseInvoice**](InvoicesApi.md#reverseinvoice) | **POST** /invoices/{invoice_id}/reverse | Reverse an invoice
[**UnpostInvoice**](InvoicesApi.md#unpostinvoice) | **POST** /invoices/{invoice_id}/unpost | Unpost an invoice
[**WriteOffInvoice**](InvoicesApi.md#writeoffinvoice) | **POST** /invoices/{invoice_id}/write-off | Write off an invoice



## CancelInvoice

> Invoice CancelInvoice (string invoiceId, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityId = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Cancel an invoice

Cancels an invoice. Only the invoice with the `draft` status can be canceled.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CancelInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
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
                // Cancel an invoice
                Invoice result = apiInstance.CancelInvoice(invoiceId, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.CancelInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Invoice**](Invoice.md)

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


## CreateInvoice

> Invoice CreateInvoice (InvoiceCreateRequest invoiceCreateRequest, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Create an invoice

Creates an invoice for a subscription.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class CreateInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceCreateRequest = new InvoiceCreateRequest(); // InvoiceCreateRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
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
                // Create an invoice
                Invoice result = apiInstance.CreateInvoice(invoiceCreateRequest, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoice: " + e.Message );
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
 **invoiceCreateRequest** | [**InvoiceCreateRequest**](InvoiceCreateRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Invoice**](Invoice.md)

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


## DeleteInvoice

> void DeleteInvoice (string invoiceId, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Delete an invoice

Deletes an invoice that has not been canceled.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class DeleteInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var async = true;  // bool? | Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. (optional)  (default to false)
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // Delete an invoice
                apiInstance.DeleteInvoice(invoiceId, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.DeleteInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
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


## EmailInvoice

> void EmailInvoice (string invoiceId, string zuoraTrackId = null, bool? async = null, string zuoraEntityId = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Email an invoice

Emails an email to your customer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class EmailInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var async = true;  // bool? | Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. (optional) 
            var zuoraEntityId = zuoraEntityId_example;  // string | An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // Email an invoice
                apiInstance.EmailInvoice(invoiceId, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.EmailInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **async** | **bool?**| Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#39;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID. | [optional] 
 **zuoraEntityId** | **string**| An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header. | [optional] 
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
| **204** | Default Response |  -  |
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


## GetInvoice

> Invoice GetInvoice (string invoiceId, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Retrieve an invoice

Retrieves the invoice with the given invoice ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
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
                // Retrieve an invoice
                Invoice result = apiInstance.GetInvoice(invoiceId, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **expand** | [**List&lt;string&gt;**](string.md)| Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. | [optional] 
 **filter** | [**List&lt;string&gt;**](string.md)| A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operaiton, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[subscription_id].EQ:8ad09e208858b5cf0188595208151c63&#x60; | [optional] 
 **pageSize** | **int?**| The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error. | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**Invoice**](Invoice.md)

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


## GetInvoiceItems

> InvoiceItemListResponse GetInvoiceItems (string cursor = null, List<string> expand = null, List<string> filter = null, List<string> sort = null, int? pageSize = null, List<string> fields = null, List<string> taxationItemsFields = null, List<string> lineItemFields = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

List invoice items

Retrieves information about all items of invoices.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetInvoiceItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var cursor = cursor_example;  // string | A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with `next_page=W3sib3JkZXJ=`, your subsequent call can include `cursor=W3sib3JkZXJ=` in order to fetch the next page of the list. (optional) 
            var expand = new List<string>(); // List<string> | Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var filter = new List<string>(); // List<string> | A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var sort = new List<string>(); // List<string> | A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. `account_number.asc`) or descending (e.g. `account_number.desc`). You cannot sort on properties that are arrays. If the array-type properties are specified for the `sort[]` parameter, they are ignored. (optional) 
            var pageSize = 56;  // int? | The maximum number of results to return in a single page. If the specified `page_size` is less than 1 or greater than 99, Zuora will return a 400 error. (optional) 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // List invoice items
                InvoiceItemListResponse result = apiInstance.GetInvoiceItems(cursor, expand, filter, sort, pageSize, fields, taxationItemsFields, lineItemFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceItems: " + e.Message );
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
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**InvoiceItemListResponse**](InvoiceItemListResponse.md)

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


## GetInvoices

> InvoiceListResponse GetInvoices (string cursor = null, List<string> expand = null, List<string> filter = null, List<string> sort = null, int? pageSize = null, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, string zuoraTrackId = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

List invoices

Returns a dictionary with a data property that contains an array of invoices, starting after cursor. Each entry in the array is a separate invoice object. If no more invoices are available, the resulting array will be empty.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var cursor = cursor_example;  // string | A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with `next_page=W3sib3JkZXJ=`, your subsequent call can include `cursor=W3sib3JkZXJ=` in order to fetch the next page of the list. (optional) 
            var expand = new List<string>(); // List<string> | Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://www.zuora.com/developer/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var filter = new List<string>(); // List<string> | A case-sensitive filter on the list. See the [Filter lists](https://www.zuora.com/developer/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions. (optional) 
            var sort = new List<string>(); // List<string> | A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. `account_number.asc`) or descending (e.g. `account_number.desc`). You cannot sort on properties that are arrays. If the array-type properties are specified for the `sort[]` parameter, they are ignored. (optional) 
            var pageSize = 56;  // int? | The maximum number of results to return in a single page. If the specified `page_size` is less than 1 or greater than 99, Zuora will return a 400 error. (optional) 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
            var zuoraTrackId = zuoraTrackId_example;  // string | A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote ('). (optional) 
            var zuoraEntityIds = zuoraEntityIds_example;  // string | An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 
            var contentEncoding = contentEncoding_example;  // string | Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). (optional) 

            try
            {
                // List invoices
                InvoiceListResponse result = apiInstance.GetInvoices(cursor, expand, filter, sort, pageSize, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoices: " + e.Message );
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
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
 **zuoraTrackId** | **string**| A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#39;). | [optional] 
 **zuoraEntityIds** | **string**| An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header. | [optional] 
 **idempotencyKey** | **string**| Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://www.zuora.com/developer/api-references/quickstart-api/tag/Idempotent-Requests/). | [optional] 
 **acceptEncoding** | **string**| Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 
 **contentEncoding** | **string**| Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://www.zuora.com/developer/api-references/quickstart-api/tag/Request-and-Response-Compression/). | [optional] 

### Return type

[**InvoiceListResponse**](InvoiceListResponse.md)

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


## PatchInvoice

> Invoice PatchInvoice (string invoiceId, InvoicePatchRequest invoicePatchRequest, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Update an invoice

Updates an invoice by setting the values of the specified fields. Any fields not provided in the request remain unchanged.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class PatchInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var invoicePatchRequest = new InvoicePatchRequest(); // InvoicePatchRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
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
                // Update an invoice
                Invoice result = apiInstance.PatchInvoice(invoiceId, invoicePatchRequest, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.PatchInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **invoicePatchRequest** | [**InvoicePatchRequest**](InvoicePatchRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Invoice**](Invoice.md)

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


## PayInvoice

> Invoice PayInvoice (string invoiceId, PayInvoiceRequest payInvoiceRequest, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Pay an invoice

Pays an invoice using an existing payment method.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class PayInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var payInvoiceRequest = new PayInvoiceRequest(); // PayInvoiceRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
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
                // Pay an invoice
                Invoice result = apiInstance.PayInvoice(invoiceId, payInvoiceRequest, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.PayInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **payInvoiceRequest** | [**PayInvoiceRequest**](PayInvoiceRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Invoice**](Invoice.md)

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


## PostInvoice

> Invoice PostInvoice (string invoiceId, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityId = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Post an invoice

Opens a draft invoice.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class PostInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
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
                // Post an invoice
                Invoice result = apiInstance.PostInvoice(invoiceId, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.PostInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Invoice**](Invoice.md)

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


## ReverseInvoice

> Invoice ReverseInvoice (string invoiceId, InvoiceReverseRequest invoiceReverseRequest, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Reverse an invoice

Reverses a posted invoice.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class ReverseInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var invoiceReverseRequest = new InvoiceReverseRequest(); // InvoiceReverseRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
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
                // Reverse an invoice
                Invoice result = apiInstance.ReverseInvoice(invoiceId, invoiceReverseRequest, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.ReverseInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **invoiceReverseRequest** | [**InvoiceReverseRequest**](InvoiceReverseRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Invoice**](Invoice.md)

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


## UnpostInvoice

> Invoice UnpostInvoice (string invoiceId, List<string> fields = null, List<string> invoiceItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> lineItemFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityId = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Unpost an invoice

Unposts an open invoice that has not been applied or refunded, and changes its `state` to `draft`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class UnpostInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `state`, `balance`, `due_date`, `invoice_number`, `posted_by_id`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `paid`, `past_due`, `document_date`, `amount_paid`, `amount_refunded`, `payment_terms`, `bill_to_id`, `sold_to_id`, `billing_document_settings`          </details> (optional) 
            var invoiceItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `booking_reference`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `invoice_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `accounting_code`, `service_end`, `service_start`, `accounts_receivable_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `amount_credited`, `amount_paid`, `remaining_balance`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
            var lineItemFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `total`, `subtotal`, `quantity_fulfilled`, `quantity_pending_fulfillment`, `unit_of_measure`, `accounting_code`, `adjustment_liability_account`, `unit_amount`, `target_date`, `billing_rule`, `contract_asset_account`, `contract_liability_account`, `description`, `discount_total`, `revenue`, `discount_unit_amount`, `discount_percent`, `category`, `name`, `item_number`, `type`, `list_price`, `list_unit_price`, `original_order_date`, `original_order_id`, `original_order_line_item_id`, `original_order_line_item_number`, `original_order_number`, `product_code`, `price_id`, `purchase_order_number`, `quantity`, `quantity_available_for_return`, `related_subscription_number`, `requires_fulfillment`, `sold_to_id`, `original_sold_to_id`, `tax_code`, `tax_inclusive`, `end_date`, `start_date`, `unbilled_receivables_account`, `state`, `order_id`          </details> (optional) 
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
                // Unpost an invoice
                Invoice result = apiInstance.UnpostInvoice(invoiceId, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.UnpostInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **invoiceItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
 **lineItemFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt; | [optional] 
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

[**Invoice**](Invoice.md)

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


## WriteOffInvoice

> CreditMemo WriteOffInvoice (string invoiceId, WriteOffRequest writeOffRequest, List<string> fields = null, List<string> appliedToFields = null, List<string> creditMemoItemsFields = null, List<string> taxationItemsFields = null, List<string> accountFields = null, List<string> billToFields = null, List<string> expand = null, List<string> filter = null, int? pageSize = null, string zuoraTrackId = null, bool? async = null, string zuoraEntityIds = null, string idempotencyKey = null, string acceptEncoding = null, string contentEncoding = null)

Write off an invoice

Writes off an invoice

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Zuora.Api;
using Zuora.Client;
using Zuora.Model;

namespace Example
{
    public class WriteOffInvoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.sandbox.na.zuora.com/v2";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(Configuration.Default);
            var invoiceId = invoiceId_example;  // string | Identifier for the invoices, either `invoice_number` or `invoice_id`
            var writeOffRequest = new WriteOffRequest(); // WriteOffRequest | 
            var fields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `credit_memo_number`, `state_transitions`, `description`, `account_id`, `total`, `subtotal`, `tax`, `document_date`, `exclude_from_auto_apply_rules`, `posted_by_id`, `state`, `balance`, `invoice_id`, `reason_code`, `amount_refunded`, `bill_to_id`, `billing_document_settings`          </details> (optional) 
            var appliedToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `id`, `amount`, `billing_document_id`, `billing_document_type`          </details> (optional) 
            var creditMemoItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `applied_to_item_id`, `price_id`, `discount_item`, `deferred_revenue_account`, `description`, `credit_memo_id`, `sku`, `name`, `purchase_order_number`, `quantity`, `recognized_revenue_account`, `remaining_balance`, `revenue_recognition_rule_name`, `service_end`, `service_start`, `accounts_receivable_account`, `on_account_account`, `subscription_id`, `subscription_item_id`, `tax`, `tax_code`, `tax_inclusive`, `unit_amount`, `unit_of_measure`, `subtotal`, `invoice_item_id`, `document_item_date`          </details> (optional) 
            var taxationItemsFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `amount`, `amount_exempt`, `tax_date`, `jurisdiction`, `location_code`, `name`, `sales_tax_payable_account`, `tax_code`, `tax_code_name`, `tax_rate`, `tax_rate_name`, `tax_inclusive`, `tax_rate_type`, `source_tax_item_id`, `amount_applied`, `amount_refunded`, `on_account_account`          </details> (optional) 
            var accountFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `auto_pay`, `account_number`, `bill_to_id`, `sold_to_id`, `billing_document_settings`, `communication_profile_id`, `crm_id`, `sales_rep`, `parent_account_id`, `payment_gateway`, `payment_terms`, `remaining_credit_memo_balance`, `remaining_debit_memo_balance`, `remaining_invoice_balance`, `remaining_payment_balance`, `sequence_set_id`, `tax_certificate`, `batch`, `tax_identifier`, `bill_cycle_day`, `description`, `name`, `currency`, `default_payment_method_id`, `enabled`          </details> (optional) 
            var billToFields = new List<string>(); // List<string> | Allows you to specify which fields are returned in the response.          <details>            <summary> Accepted values </summary>              `custom_fields`, `created_by_id`, `updated_by_id`, `created_time`, `id`, `updated_time`, `account_id`, `address`, `home_phone`, `first_name`, `last_name`, `email`, `work_email`, `nickname`, `other_phone`, `work_phone`, `mobile_phone`, `tax_region`, `other_phone_type`, `fax`          </details> (optional) 
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
                // Write off an invoice
                CreditMemo result = apiInstance.WriteOffInvoice(invoiceId, writeOffRequest, fields, appliedToFields, creditMemoItemsFields, taxationItemsFields, accountFields, billToFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvoicesApi.WriteOffInvoice: " + e.Message );
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
 **invoiceId** | **string**| Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoice_id&#x60; | 
 **writeOffRequest** | [**WriteOffRequest**](WriteOffRequest.md)|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;credit_memo_number&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;document_date&#x60;, &#x60;exclude_from_auto_apply_rules&#x60;, &#x60;posted_by_id&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;invoice_id&#x60;, &#x60;reason_code&#x60;, &#x60;amount_refunded&#x60;, &#x60;bill_to_id&#x60;, &#x60;billing_document_settings&#x60;          &lt;/details&gt; | [optional] 
 **appliedToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;          &lt;/details&gt; | [optional] 
 **creditMemoItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;credit_memo_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;on_account_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;subtotal&#x60;, &#x60;invoice_item_id&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt; | [optional] 
 **taxationItemsFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;source_tax_item_id&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;on_account_account&#x60;          &lt;/details&gt; | [optional] 
 **accountFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt; | [optional] 
 **billToFields** | [**List&lt;string&gt;**](string.md)| Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt; | [optional] 
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

[**CreditMemo**](CreditMemo.md)

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

