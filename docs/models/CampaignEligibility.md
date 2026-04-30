# TalonOneSdk.Model.CampaignEligibility

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Unique ID of Campaign. | 
**ApplicationId** | **long** | The ID of the Application that owns this entity. | 
**Name** | **string** | The name of the campaign. | 
**Tags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**Features** | **List&lt;CampaignEligibility.FeaturesEnum&gt;** | The features enabled in this campaign. | 
**Eligibility** | [**List&lt;CampaignEligibilityDetails&gt;**](CampaignEligibilityDetails.md) | The customer&#39;s eligibility for each campaign in the current customer session. | 
**Description** | **string** | A detailed description of the campaign. | [optional] 
**StartTime** | **DateTime** | Timestamp when the campaign will become active. | [optional] 
**EndTime** | **DateTime** | Timestamp when the campaign will become inactive. | [optional] 
**Attributes** | **Object** | Arbitrary properties associated with this campaign. | [optional] 
**State** | **string** | The state of the campaign.  | [default to StateEnum.Enabled]
**Rules** | [**List&lt;RuleMetadata&gt;**](RuleMetadata.md) | A list of rules containing customer-facing details of the rewards defined in the campaign. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

