# TalonOneSdk.Model.MCPOAuthTokenRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrantType** | **string** | OAuth2 grant type. | 
**Code** | **string** | Authorization code. Required for &#x60;authorization_code&#x60; grant. | [optional] 
**ClientId** | **string** | Client ID. Required for &#x60;authorization_code&#x60; grant. | [optional] 
**ClientSecret** | **string** | Client secret for confidential (static) clients. May also be supplied via HTTP Basic authentication. Public clients registered via dynamic client registration omit it. | [optional] 
**RedirectUri** | **string** | Redirect URI. Required for &#x60;authorization_code&#x60; grant. | [optional] 
**CodeVerifier** | **string** | PKCE code verifier. Required for &#x60;authorization_code&#x60; grant. | [optional] 
**RefreshToken** | **string** | Refresh token. Required for &#x60;refresh_token&#x60; grant. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

