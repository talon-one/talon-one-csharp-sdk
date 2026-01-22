# TalonOneSdk.Model.CollectionsCatalog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this collection. | 
**AccountId** | **long** | The ID of the account that owns this collection. | 
**ApplicationId** | **long** | The ID of the Application that owns this collection. | 
**Title** | **string** | A short description of the collection catalog. | 
**Category** | **string** | Category used to group collection catalogs. | 
**Source** | **string** | Indicates whether the collection is custom or shipped by Talon.One. | 
**Rules** | [**List&lt;CatalogRule&gt;**](CatalogRule.md) | Array of rule templates in this collection catalog. Rules only contain title (no description, as description is at the collection catalog level). | 
**CartItemFilters** | [**List&lt;CartItemFilterTemplate&gt;**](CartItemFilterTemplate.md) | Array of cart item filter templates in this collection catalog. Cart item filters only contain name (no description, as description is at the collection catalog level). | 
**Created** | **DateTime** | Timestamp when the collection was created. | 
**CreatedBy** | **long** | ID of the user who created the collection. | 
**Description** | **string** | A longer, more detailed description of the collection catalog. | [optional] 
**Modified** | **DateTime** | Timestamp when the collection was last updated. | [optional] 
**ModifiedBy** | **long** | ID of the user who last updated the collection. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

