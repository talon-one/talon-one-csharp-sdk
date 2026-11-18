# TalonOneSdk.Model.NewDigitalPass

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoyaltyProgramId** | **long** | The ID of the associated loyalty program. | 
**PassTemplateId** | **Guid** | The ID of the digital pass template used to generate the pass. | 
**ProfileIntegrationId** | **string** | The integration ID of the customer profile the pass is issued for. | 
**Platform** | **string** | The wallet platform the pass is generated for. Possible values:  - &#x60;apple&#x60;: The digital pass is generated for Apple Wallet. - &#x60;google&#x60;: The digital pass is generated for Google Wallet.  | 
**LoyaltyCardId** | **string** | The identifier of the loyalty card the pass is issued for.  **Note**: Only applicable for card-based loyalty programs.  | [optional] 
**Attributes** | **Dictionary&lt;string, string&gt;** | A map of placeholder values that you provide to fill in the pass template. Pass templates reference each value as &#x60;CustomerProfile.Attributes.&lt;key&gt;&#x60;.  Each key must start with a letter or an underscore and can contain only letters, digits, and underscores. If the template requires a value that is missing, the request fails with a &#x60;422&#x60; error.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

