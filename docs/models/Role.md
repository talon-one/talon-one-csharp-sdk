# TalonOne.Model.Role

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Modified** | **DateTime** | The time this entity was last modified. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**Name** | **string** | Name of the role. | 
**Acl** | **Object** | The &#x60;Access Control List&#x60; json defining the role of the user. This represents the access control on the user level. | 
**CampaignGroupID** | **long** | The ID of the [Campaign Group](https://docs.talon.one/docs/product/account/account-settings/managing-campaign-groups) this role was created for.  | [optional] 
**Description** | **string** | Description of the role. | [optional] 
**Members** | **List&lt;long&gt;** | A list of user identifiers assigned to this role. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

