# TalonOneSdk.Model.CreateReferralBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**CampaignId** | [**CreateReferralBlock1CampaignId**](CreateReferralBlock1CampaignId.md) |  | 
**FriendId** | **string** | An optional integration ID of the friend&#39;s profile. | 
**StoreInSession** | **bool** | When &#x60;true&#x60;, the referral code is stored in the session. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 
**UsageLimit** | [**CreateReferralBlock1UsageLimit**](CreateReferralBlock1UsageLimit.md) |  | [optional] 
**StartDate** | **Object** |  | [optional] 
**ExpiryDate** | **Object** |  | [optional] 
**Attributes** | **Object** |  | [optional] 
**ValidCharacters** | **string** | Characters used to generate the random parts of a code. | [optional] 
**Pattern** | **string** | The pattern used to generate codes, such as coupon codes, referral codes, and loyalty cards. The character &#x60;#&#x60; is a placeholder and is replaced by a random character from the &#x60;validCharacters&#x60; set.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

