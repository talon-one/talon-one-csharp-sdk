# TalonOneSdk.Api.ManagementApi

All URIs are relative to *https://yourbaseurl.talon.one*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CouponCreatedEvent**](ManagementApi.md#couponcreatedevent) | **POST** /CouponCreatedEvent | Coupon Created Event |
| [**CouponDeletedEvent**](ManagementApi.md#coupondeletedevent) | **POST** /CouponDeletedEvent | Coupon Deleted Event |
| [**CouponUpdatedEvent**](ManagementApi.md#couponupdatedevent) | **POST** /CouponUpdatedEvent | Coupon Updated Event |
| [**LoyaltyPointsChangedEvent**](ManagementApi.md#loyaltypointschangedevent) | **POST** /LoyaltyPointsChangedEvent | Changed Loyalty Points Event |
| [**LoyaltyTierDowngradeEvent**](ManagementApi.md#loyaltytierdowngradeevent) | **POST** /LoyaltyTierDowngradeEvent | Loyalty Tier Downgrade Event |
| [**LoyaltyTierUpgradeEvent**](ManagementApi.md#loyaltytierupgradeevent) | **POST** /LoyaltyTierUpgradeEvent | Loyalty Tier Upgrade Event |

<a id="couponcreatedevent"></a>
# **CouponCreatedEvent**
> void CouponCreatedEvent (CouponCreatedEventRequest couponCreatedEventRequest)

Coupon Created Event


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **couponCreatedEventRequest** | [**CouponCreatedEventRequest**](CouponCreatedEventRequest.md) | ... |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="coupondeletedevent"></a>
# **CouponDeletedEvent**
> void CouponDeletedEvent (CouponDeletedEventRequest couponDeletedEventRequest)

Coupon Deleted Event


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **couponDeletedEventRequest** | [**CouponDeletedEventRequest**](CouponDeletedEventRequest.md) | ... |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="couponupdatedevent"></a>
# **CouponUpdatedEvent**
> void CouponUpdatedEvent (CouponUpdatedEventRequest couponUpdatedEventRequest)

Coupon Updated Event


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **couponUpdatedEventRequest** | [**CouponUpdatedEventRequest**](CouponUpdatedEventRequest.md) | ... |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="loyaltypointschangedevent"></a>
# **LoyaltyPointsChangedEvent**
> void LoyaltyPointsChangedEvent (LoyaltyPointsChangedEventRequest loyaltyPointsChangedEventRequest)

Changed Loyalty Points Event


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyPointsChangedEventRequest** | [**LoyaltyPointsChangedEventRequest**](LoyaltyPointsChangedEventRequest.md) | ... |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="loyaltytierdowngradeevent"></a>
# **LoyaltyTierDowngradeEvent**
> void LoyaltyTierDowngradeEvent (LoyaltyTierDowngradeEventRequest loyaltyTierDowngradeEventRequest)

Loyalty Tier Downgrade Event


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyTierDowngradeEventRequest** | [**LoyaltyTierDowngradeEventRequest**](LoyaltyTierDowngradeEventRequest.md) | ... |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="loyaltytierupgradeevent"></a>
# **LoyaltyTierUpgradeEvent**
> void LoyaltyTierUpgradeEvent (LoyaltyTierUpgradeEventRequest loyaltyTierUpgradeEventRequest)

Loyalty Tier Upgrade Event


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyTierUpgradeEventRequest** | [**LoyaltyTierUpgradeEventRequest**](LoyaltyTierUpgradeEventRequest.md) | ... |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

