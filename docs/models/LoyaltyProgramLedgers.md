# TalonOneSdk.Model.LoyaltyProgramLedgers
Customer-specific information about loyalty points.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The internal ID of loyalty program. | 
**Title** | **string** | Visible name of loyalty program. | 
**Name** | **string** | Internal name of loyalty program. | 
**Ledger** | [**LedgerInfo**](LedgerInfo.md) | Information about the main ledger in the loyalty program. | 
**JoinDate** | **DateTime** | The date on which the customer joined the loyalty program in RFC3339.  **Note**: This is in the loyalty program&#39;s time zone.  | [optional] 
**SubLedgers** | [**Dictionary&lt;string, LedgerInfo&gt;**](LedgerInfo.md) | A map containing information about each loyalty subledger. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

