# TalonOneSdk.Model.RedeemLoyaltyPointsBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Program** | [**RedeemLoyaltyPointsBlock1Program**](RedeemLoyaltyPointsBlock1Program.md) |  | 
**Subledger** | **string** | The name of the subledger to deduct points from. Can be empty if this block deducts from the loyalty program&#39;s main ledger instead of a subledger. | 
**Value** | [**RedeemLoyaltyPointsBlock1Value**](RedeemLoyaltyPointsBlock1Value.md) |  | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 
**Name** | **string** | A custom description recorded as the reason for the point deduction. | [optional] 
**OnFailure** | [**List&lt;PromotionBlock&gt;**](PromotionBlock.md) | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

