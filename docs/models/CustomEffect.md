# TalonOne.Model.CustomEffect

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**ApplicationIds** | **List&lt;long&gt;** | The IDs of the Applications that are related to this entity. | 
**Name** | **string** | The name of this effect. | 
**Title** | **string** | The title of this effect. | 
**Payload** | **string** | The JSON payload of this effect. | 
**Enabled** | **bool** | Determines if this effect is active. | 
**CreatedBy** | **long** | ID of the user who created this effect. | 
**IsPerItem** | **bool** | Indicates if this effect is per item or not. | [optional] 
**Description** | **string** | The description of this effect. | [optional] 
**Params** | [**List&lt;TemplateArgDef&gt;**](TemplateArgDef.md) | Array of template argument definitions. | [optional] 
**ModifiedBy** | **long** | ID of the user who last updated this effect if available. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

