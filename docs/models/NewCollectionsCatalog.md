# TalonOneSdk.Model.NewCollectionsCatalog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The display name for the collection catalog. | 
**Description** | **string** | A longer, more detailed description of the collection catalog. | [optional] 
**Category** | **string** | Category used to group collection catalogs. | [optional] [default to CategoryEnum.Custom]
**Rules** | [**List&lt;CatalogRule&gt;**](CatalogRule.md) | Array of rules to store in this collection catalog. Rules should only contain title (no description, as description is at the collection catalog level). At least one rule or cart item filter is required. | [optional] 
**CartItemFilters** | [**List&lt;CartItemFilterTemplate&gt;**](CartItemFilterTemplate.md) | Array of cart item filters to store in this collection catalog. If not provided, will be extracted from the rules. Cart item filters should only contain name (no description, as description is at the collection catalog level). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

