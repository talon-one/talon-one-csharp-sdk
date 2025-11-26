# TalonOne.Model.TemplateDef

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**Title** | **string** | Campaigner-friendly name for the template that will be shown in the rule editor. | 
**Category** | **string** | Used for grouping templates in the rule editor sidebar. | 
**Expr** | **List&lt;Object&gt;** | A Talang expression that contains variable bindings referring to args. | 
**Args** | [**List&lt;TemplateArgDef&gt;**](TemplateArgDef.md) | An array of argument definitions. | 
**Name** | **string** | The template name used in Talang. | 
**Description** | **string** | A short description of the template that will be shown in the rule editor. | [optional] 
**Help** | **string** | Extended help text for the template. | [optional] 
**Expose** | **bool** | A flag to control exposure in Rule Builder. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

