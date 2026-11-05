# TalonOneSdk.Model.BestPriorPrice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The ID of the price record. | 
**Sku** | **string** | sku | 
**ObservedAt** | **DateTime** | The date and time when the price change was recorded. | 
**ContextIds** | **List&lt;string&gt;** | The identifiers of the relevant context (the sales events, e.g. \&quot;Spring Sale\&quot;, \&quot;Summer Sale\&quot;) at the time the price change was recorded. Includes the context IDs of any price adjustments and of the campaigns that influenced the final price.  | 
**Price** | **decimal** | Price of the item. | 
**Metadata** | [**BestPriorPriceMetadata**](BestPriorPriceMetadata.md) |  | 
**Target** | [**LabelTarget**](LabelTarget.md) |  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

