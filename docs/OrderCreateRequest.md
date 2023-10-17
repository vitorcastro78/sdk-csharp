
# Zuora.Model.OrderCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**category** | **string** | Category of the order to indicate a product sale or return. Default value is &#x60;sale&#x60;. | [optional] 
**custom_objects** | **Dictionary&lt;string, Object&gt;** | The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields). | [optional] [readonly] 
**custom_fields** | **Dictionary&lt;string, Object&gt;** | Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format. | [optional] 
**description** | **string** | An arbitrary string attached to the object. Often useful for displaying to users. | [optional] 
**account_number** | **string** | Human-readable identifier of the account. It can be user-supplied. | [optional] 
**account_id** | **string** | Identifier of the account. | [optional] 
**account_data** | [**AccountCreateRequest**](AccountCreateRequest.md) | The information of the new account that owns the subscription. The subscription owner account can be different from the invoice owner account. If you specify this field, do not specify &#x60;account_id&#x60;. | [optional] 
**order_date** | **DateTime** | The date when the order is signed. All the order actions under this order will use this order date as the contract effective date if the contract effective date field is skipped or its value is left as null. | [optional] 
**order_number** | **string** | The order number of the new order. If not provided, system will auto-generate a number for this order.     Note: Ensure that the order number does not contain a slash. | [optional] 
**line_items** | [**List&lt;LineItemCreateRequest&gt;**](LineItemCreateRequest.md) | Order line items are non-subscription-based items created by an order, representing transactional charges such as one-time fees, physical goods, or professional service charges that are not sold as subscription services.    By specifying this field, you can launch non-subscription and unified monetization business models in Zuora, in addition to subscription business models. | [optional] 
**processing_options** | [**OrdersProcessingOption**](OrdersProcessingOption.md) |  | [optional] 
**subscriptions** | [**List&lt;PostSubscriptionOrderRequest&gt;**](PostSubscriptionOrderRequest.md) | Based on the intended order action, each item should include specific fields.     For example, to create a new subscription for a new account, you must specify the &#x60;account_data&#x60; and &#x60;subscription_plans&#x60; fields at a minimum. | [optional] 
**state** | **string** | The status of the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

