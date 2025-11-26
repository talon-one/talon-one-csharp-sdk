# TalonOne.Model.AddLoyaltyPointsEffectProps
The properties specific to the \"addLoyaltyPoints\" effect. This gets triggered whenever a validated rule contained an \"add loyalty\" effect. These points are automatically stored and managed inside Talon.One. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name / description of this loyalty point addition. | 
**ProgramId** | **long** | The ID of the loyalty program where these points were added. | 
**SubLedgerId** | **string** | The ID of the subledger within the loyalty program where these points were added. | 
**Value** | **decimal** | The amount of points that were added. | 
**RecipientIntegrationId** | **string** | The user for whom these points were added. | 
**TransactionUUID** | **string** | The identifier of this addition in the loyalty ledger. | 
**DesiredValue** | **decimal** | The original amount of loyalty points to be awarded. | [optional] 
**StartDate** | **DateTime** | Date after which points will be valid. | [optional] 
**ExpiryDate** | **DateTime** | Date after which points will expire. | [optional] 
**CartItemPosition** | **decimal** | The index of the item in the cart items list on which the loyal points addition should be applied. | [optional] 
**CartItemSubPosition** | **decimal** | For cart items with &#x60;quantity&#x60; &gt; 1, the sub position indicates to which item the loyalty points addition is applied.  | [optional] 
**CardIdentifier** | **string** | The alphanumeric identifier of the loyalty card.  | [optional] 
**BundleIndex** | **long** | The position of the bundle in a list of item bundles created from the same bundle definition. | [optional] 
**BundleName** | **string** | The name of the bundle definition. | [optional] 
**AwaitsActivation** | **bool** | If &#x60;true&#x60;, the loyalty points are pending until  action-based activation takes place. The &#x60;startDate&#x60; parameter automatically  defaults to &#x60;on_action&#x60;.  | [optional] 
**ValidityDuration** | **string** | The duration for which the points remain active, relative to the  activation date. Example: &#x60;30D&#x60;.   **Note**: This value is only returned if &#x60;awaitsActivation&#x60; is &#x60;true&#x60;  and &#x60;expiryDate&#x60; is not set.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

