# TalonOne.Model.ScimUser
Schema definition for users that have been provisioned using the SCIM protocol with an identity provider, for example, Microsoft Entra ID.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | Unique identifier of the user. This is usually an email address. | 
**Id** | **string** | ID of the user. | 
**Active** | **bool** | Status of the user. | [optional] 
**DisplayName** | **string** | Display name of the user. | [optional] 
**Name** | [**ScimBaseUserName**](ScimBaseUserName.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

