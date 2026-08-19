# TalonOneSdk.Model.SelectorGroupBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | 
**Type** | **string** | A block discriminator of type &#x60;group&#x60;. | 
**Operator** | **string** | Logical operator applied across child blocks. &#x60;all&#x60; requires every child to pass, &#x60;atLeastOne&#x60; requires at least one, &#x60;none&#x60; requires all to fail. | 
**Blocks** | [**List&lt;SelectorBlock&gt;**](SelectorBlock.md) | Child predicate blocks evaluated according to the operator. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

