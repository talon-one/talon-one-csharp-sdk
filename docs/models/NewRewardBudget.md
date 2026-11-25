# TalonOneSdk.Model.NewRewardBudget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The type of count that the budget keeps of how many times the reward has  been unlocked.   - &#x60;perReward&#x60;: Counts how many times the reward has been unlocked by all customers. - &#x60;perProfile&#x60;: Counts how many times each customer profile has unlocked the reward.  | 
**Period** | **string** | The time frame after which the budget count resets to &#x60;0&#x60;. If you select &#x60;overall&#x60;, the budget never resets.  The count resets at the start of each calendar time frame, not on the day the budget was created. For example, a &#x60;monthly&#x60; budget created on 20 October counts the unlocks from 20 to 31 October. On 1 November, the count resets to &#x60;0&#x60;.  | 
**Limit** | **long** | The maximum number of times the reward can be unlocked in the time frame. | 
**Metric** | **string** | The customer action that counts towards the budget. | [optional] [default to MetricEnum.Unlocks]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

