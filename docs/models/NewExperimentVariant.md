# TalonOneSdk.Model.NewExperimentVariant

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this variant. | 
**Weight** | **long** | The percentage split of this variant. For &#x60;random&#x60; assignment, the split must be between 1 and 99 and the sum across all variants must equal 100. Ignored for &#x60;audience&#x60; and &#x60;external&#x60; assignment.  | 
**Ruleset** | [**NewRuleset**](NewRuleset.md) |  | 
**IsPrimary** | **bool** | **Deprecated.** Use &#x60;order&#x60; instead. Indicates whether this is the primary variant. This is computed as &#x60;order &#x3D;&#x3D; 0&#x60;.  | [optional] 
**Order** | **long** | The position of this variant in the experiment. The variant with &#x60;order: 0&#x60; is the primary variant. When omitted, the backend assigns order based on the array position.  | [optional] 
**AudienceId** | **long** | The ID of the audience this variant targets. Only used when the experiment &#x60;assignmentType&#x60; is &#x60;audience&#x60;.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

