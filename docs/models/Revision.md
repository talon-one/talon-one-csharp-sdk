# TalonOneSdk.Model.Revision

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints. | 
**AccountId** | **long** | The ID of the account that owns this entity. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**CampaignId** | **long** | The ID of the campaign that the revision was created from. | 
**Created** | **DateTime** | Timestamp when the revision was created. | 
**CreatedBy** | **long** | The ID of the user who created this revision. | 
**ActivateAt** | **DateTime** | Timestamp when the revision will be activated. | [optional] 
**ActivatedAt** | **DateTime** | Timestamp when this revision was activated. | [optional] 
**ActivatedBy** | **long** | The ID of the user who activated this revision. | [optional] 
**CurrentVersion** | [**RevisionVersion**](RevisionVersion.md) | The current version of this revision. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

