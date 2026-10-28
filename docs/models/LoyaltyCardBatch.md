# TalonOneSdk.Model.LoyaltyCardBatch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumberOfCards** | **long** | Number of loyalty cards in the batch. | 
**BatchId** | **string** | ID of the loyalty card batch. | [optional] 
**Status** | **string** | Status of the loyalty cards in the batch. | [optional] [default to StatusEnum.Active]
**Attributes** | **Object** | Set values for the [custom attributes](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes) of a loyalty card. These attributes must be created in the Campaign Manager before their values can be updated through this endpoint.  | [optional] 
**CardCodeSettings** | [**CodeGeneratorSettings**](CodeGeneratorSettings.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

