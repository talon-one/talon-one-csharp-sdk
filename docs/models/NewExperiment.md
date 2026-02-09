# TalonOneSdk.Model.NewExperiment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsVariantAssignmentExternal** | **bool** | The source of the assignment. - false - The assignment to the variant is handled internally by the Talon.Oneandled internally by the Talon.One. - true - The assignment to the variant handled externally.  | 
**Campaign** | [**NewCampaign**](NewCampaign.md) |  | 
**Activated** | **DateTime** | The date and time the experiment was activated.  | [optional] 
**State** | **string** | A disabled experiment is not evaluated for rules or coupons.  | [optional] [default to StateEnum.Disabled]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

