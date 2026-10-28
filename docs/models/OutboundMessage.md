# TalonOneSdk.Model.OutboundMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **Guid** | UUID of the outbound message. | 
**NotificationType** | **string** | Type of notification that triggered the outbound message. | 
**FirstLogAt** | **DateTime** | Timestamp of the first log entry for this message. | 
**LastLogAt** | **DateTime** | Timestamp of the last log entry for this message. | 
**Status** | **string** |  | 
**NotificationId** | **long** | ID of the notification that triggered the outbound message. | [optional] 
**NotificationName** | **string** | Name of the notification that triggered the outbound message. | [optional] 
**WebhookId** | **long** | ID of the webhook that triggered the outbound message. | [optional] 
**WebhookName** | **string** | Name of the webhook that triggered the outbound message. | [optional] 
**ApplicationId** | **long** | ID of the Application associated with the outbound message. | [optional] 
**LoyaltyProgramId** | **long** | ID of the loyalty program associated with the outbound message. | [optional] 
**Request** | [**OutboundLogRequest**](OutboundLogRequest.md) |  | [optional] 
**LastResponseCode** | **long** | HTTP status code from the latest response. | [optional] 
**RetryCount** | **long** | Number of retries. | [optional] 
**Responses** | [**List&lt;OutboundMessageResponse&gt;**](OutboundMessageResponse.md) | Log entries for this message. One entry per delivery attempt. Empty when &#x60;includeLogs&#x3D;false&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

