# TalonOneSdk.Model.UpdateAttributeValueBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Operator** | **string** | The update operation applied to the attribute. | 
**Attribute** | [**UpdateAttributeValueBlock1Attribute**](UpdateAttributeValueBlock1Attribute.md) |  | 
**Target** | [**UpdateAttributeValueBlock1Target**](UpdateAttributeValueBlock1Target.md) |  | 
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 
**Value** | **Object** | The value of the attribute. Omitted when operator is set to &#x60;toggle&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

