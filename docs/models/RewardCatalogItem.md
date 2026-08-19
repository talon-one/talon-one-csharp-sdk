# TalonOneSdk.Model.RewardCatalogItem
A reward returned by the rewards catalog Integration API endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The unique ID of the reward. | 
**Name** | **string** | The customer-facing name of the reward. | 
**Rule** | [**RuleMetadata**](RuleMetadata.md) | Customer-facing rule metadata for the reward. | 
**Description** | **string** | The customer-facing description of the reward. | [optional] 
**PointsRequired** | [**List&lt;RewardPointsRequired&gt;**](RewardPointsRequired.md) | The loyalty points required to activate the reward. | [optional] 
**Eligibility** | [**RewardEligibility**](RewardEligibility.md) | The customer&#39;s eligibility for the reward. Returned only when the request includes a &#x60;profileIntegrationId&#x60; or &#x60;loyaltyCardId&#x60;.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

