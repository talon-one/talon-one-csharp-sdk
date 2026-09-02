# TalonOneSdk.Model.TriggerWebhookBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Webhook** | [**TriggerWebhookBlock1Webhook**](TriggerWebhookBlock1Webhook.md) |  | 
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Params** | **Dictionary&lt;string, Object&gt;** | The webhook&#39;s parameters, in configured order. Each property name is the parameter&#39;s title, lowercased with spaces replaced by underscores (for example, &#x60;Order ID&#x60; becomes &#x60;order_id&#x60;); falls back to &#x60;param_0&#x60;, &#x60;param_1&#x60;, and so on if a title is blank or collides with another. | [optional] 
**OnError** | **Dictionary&lt;string, List&lt;Block&gt;&gt;** | Named error handlers evaluated when a specific error occurs. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

