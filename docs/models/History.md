# TalonOneSdk.Model.History

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The ID of the price record. | 
**ObservedAt** | **DateTime** | The date and time from which the price record is effective. | 
**ContextIds** | **List&lt;string&gt;** | The identifiers of the relevant context (the sales events, e.g. \&quot;Spring Sale\&quot;, \&quot;Summer Sale\&quot;) at the time from which the price record is effective. Includes the context IDs of any price adjustments and of the campaigns that influenced the final price.  | 
**Price** | **decimal** | Price of the item. | 
**Metadata** | [**BestPriorPriceMetadata**](BestPriorPriceMetadata.md) |  | 
**Target** | [**LabelTarget**](LabelTarget.md) |  | 
**ExcludedAt** | **DateTime** | The date and time when the price record was excluded. | [optional] 
**ExclusionReason** | **string** | The reason for excluding this price record. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

