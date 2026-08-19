# TalonOneSdk.Model.CheckTierBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Operator** | **string** | An indicator of how the block compares its elements. | 
**Subledger** | **string** | The name of the subledger to check the balance of. Can be empty if this block checks the loyalty program&#39;s main ledger balance instead of a subledger. | 
**Tier** | [**CheckTierBlock1Tier**](CheckTierBlock1Tier.md) |  | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 
**OnFailure** | [**List&lt;PromotionBlock&gt;**](PromotionBlock.md) | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

