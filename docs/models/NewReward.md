# TalonOneSdk.Model.NewReward

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the reward. | 
**ApiName** | **string** | A unique identifier used to reference the reward in API integrations. | 
**ApplicationIds** | **List&lt;long&gt;** | The IDs of the Applications this reward is connected to.   **Note**: Currently, a reward can only be connected to one Application.  | 
**Sandbox** | **bool** | Indicates if this is a live or sandbox reward. Rewards of a given type can only be connected to Applications of the same type. | 
**Description** | **string** | A description of the reward. | [optional] 
**Rule** | [**List&lt;Rule&gt;**](Rule.md) | Rule to apply. | [optional] 
**Bindings** | [**List&lt;Binding&gt;**](Binding.md) | A list of named variables created before the reward&#39;s rules are evaluated.  Each binding pairs a name with a talang expression. The expression is evaluated once  and its result is available by name in any rule condition or effect. Bindings must be defined outside of individual rules. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

