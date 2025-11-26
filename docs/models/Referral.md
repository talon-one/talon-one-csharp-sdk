# TalonOne.Model.Referral

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**CampaignId** | **long** | ID of the campaign from which the referral received the referral code. | 
**AdvocateProfileIntegrationId** | **string** | The Integration ID of the Advocate&#39;s Profile. | 
**Code** | **string** | The referral code. | 
**UsageCounter** | **long** | The number of times this referral code has been successfully used. | 
**StartDate** | **DateTime** | Timestamp at which point the referral code becomes valid. | [optional] 
**ExpiryDate** | **DateTime** | Expiration date of the referral code. Referral never expires if this is omitted. | [optional] 
**UsageLimit** | **long** | The number of times a referral code can be used. &#x60;0&#x60; means no limit but any campaign usage limits will still apply.  | [optional] 
**FriendProfileIntegrationId** | **string** | An optional Integration ID of the Friend&#39;s Profile. | [optional] 
**Attributes** | **Object** | Arbitrary properties associated with this item. | [optional] 
**ImportId** | **long** | The ID of the Import which created this referral. | [optional] 
**BatchId** | **string** | The ID of the batch the referrals belong to. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

