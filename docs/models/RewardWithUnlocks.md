# TalonOneSdk.Model.RewardWithUnlocks
A reward and details of each time a customer profile has unlocked it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The unique ID of the reward. | 
**IntegrationId** | **string** | A unique identifier used to reference the reward in API integrations. | 
**Name** | **string** | The customer-facing name of the reward. | 
**Rule** | [**RuleMetadata**](RuleMetadata.md) | Customer-facing rule metadata for the reward. | 
**Description** | **string** | Customer-facing description of the reward. | [optional] 
**Unlocked** | [**List&lt;CustomerReward&gt;**](CustomerReward.md) | The instances of this reward that the customer has unlocked but not used. Expired customer rewards are not returned. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

