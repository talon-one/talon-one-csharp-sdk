# TalonOneSdk.Model.CampaignEligibilityDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Passed** | **bool** | Indicates whether the customer was eligible for the campaign in the current session. | 
**CouponCode** | **string** | The coupon code used to check a customer&#39;s eligibility for the campaign in the current session, if applicable. | [optional] 
**Details** | [**CampaignEligibilityFailureDetails**](CampaignEligibilityFailureDetails.md) | The details about why the customer was not eligible for the campaign in the current session. Only returned when &#x60;passed&#x60; is &#x60;false&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

