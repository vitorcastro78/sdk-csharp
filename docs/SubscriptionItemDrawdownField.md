
# Zuora.Model.SubscriptionItemDrawdownField

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**conversion_rate** | **decimal** | The conversion rate between usage unit of measure (UOM) and drawdown unit of measure for a drawdown charge.        **Note**:    &lt;ul&gt;    &lt;li&gt;Must be a positive number (&gt;0).&lt;/li&gt;    &lt;li&gt;Must be &#x60;1&#x60; when usage UOM and drawdown UOM are the same.&lt;/li&gt;     &lt;li&gt;If both &#x60;conversion_rate&#x60; and &#x60;unit_of_measure&#x60; for the drawdown are empty, the system will set default values respectively: &lt;ul&gt;      &lt;li&gt; &#x60;conversion_rate&#x60;: 1 &lt;/li&gt;      &lt;li&gt; &#x60;unit_of_measure&#x60;: Same as the usage UOM of this drawdown charge. &lt;/li&gt;&lt;/ul&gt;&lt;/li&gt;&lt;/ul&gt;        The &#x60;conversion_rate&#x60; and &#x60;unit_of_measure&#x60; fields need to have values or be empty at the same time.      | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

