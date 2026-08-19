# TalonOneSdk.Model.CheckBudgetBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Operator** | **string** | The comparison operator applied to the limit. &#x60;available&#x60; checks if there is budget available for a given limitable action; &#x60;enoughFor&#x60; checks if the available budget meets or exceeds a specific value limit. | 
**Action** | **string** | The limitable action to check. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 
**Value** | **decimal** | The value to check against when using the &#x60;enoughFor&#x60; operator. | [optional] 
**OnFailure** | [**List&lt;PromotionBlock&gt;**](PromotionBlock.md) | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

