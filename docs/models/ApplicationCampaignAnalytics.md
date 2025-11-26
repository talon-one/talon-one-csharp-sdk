# TalonOne.Model.ApplicationCampaignAnalytics

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | The start of the aggregation time frame in UTC. | 
**EndTime** | **DateTime** | The end of the aggregation time frame in UTC. | 
**CampaignId** | **long** | The ID of the campaign. | 
**CampaignName** | **string** | The name of the campaign. | 
**CampaignTags** | **List&lt;string&gt;** | A list of tags for the campaign. | 
**CampaignState** | **string** | The state of the campaign.  **Note:** A disabled or archived campaign is not evaluated for rules or coupons.  | 
**TotalRevenue** | [**AnalyticsDataPointWithTrendAndInfluencedRate**](AnalyticsDataPointWithTrendAndInfluencedRate.md) | The total, pre-discount value of all items purchased in a customer session. | [optional] 
**SessionsCount** | [**AnalyticsDataPointWithTrendAndInfluencedRate**](AnalyticsDataPointWithTrendAndInfluencedRate.md) | The number of all closed sessions. The &#x60;influenced&#x60; value includes only sessions with at least one applied effect. | [optional] 
**AvgItemsPerSession** | [**AnalyticsDataPointWithTrendAndUplift**](AnalyticsDataPointWithTrendAndUplift.md) | The number of items from sessions divided by the number of sessions. The &#x60;influenced&#x60; value includes only sessions with at least one applied effect. | [optional] 
**AvgSessionValue** | [**AnalyticsDataPointWithTrendAndUplift**](AnalyticsDataPointWithTrendAndUplift.md) | The average customer session value, calculated by dividing the revenue value by the number of sessions. The &#x60;influenced&#x60; value includes only sessions with at least one applied effect. | [optional] 
**TotalDiscounts** | [**AnalyticsDataPointWithTrend**](AnalyticsDataPointWithTrend.md) | The total value of discounts given for cart items in influenced sessions. | [optional] 
**CouponsCount** | [**AnalyticsDataPointWithTrend**](AnalyticsDataPointWithTrend.md) | The number of times a coupon was successfully redeemed in influenced sessions. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

