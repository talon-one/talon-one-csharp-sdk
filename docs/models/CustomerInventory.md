# TalonOneSdk.Model.CustomerInventory

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**CustomerProfile**](CustomerProfile.md) |  | [optional] 
**Loyalty** | [**Loyalty**](Loyalty.md) |  | [optional] 
**Referrals** | [**List&lt;InventoryReferral&gt;**](InventoryReferral.md) |  | [optional] 
**Coupons** | [**List&lt;InventoryCoupon&gt;**](InventoryCoupon.md) | The coupons reserved by this profile. This array includes hard and soft reservations.  | [optional] 
**Giveaways** | [**List&lt;Giveaway&gt;**](Giveaway.md) |  | [optional] 
**Achievements** | [**List&lt;AchievementProgressWithDefinition&gt;**](AchievementProgressWithDefinition.md) | The customer&#39;s progress in each achievement they have participated in.  Only achievements the customer has started are included, whether they  are in progress, completed, or expired. Recurring achievements can appear  more than once, once per iteration.  | [optional] 
**Rewards** | [**List&lt;RewardWithUnlocks&gt;**](RewardWithUnlocks.md) | The rewards that the customer has unlocked but not used. Expired customer rewards are not returned. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

