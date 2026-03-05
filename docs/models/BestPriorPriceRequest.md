# TalonOneSdk.Model.BestPriorPriceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Skus** | **List&lt;string&gt;** | List of product SKUs to check when determining the best prior price. | 
**TimeframeEndDate** | **DateTime** | The end date and time that defines the latest time for retrieving historical SKU prices. | 
**Timeframe** | **string** | The number of days prior to the timeframeEndDate. Only prices within this look back period are considered for the best prior price evaluation. | 
**StrictEndDate** | **bool** | This property is **deprecated**. Use &#x60;timeframeEndDateType&#x60; instead.  Indicates whether the timeframe includes the start of the current sale. - When &#x60;false&#x60;, the timeframe includes the start date of the current sale. - When &#x60;true&#x60;, the timeframe strictly uses the number of days specified in &#x60;timeframe&#x60;.  | 
**TimeframeEndDateType** | **string** | Sets the timeframe for retrieving historical pricing data. Can be one of the following values: - &#x60;strict&#x60;: The timeframe ends at the &#x60;timeframeEndDate&#x60; value. - &#x60;price&#x60;: The timeframe ends at the start of the current &#x60;contextId&#x60; with the current price value. Identical price records are merged. If there is no &#x60;contextId&#x60; for the most recent price, the most recent timestamp for the price is used.  - &#x60;sale&#x60;:  The timeframe ends at the start of current &#x60;contextId&#x60; and takes the prices prior to the start of the &#x60;contextId&#x60; into account.  | [optional] 
**Target** | [**BestPriorTarget**](BestPriorTarget.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

