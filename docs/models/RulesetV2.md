# TalonOneSdk.Model.RulesetV2
Ruleset in the V2 JSON block format.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**UserId** | **long** | The ID of the user that created this ruleset. | 
**PromotionRules** | [**List&lt;PromotionRuleV2&gt;**](PromotionRuleV2.md) | Set of promotion rules. | 
**StrikethroughRules** | [**List&lt;StrikethroughRuleV2&gt;**](StrikethroughRuleV2.md) | Set of strikethrough rules. | 
**CampaignId** | **long** | The ID of the campaign that owns this entity. | [optional] 
**TemplateId** | **long** | The ID of the campaign template that owns this entity. | [optional] 
**ActivatedAt** | **DateTime** | Timestamp indicating when this ruleset was activated. | [optional] 
**Selectors** | [**List&lt;Selector&gt;**](Selector.md) | Variable bindings of type selector. | [optional] 
**Bundles** | [**List&lt;Bundle&gt;**](Bundle.md) | Variable bindings of type bundle. | [optional] 
**Parameters** | [**List&lt;TemplateParameter&gt;**](TemplateParameter.md) | Variable bindings of type template parameter. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

