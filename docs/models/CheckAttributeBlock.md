# TalonOneSdk.Model.CheckAttributeBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | A block discriminator of type &#x60;checkAttribute&#x60;. | 
**Operator** | **string** | The comparison operator applied to the attribute. | 
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Attribute** | **Object** | The attribute path identifier (e.g. \&quot;$Session.Total\&quot;). | 
**OnFailure** | [**List&lt;Block&gt;**](Block.md) | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

