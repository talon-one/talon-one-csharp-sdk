# TalonOneSdk.Model.CreateCouponBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**CampaignId** | [**CreateCouponBlock1CampaignId**](CreateCouponBlock1CampaignId.md) |  | 
**RecipientId** | **string** | The integration ID of the customer that is allowed to redeem this coupon. | 
**StoreInSession** | **bool** | When &#x60;true&#x60;, the coupon is stored in the session. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 
**UsageLimit** | [**CreateCouponBlock1UsageLimit**](CreateCouponBlock1UsageLimit.md) |  | [optional] 
**DiscountLimit** | [**CreateCouponBlock1DiscountLimit**](CreateCouponBlock1DiscountLimit.md) |  | [optional] 
**StartDate** | **Object** |  | [optional] 
**ExpiryDate** | **Object** |  | [optional] 
**Attributes** | **Object** |  | [optional] 
**ValidCharacters** | **string** | Characters used to generate the random parts of a code. | [optional] 
**Pattern** | **string** | The pattern used to generate codes, such as coupon codes, referral codes, and loyalty cards. The character &#x60;#&#x60; is a placeholder and is replaced by a random character from the &#x60;validCharacters&#x60; set.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

