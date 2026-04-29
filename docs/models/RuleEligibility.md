# TalonOneSdk.Model.RuleEligibility
The customer's eligibility for a rule in the current session, based on whether all of the rule's conditions were met.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Passed** | **bool** | Indicates whether the customer was eligible for the rule in the current session, based on whether all of the rule&#39;s conditions were met. | 
**CouponCode** | **string** | The coupon code used to check a customer&#39;s eligibility for the rule in the current session, if applicable. | [optional] 
**Details** | [**RuleEligibilityFailureDetails**](RuleEligibilityFailureDetails.md) | The details about why the customer was not eligible for the rule in the current session. Only returned when &#x60;passed&#x60; is &#x60;false&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

