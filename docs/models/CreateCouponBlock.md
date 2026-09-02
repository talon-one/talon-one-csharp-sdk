# TalonOneSdk.Model.CreateCouponBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**CampaignId** | [**CreateCouponBlock1CampaignId**](CreateCouponBlock1CampaignId.md) |  | 
**RecipientId** | **string** | The integration ID of the customer that is allowed to redeem this coupon. | 
**StoreInSession** | **bool** | When &#x60;true&#x60;, the coupon is stored in the session. | 
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**UsageLimit** | [**CreateCouponBlock1UsageLimit**](CreateCouponBlock1UsageLimit.md) |  | [optional] 
**DiscountLimit** | [**CreateCouponBlock1DiscountLimit**](CreateCouponBlock1DiscountLimit.md) |  | [optional] 
**StartDate** | **Object** | Timestamp at which point the coupon becomes valid. | [optional] 
**ExpiryDate** | **Object** | Expiration date of the coupon. Coupon never expires if this is omitted. | [optional] 
**Attributes** | **Object** | Custom attributes associated with this coupon code. | [optional] 
**ValidCharacters** | **string** | Characters used to generate the random parts of a code. | [optional] 
**Pattern** | **string** | The pattern used to generate codes, such as coupon codes, referral codes, and loyalty cards. The character &#x60;#&#x60; is a placeholder and is replaced by a random character from the &#x60;validCharacters&#x60; set.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

