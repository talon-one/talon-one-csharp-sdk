# TalonOneSdk.Model.ApplicationAnalyticsDataPoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | The start of the aggregation time frame in UTC. | 
**EndTime** | **DateTime** | The end of the aggregation time frame in UTC. | 
**TotalRevenue** | [**AnalyticsDataPoint**](AnalyticsDataPoint.md) | The total, pre-discount value of all items purchased in a customer session. | [optional] 
**SessionsCount** | [**AnalyticsDataPoint**](AnalyticsDataPoint.md) | The number of all closed sessions. The &#x60;influenced&#x60; value includes only sessions with at least one applied effect. | [optional] 
**AvgItemsPerSession** | [**AnalyticsDataPoint**](AnalyticsDataPoint.md) | The number of items from sessions divided by the number of sessions. The &#x60;influenced&#x60; value includes only sessions with at least one applied effect. | [optional] 
**AvgSessionValue** | [**AnalyticsDataPoint**](AnalyticsDataPoint.md) | The average customer session value, calculated by dividing the revenue value by the number of sessions. The &#x60;influenced&#x60; value includes only sessions with at least one applied effect. | [optional] 
**TotalDiscounts** | **decimal** | The total value of discounts given for cart items in influenced sessions. | [optional] 
**CouponsCount** | **decimal** | The number of times a coupon was successfully redeemed in influenced sessions. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

