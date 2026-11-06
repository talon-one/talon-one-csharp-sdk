# TalonOneSdk.Model.BetweenCheckAttributeBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | A block discriminator of type &#x60;checkAttribute&#x60;. | 
**Operator** | **string** | The range comparison operator. Must be &#x60;between&#x60;. | 
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Attribute** | **Object** | The attribute path identifier (e.g. \&quot;$Session.Total\&quot;). | 
**Value** | **Object** | The comparison value for scalar operators. | [optional] 
**Min** | **Object** | The minimum value allowed for the &#x60;between&#x60; operator. | 
**Max** | **Object** | The maximum value allowed for the &#x60;between&#x60; operator. | 
**Start** | **Object** | The start value for the &#x60;within&#x60; operator. | [optional] 
**End** | **Object** | The end value for the &#x60;within&#x60; operator. | [optional] 
**StartInclusive** | **bool** | When &#x60;true&#x60;, the &#x60;start&#x60; value is included in the range for the &#x60;within&#x60; operator. | [optional] 
**EndInclusive** | **bool** | When &#x60;true&#x60;, the &#x60;end&#x60; value is included in the range for the &#x60;within&#x60; operator. | [optional] 
**TimezoneInsensitive** | **bool** | Indicates whether the &#x60;within&#x60; operator ignores time zones and compares the wall-clock time only. When &#x60;false&#x60;, time zones are taken into account. | [optional] 
**Values** | **Object** | The set of values to match against for list operators. For location operators (&#x60;in&#x60;, &#x60;not(in)&#x60;), an array of objects with a &#x60;geometry&#x60; (see &#x60;GeoJSONGeometry&#x60;) and an optional &#x60;name&#x60;, or a string reference to a list attribute. | [optional] 
**Count** | **Object** | The count threshold for &#x60;containsAtLeast&#x60; and &#x60;containsExactly&#x60; operators. | [optional] 
**OnFailure** | [**List&lt;Block&gt;**](Block.md) | Promotion blocks evaluated when this block fails or returns false. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

