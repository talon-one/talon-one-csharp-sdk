# Talon.One C# SDK

> [!WARNING]
This project is in beta. Use is "AS IS" and at your own risk.
The stable version of this SDK is available [here](https://github.com/talon-one/TalonOne.cs).

This SDK supports all of the operations of Talon.One's Integration API and Management API.

## Frameworks supported

- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.15.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```powershell
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

## Installation

Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using TalonOneSdk.Api;
using TalonOneSdk.Client;
using TalonOneSdk.Model;
```

## Determining the base URL of the endpoints

The API is available at the same hostname as your Campaign Manager deployment.
For example, if you access the Campaign Manager at `https://yourbaseurl.talon.one`,
the URL for the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint
is `https://yourbaseurl.talon.one/v2/customer_sessions/{Id}`.

## Getting started

### Integration API

The following code shows an example of using the Integration API:

```csharp
using System;
using System.Collections.Generic;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Example
{
    public class Example
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            // Configure services and API key authorization
            var services = new ServiceCollection();

            var hostConfiguration = new HostConfiguration(services)
                .AddApiHttpClients(client => client.BaseAddress = new System.Uri("https://yourbaseurl.talon.one"))
                .AddTokens(new ApiKeyToken(
                    "e18149e88f42205432281c9d3d0e711111302722577ad60dcebc86c43aabfe70",
                    ClientUtils.ApiKeyHeader.Authorization,
                    "ApiKey-v1 "
                ))
                .UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

            var serviceProvider = services.BuildServiceProvider();
            var apiFactory = serviceProvider.GetRequiredService<IApiFactory>();

            // ************************************************
            // Integration API example to send a session update
            // ************************************************

            // Create the Integration API instance using the factory
            var integrationApi = apiFactory.Create<IIntegrationApi>();
            var customerSessionId = "my_unique_session_integration_id_2";  // The custom identifier for this session, must be unique within the account.

            // Preparing a NewCustomerSessionV2 object
            NewCustomerSessionV2 customerSession = new NewCustomerSessionV2 {
                ProfileId = "PROFILE_ID",
                CouponCodes = new List<string> {
                    "Cool-Stuff-2020"
                },
                CartItems = new List<CartItem> {
                    new CartItem(
                        name: "Hummus Tahini",
                        sku: "hum-t",
                        quantity: 1,
                        price: (decimal)5.5,
                        category: "Food"
                    ),
                    new CartItem(
                        name: "Iced Mint Lemonade",
                        sku: "ice-mn-lemon",
                        quantity: 1,
                        price: (decimal)3.5,
                        category: "Beverages"
                    )
                }
            };

            // Instantiating an IntegrationRequest object
            IntegrationRequest body = new IntegrationRequest(
                customerSession
                // Optional list of requested information to be present on the response.
                // See src/TalonOne/Model/IntegrationRequest#ResponseContentEnum for full list of supported values
                // new List<IntegrationRequest.ResponseContentEnum> {
                //     IntegrationRequest.ResponseContentEnum.CustomerSession,
                //     IntegrationRequest.ResponseContentEnum.CustomerProfile
                // }
            );

            // Create/update a customer session using `UpdateCustomerSessionV2Async` function
            var response = await integrationApi.UpdateCustomerSessionV2Async(customerSessionId, body);

            // Access the result from the response
            var result = response.Ok();
            Console.WriteLine(result);

            // Parsing the returned effects list, please consult https://developers.talon.one/Integration-API/handling-effects-v2 for the full list of effects and their corresponding properties
            foreach (Effect effect in result.Effects) {
                switch(effect.EffectType) {
                    case "setDiscount":
                        // Initiating right props instance according to the effect type
                        SetDiscountEffectProps setDiscountEffectProps = (SetDiscountEffectProps) Newtonsoft.Json.JsonConvert.DeserializeObject(effect.Props.ToString(), typeof(SetDiscountEffectProps));

                        // Access the specific effect's properties
                        Console.WriteLine("Set a discount '{0}' of {1:00.000}", setDiscountEffectProps.Name, setDiscountEffectProps.Value);
                        break;
                    // case "acceptCoupon":
                        // AcceptCouponEffectProps acceptCouponEffectProps = (AcceptCouponEffectProps) Newtonsoft.Json.JsonConvert.DeserializeObject(effect.Props.ToString(), typeof(AcceptCouponEffectProps));

                        // Work with AcceptCouponEffectProps' properties
                        // ...
                        // break;
                    default:
                        Console.WriteLine("Encounter unknown effect type: {0}", effect.EffectType);
                        break;
                }
            }
        }
    }
}
```

### Management API

The following code shows an example of using the Management API:

```csharp
using System;
using System.Collections.Generic;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Example
{
    public class Example
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            // Configure services and API key authorization
            var services = new ServiceCollection();

            var hostConfiguration = new HostConfiguration(services)
                .AddApiHttpClients(client => client.BaseAddress = new System.Uri("https://yourbaseurl.talon.one"))
                .AddTokens(new ApiKeyToken(
                    "2f0dce055da01ae595005d7d79154bae7448d319d5fc7c5b2951fadd6ba1ea07",
                    ClientUtils.ApiKeyHeader.Authorization,
                    "ManagementKey-v1 "
                ))
                .UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

            var serviceProvider = services.BuildServiceProvider();
            var apiFactory = serviceProvider.GetRequiredService<IApiFactory>();

            // ****************************************************
            // Management API example to load application with id 7
            // ****************************************************

            // Create the Management API instance using the factory
            var managementApi = apiFactory.Create<IManagementApi>();

            // Calling `GetApplicationAsync` function with the desired id (7)
            var response = await managementApi.GetApplicationAsync(7);
            var result = response.Ok();
            Console.WriteLine(result);
        }
    }
}
```

## Documentation for API endpoints

All URLs are relative to `https://yourbaseurl.talon.one`.

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*IntegrationApi* | [**BestPriorPrice**](docs/apis/IntegrationApi.md#bestpriorprice) | **POST** /v1/best_prior_price | Fetch best prior price
*IntegrationApi* | [**CreateAudienceV2**](docs/apis/IntegrationApi.md#createaudiencev2) | **POST** /v2/audiences | Create audience
*IntegrationApi* | [**CreateCouponReservation**](docs/apis/IntegrationApi.md#createcouponreservation) | **POST** /v1/coupon_reservations/{couponValue} | Create coupon reservation
*IntegrationApi* | [**CreateReferral**](docs/apis/IntegrationApi.md#createreferral) | **POST** /v1/referrals | Create referral code for an advocate
*IntegrationApi* | [**CreateReferralsForMultipleAdvocates**](docs/apis/IntegrationApi.md#createreferralsformultipleadvocates) | **POST** /v1/referrals_for_multiple_advocates | Create referral codes for multiple advocates
*IntegrationApi* | [**DeleteAudienceMembershipsV2**](docs/apis/IntegrationApi.md#deleteaudiencemembershipsv2) | **DELETE** /v2/audiences/{audienceId}/memberships | Delete audience memberships
*IntegrationApi* | [**DeleteAudienceV2**](docs/apis/IntegrationApi.md#deleteaudiencev2) | **DELETE** /v2/audiences/{audienceId} | Delete audience
*IntegrationApi* | [**DeleteCouponReservation**](docs/apis/IntegrationApi.md#deletecouponreservation) | **DELETE** /v1/coupon_reservations/{couponValue} | Delete coupon reservations
*IntegrationApi* | [**DeleteCustomerData**](docs/apis/IntegrationApi.md#deletecustomerdata) | **DELETE** /v1/customer_data/{integrationId} | Delete customer's personal data
*IntegrationApi* | [**GenerateLoyaltyCard**](docs/apis/IntegrationApi.md#generateloyaltycard) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/cards | Generate loyalty card
*IntegrationApi* | [**GetCustomerAchievementHistory**](docs/apis/IntegrationApi.md#getcustomerachievementhistory) | **GET** /v1/customer_profiles/{integrationId}/achievements/{achievementId} | List customer's achievement history
*IntegrationApi* | [**GetCustomerAchievements**](docs/apis/IntegrationApi.md#getcustomerachievements) | **GET** /v1/customer_profiles/{integrationId}/achievements | List customer's available achievements
*IntegrationApi* | [**GetCustomerInventory**](docs/apis/IntegrationApi.md#getcustomerinventory) | **GET** /v1/customer_profiles/{integrationId}/inventory | List customer data
*IntegrationApi* | [**GetCustomerSession**](docs/apis/IntegrationApi.md#getcustomersession) | **GET** /v2/customer_sessions/{customerSessionId} | Get customer session
*IntegrationApi* | [**GetLoyaltyBalances**](docs/apis/IntegrationApi.md#getloyaltybalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/balances | Get customer's loyalty balances
*IntegrationApi* | [**GetLoyaltyCardBalances**](docs/apis/IntegrationApi.md#getloyaltycardbalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/balances | Get card's point balances
*IntegrationApi* | [**GetLoyaltyCardPoints**](docs/apis/IntegrationApi.md#getloyaltycardpoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/points | List card's unused loyalty points
*IntegrationApi* | [**GetLoyaltyCardTransactions**](docs/apis/IntegrationApi.md#getloyaltycardtransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/transactions | List card's transactions
*IntegrationApi* | [**GetLoyaltyProgramProfilePoints**](docs/apis/IntegrationApi.md#getloyaltyprogramprofilepoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/points | List customer's unused loyalty points
*IntegrationApi* | [**GetLoyaltyProgramProfileTransactions**](docs/apis/IntegrationApi.md#getloyaltyprogramprofiletransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/transactions | List customer's loyalty transactions
*IntegrationApi* | [**GetReservedCustomers**](docs/apis/IntegrationApi.md#getreservedcustomers) | **GET** /v1/coupon_reservations/customerprofiles/{couponValue} | List customers that have this coupon reserved
*IntegrationApi* | [**LinkLoyaltyCardToProfile**](docs/apis/IntegrationApi.md#linkloyaltycardtoprofile) | **POST** /v2/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/link_profile | Link customer profile to card
*IntegrationApi* | [**ReopenCustomerSession**](docs/apis/IntegrationApi.md#reopencustomersession) | **PUT** /v2/customer_sessions/{customerSessionId}/reopen | Reopen customer session
*IntegrationApi* | [**ReturnCartItems**](docs/apis/IntegrationApi.md#returncartitems) | **POST** /v2/customer_sessions/{customerSessionId}/returns | Return cart items
*IntegrationApi* | [**SyncCatalog**](docs/apis/IntegrationApi.md#synccatalog) | **PUT** /v1/catalogs/{catalogId}/sync | Sync cart item catalog
*IntegrationApi* | [**TrackEventV2**](docs/apis/IntegrationApi.md#trackeventv2) | **POST** /v2/events | Track event
*IntegrationApi* | [**UpdateAudienceCustomersAttributes**](docs/apis/IntegrationApi.md#updateaudiencecustomersattributes) | **PUT** /v2/audience_customers/{audienceId}/attributes | Update profile attributes for all customers in audience
*IntegrationApi* | [**UpdateAudienceV2**](docs/apis/IntegrationApi.md#updateaudiencev2) | **PUT** /v2/audiences/{audienceId} | Update audience name
*IntegrationApi* | [**UpdateCustomerProfileAudiences**](docs/apis/IntegrationApi.md#updatecustomerprofileaudiences) | **POST** /v2/customer_audiences | Update multiple customer profiles' audiences
*IntegrationApi* | [**UpdateCustomerProfileV2**](docs/apis/IntegrationApi.md#updatecustomerprofilev2) | **PUT** /v2/customer_profiles/{integrationId} | Update customer profile
*IntegrationApi* | [**UpdateCustomerProfilesV2**](docs/apis/IntegrationApi.md#updatecustomerprofilesv2) | **PUT** /v2/customer_profiles | Update multiple customer profiles
*IntegrationApi* | [**UpdateCustomerSessionV2**](docs/apis/IntegrationApi.md#updatecustomersessionv2) | **PUT** /v2/customer_sessions/{customerSessionId} | Update customer session
*ManagementApi* | [**ActivateUserByEmail**](docs/apis/ManagementApi.md#activateuserbyemail) | **POST** /v1/users/activate | Enable user by email address
*ManagementApi* | [**AddLoyaltyCardPoints**](docs/apis/ManagementApi.md#addloyaltycardpoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/add_points | Add points to card
*ManagementApi* | [**AddLoyaltyPoints**](docs/apis/ManagementApi.md#addloyaltypoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/add_points | Add points to customer profile
*ManagementApi* | [**CopyCampaignToApplications**](docs/apis/ManagementApi.md#copycampaigntoapplications) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/copy | Copy the campaign into the specified Application
*ManagementApi* | [**CreateAccountCollection**](docs/apis/ManagementApi.md#createaccountcollection) | **POST** /v1/collections | Create account-level collection
*ManagementApi* | [**CreateAchievement**](docs/apis/ManagementApi.md#createachievement) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements | Create achievement
*ManagementApi* | [**CreateAdditionalCost**](docs/apis/ManagementApi.md#createadditionalcost) | **POST** /v1/additional_costs | Create additional cost
*ManagementApi* | [**CreateAttribute**](docs/apis/ManagementApi.md#createattribute) | **POST** /v1/attributes | Create custom attribute
*ManagementApi* | [**CreateBatchLoyaltyCards**](docs/apis/ManagementApi.md#createbatchloyaltycards) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/cards/batch | Create loyalty cards
*ManagementApi* | [**CreateCampaignFromTemplate**](docs/apis/ManagementApi.md#createcampaignfromtemplate) | **POST** /v1/applications/{applicationId}/create_campaign_from_template | Create campaign from campaign template
*ManagementApi* | [**CreateCampaignStoreBudget**](docs/apis/ManagementApi.md#createcampaignstorebudget) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets | Create campaign store budget
*ManagementApi* | [**CreateCollection**](docs/apis/ManagementApi.md#createcollection) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/collections | Create campaign-level collection
*ManagementApi* | [**CreateCoupons**](docs/apis/ManagementApi.md#createcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Create coupons
*ManagementApi* | [**CreateCouponsAsync**](docs/apis/ManagementApi.md#createcouponsasync) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_async | Create coupons asynchronously
*ManagementApi* | [**CreateCouponsDeletionJob**](docs/apis/ManagementApi.md#createcouponsdeletionjob) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_deletion_jobs | Creates a coupon deletion job
*ManagementApi* | [**CreateCouponsForMultipleRecipients**](docs/apis/ManagementApi.md#createcouponsformultiplerecipients) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_with_recipients | Create coupons for multiple recipients
*ManagementApi* | [**CreateInviteEmail**](docs/apis/ManagementApi.md#createinviteemail) | **POST** /v1/invite_emails | Resend invitation email
*ManagementApi* | [**CreateInviteV2**](docs/apis/ManagementApi.md#createinvitev2) | **POST** /v2/invites | Invite user
*ManagementApi* | [**CreatePasswordRecoveryEmail**](docs/apis/ManagementApi.md#createpasswordrecoveryemail) | **POST** /v1/password_recovery_emails | Request a password reset
*ManagementApi* | [**CreateSession**](docs/apis/ManagementApi.md#createsession) | **POST** /v1/sessions | Create session
*ManagementApi* | [**CreateStore**](docs/apis/ManagementApi.md#createstore) | **POST** /v1/applications/{applicationId}/stores | Create store
*ManagementApi* | [**DeactivateUserByEmail**](docs/apis/ManagementApi.md#deactivateuserbyemail) | **POST** /v1/users/deactivate | Disable user by email address
*ManagementApi* | [**DeductLoyaltyCardPoints**](docs/apis/ManagementApi.md#deductloyaltycardpoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/deduct_points | Deduct points from card
*ManagementApi* | [**DeleteAccountCollection**](docs/apis/ManagementApi.md#deleteaccountcollection) | **DELETE** /v1/collections/{collectionId} | Delete account-level collection
*ManagementApi* | [**DeleteAchievement**](docs/apis/ManagementApi.md#deleteachievement) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Delete achievement
*ManagementApi* | [**DeleteCampaign**](docs/apis/ManagementApi.md#deletecampaign) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId} | Delete campaign
*ManagementApi* | [**DeleteCampaignStoreBudgets**](docs/apis/ManagementApi.md#deletecampaignstorebudgets) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets | Delete campaign store budgets
*ManagementApi* | [**DeleteCollection**](docs/apis/ManagementApi.md#deletecollection) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Delete campaign-level collection
*ManagementApi* | [**DeleteCoupon**](docs/apis/ManagementApi.md#deletecoupon) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Delete coupon
*ManagementApi* | [**DeleteCoupons**](docs/apis/ManagementApi.md#deletecoupons) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Delete coupons
*ManagementApi* | [**DeleteLoyaltyCard**](docs/apis/ManagementApi.md#deleteloyaltycard) | **DELETE** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Delete loyalty card
*ManagementApi* | [**DeleteReferral**](docs/apis/ManagementApi.md#deletereferral) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Delete referral
*ManagementApi* | [**DeleteStore**](docs/apis/ManagementApi.md#deletestore) | **DELETE** /v1/applications/{applicationId}/stores/{storeId} | Delete store
*ManagementApi* | [**DeleteUser**](docs/apis/ManagementApi.md#deleteuser) | **DELETE** /v1/users/{userId} | Delete user
*ManagementApi* | [**DeleteUserByEmail**](docs/apis/ManagementApi.md#deleteuserbyemail) | **POST** /v1/users/delete | Delete user by email address
*ManagementApi* | [**DestroySession**](docs/apis/ManagementApi.md#destroysession) | **DELETE** /v1/sessions | Destroy session
*ManagementApi* | [**DisconnectCampaignStores**](docs/apis/ManagementApi.md#disconnectcampaignstores) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/stores | Disconnect stores
*ManagementApi* | [**ExportAccountCollectionItems**](docs/apis/ManagementApi.md#exportaccountcollectionitems) | **GET** /v1/collections/{collectionId}/export | Export account-level collection's items
*ManagementApi* | [**ExportAchievements**](docs/apis/ManagementApi.md#exportachievements) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId}/export | Export achievement customer data
*ManagementApi* | [**ExportAudiencesMemberships**](docs/apis/ManagementApi.md#exportaudiencesmemberships) | **GET** /v1/audiences/{audienceId}/memberships/export | Export audience members
*ManagementApi* | [**ExportCampaignStoreBudgets**](docs/apis/ManagementApi.md#exportcampaignstorebudgets) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets/export | Export campaign store budgets
*ManagementApi* | [**ExportCampaignStores**](docs/apis/ManagementApi.md#exportcampaignstores) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/export | Export stores
*ManagementApi* | [**ExportCollectionItems**](docs/apis/ManagementApi.md#exportcollectionitems) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId}/export | Export campaign-level collection's items
*ManagementApi* | [**ExportCoupons**](docs/apis/ManagementApi.md#exportcoupons) | **GET** /v1/applications/{applicationId}/export_coupons | Export coupons
*ManagementApi* | [**ExportCustomerSessions**](docs/apis/ManagementApi.md#exportcustomersessions) | **GET** /v1/applications/{applicationId}/export_customer_sessions | Export customer sessions
*ManagementApi* | [**ExportCustomersTiers**](docs/apis/ManagementApi.md#exportcustomerstiers) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customers_tiers | Export customers' tier data
*ManagementApi* | [**ExportEffects**](docs/apis/ManagementApi.md#exporteffects) | **GET** /v1/applications/{applicationId}/export_effects | Export triggered effects
*ManagementApi* | [**ExportLoyaltyBalance**](docs/apis/ManagementApi.md#exportloyaltybalance) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customer_balance | Export customer loyalty balance to CSV
*ManagementApi* | [**ExportLoyaltyBalances**](docs/apis/ManagementApi.md#exportloyaltybalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customer_balances | Export customer loyalty balances
*ManagementApi* | [**ExportLoyaltyCardBalances**](docs/apis/ManagementApi.md#exportloyaltycardbalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_card_balances | Export all card transaction logs
*ManagementApi* | [**ExportLoyaltyCardLedger**](docs/apis/ManagementApi.md#exportloyaltycardledger) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/export_log | Export card's ledger log
*ManagementApi* | [**ExportLoyaltyCards**](docs/apis/ManagementApi.md#exportloyaltycards) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/export | Export loyalty cards
*ManagementApi* | [**ExportLoyaltyLedger**](docs/apis/ManagementApi.md#exportloyaltyledger) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/export_log | Export customer's transaction logs
*ManagementApi* | [**ExportPoolGiveaways**](docs/apis/ManagementApi.md#exportpoolgiveaways) | **GET** /v1/giveaways/pools/{poolId}/export | Export giveaway codes of a giveaway pool
*ManagementApi* | [**ExportReferrals**](docs/apis/ManagementApi.md#exportreferrals) | **GET** /v1/applications/{applicationId}/export_referrals | Export referrals
*ManagementApi* | [**GetAccessLogsWithoutTotalCount**](docs/apis/ManagementApi.md#getaccesslogswithouttotalcount) | **GET** /v1/applications/{applicationId}/access_logs/no_total | Get access logs for Application
*ManagementApi* | [**GetAccount**](docs/apis/ManagementApi.md#getaccount) | **GET** /v1/accounts/{accountId} | Get account details
*ManagementApi* | [**GetAccountAnalytics**](docs/apis/ManagementApi.md#getaccountanalytics) | **GET** /v1/accounts/{accountId}/analytics | Get account analytics
*ManagementApi* | [**GetAccountCollection**](docs/apis/ManagementApi.md#getaccountcollection) | **GET** /v1/collections/{collectionId} | Get account-level collection
*ManagementApi* | [**GetAchievement**](docs/apis/ManagementApi.md#getachievement) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Get achievement
*ManagementApi* | [**GetAdditionalCost**](docs/apis/ManagementApi.md#getadditionalcost) | **GET** /v1/additional_costs/{additionalCostId} | Get additional cost
*ManagementApi* | [**GetAdditionalCosts**](docs/apis/ManagementApi.md#getadditionalcosts) | **GET** /v1/additional_costs | List additional costs
*ManagementApi* | [**GetApplication**](docs/apis/ManagementApi.md#getapplication) | **GET** /v1/applications/{applicationId} | Get Application
*ManagementApi* | [**GetApplicationApiHealth**](docs/apis/ManagementApi.md#getapplicationapihealth) | **GET** /v1/applications/{applicationId}/health_report | Get Application health
*ManagementApi* | [**GetApplicationCustomer**](docs/apis/ManagementApi.md#getapplicationcustomer) | **GET** /v1/applications/{applicationId}/customers/{customerId} | Get application's customer
*ManagementApi* | [**GetApplicationCustomerFriends**](docs/apis/ManagementApi.md#getapplicationcustomerfriends) | **GET** /v1/applications/{applicationId}/profile/{integrationId}/friends | List friends referred by customer profile
*ManagementApi* | [**GetApplicationCustomers**](docs/apis/ManagementApi.md#getapplicationcustomers) | **GET** /v1/applications/{applicationId}/customers | List application's customers
*ManagementApi* | [**GetApplicationCustomersByAttributes**](docs/apis/ManagementApi.md#getapplicationcustomersbyattributes) | **POST** /v1/applications/{applicationId}/customer_search | List application customers matching the given attributes
*ManagementApi* | [**GetApplicationEventTypes**](docs/apis/ManagementApi.md#getapplicationeventtypes) | **GET** /v1/applications/{applicationId}/event_types | List Applications event types
*ManagementApi* | [**GetApplicationEventsWithoutTotalCount**](docs/apis/ManagementApi.md#getapplicationeventswithouttotalcount) | **GET** /v1/applications/{applicationId}/events/no_total | List Applications events
*ManagementApi* | [**GetApplicationSession**](docs/apis/ManagementApi.md#getapplicationsession) | **GET** /v1/applications/{applicationId}/sessions/{sessionId} | Get Application session
*ManagementApi* | [**GetApplicationSessions**](docs/apis/ManagementApi.md#getapplicationsessions) | **GET** /v1/applications/{applicationId}/sessions | List Application sessions
*ManagementApi* | [**GetApplications**](docs/apis/ManagementApi.md#getapplications) | **GET** /v1/applications | List Applications
*ManagementApi* | [**GetAttribute**](docs/apis/ManagementApi.md#getattribute) | **GET** /v1/attributes/{attributeId} | Get custom attribute
*ManagementApi* | [**GetAttributes**](docs/apis/ManagementApi.md#getattributes) | **GET** /v1/attributes | List custom attributes
*ManagementApi* | [**GetAudienceMemberships**](docs/apis/ManagementApi.md#getaudiencememberships) | **GET** /v1/audiences/{audienceId}/memberships | List audience members
*ManagementApi* | [**GetAudiences**](docs/apis/ManagementApi.md#getaudiences) | **GET** /v1/audiences | List audiences
*ManagementApi* | [**GetAudiencesAnalytics**](docs/apis/ManagementApi.md#getaudiencesanalytics) | **GET** /v1/audiences/analytics | List audience analytics
*ManagementApi* | [**GetCampaign**](docs/apis/ManagementApi.md#getcampaign) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId} | Get campaign
*ManagementApi* | [**GetCampaignAnalytics**](docs/apis/ManagementApi.md#getcampaignanalytics) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/analytics | Get analytics of campaigns
*ManagementApi* | [**GetCampaignByAttributes**](docs/apis/ManagementApi.md#getcampaignbyattributes) | **POST** /v1/applications/{applicationId}/campaigns_search | List campaigns that match the given attributes
*ManagementApi* | [**GetCampaignGroup**](docs/apis/ManagementApi.md#getcampaigngroup) | **GET** /v1/campaign_groups/{campaignGroupId} | Get campaign access group
*ManagementApi* | [**GetCampaignGroups**](docs/apis/ManagementApi.md#getcampaigngroups) | **GET** /v1/campaign_groups | List campaign access groups
*ManagementApi* | [**GetCampaignTemplates**](docs/apis/ManagementApi.md#getcampaigntemplates) | **GET** /v1/campaign_templates | List campaign templates
*ManagementApi* | [**GetCampaigns**](docs/apis/ManagementApi.md#getcampaigns) | **GET** /v1/applications/{applicationId}/campaigns | List campaigns
*ManagementApi* | [**GetChanges**](docs/apis/ManagementApi.md#getchanges) | **GET** /v1/changes | Get audit logs for an account
*ManagementApi* | [**GetCollection**](docs/apis/ManagementApi.md#getcollection) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Get campaign-level collection
*ManagementApi* | [**GetCollectionItems**](docs/apis/ManagementApi.md#getcollectionitems) | **GET** /v1/collections/{collectionId}/items | Get collection items
*ManagementApi* | [**GetCouponsWithoutTotalCount**](docs/apis/ManagementApi.md#getcouponswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/no_total | List coupons
*ManagementApi* | [**GetCustomerActivityReport**](docs/apis/ManagementApi.md#getcustomeractivityreport) | **GET** /v1/applications/{applicationId}/customer_activity_reports/{customerId} | Get customer's activity report
*ManagementApi* | [**GetCustomerActivityReportsWithoutTotalCount**](docs/apis/ManagementApi.md#getcustomeractivityreportswithouttotalcount) | **GET** /v1/applications/{applicationId}/customer_activity_reports/no_total | Get Activity Reports for Application Customers
*ManagementApi* | [**GetCustomerAnalytics**](docs/apis/ManagementApi.md#getcustomeranalytics) | **GET** /v1/applications/{applicationId}/customers/{customerId}/analytics | Get customer's analytics report
*ManagementApi* | [**GetCustomerProfile**](docs/apis/ManagementApi.md#getcustomerprofile) | **GET** /v1/customers/{customerId} | Get customer profile
*ManagementApi* | [**GetCustomerProfileAchievementProgress**](docs/apis/ManagementApi.md#getcustomerprofileachievementprogress) | **GET** /v1/applications/{applicationId}/achievement_progress/{integrationId} | List customer achievements
*ManagementApi* | [**GetCustomerProfiles**](docs/apis/ManagementApi.md#getcustomerprofiles) | **GET** /v1/customers/no_total | List customer profiles
*ManagementApi* | [**GetCustomersByAttributes**](docs/apis/ManagementApi.md#getcustomersbyattributes) | **POST** /v1/customer_search/no_total | List customer profiles matching the given attributes
*ManagementApi* | [**GetDashboardStatistics**](docs/apis/ManagementApi.md#getdashboardstatistics) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/dashboard | Get statistics for loyalty dashboard
*ManagementApi* | [**GetEventTypes**](docs/apis/ManagementApi.md#geteventtypes) | **GET** /v1/event_types | List event types
*ManagementApi* | [**GetExports**](docs/apis/ManagementApi.md#getexports) | **GET** /v1/exports | Get exports
*ManagementApi* | [**GetLoyaltyCard**](docs/apis/ManagementApi.md#getloyaltycard) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Get loyalty card
*ManagementApi* | [**GetLoyaltyCardTransactionLogs**](docs/apis/ManagementApi.md#getloyaltycardtransactionlogs) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/logs | List card's transactions
*ManagementApi* | [**GetLoyaltyCards**](docs/apis/ManagementApi.md#getloyaltycards) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards | List loyalty cards
*ManagementApi* | [**GetLoyaltyPoints**](docs/apis/ManagementApi.md#getloyaltypoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId} | Get customer's full loyalty ledger
*ManagementApi* | [**GetLoyaltyProgram**](docs/apis/ManagementApi.md#getloyaltyprogram) | **GET** /v1/loyalty_programs/{loyaltyProgramId} | Get loyalty program
*ManagementApi* | [**GetLoyaltyProgramTransactions**](docs/apis/ManagementApi.md#getloyaltyprogramtransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/transactions | List loyalty program transactions
*ManagementApi* | [**GetLoyaltyPrograms**](docs/apis/ManagementApi.md#getloyaltyprograms) | **GET** /v1/loyalty_programs | List loyalty programs
*ManagementApi* | [**GetLoyaltyStatistics**](docs/apis/ManagementApi.md#getloyaltystatistics) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/statistics | Get loyalty program statistics
*ManagementApi* | [**GetMessageLogs**](docs/apis/ManagementApi.md#getmessagelogs) | **GET** /v1/message_logs | List message log entries
*ManagementApi* | [**GetReferralsWithoutTotalCount**](docs/apis/ManagementApi.md#getreferralswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/no_total | List referrals
*ManagementApi* | [**GetRoleV2**](docs/apis/ManagementApi.md#getrolev2) | **GET** /v2/roles/{roleId} | Get role
*ManagementApi* | [**GetRuleset**](docs/apis/ManagementApi.md#getruleset) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Get ruleset
*ManagementApi* | [**GetRulesets**](docs/apis/ManagementApi.md#getrulesets) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets | List campaign rulesets
*ManagementApi* | [**GetStore**](docs/apis/ManagementApi.md#getstore) | **GET** /v1/applications/{applicationId}/stores/{storeId} | Get store
*ManagementApi* | [**GetUser**](docs/apis/ManagementApi.md#getuser) | **GET** /v1/users/{userId} | Get user
*ManagementApi* | [**GetUsers**](docs/apis/ManagementApi.md#getusers) | **GET** /v1/users | List users in account
*ManagementApi* | [**GetWebhook**](docs/apis/ManagementApi.md#getwebhook) | **GET** /v1/webhooks/{webhookId} | Get webhook
*ManagementApi* | [**GetWebhooks**](docs/apis/ManagementApi.md#getwebhooks) | **GET** /v1/webhooks | List webhooks
*ManagementApi* | [**ImportAccountCollection**](docs/apis/ManagementApi.md#importaccountcollection) | **POST** /v1/collections/{collectionId}/import | Import data into existing account-level collection
*ManagementApi* | [**ImportAllowedList**](docs/apis/ManagementApi.md#importallowedlist) | **POST** /v1/attributes/{attributeId}/allowed_list/import | Import allowed values for attribute
*ManagementApi* | [**ImportAudiencesMemberships**](docs/apis/ManagementApi.md#importaudiencesmemberships) | **POST** /v1/audiences/{audienceId}/memberships/import | Import audience members
*ManagementApi* | [**ImportCampaignStoreBudget**](docs/apis/ManagementApi.md#importcampaignstorebudget) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets/import | Import campaign store budgets
*ManagementApi* | [**ImportCampaignStores**](docs/apis/ManagementApi.md#importcampaignstores) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/import | Import stores
*ManagementApi* | [**ImportCollection**](docs/apis/ManagementApi.md#importcollection) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId}/import | Import data into existing campaign-level collection
*ManagementApi* | [**ImportCoupons**](docs/apis/ManagementApi.md#importcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_coupons | Import coupons
*ManagementApi* | [**ImportLoyaltyCards**](docs/apis/ManagementApi.md#importloyaltycards) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_cards | Import loyalty cards
*ManagementApi* | [**ImportLoyaltyCustomersTiers**](docs/apis/ManagementApi.md#importloyaltycustomerstiers) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_customers_tiers | Import customers into loyalty tiers
*ManagementApi* | [**ImportLoyaltyPoints**](docs/apis/ManagementApi.md#importloyaltypoints) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_points | Import loyalty points
*ManagementApi* | [**ImportPoolGiveaways**](docs/apis/ManagementApi.md#importpoolgiveaways) | **POST** /v1/giveaways/pools/{poolId}/import | Import giveaway codes into a giveaway pool
*ManagementApi* | [**ImportReferrals**](docs/apis/ManagementApi.md#importreferrals) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_referrals | Import referrals
*ManagementApi* | [**InviteUserExternal**](docs/apis/ManagementApi.md#inviteuserexternal) | **POST** /v1/users/invite | Invite user from identity provider
*ManagementApi* | [**ListAccountCollections**](docs/apis/ManagementApi.md#listaccountcollections) | **GET** /v1/collections | List collections in account
*ManagementApi* | [**ListAchievements**](docs/apis/ManagementApi.md#listachievements) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements | List achievements
*ManagementApi* | [**ListAllRolesV2**](docs/apis/ManagementApi.md#listallrolesv2) | **GET** /v2/roles | List roles
*ManagementApi* | [**ListCampaignStoreBudgetLimits**](docs/apis/ManagementApi.md#listcampaignstorebudgetlimits) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets | List campaign store budget limits
*ManagementApi* | [**ListCatalogItems**](docs/apis/ManagementApi.md#listcatalogitems) | **GET** /v1/catalogs/{catalogId}/items | List items in a catalog
*ManagementApi* | [**ListCollections**](docs/apis/ManagementApi.md#listcollections) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections | List collections in campaign
*ManagementApi* | [**ListCollectionsInApplication**](docs/apis/ManagementApi.md#listcollectionsinapplication) | **GET** /v1/applications/{applicationId}/collections | List collections in Application
*ManagementApi* | [**ListStores**](docs/apis/ManagementApi.md#liststores) | **GET** /v1/applications/{applicationId}/stores | List stores
*ManagementApi* | [**OktaEventHandlerChallenge**](docs/apis/ManagementApi.md#oktaeventhandlerchallenge) | **GET** /v1/provisioning/okta | Validate Okta API ownership
*ManagementApi* | [**RemoveLoyaltyPoints**](docs/apis/ManagementApi.md#removeloyaltypoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/deduct_points | Deduct points from customer profile
*ManagementApi* | [**ResetPassword**](docs/apis/ManagementApi.md#resetpassword) | **POST** /v1/reset_password | Reset password
*ManagementApi* | [**ScimCreateGroup**](docs/apis/ManagementApi.md#scimcreategroup) | **POST** /v1/provisioning/scim/Groups | Create SCIM group
*ManagementApi* | [**ScimCreateUser**](docs/apis/ManagementApi.md#scimcreateuser) | **POST** /v1/provisioning/scim/Users | Create SCIM user
*ManagementApi* | [**ScimDeleteGroup**](docs/apis/ManagementApi.md#scimdeletegroup) | **DELETE** /v1/provisioning/scim/Groups/{groupId} | Delete SCIM group
*ManagementApi* | [**ScimDeleteUser**](docs/apis/ManagementApi.md#scimdeleteuser) | **DELETE** /v1/provisioning/scim/Users/{userId} | Delete SCIM user
*ManagementApi* | [**ScimGetGroup**](docs/apis/ManagementApi.md#scimgetgroup) | **GET** /v1/provisioning/scim/Groups/{groupId} | Get SCIM group
*ManagementApi* | [**ScimGetGroups**](docs/apis/ManagementApi.md#scimgetgroups) | **GET** /v1/provisioning/scim/Groups | List SCIM groups
*ManagementApi* | [**ScimGetResourceTypes**](docs/apis/ManagementApi.md#scimgetresourcetypes) | **GET** /v1/provisioning/scim/ResourceTypes | List supported SCIM resource types
*ManagementApi* | [**ScimGetSchemas**](docs/apis/ManagementApi.md#scimgetschemas) | **GET** /v1/provisioning/scim/Schemas | List supported SCIM schemas
*ManagementApi* | [**ScimGetServiceProviderConfig**](docs/apis/ManagementApi.md#scimgetserviceproviderconfig) | **GET** /v1/provisioning/scim/ServiceProviderConfig | Get SCIM service provider configuration
*ManagementApi* | [**ScimGetUser**](docs/apis/ManagementApi.md#scimgetuser) | **GET** /v1/provisioning/scim/Users/{userId} | Get SCIM user
*ManagementApi* | [**ScimGetUsers**](docs/apis/ManagementApi.md#scimgetusers) | **GET** /v1/provisioning/scim/Users | List SCIM users
*ManagementApi* | [**ScimPatchGroup**](docs/apis/ManagementApi.md#scimpatchgroup) | **PATCH** /v1/provisioning/scim/Groups/{groupId} | Update SCIM group attributes
*ManagementApi* | [**ScimPatchUser**](docs/apis/ManagementApi.md#scimpatchuser) | **PATCH** /v1/provisioning/scim/Users/{userId} | Update SCIM user attributes
*ManagementApi* | [**ScimReplaceGroupAttributes**](docs/apis/ManagementApi.md#scimreplacegroupattributes) | **PUT** /v1/provisioning/scim/Groups/{groupId} | Update SCIM group
*ManagementApi* | [**ScimReplaceUserAttributes**](docs/apis/ManagementApi.md#scimreplaceuserattributes) | **PUT** /v1/provisioning/scim/Users/{userId} | Update SCIM user
*ManagementApi* | [**SearchCouponsAdvancedApplicationWideWithoutTotalCount**](docs/apis/ManagementApi.md#searchcouponsadvancedapplicationwidewithouttotalcount) | **POST** /v1/applications/{applicationId}/coupons_search_advanced/no_total | List coupons that match the given attributes (without total count)
*ManagementApi* | [**SearchCouponsAdvancedWithoutTotalCount**](docs/apis/ManagementApi.md#searchcouponsadvancedwithouttotalcount) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search_advanced/no_total | List coupons that match the given attributes in campaign (without total count)
*ManagementApi* | [**SummarizeCampaignStoreBudget**](docs/apis/ManagementApi.md#summarizecampaignstorebudget) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets/summary | Get summary of campaign store budgets
*ManagementApi* | [**TransferLoyaltyCard**](docs/apis/ManagementApi.md#transferloyaltycard) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/transfer | Transfer card data
*ManagementApi* | [**UpdateAccountCollection**](docs/apis/ManagementApi.md#updateaccountcollection) | **PUT** /v1/collections/{collectionId} | Update account-level collection
*ManagementApi* | [**UpdateAchievement**](docs/apis/ManagementApi.md#updateachievement) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Update achievement
*ManagementApi* | [**UpdateAdditionalCost**](docs/apis/ManagementApi.md#updateadditionalcost) | **PUT** /v1/additional_costs/{additionalCostId} | Update additional cost
*ManagementApi* | [**UpdateAttribute**](docs/apis/ManagementApi.md#updateattribute) | **PUT** /v1/attributes/{attributeId} | Update custom attribute
*ManagementApi* | [**UpdateCampaign**](docs/apis/ManagementApi.md#updatecampaign) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId} | Update campaign
*ManagementApi* | [**UpdateCollection**](docs/apis/ManagementApi.md#updatecollection) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Update campaign-level collection's description
*ManagementApi* | [**UpdateCoupon**](docs/apis/ManagementApi.md#updatecoupon) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Update coupon
*ManagementApi* | [**UpdateCouponBatch**](docs/apis/ManagementApi.md#updatecouponbatch) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Update coupons
*ManagementApi* | [**UpdateLoyaltyCard**](docs/apis/ManagementApi.md#updateloyaltycard) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Update loyalty card status
*ManagementApi* | [**UpdateReferral**](docs/apis/ManagementApi.md#updatereferral) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Update referral
*ManagementApi* | [**UpdateRoleV2**](docs/apis/ManagementApi.md#updaterolev2) | **PUT** /v2/roles/{roleId} | Update role
*ManagementApi* | [**UpdateStore**](docs/apis/ManagementApi.md#updatestore) | **PUT** /v1/applications/{applicationId}/stores/{storeId} | Update store
*ManagementApi* | [**UpdateUser**](docs/apis/ManagementApi.md#updateuser) | **PUT** /v1/users/{userId} | Update user

## Documentation for models

- [Model.APIError](docs/models/APIError.md)
- [Model.AcceptCouponEffectProps](docs/models/AcceptCouponEffectProps.md)
- [Model.AcceptReferralEffectProps](docs/models/AcceptReferralEffectProps.md)
- [Model.AccessLogEntry](docs/models/AccessLogEntry.md)
- [Model.Account](docs/models/Account.md)
- [Model.AccountAdditionalCost](docs/models/AccountAdditionalCost.md)
- [Model.AccountAnalytics](docs/models/AccountAnalytics.md)
- [Model.AccountDashboardStatistic](docs/models/AccountDashboardStatistic.md)
- [Model.AccountDashboardStatisticCampaigns](docs/models/AccountDashboardStatisticCampaigns.md)
- [Model.AccountDashboardStatisticDiscount](docs/models/AccountDashboardStatisticDiscount.md)
- [Model.AccountDashboardStatisticLoyaltyPoints](docs/models/AccountDashboardStatisticLoyaltyPoints.md)
- [Model.AccountDashboardStatisticReferrals](docs/models/AccountDashboardStatisticReferrals.md)
- [Model.AccountDashboardStatisticRevenue](docs/models/AccountDashboardStatisticRevenue.md)
- [Model.AccountEntity](docs/models/AccountEntity.md)
- [Model.AccountLimits](docs/models/AccountLimits.md)
- [Model.Achievement](docs/models/Achievement.md)
- [Model.AchievementAdditionalProperties](docs/models/AchievementAdditionalProperties.md)
- [Model.AchievementBase](docs/models/AchievementBase.md)
- [Model.AchievementProgress](docs/models/AchievementProgress.md)
- [Model.AchievementProgressWithDefinition](docs/models/AchievementProgressWithDefinition.md)
- [Model.AchievementStatusEntry](docs/models/AchievementStatusEntry.md)
- [Model.ActivateLoyaltyPoints](docs/models/ActivateLoyaltyPoints.md)
- [Model.ActivateLoyaltyPointsResponse](docs/models/ActivateLoyaltyPointsResponse.md)
- [Model.ActivateUserRequest](docs/models/ActivateUserRequest.md)
- [Model.AddFreeItemEffectProps](docs/models/AddFreeItemEffectProps.md)
- [Model.AddItemCatalogAction](docs/models/AddItemCatalogAction.md)
- [Model.AddLoyaltyPoints](docs/models/AddLoyaltyPoints.md)
- [Model.AddLoyaltyPointsEffectProps](docs/models/AddLoyaltyPointsEffectProps.md)
- [Model.AddPriceAdjustmentCatalogAction](docs/models/AddPriceAdjustmentCatalogAction.md)
- [Model.AddToAudienceEffectProps](docs/models/AddToAudienceEffectProps.md)
- [Model.AddedDeductedPointsBalancesAction](docs/models/AddedDeductedPointsBalancesAction.md)
- [Model.AddedDeductedPointsBalancesNotification](docs/models/AddedDeductedPointsBalancesNotification.md)
- [Model.AddedDeductedPointsBalancesNotificationPolicy](docs/models/AddedDeductedPointsBalancesNotificationPolicy.md)
- [Model.AddedDeductedPointsNotification](docs/models/AddedDeductedPointsNotification.md)
- [Model.AddedDeductedPointsNotificationPolicy](docs/models/AddedDeductedPointsNotificationPolicy.md)
- [Model.AdditionalCampaignProperties](docs/models/AdditionalCampaignProperties.md)
- [Model.AdditionalCost](docs/models/AdditionalCost.md)
- [Model.AnalyticsDataPoint](docs/models/AnalyticsDataPoint.md)
- [Model.AnalyticsDataPointWithTrend](docs/models/AnalyticsDataPointWithTrend.md)
- [Model.AnalyticsDataPointWithTrendAndInfluencedRate](docs/models/AnalyticsDataPointWithTrendAndInfluencedRate.md)
- [Model.AnalyticsDataPointWithTrendAndUplift](docs/models/AnalyticsDataPointWithTrendAndUplift.md)
- [Model.AnalyticsProduct](docs/models/AnalyticsProduct.md)
- [Model.AnalyticsSKU](docs/models/AnalyticsSKU.md)
- [Model.Application](docs/models/Application.md)
- [Model.ApplicationAPIKey](docs/models/ApplicationAPIKey.md)
- [Model.ApplicationAnalyticsDataPoint](docs/models/ApplicationAnalyticsDataPoint.md)
- [Model.ApplicationApiHealth](docs/models/ApplicationApiHealth.md)
- [Model.ApplicationCIF](docs/models/ApplicationCIF.md)
- [Model.ApplicationCIFExpression](docs/models/ApplicationCIFExpression.md)
- [Model.ApplicationCIFReferences](docs/models/ApplicationCIFReferences.md)
- [Model.ApplicationCampaignAnalytics](docs/models/ApplicationCampaignAnalytics.md)
- [Model.ApplicationCampaignStats](docs/models/ApplicationCampaignStats.md)
- [Model.ApplicationCustomer](docs/models/ApplicationCustomer.md)
- [Model.ApplicationCustomerEntity](docs/models/ApplicationCustomerEntity.md)
- [Model.ApplicationEntity](docs/models/ApplicationEntity.md)
- [Model.ApplicationEvent](docs/models/ApplicationEvent.md)
- [Model.ApplicationNotification](docs/models/ApplicationNotification.md)
- [Model.ApplicationReferee](docs/models/ApplicationReferee.md)
- [Model.ApplicationSession](docs/models/ApplicationSession.md)
- [Model.ApplicationSessionEntity](docs/models/ApplicationSessionEntity.md)
- [Model.ApplicationStoreEntity](docs/models/ApplicationStoreEntity.md)
- [Model.AsyncCouponCreationResponse](docs/models/AsyncCouponCreationResponse.md)
- [Model.AsyncCouponDeletionJobResponse](docs/models/AsyncCouponDeletionJobResponse.md)
- [Model.AsyncCouponsData](docs/models/AsyncCouponsData.md)
- [Model.Attribute](docs/models/Attribute.md)
- [Model.AttributesMandatory](docs/models/AttributesMandatory.md)
- [Model.AttributesSettings](docs/models/AttributesSettings.md)
- [Model.Audience](docs/models/Audience.md)
- [Model.AudienceAnalytics](docs/models/AudienceAnalytics.md)
- [Model.AudienceCustomer](docs/models/AudienceCustomer.md)
- [Model.AudienceIntegrationID](docs/models/AudienceIntegrationID.md)
- [Model.AudienceMembership](docs/models/AudienceMembership.md)
- [Model.AudienceReference](docs/models/AudienceReference.md)
- [Model.AwardGiveawayEffectProps](docs/models/AwardGiveawayEffectProps.md)
- [Model.BaseCampaign](docs/models/BaseCampaign.md)
- [Model.BaseLoyaltyProgram](docs/models/BaseLoyaltyProgram.md)
- [Model.BaseNotification](docs/models/BaseNotification.md)
- [Model.BaseNotificationEntity](docs/models/BaseNotificationEntity.md)
- [Model.BaseNotificationWebhook](docs/models/BaseNotificationWebhook.md)
- [Model.BaseNotifications](docs/models/BaseNotifications.md)
- [Model.BaseSamlConnection](docs/models/BaseSamlConnection.md)
- [Model.BestPriorPrice](docs/models/BestPriorPrice.md)
- [Model.BestPriorPriceMetadata](docs/models/BestPriorPriceMetadata.md)
- [Model.BestPriorPriceRequest](docs/models/BestPriorPriceRequest.md)
- [Model.BestPriorPriceRequestTarget](docs/models/BestPriorPriceRequestTarget.md)
- [Model.Binding](docs/models/Binding.md)
- [Model.BulkApplicationNotification](docs/models/BulkApplicationNotification.md)
- [Model.BulkOperationOnCampaigns](docs/models/BulkOperationOnCampaigns.md)
- [Model.Campaign](docs/models/Campaign.md)
- [Model.CampaignActivationRequest](docs/models/CampaignActivationRequest.md)
- [Model.CampaignAnalytics](docs/models/CampaignAnalytics.md)
- [Model.CampaignBudget](docs/models/CampaignBudget.md)
- [Model.CampaignCollection](docs/models/CampaignCollection.md)
- [Model.CampaignCollectionEditedNotification](docs/models/CampaignCollectionEditedNotification.md)
- [Model.CampaignCollectionEditedNotificationItem](docs/models/CampaignCollectionEditedNotificationItem.md)
- [Model.CampaignCollectionWithoutPayload](docs/models/CampaignCollectionWithoutPayload.md)
- [Model.CampaignCopy](docs/models/CampaignCopy.md)
- [Model.CampaignCreatedNotification](docs/models/CampaignCreatedNotification.md)
- [Model.CampaignCreatedNotificationItem](docs/models/CampaignCreatedNotificationItem.md)
- [Model.CampaignDeactivationRequest](docs/models/CampaignDeactivationRequest.md)
- [Model.CampaignDeletedNotification](docs/models/CampaignDeletedNotification.md)
- [Model.CampaignDeletedNotificationItem](docs/models/CampaignDeletedNotificationItem.md)
- [Model.CampaignDetail](docs/models/CampaignDetail.md)
- [Model.CampaignEditedNotification](docs/models/CampaignEditedNotification.md)
- [Model.CampaignEditedNotificationItem](docs/models/CampaignEditedNotificationItem.md)
- [Model.CampaignEntity](docs/models/CampaignEntity.md)
- [Model.CampaignEvaluationGroup](docs/models/CampaignEvaluationGroup.md)
- [Model.CampaignEvaluationPosition](docs/models/CampaignEvaluationPosition.md)
- [Model.CampaignEvaluationTreeChangedMessage](docs/models/CampaignEvaluationTreeChangedMessage.md)
- [Model.CampaignEvaluationTreeChangedNotification](docs/models/CampaignEvaluationTreeChangedNotification.md)
- [Model.CampaignGroup](docs/models/CampaignGroup.md)
- [Model.CampaignGroupEntity](docs/models/CampaignGroupEntity.md)
- [Model.CampaignLogSummary](docs/models/CampaignLogSummary.md)
- [Model.CampaignNotificationBase](docs/models/CampaignNotificationBase.md)
- [Model.CampaignNotificationGeneric](docs/models/CampaignNotificationGeneric.md)
- [Model.CampaignNotificationItemBase](docs/models/CampaignNotificationItemBase.md)
- [Model.CampaignNotificationPolicy](docs/models/CampaignNotificationPolicy.md)
- [Model.CampaignRulesetChangedNotification](docs/models/CampaignRulesetChangedNotification.md)
- [Model.CampaignRulesetChangedNotificationItem](docs/models/CampaignRulesetChangedNotificationItem.md)
- [Model.CampaignSearch](docs/models/CampaignSearch.md)
- [Model.CampaignSet](docs/models/CampaignSet.md)
- [Model.CampaignSetBranchNode](docs/models/CampaignSetBranchNode.md)
- [Model.CampaignSetLeafNode](docs/models/CampaignSetLeafNode.md)
- [Model.CampaignSetNode](docs/models/CampaignSetNode.md)
- [Model.CampaignStateChangedNotification](docs/models/CampaignStateChangedNotification.md)
- [Model.CampaignStateChangedNotificationItem](docs/models/CampaignStateChangedNotificationItem.md)
- [Model.CampaignStoreBudget](docs/models/CampaignStoreBudget.md)
- [Model.CampaignStoreBudgetLimitConfig](docs/models/CampaignStoreBudgetLimitConfig.md)
- [Model.CampaignTemplate](docs/models/CampaignTemplate.md)
- [Model.CampaignTemplateCollection](docs/models/CampaignTemplateCollection.md)
- [Model.CampaignTemplateCouponReservationSettings](docs/models/CampaignTemplateCouponReservationSettings.md)
- [Model.CampaignTemplateParams](docs/models/CampaignTemplateParams.md)
- [Model.CampaignVersions](docs/models/CampaignVersions.md)
- [Model.CardAddedDeductedPointsBalancesNotification](docs/models/CardAddedDeductedPointsBalancesNotification.md)
- [Model.CardAddedDeductedPointsBalancesNotificationPolicy](docs/models/CardAddedDeductedPointsBalancesNotificationPolicy.md)
- [Model.CardAddedDeductedPointsNotification](docs/models/CardAddedDeductedPointsNotification.md)
- [Model.CardAddedDeductedPointsNotificationPolicy](docs/models/CardAddedDeductedPointsNotificationPolicy.md)
- [Model.CardExpiringPointsNotificationPolicy](docs/models/CardExpiringPointsNotificationPolicy.md)
- [Model.CardExpiringPointsNotificationTrigger](docs/models/CardExpiringPointsNotificationTrigger.md)
- [Model.CardLedgerPointsEntryIntegrationAPI](docs/models/CardLedgerPointsEntryIntegrationAPI.md)
- [Model.CardLedgerTransactionLogEntry](docs/models/CardLedgerTransactionLogEntry.md)
- [Model.CardLedgerTransactionLogEntryIntegrationAPI](docs/models/CardLedgerTransactionLogEntryIntegrationAPI.md)
- [Model.CartItem](docs/models/CartItem.md)
- [Model.Catalog](docs/models/Catalog.md)
- [Model.CatalogActionFilter](docs/models/CatalogActionFilter.md)
- [Model.CatalogItem](docs/models/CatalogItem.md)
- [Model.CatalogSyncRequest](docs/models/CatalogSyncRequest.md)
- [Model.CatalogsStrikethroughNotificationPolicy](docs/models/CatalogsStrikethroughNotificationPolicy.md)
- [Model.Change](docs/models/Change.md)
- [Model.ChangeLoyaltyTierLevelEffectProps](docs/models/ChangeLoyaltyTierLevelEffectProps.md)
- [Model.ChangeProfilePassword](docs/models/ChangeProfilePassword.md)
- [Model.CodeGeneratorSettings](docs/models/CodeGeneratorSettings.md)
- [Model.Collection](docs/models/Collection.md)
- [Model.CollectionItem](docs/models/CollectionItem.md)
- [Model.CollectionWithoutPayload](docs/models/CollectionWithoutPayload.md)
- [Model.Coupon](docs/models/Coupon.md)
- [Model.CouponConstraints](docs/models/CouponConstraints.md)
- [Model.CouponCreatedEffectProps](docs/models/CouponCreatedEffectProps.md)
- [Model.CouponCreationJob](docs/models/CouponCreationJob.md)
- [Model.CouponDeletionFilters](docs/models/CouponDeletionFilters.md)
- [Model.CouponDeletionJob](docs/models/CouponDeletionJob.md)
- [Model.CouponEntity](docs/models/CouponEntity.md)
- [Model.CouponFailureSummary](docs/models/CouponFailureSummary.md)
- [Model.CouponLimitConfigs](docs/models/CouponLimitConfigs.md)
- [Model.CouponRejectionReason](docs/models/CouponRejectionReason.md)
- [Model.CouponRejections](docs/models/CouponRejections.md)
- [Model.CouponReservations](docs/models/CouponReservations.md)
- [Model.CouponSearch](docs/models/CouponSearch.md)
- [Model.CouponValue](docs/models/CouponValue.md)
- [Model.CouponsNotificationData](docs/models/CouponsNotificationData.md)
- [Model.CouponsNotificationPolicy](docs/models/CouponsNotificationPolicy.md)
- [Model.CreateAchievement](docs/models/CreateAchievement.md)
- [Model.CreateApplicationAPIKey](docs/models/CreateApplicationAPIKey.md)
- [Model.CreateCouponData](docs/models/CreateCouponData.md)
- [Model.CreateCoupons200Response](docs/models/CreateCoupons200Response.md)
- [Model.CreateManagementKey](docs/models/CreateManagementKey.md)
- [Model.CreateReferralsForMultipleAdvocates201Response](docs/models/CreateReferralsForMultipleAdvocates201Response.md)
- [Model.CreateTemplateCampaign](docs/models/CreateTemplateCampaign.md)
- [Model.CreateTemplateCampaignResponse](docs/models/CreateTemplateCampaignResponse.md)
- [Model.CustomEffect](docs/models/CustomEffect.md)
- [Model.CustomEffectProps](docs/models/CustomEffectProps.md)
- [Model.CustomerActivityReport](docs/models/CustomerActivityReport.md)
- [Model.CustomerAnalytics](docs/models/CustomerAnalytics.md)
- [Model.CustomerInventory](docs/models/CustomerInventory.md)
- [Model.CustomerProfile](docs/models/CustomerProfile.md)
- [Model.CustomerProfileAudienceRequest](docs/models/CustomerProfileAudienceRequest.md)
- [Model.CustomerProfileAudienceRequestItem](docs/models/CustomerProfileAudienceRequestItem.md)
- [Model.CustomerProfileEntity](docs/models/CustomerProfileEntity.md)
- [Model.CustomerProfileIntegrationRequestV2](docs/models/CustomerProfileIntegrationRequestV2.md)
- [Model.CustomerProfileIntegrationResponseV2](docs/models/CustomerProfileIntegrationResponseV2.md)
- [Model.CustomerProfileSearchQuery](docs/models/CustomerProfileSearchQuery.md)
- [Model.CustomerProfileUpdateV2Response](docs/models/CustomerProfileUpdateV2Response.md)
- [Model.CustomerSession](docs/models/CustomerSession.md)
- [Model.CustomerSessionV2](docs/models/CustomerSessionV2.md)
- [Model.DeactivateUserRequest](docs/models/DeactivateUserRequest.md)
- [Model.DeductLoyaltyPoints](docs/models/DeductLoyaltyPoints.md)
- [Model.DeductLoyaltyPointsEffectProps](docs/models/DeductLoyaltyPointsEffectProps.md)
- [Model.DeleteCouponsData](docs/models/DeleteCouponsData.md)
- [Model.DeleteUserRequest](docs/models/DeleteUserRequest.md)
- [Model.Effect](docs/models/Effect.md)
- [Model.EffectEntity](docs/models/EffectEntity.md)
- [Model.EmailEntity](docs/models/EmailEntity.md)
- [Model.Endpoint](docs/models/Endpoint.md)
- [Model.Entity](docs/models/Entity.md)
- [Model.EntityWithTalangVisibleID](docs/models/EntityWithTalangVisibleID.md)
- [Model.ErrorEffectProps](docs/models/ErrorEffectProps.md)
- [Model.ErrorResponse](docs/models/ErrorResponse.md)
- [Model.ErrorResponseWithStatus](docs/models/ErrorResponseWithStatus.md)
- [Model.ErrorSource](docs/models/ErrorSource.md)
- [Model.EvaluableCampaignIds](docs/models/EvaluableCampaignIds.md)
- [Model.Event](docs/models/Event.md)
- [Model.EventType](docs/models/EventType.md)
- [Model.EventV2](docs/models/EventV2.md)
- [Model.EventV3](docs/models/EventV3.md)
- [Model.ExpiringCardPointsData](docs/models/ExpiringCardPointsData.md)
- [Model.ExpiringCardPointsNotification](docs/models/ExpiringCardPointsNotification.md)
- [Model.ExpiringCouponsData](docs/models/ExpiringCouponsData.md)
- [Model.ExpiringCouponsNotification](docs/models/ExpiringCouponsNotification.md)
- [Model.ExpiringCouponsNotificationPolicy](docs/models/ExpiringCouponsNotificationPolicy.md)
- [Model.ExpiringCouponsNotificationTrigger](docs/models/ExpiringCouponsNotificationTrigger.md)
- [Model.ExpiringPointsData](docs/models/ExpiringPointsData.md)
- [Model.ExpiringPointsNotification](docs/models/ExpiringPointsNotification.md)
- [Model.ExpiringPointsNotificationPolicy](docs/models/ExpiringPointsNotificationPolicy.md)
- [Model.ExpiringPointsNotificationTrigger](docs/models/ExpiringPointsNotificationTrigger.md)
- [Model.Export](docs/models/Export.md)
- [Model.ExtendLoyaltyPointsExpiryDateEffectProps](docs/models/ExtendLoyaltyPointsExpiryDateEffectProps.md)
- [Model.ExtendedCoupon](docs/models/ExtendedCoupon.md)
- [Model.FeatureFlag](docs/models/FeatureFlag.md)
- [Model.FeaturesFeed](docs/models/FeaturesFeed.md)
- [Model.FuncArgDef](docs/models/FuncArgDef.md)
- [Model.FunctionDef](docs/models/FunctionDef.md)
- [Model.GenerateAuditLogSummary](docs/models/GenerateAuditLogSummary.md)
- [Model.GenerateCampaignDescription](docs/models/GenerateCampaignDescription.md)
- [Model.GenerateCampaignSummary](docs/models/GenerateCampaignSummary.md)
- [Model.GenerateCampaignTags](docs/models/GenerateCampaignTags.md)
- [Model.GenerateCouponFailureDetailedSummary](docs/models/GenerateCouponFailureDetailedSummary.md)
- [Model.GenerateCouponFailureSummary](docs/models/GenerateCouponFailureSummary.md)
- [Model.GenerateItemFilterDescription](docs/models/GenerateItemFilterDescription.md)
- [Model.GenerateLoyaltyCard](docs/models/GenerateLoyaltyCard.md)
- [Model.GenerateRuleTitle](docs/models/GenerateRuleTitle.md)
- [Model.GenerateRuleTitleRule](docs/models/GenerateRuleTitleRule.md)
- [Model.GenerateUserSessionSummary](docs/models/GenerateUserSessionSummary.md)
- [Model.GetAccessLogsWithoutTotalCount200Response](docs/models/GetAccessLogsWithoutTotalCount200Response.md)
- [Model.GetAdditionalCosts200Response](docs/models/GetAdditionalCosts200Response.md)
- [Model.GetApplicationCustomerFriends200Response](docs/models/GetApplicationCustomerFriends200Response.md)
- [Model.GetApplicationCustomers200Response](docs/models/GetApplicationCustomers200Response.md)
- [Model.GetApplicationCustomersByAttributes200Response](docs/models/GetApplicationCustomersByAttributes200Response.md)
- [Model.GetApplicationEventTypes200Response](docs/models/GetApplicationEventTypes200Response.md)
- [Model.GetApplicationEventsWithoutTotalCount200Response](docs/models/GetApplicationEventsWithoutTotalCount200Response.md)
- [Model.GetApplicationSessions200Response](docs/models/GetApplicationSessions200Response.md)
- [Model.GetApplications200Response](docs/models/GetApplications200Response.md)
- [Model.GetAttributes200Response](docs/models/GetAttributes200Response.md)
- [Model.GetAudienceMemberships200Response](docs/models/GetAudienceMemberships200Response.md)
- [Model.GetAudiences200Response](docs/models/GetAudiences200Response.md)
- [Model.GetAudiencesAnalytics200Response](docs/models/GetAudiencesAnalytics200Response.md)
- [Model.GetCampaignAnalytics200Response](docs/models/GetCampaignAnalytics200Response.md)
- [Model.GetCampaignGroups200Response](docs/models/GetCampaignGroups200Response.md)
- [Model.GetCampaignTemplates200Response](docs/models/GetCampaignTemplates200Response.md)
- [Model.GetCampaigns200Response](docs/models/GetCampaigns200Response.md)
- [Model.GetChanges200Response](docs/models/GetChanges200Response.md)
- [Model.GetCollectionItems200Response](docs/models/GetCollectionItems200Response.md)
- [Model.GetCouponsWithoutTotalCount200Response](docs/models/GetCouponsWithoutTotalCount200Response.md)
- [Model.GetCustomerAchievementHistory200Response](docs/models/GetCustomerAchievementHistory200Response.md)
- [Model.GetCustomerAchievements200Response](docs/models/GetCustomerAchievements200Response.md)
- [Model.GetCustomerActivityReportsWithoutTotalCount200Response](docs/models/GetCustomerActivityReportsWithoutTotalCount200Response.md)
- [Model.GetCustomerProfileAchievementProgress200Response](docs/models/GetCustomerProfileAchievementProgress200Response.md)
- [Model.GetCustomerProfiles200Response](docs/models/GetCustomerProfiles200Response.md)
- [Model.GetCustomersByAttributes200Response](docs/models/GetCustomersByAttributes200Response.md)
- [Model.GetDashboardStatistics200Response](docs/models/GetDashboardStatistics200Response.md)
- [Model.GetEventTypes200Response](docs/models/GetEventTypes200Response.md)
- [Model.GetExports200Response](docs/models/GetExports200Response.md)
- [Model.GetIntegrationCouponRequest](docs/models/GetIntegrationCouponRequest.md)
- [Model.GetLoyaltyCardPoints200Response](docs/models/GetLoyaltyCardPoints200Response.md)
- [Model.GetLoyaltyCardTransactionLogs200Response](docs/models/GetLoyaltyCardTransactionLogs200Response.md)
- [Model.GetLoyaltyCardTransactions200Response](docs/models/GetLoyaltyCardTransactions200Response.md)
- [Model.GetLoyaltyCards200Response](docs/models/GetLoyaltyCards200Response.md)
- [Model.GetLoyaltyProgramProfilePoints200Response](docs/models/GetLoyaltyProgramProfilePoints200Response.md)
- [Model.GetLoyaltyProgramProfileTransactions200Response](docs/models/GetLoyaltyProgramProfileTransactions200Response.md)
- [Model.GetLoyaltyProgramTransactions200Response](docs/models/GetLoyaltyProgramTransactions200Response.md)
- [Model.GetLoyaltyPrograms200Response](docs/models/GetLoyaltyPrograms200Response.md)
- [Model.GetReferralsWithoutTotalCount200Response](docs/models/GetReferralsWithoutTotalCount200Response.md)
- [Model.GetReservedCustomers200Response](docs/models/GetReservedCustomers200Response.md)
- [Model.GetRulesets200Response](docs/models/GetRulesets200Response.md)
- [Model.GetUsers200Response](docs/models/GetUsers200Response.md)
- [Model.GetWebhooks200Response](docs/models/GetWebhooks200Response.md)
- [Model.Giveaway](docs/models/Giveaway.md)
- [Model.GiveawaysPool](docs/models/GiveawaysPool.md)
- [Model.HiddenConditionsEffects](docs/models/HiddenConditionsEffects.md)
- [Model.IdentifiableEntity](docs/models/IdentifiableEntity.md)
- [Model.Import](docs/models/Import.md)
- [Model.ImportEntity](docs/models/ImportEntity.md)
- [Model.IncreaseAchievementProgressEffectProps](docs/models/IncreaseAchievementProgressEffectProps.md)
- [Model.IntegrationCoupon](docs/models/IntegrationCoupon.md)
- [Model.IntegrationCustomerProfileAudienceRequest](docs/models/IntegrationCustomerProfileAudienceRequest.md)
- [Model.IntegrationCustomerProfileAudienceRequestItem](docs/models/IntegrationCustomerProfileAudienceRequestItem.md)
- [Model.IntegrationCustomerSessionResponse](docs/models/IntegrationCustomerSessionResponse.md)
- [Model.IntegrationEntity](docs/models/IntegrationEntity.md)
- [Model.IntegrationEvent](docs/models/IntegrationEvent.md)
- [Model.IntegrationEventV2Request](docs/models/IntegrationEventV2Request.md)
- [Model.IntegrationEventV3Request](docs/models/IntegrationEventV3Request.md)
- [Model.IntegrationEventV3Response](docs/models/IntegrationEventV3Response.md)
- [Model.IntegrationProfileEntity](docs/models/IntegrationProfileEntity.md)
- [Model.IntegrationProfileEntityV3](docs/models/IntegrationProfileEntityV3.md)
- [Model.IntegrationRequest](docs/models/IntegrationRequest.md)
- [Model.IntegrationState](docs/models/IntegrationState.md)
- [Model.IntegrationStateV2](docs/models/IntegrationStateV2.md)
- [Model.IntegrationStoreEntity](docs/models/IntegrationStoreEntity.md)
- [Model.InventoryCoupon](docs/models/InventoryCoupon.md)
- [Model.InventoryReferral](docs/models/InventoryReferral.md)
- [Model.ItemAttribute](docs/models/ItemAttribute.md)
- [Model.LabelTargetAudience](docs/models/LabelTargetAudience.md)
- [Model.LabelTargetNone](docs/models/LabelTargetNone.md)
- [Model.LedgerEntry](docs/models/LedgerEntry.md)
- [Model.LedgerInfo](docs/models/LedgerInfo.md)
- [Model.LedgerPointsEntryIntegrationAPI](docs/models/LedgerPointsEntryIntegrationAPI.md)
- [Model.LedgerTransactionLogEntryIntegrationAPI](docs/models/LedgerTransactionLogEntryIntegrationAPI.md)
- [Model.LibraryAttribute](docs/models/LibraryAttribute.md)
- [Model.LimitConfig](docs/models/LimitConfig.md)
- [Model.LimitCounter](docs/models/LimitCounter.md)
- [Model.ListAccountCollections200Response](docs/models/ListAccountCollections200Response.md)
- [Model.ListAchievements200Response](docs/models/ListAchievements200Response.md)
- [Model.ListAllRolesV2200Response](docs/models/ListAllRolesV2200Response.md)
- [Model.ListCampaignStoreBudgetLimits200Response](docs/models/ListCampaignStoreBudgetLimits200Response.md)
- [Model.ListCampaignStoreBudgets](docs/models/ListCampaignStoreBudgets.md)
- [Model.ListCampaignStoreBudgetsStore](docs/models/ListCampaignStoreBudgetsStore.md)
- [Model.ListCatalogItems200Response](docs/models/ListCatalogItems200Response.md)
- [Model.ListStores200Response](docs/models/ListStores200Response.md)
- [Model.LoginParams](docs/models/LoginParams.md)
- [Model.Loyalty](docs/models/Loyalty.md)
- [Model.LoyaltyBalance](docs/models/LoyaltyBalance.md)
- [Model.LoyaltyBalanceWithTier](docs/models/LoyaltyBalanceWithTier.md)
- [Model.LoyaltyBalances](docs/models/LoyaltyBalances.md)
- [Model.LoyaltyBalancesWithTiers](docs/models/LoyaltyBalancesWithTiers.md)
- [Model.LoyaltyCard](docs/models/LoyaltyCard.md)
- [Model.LoyaltyCardBalances](docs/models/LoyaltyCardBalances.md)
- [Model.LoyaltyCardBatch](docs/models/LoyaltyCardBatch.md)
- [Model.LoyaltyCardBatchResponse](docs/models/LoyaltyCardBatchResponse.md)
- [Model.LoyaltyCardProfileRegistration](docs/models/LoyaltyCardProfileRegistration.md)
- [Model.LoyaltyCardRegistration](docs/models/LoyaltyCardRegistration.md)
- [Model.LoyaltyDashboardData](docs/models/LoyaltyDashboardData.md)
- [Model.LoyaltyDashboardPointsBreakdown](docs/models/LoyaltyDashboardPointsBreakdown.md)
- [Model.LoyaltyLedger](docs/models/LoyaltyLedger.md)
- [Model.LoyaltyLedgerEntry](docs/models/LoyaltyLedgerEntry.md)
- [Model.LoyaltyLedgerEntryExpiryDateChange](docs/models/LoyaltyLedgerEntryExpiryDateChange.md)
- [Model.LoyaltyLedgerEntryFlags](docs/models/LoyaltyLedgerEntryFlags.md)
- [Model.LoyaltyLedgerTransactions](docs/models/LoyaltyLedgerTransactions.md)
- [Model.LoyaltyMembership](docs/models/LoyaltyMembership.md)
- [Model.LoyaltyProgram](docs/models/LoyaltyProgram.md)
- [Model.LoyaltyProgramBalance](docs/models/LoyaltyProgramBalance.md)
- [Model.LoyaltyProgramEntity](docs/models/LoyaltyProgramEntity.md)
- [Model.LoyaltyProgramLedgers](docs/models/LoyaltyProgramLedgers.md)
- [Model.LoyaltyProgramTransaction](docs/models/LoyaltyProgramTransaction.md)
- [Model.LoyaltySubLedger](docs/models/LoyaltySubLedger.md)
- [Model.LoyaltyTier](docs/models/LoyaltyTier.md)
- [Model.ManagementKey](docs/models/ManagementKey.md)
- [Model.ManagerConfig](docs/models/ManagerConfig.md)
- [Model.MessageLogEntries](docs/models/MessageLogEntries.md)
- [Model.MessageLogEntry](docs/models/MessageLogEntry.md)
- [Model.MessageLogRequest](docs/models/MessageLogRequest.md)
- [Model.MessageLogResponse](docs/models/MessageLogResponse.md)
- [Model.MessageTest](docs/models/MessageTest.md)
- [Model.Meta](docs/models/Meta.md)
- [Model.ModelEnvironment](docs/models/ModelEnvironment.md)
- [Model.MultiApplicationEntity](docs/models/MultiApplicationEntity.md)
- [Model.MultipleAttribute](docs/models/MultipleAttribute.md)
- [Model.MultipleAudiences](docs/models/MultipleAudiences.md)
- [Model.MultipleAudiencesItem](docs/models/MultipleAudiencesItem.md)
- [Model.MultipleCustomerProfileIntegrationRequest](docs/models/MultipleCustomerProfileIntegrationRequest.md)
- [Model.MultipleCustomerProfileIntegrationRequestItem](docs/models/MultipleCustomerProfileIntegrationRequestItem.md)
- [Model.MultipleCustomerProfileIntegrationResponseV2](docs/models/MultipleCustomerProfileIntegrationResponseV2.md)
- [Model.MultipleNewAttribute](docs/models/MultipleNewAttribute.md)
- [Model.MultipleNewAudiences](docs/models/MultipleNewAudiences.md)
- [Model.MutableEntity](docs/models/MutableEntity.md)
- [Model.NewAccount](docs/models/NewAccount.md)
- [Model.NewAccountSignUp](docs/models/NewAccountSignUp.md)
- [Model.NewAdditionalCost](docs/models/NewAdditionalCost.md)
- [Model.NewAppWideCouponDeletionJob](docs/models/NewAppWideCouponDeletionJob.md)
- [Model.NewApplication](docs/models/NewApplication.md)
- [Model.NewApplicationAPIKey](docs/models/NewApplicationAPIKey.md)
- [Model.NewApplicationCIF](docs/models/NewApplicationCIF.md)
- [Model.NewApplicationCIFExpression](docs/models/NewApplicationCIFExpression.md)
- [Model.NewAttribute](docs/models/NewAttribute.md)
- [Model.NewAudience](docs/models/NewAudience.md)
- [Model.NewBaseNotification](docs/models/NewBaseNotification.md)
- [Model.NewCampaign](docs/models/NewCampaign.md)
- [Model.NewCampaignCollection](docs/models/NewCampaignCollection.md)
- [Model.NewCampaignEvaluationGroup](docs/models/NewCampaignEvaluationGroup.md)
- [Model.NewCampaignGroup](docs/models/NewCampaignGroup.md)
- [Model.NewCampaignSet](docs/models/NewCampaignSet.md)
- [Model.NewCampaignStoreBudget](docs/models/NewCampaignStoreBudget.md)
- [Model.NewCampaignStoreBudgetStoreLimit](docs/models/NewCampaignStoreBudgetStoreLimit.md)
- [Model.NewCampaignTemplate](docs/models/NewCampaignTemplate.md)
- [Model.NewCatalog](docs/models/NewCatalog.md)
- [Model.NewCollection](docs/models/NewCollection.md)
- [Model.NewCouponCreationJob](docs/models/NewCouponCreationJob.md)
- [Model.NewCouponDeletionJob](docs/models/NewCouponDeletionJob.md)
- [Model.NewCoupons](docs/models/NewCoupons.md)
- [Model.NewCouponsForMultipleRecipients](docs/models/NewCouponsForMultipleRecipients.md)
- [Model.NewCustomEffect](docs/models/NewCustomEffect.md)
- [Model.NewCustomerProfile](docs/models/NewCustomerProfile.md)
- [Model.NewCustomerSession](docs/models/NewCustomerSession.md)
- [Model.NewCustomerSessionV2](docs/models/NewCustomerSessionV2.md)
- [Model.NewEvent](docs/models/NewEvent.md)
- [Model.NewEventType](docs/models/NewEventType.md)
- [Model.NewExternalInvitation](docs/models/NewExternalInvitation.md)
- [Model.NewGiveawaysPool](docs/models/NewGiveawaysPool.md)
- [Model.NewInternalAudience](docs/models/NewInternalAudience.md)
- [Model.NewInvitation](docs/models/NewInvitation.md)
- [Model.NewInviteEmail](docs/models/NewInviteEmail.md)
- [Model.NewLoyaltyProgram](docs/models/NewLoyaltyProgram.md)
- [Model.NewLoyaltyTier](docs/models/NewLoyaltyTier.md)
- [Model.NewManagementKey](docs/models/NewManagementKey.md)
- [Model.NewMessageTest](docs/models/NewMessageTest.md)
- [Model.NewMultipleAudiencesItem](docs/models/NewMultipleAudiencesItem.md)
- [Model.NewNotificationWebhook](docs/models/NewNotificationWebhook.md)
- [Model.NewOutgoingIntegrationWebhook](docs/models/NewOutgoingIntegrationWebhook.md)
- [Model.NewPassword](docs/models/NewPassword.md)
- [Model.NewPasswordEmail](docs/models/NewPasswordEmail.md)
- [Model.NewPicklist](docs/models/NewPicklist.md)
- [Model.NewPriceAdjustment](docs/models/NewPriceAdjustment.md)
- [Model.NewPriceType](docs/models/NewPriceType.md)
- [Model.NewReferral](docs/models/NewReferral.md)
- [Model.NewReferralsForMultipleAdvocates](docs/models/NewReferralsForMultipleAdvocates.md)
- [Model.NewReturn](docs/models/NewReturn.md)
- [Model.NewRevisionVersion](docs/models/NewRevisionVersion.md)
- [Model.NewRole](docs/models/NewRole.md)
- [Model.NewRoleV2](docs/models/NewRoleV2.md)
- [Model.NewRuleset](docs/models/NewRuleset.md)
- [Model.NewSamlConnection](docs/models/NewSamlConnection.md)
- [Model.NewSecondaryDeployment](docs/models/NewSecondaryDeployment.md)
- [Model.NewStore](docs/models/NewStore.md)
- [Model.NewTemplateDef](docs/models/NewTemplateDef.md)
- [Model.NewUser](docs/models/NewUser.md)
- [Model.NewWebhook](docs/models/NewWebhook.md)
- [Model.Notification](docs/models/Notification.md)
- [Model.NotificationActivation](docs/models/NotificationActivation.md)
- [Model.NotificationListItem](docs/models/NotificationListItem.md)
- [Model.OktaEvent](docs/models/OktaEvent.md)
- [Model.OktaEventPayload](docs/models/OktaEventPayload.md)
- [Model.OktaEventPayloadData](docs/models/OktaEventPayloadData.md)
- [Model.OktaEventTarget](docs/models/OktaEventTarget.md)
- [Model.OneTimeCode](docs/models/OneTimeCode.md)
- [Model.OutgoingIntegrationBrazePolicy](docs/models/OutgoingIntegrationBrazePolicy.md)
- [Model.OutgoingIntegrationCleverTapPolicy](docs/models/OutgoingIntegrationCleverTapPolicy.md)
- [Model.OutgoingIntegrationConfiguration](docs/models/OutgoingIntegrationConfiguration.md)
- [Model.OutgoingIntegrationIterablePolicy](docs/models/OutgoingIntegrationIterablePolicy.md)
- [Model.OutgoingIntegrationMoEngagePolicy](docs/models/OutgoingIntegrationMoEngagePolicy.md)
- [Model.OutgoingIntegrationTemplate](docs/models/OutgoingIntegrationTemplate.md)
- [Model.OutgoingIntegrationTemplateWithConfigurationDetails](docs/models/OutgoingIntegrationTemplateWithConfigurationDetails.md)
- [Model.OutgoingIntegrationTemplates](docs/models/OutgoingIntegrationTemplates.md)
- [Model.OutgoingIntegrationType](docs/models/OutgoingIntegrationType.md)
- [Model.OutgoingIntegrationTypes](docs/models/OutgoingIntegrationTypes.md)
- [Model.PatchItemCatalogAction](docs/models/PatchItemCatalogAction.md)
- [Model.PatchManyItemsCatalogAction](docs/models/PatchManyItemsCatalogAction.md)
- [Model.PendingActivePointsData](docs/models/PendingActivePointsData.md)
- [Model.PendingActivePointsNotification](docs/models/PendingActivePointsNotification.md)
- [Model.PendingPointsNotificationPolicy](docs/models/PendingPointsNotificationPolicy.md)
- [Model.Picklist](docs/models/Picklist.md)
- [Model.PriceDetail](docs/models/PriceDetail.md)
- [Model.PriceType](docs/models/PriceType.md)
- [Model.PriceTypeReferenceDetail](docs/models/PriceTypeReferenceDetail.md)
- [Model.PriceTypeReferences](docs/models/PriceTypeReferences.md)
- [Model.PrismaticConfig](docs/models/PrismaticConfig.md)
- [Model.PrismaticEventPayloadCouponBasedNotifications](docs/models/PrismaticEventPayloadCouponBasedNotifications.md)
- [Model.PrismaticEventPayloadCouponBasedNotificationsLimits](docs/models/PrismaticEventPayloadCouponBasedNotificationsLimits.md)
- [Model.PrismaticEventPayloadLoyaltyProfileBasedNotifications](docs/models/PrismaticEventPayloadLoyaltyProfileBasedNotifications.md)
- [Model.PrismaticEventPayloadLoyaltyProfileBasedNotificationsAction](docs/models/PrismaticEventPayloadLoyaltyProfileBasedNotificationsAction.md)
- [Model.PrismaticFlow](docs/models/PrismaticFlow.md)
- [Model.PrismaticFlowConfig](docs/models/PrismaticFlowConfig.md)
- [Model.PrismaticFlowWithConfig](docs/models/PrismaticFlowWithConfig.md)
- [Model.PrismaticPaginatedEventPayload](docs/models/PrismaticPaginatedEventPayload.md)
- [Model.Product](docs/models/Product.md)
- [Model.ProductSearchMatch](docs/models/ProductSearchMatch.md)
- [Model.ProductUnitAnalytics](docs/models/ProductUnitAnalytics.md)
- [Model.ProductUnitAnalyticsDataPoint](docs/models/ProductUnitAnalyticsDataPoint.md)
- [Model.ProductUnitAnalyticsTotals](docs/models/ProductUnitAnalyticsTotals.md)
- [Model.ProfileAudiencesChanges](docs/models/ProfileAudiencesChanges.md)
- [Model.ProjectedTier](docs/models/ProjectedTier.md)
- [Model.RedeemReferralEffectProps](docs/models/RedeemReferralEffectProps.md)
- [Model.Referral](docs/models/Referral.md)
- [Model.ReferralConstraints](docs/models/ReferralConstraints.md)
- [Model.ReferralCreatedEffectProps](docs/models/ReferralCreatedEffectProps.md)
- [Model.ReferralRejectionReason](docs/models/ReferralRejectionReason.md)
- [Model.RejectCouponEffectProps](docs/models/RejectCouponEffectProps.md)
- [Model.RejectReferralEffectProps](docs/models/RejectReferralEffectProps.md)
- [Model.RemoveFromAudienceEffectProps](docs/models/RemoveFromAudienceEffectProps.md)
- [Model.RemoveItemCatalogAction](docs/models/RemoveItemCatalogAction.md)
- [Model.RemoveManyItemsCatalogAction](docs/models/RemoveManyItemsCatalogAction.md)
- [Model.ReopenSessionResponse](docs/models/ReopenSessionResponse.md)
- [Model.ReserveCouponEffectProps](docs/models/ReserveCouponEffectProps.md)
- [Model.Return](docs/models/Return.md)
- [Model.ReturnIntegrationRequest](docs/models/ReturnIntegrationRequest.md)
- [Model.ReturnedCartItem](docs/models/ReturnedCartItem.md)
- [Model.Revision](docs/models/Revision.md)
- [Model.RevisionActivation](docs/models/RevisionActivation.md)
- [Model.RevisionActivationRequest](docs/models/RevisionActivationRequest.md)
- [Model.RevisionVersion](docs/models/RevisionVersion.md)
- [Model.Role](docs/models/Role.md)
- [Model.RoleAssign](docs/models/RoleAssign.md)
- [Model.RoleMembership](docs/models/RoleMembership.md)
- [Model.RoleV2](docs/models/RoleV2.md)
- [Model.RoleV2ApplicationDetails](docs/models/RoleV2ApplicationDetails.md)
- [Model.RoleV2Base](docs/models/RoleV2Base.md)
- [Model.RoleV2PermissionSet](docs/models/RoleV2PermissionSet.md)
- [Model.RoleV2Permissions](docs/models/RoleV2Permissions.md)
- [Model.RoleV2Readonly](docs/models/RoleV2Readonly.md)
- [Model.RoleV2RolesGroup](docs/models/RoleV2RolesGroup.md)
- [Model.RollbackAddedLoyaltyPointsEffectProps](docs/models/RollbackAddedLoyaltyPointsEffectProps.md)
- [Model.RollbackCouponEffectProps](docs/models/RollbackCouponEffectProps.md)
- [Model.RollbackDeductedLoyaltyPointsEffectProps](docs/models/RollbackDeductedLoyaltyPointsEffectProps.md)
- [Model.RollbackDiscountEffectProps](docs/models/RollbackDiscountEffectProps.md)
- [Model.RollbackIncreasedAchievementProgressEffectProps](docs/models/RollbackIncreasedAchievementProgressEffectProps.md)
- [Model.RollbackReferralEffectProps](docs/models/RollbackReferralEffectProps.md)
- [Model.Rule](docs/models/Rule.md)
- [Model.RuleFailureReason](docs/models/RuleFailureReason.md)
- [Model.Ruleset](docs/models/Ruleset.md)
- [Model.SSOConfig](docs/models/SSOConfig.md)
- [Model.SamlConnection](docs/models/SamlConnection.md)
- [Model.SamlConnectionInternal](docs/models/SamlConnectionInternal.md)
- [Model.SamlConnectionMetadata](docs/models/SamlConnectionMetadata.md)
- [Model.SamlLoginEndpoint](docs/models/SamlLoginEndpoint.md)
- [Model.ScimBaseGroup](docs/models/ScimBaseGroup.md)
- [Model.ScimBaseUser](docs/models/ScimBaseUser.md)
- [Model.ScimBaseUserName](docs/models/ScimBaseUserName.md)
- [Model.ScimGroup](docs/models/ScimGroup.md)
- [Model.ScimGroupMember](docs/models/ScimGroupMember.md)
- [Model.ScimGroupsListResponse](docs/models/ScimGroupsListResponse.md)
- [Model.ScimNewUser](docs/models/ScimNewUser.md)
- [Model.ScimPatchOperation](docs/models/ScimPatchOperation.md)
- [Model.ScimPatchRequest](docs/models/ScimPatchRequest.md)
- [Model.ScimResource](docs/models/ScimResource.md)
- [Model.ScimResourceTypesListResponse](docs/models/ScimResourceTypesListResponse.md)
- [Model.ScimSchemaResource](docs/models/ScimSchemaResource.md)
- [Model.ScimSchemasListResponse](docs/models/ScimSchemasListResponse.md)
- [Model.ScimServiceProviderConfigResponse](docs/models/ScimServiceProviderConfigResponse.md)
- [Model.ScimServiceProviderConfigResponseBulk](docs/models/ScimServiceProviderConfigResponseBulk.md)
- [Model.ScimServiceProviderConfigResponseChangePassword](docs/models/ScimServiceProviderConfigResponseChangePassword.md)
- [Model.ScimServiceProviderConfigResponseFilter](docs/models/ScimServiceProviderConfigResponseFilter.md)
- [Model.ScimServiceProviderConfigResponsePatch](docs/models/ScimServiceProviderConfigResponsePatch.md)
- [Model.ScimServiceProviderConfigResponseSort](docs/models/ScimServiceProviderConfigResponseSort.md)
- [Model.ScimUser](docs/models/ScimUser.md)
- [Model.ScimUsersListResponse](docs/models/ScimUsersListResponse.md)
- [Model.SecondaryDeployment](docs/models/SecondaryDeployment.md)
- [Model.Session](docs/models/Session.md)
- [Model.SessionCoupons](docs/models/SessionCoupons.md)
- [Model.SetDiscountEffectProps](docs/models/SetDiscountEffectProps.md)
- [Model.SetDiscountPerAdditionalCostEffectProps](docs/models/SetDiscountPerAdditionalCostEffectProps.md)
- [Model.SetDiscountPerAdditionalCostPerItemEffectProps](docs/models/SetDiscountPerAdditionalCostPerItemEffectProps.md)
- [Model.SetDiscountPerItemEffectProps](docs/models/SetDiscountPerItemEffectProps.md)
- [Model.SetLoyaltyPointsExpiryDateEffectProps](docs/models/SetLoyaltyPointsExpiryDateEffectProps.md)
- [Model.ShowBundleMetadataEffectProps](docs/models/ShowBundleMetadataEffectProps.md)
- [Model.ShowNotificationEffectProps](docs/models/ShowNotificationEffectProps.md)
- [Model.SkuUnitAnalytics](docs/models/SkuUnitAnalytics.md)
- [Model.SkuUnitAnalyticsDataPoint](docs/models/SkuUnitAnalyticsDataPoint.md)
- [Model.SlotDef](docs/models/SlotDef.md)
- [Model.Store](docs/models/Store.md)
- [Model.StrikethroughChangedItem](docs/models/StrikethroughChangedItem.md)
- [Model.StrikethroughCustomEffectPerItemProps](docs/models/StrikethroughCustomEffectPerItemProps.md)
- [Model.StrikethroughDebugResponse](docs/models/StrikethroughDebugResponse.md)
- [Model.StrikethroughEffect](docs/models/StrikethroughEffect.md)
- [Model.StrikethroughLabelingNotification](docs/models/StrikethroughLabelingNotification.md)
- [Model.StrikethroughSetDiscountPerItemEffectProps](docs/models/StrikethroughSetDiscountPerItemEffectProps.md)
- [Model.StrikethroughSetDiscountPerItemMemberEffectProps](docs/models/StrikethroughSetDiscountPerItemMemberEffectProps.md)
- [Model.StrikethroughTrigger](docs/models/StrikethroughTrigger.md)
- [Model.SummarizeCampaignStoreBudget200Response](docs/models/SummarizeCampaignStoreBudget200Response.md)
- [Model.SummaryCampaignStoreBudget](docs/models/SummaryCampaignStoreBudget.md)
- [Model.TalangAttribute](docs/models/TalangAttribute.md)
- [Model.TalangAttributeVisibility](docs/models/TalangAttributeVisibility.md)
- [Model.TemplateArgDef](docs/models/TemplateArgDef.md)
- [Model.TemplateDef](docs/models/TemplateDef.md)
- [Model.TemplateLimitConfig](docs/models/TemplateLimitConfig.md)
- [Model.Tier](docs/models/Tier.md)
- [Model.TierDowngradeData](docs/models/TierDowngradeData.md)
- [Model.TierDowngradeNotification](docs/models/TierDowngradeNotification.md)
- [Model.TierDowngradeNotificationPolicy](docs/models/TierDowngradeNotificationPolicy.md)
- [Model.TierUpgradeData](docs/models/TierUpgradeData.md)
- [Model.TierUpgradeNotification](docs/models/TierUpgradeNotification.md)
- [Model.TierUpgradeNotificationPolicy](docs/models/TierUpgradeNotificationPolicy.md)
- [Model.TierWillDowngradeData](docs/models/TierWillDowngradeData.md)
- [Model.TierWillDowngradeNotification](docs/models/TierWillDowngradeNotification.md)
- [Model.TierWillDowngradeNotificationPolicy](docs/models/TierWillDowngradeNotificationPolicy.md)
- [Model.TierWillDowngradeNotificationTrigger](docs/models/TierWillDowngradeNotificationTrigger.md)
- [Model.TimePoint](docs/models/TimePoint.md)
- [Model.TrackEventV2Response](docs/models/TrackEventV2Response.md)
- [Model.TransferLoyaltyCard](docs/models/TransferLoyaltyCard.md)
- [Model.TriggerWebhookEffectProps](docs/models/TriggerWebhookEffectProps.md)
- [Model.TwoFAConfig](docs/models/TwoFAConfig.md)
- [Model.UpdateAccount](docs/models/UpdateAccount.md)
- [Model.UpdateAchievement](docs/models/UpdateAchievement.md)
- [Model.UpdateApplication](docs/models/UpdateApplication.md)
- [Model.UpdateApplicationAPIKey](docs/models/UpdateApplicationAPIKey.md)
- [Model.UpdateApplicationCIF](docs/models/UpdateApplicationCIF.md)
- [Model.UpdateAttributeEffectProps](docs/models/UpdateAttributeEffectProps.md)
- [Model.UpdateAudience](docs/models/UpdateAudience.md)
- [Model.UpdateCampaign](docs/models/UpdateCampaign.md)
- [Model.UpdateCampaignCollection](docs/models/UpdateCampaignCollection.md)
- [Model.UpdateCampaignEvaluationGroup](docs/models/UpdateCampaignEvaluationGroup.md)
- [Model.UpdateCampaignGroup](docs/models/UpdateCampaignGroup.md)
- [Model.UpdateCampaignTemplate](docs/models/UpdateCampaignTemplate.md)
- [Model.UpdateCatalog](docs/models/UpdateCatalog.md)
- [Model.UpdateCollection](docs/models/UpdateCollection.md)
- [Model.UpdateCoupon](docs/models/UpdateCoupon.md)
- [Model.UpdateCouponBatch](docs/models/UpdateCouponBatch.md)
- [Model.UpdateCouponsData](docs/models/UpdateCouponsData.md)
- [Model.UpdateCustomEffect](docs/models/UpdateCustomEffect.md)
- [Model.UpdateCustomerProfileV2409Response](docs/models/UpdateCustomerProfileV2409Response.md)
- [Model.UpdateCustomerSessionV2409Response](docs/models/UpdateCustomerSessionV2409Response.md)
- [Model.UpdateLoyaltyCard](docs/models/UpdateLoyaltyCard.md)
- [Model.UpdateLoyaltyProgram](docs/models/UpdateLoyaltyProgram.md)
- [Model.UpdateLoyaltyProgramTier](docs/models/UpdateLoyaltyProgramTier.md)
- [Model.UpdatePicklist](docs/models/UpdatePicklist.md)
- [Model.UpdatePriceType](docs/models/UpdatePriceType.md)
- [Model.UpdateReferral](docs/models/UpdateReferral.md)
- [Model.UpdateReferralBatch](docs/models/UpdateReferralBatch.md)
- [Model.UpdateRole](docs/models/UpdateRole.md)
- [Model.UpdateStore](docs/models/UpdateStore.md)
- [Model.UpdateUser](docs/models/UpdateUser.md)
- [Model.User](docs/models/User.md)
- [Model.UserEntity](docs/models/UserEntity.md)
- [Model.ValueMap](docs/models/ValueMap.md)
- [Model.Webhook](docs/models/Webhook.md)
- [Model.WebhookAuthentication](docs/models/WebhookAuthentication.md)
- [Model.WebhookAuthenticationBase](docs/models/WebhookAuthenticationBase.md)
- [Model.WebhookAuthenticationDataBasic](docs/models/WebhookAuthenticationDataBasic.md)
- [Model.WebhookAuthenticationDataCustom](docs/models/WebhookAuthenticationDataCustom.md)
- [Model.WebhookAuthenticationWebhookRef](docs/models/WebhookAuthenticationWebhookRef.md)
- [Model.WebhookWithOutgoingIntegrationDetails](docs/models/WebhookWithOutgoingIntegrationDetails.md)
- [Model.WillAwardGiveawayEffectProps](docs/models/WillAwardGiveawayEffectProps.md)

## Authorization

### api_key_v1

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

### manager_auth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

### management_key

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

