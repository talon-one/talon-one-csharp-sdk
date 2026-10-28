# TalonOneSdk.Model.RollbackCouponEffectProps
This effect indicates that a coupon code redemption has been rolled back. The coupon becomes redeemable again.  This effect is triggered in the following cases:  - A session where a coupon was accepted is [cancelled](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions#manage-the-sessions-state). See an example of use in the [cancelling a session tutorial](https://docs.talon.one/docs/dev/tutorials/roll-back-effects). - A session where a coupon was accepted is [reopened](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/reopenCustomerSession).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The coupon code whose redemption has been rolled back. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

