# TalonOneSdk.Model.StrikethroughCheckAttributeBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Operator** | **string** | The comparison operator applied to the attribute. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 
**Attribute** | **Object** |  | 
**Value** | **Object** |  | [optional] 
**Min** | **Object** |  | [optional] 
**Max** | **Object** |  | [optional] 
**Start** | **Object** |  | [optional] 
**End** | **Object** |  | [optional] 
**StartInclusive** | **bool** | When &#x60;true&#x60;, the &#x60;start&#x60; value is included in the range for the &#x60;within&#x60; operator. | [optional] 
**EndInclusive** | **bool** | When &#x60;true&#x60;, the &#x60;end&#x60; value is included in the range for the &#x60;within&#x60; operator. | [optional] 
**TimezoneInsensitive** | **bool** | Indicates whether the &#x60;within&#x60; operator ignores time zones and compares the wall-clock time only. When &#x60;false&#x60;, time zones are taken into account. | [optional] 
**Values** | **Object** |  | [optional] 
**Count** | **Object** |  | [optional] 
**OnFailure** | [**List&lt;StrikethroughBlock&gt;**](StrikethroughBlock.md) | Strikethrough blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

