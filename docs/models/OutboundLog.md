# TalonOneSdk.Model.OutboundLog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **Guid** | UUID of the outbound message. | 
**NotificationType** | **string** | Type of notification that triggered the outbound message. | 
**CreatedAt** | **DateTime** | Timestamp when the log was created. | 
**ProcessingTimeMs** | **long** | Time in milliseconds between sending the outbound request and receiving the response. | 
**NotificationId** | **long** | ID of the notification that triggered the outbound message. | [optional] 
**NotificationName** | **string** | Name of the notification that triggered the outbound message. | [optional] 
**WebhookId** | **long** | ID of the webhook that triggered the outbound message. | [optional] 
**WebhookName** | **string** | Name of the webhook that triggered the outbound message. | [optional] 
**ApplicationId** | **long** | ID of the Application associated with the outbound message. | [optional] 
**LoyaltyProgramId** | **long** | ID of the loyalty program associated with the outbound message. | [optional] 
**Request** | [**OutboundLogRequest**](OutboundLogRequest.md) |  | [optional] 
**Response** | [**OutboundLogResponse**](OutboundLogResponse.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

