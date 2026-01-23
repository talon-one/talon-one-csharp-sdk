# TalonOneSdk.Model.UpdateCollectionsCatalog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The display name for the collection catalog. | [optional] 
**Description** | **string** | A longer, more detailed description of the collection catalog. | [optional] 
**Category** | **string** | Category used to group collection catalogs. | [optional] 
**Rules** | [**List&lt;CatalogRule&gt;**](CatalogRule.md) | Replaces the stored rules. Rules should only contain title (no description, as description is at the collection catalog level). | [optional] 
**CartItemFilters** | [**List&lt;CartItemFilterTemplate&gt;**](CartItemFilterTemplate.md) | Replaces the stored cart item filters. Cart item filters should only contain name (no description, as description is at the collection catalog level). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

