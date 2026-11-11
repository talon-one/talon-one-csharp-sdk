# TalonOneSdk.Model.WebhookAuthenticationBasic
A webhook authentication that uses Basic HTTP authentication.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the webhook authentication. | 
**Type** | **string** | A webhook authentication discriminator of type &#x60;basic&#x60;. | 
**Data** | [**WebhookAuthenticationDataBasic**](WebhookAuthenticationDataBasic.md) | The credentials of the webhook authentication. | 
**CreatedBy** | **string** | The name of the user who created the webhook authentication. | 
**ModifiedBy** | **string** | The name of the user who last modified the webhook authentication. | 
**Webhooks** | [**List&lt;WebhookAuthenticationWebhookRef&gt;**](WebhookAuthenticationWebhookRef.md) |  | 
**Id** | **long** | The internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**Modified** | **DateTime** | The time this entity was last modified. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

