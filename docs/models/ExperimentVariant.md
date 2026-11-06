# TalonOneSdk.Model.ExperimentVariant

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Name** | **string** |  | 
**ExperimentId** | **long** |  | [optional] 
**Ruleset** | [**Ruleset**](Ruleset.md) |  | [optional] 
**Weight** | **long** |  | [optional] 
**IsPrimary** | **bool** | **Deprecated.** Use &#x60;order&#x60; instead. Indicates whether this is the primary variant. This is computed as &#x60;order &#x3D;&#x3D; 0&#x60;.  | [optional] 
**Order** | **long** | The position of this variant in the experiment. The variant with &#x60;order: 0&#x60; is the primary variant.  | [optional] 
**AudienceId** | **long** | The ID of the audience this variant targets. Only used when the experiment &#x60;assignmentType&#x60; is &#x60;audience&#x60;.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

