# TalonOneSdk.Model.IntegrationEventV3Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileId** | **string** | ID of the customer profile set by your integration layer.  **Note:** If the customer does not yet have a known &#x60;profileId&#x60;, we recommend you use a guest &#x60;profileId&#x60;.  | 
**Type** | **string** | The name of the event. Must be a [custom event](https://docs.talon.one/docs/dev/concepts/entities/events#custom-events), not a built-in event. | 
**IntegrationId** | **string** | The unique ID of the event. Only one event with this ID can be registered.  | 
**StoreIntegrationId** | **string** | The integration ID of the store. You choose this ID when you create a store. | [optional] 
**EvaluableCampaignIds** | **List&lt;long&gt;** | When using the &#x60;dry&#x60; query parameter, use this property to list the campaign to be evaluated by the Rule Engine.  These campaigns will be evaluated, even if they are disabled, allowing you to test specific campaigns before activating them.  | [optional] 
**Attributes** | **Object** | Arbitrary additional JSON properties associated with the event. They must be created in the Campaign Manager before setting them with this property. See [creating custom attributes](https://docs.talon.one/docs/product/account/dev-tools/managing-attributes#creating-a-custom-attribute). | [optional] 
**ConnectedSessionId** | **string** | The ID of the session to reference. The session must be in &#x60;closed&#x60; state. Otherwise, the API call will fail. | [optional] 
**LoyaltyCards** | **List&lt;string&gt;** | Identifiers of the loyalty cards used during this event. | [optional] 
**ResponseContent** | **List&lt;IntegrationEventV3Request.ResponseContentEnum&gt;** | Optional list of requested information to be present on the response related to the tracking custom event.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

