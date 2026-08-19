# TalonOneSdk.Model.CheckAchievementBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Operator** | **string** | The comparison operator applied to the achievement. | 
**Achievement** | [**CheckAchievementBlock1Achievement**](CheckAchievementBlock1Achievement.md) |  | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 
**OnFailure** | [**List&lt;PromotionBlock&gt;**](PromotionBlock.md) | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

