# TalonOneSdk.Model.MCPOAuthServerMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Issuer** | **string** | The authorization server&#39;s issuer identifier (its base URL). | 
**AuthorizationEndpoint** | **string** | URL of the authorization endpoint. | 
**TokenEndpoint** | **string** | URL of the token endpoint. | 
**RegistrationEndpoint** | **string** | URL of the client registration endpoint. | 
**ResponseTypesSupported** | **List&lt;string&gt;** | List of supported OAuth2 response types. | 
**GrantTypesSupported** | **List&lt;string&gt;** | List of supported OAuth2 grant types. | 
**CodeChallengeMethodsSupported** | **List&lt;string&gt;** | List of supported PKCE code challenge methods. | 
**TokenEndpointAuthMethodsSupported** | **List&lt;string&gt;** | List of supported client authentication methods at the token endpoint. Public clients use &#x60;none&#x60;; confidential clients use &#x60;client_secret_post&#x60; or &#x60;client_secret_basic&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

