
# Zuora.Model.ResponseHeaders

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ratelimit_limit** | **string** | The request limit quota for the time window closest to exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. | [optional] 
**ratelimit_remaining** | **decimal** | The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. | [optional] 
**ratelimit_reset** | **decimal** | The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information. | [optional] 
**zuora_request_id** | **string** | Zuoraâ€™s internal identifier for this request. | [optional] 
**zuora_track_id** | **string** | A user-supplied identifier for this request. If you supply a &#x60;zuora-track-id&#x60; as a request header, Zuora returns the &#x60;zuora-track-id&#x60; as a response header.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

