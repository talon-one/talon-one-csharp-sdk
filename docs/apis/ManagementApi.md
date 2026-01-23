# TalonOneSdk.Api.ManagementApi

All URIs are relative to *https://yourbaseurl.talon.one*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateUserByEmail**](ManagementApi.md#activateuserbyemail) | **POST** /v1/users/activate | Enable user by email address |
| [**AddLoyaltyCardPoints**](ManagementApi.md#addloyaltycardpoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/add_points | Add points to card |
| [**AddLoyaltyPoints**](ManagementApi.md#addloyaltypoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/add_points | Add points to customer profile |
| [**CopyCampaignToApplications**](ManagementApi.md#copycampaigntoapplications) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/copy | Copy the campaign into the specified Application |
| [**CreateAccountCollection**](ManagementApi.md#createaccountcollection) | **POST** /v1/collections | Create account-level collection |
| [**CreateAchievement**](ManagementApi.md#createachievement) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements | Create achievement |
| [**CreateAdditionalCost**](ManagementApi.md#createadditionalcost) | **POST** /v1/additional_costs | Create additional cost |
| [**CreateAttribute**](ManagementApi.md#createattribute) | **POST** /v1/attributes | Create custom attribute |
| [**CreateBatchLoyaltyCards**](ManagementApi.md#createbatchloyaltycards) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/cards/batch | Create loyalty cards |
| [**CreateCampaignFromTemplate**](ManagementApi.md#createcampaignfromtemplate) | **POST** /v1/applications/{applicationId}/create_campaign_from_template | Create campaign from campaign template |
| [**CreateCampaignStoreBudget**](ManagementApi.md#createcampaignstorebudget) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets | Create campaign store budget |
| [**CreateCollection**](ManagementApi.md#createcollection) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/collections | Create campaign-level collection |
| [**CreateCoupons**](ManagementApi.md#createcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Create coupons |
| [**CreateCouponsAsync**](ManagementApi.md#createcouponsasync) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_async | Create coupons asynchronously |
| [**CreateCouponsDeletionJob**](ManagementApi.md#createcouponsdeletionjob) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_deletion_jobs | Creates a coupon deletion job |
| [**CreateCouponsForMultipleRecipients**](ManagementApi.md#createcouponsformultiplerecipients) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_with_recipients | Create coupons for multiple recipients |
| [**CreateInviteEmail**](ManagementApi.md#createinviteemail) | **POST** /v1/invite_emails | Resend invitation email |
| [**CreateInviteV2**](ManagementApi.md#createinvitev2) | **POST** /v2/invites | Invite user |
| [**CreatePasswordRecoveryEmail**](ManagementApi.md#createpasswordrecoveryemail) | **POST** /v1/password_recovery_emails | Request a password reset |
| [**CreateSession**](ManagementApi.md#createsession) | **POST** /v1/sessions | Create session |
| [**CreateStore**](ManagementApi.md#createstore) | **POST** /v1/applications/{applicationId}/stores | Create store |
| [**DeactivateUserByEmail**](ManagementApi.md#deactivateuserbyemail) | **POST** /v1/users/deactivate | Disable user by email address |
| [**DeductLoyaltyCardPoints**](ManagementApi.md#deductloyaltycardpoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/deduct_points | Deduct points from card |
| [**DeleteAccountCollection**](ManagementApi.md#deleteaccountcollection) | **DELETE** /v1/collections/{collectionId} | Delete account-level collection |
| [**DeleteAchievement**](ManagementApi.md#deleteachievement) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Delete achievement |
| [**DeleteCampaign**](ManagementApi.md#deletecampaign) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId} | Delete campaign |
| [**DeleteCampaignStoreBudgets**](ManagementApi.md#deletecampaignstorebudgets) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets | Delete campaign store budgets |
| [**DeleteCollection**](ManagementApi.md#deletecollection) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Delete campaign-level collection |
| [**DeleteCoupon**](ManagementApi.md#deletecoupon) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Delete coupon |
| [**DeleteCoupons**](ManagementApi.md#deletecoupons) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Delete coupons |
| [**DeleteLoyaltyCard**](ManagementApi.md#deleteloyaltycard) | **DELETE** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Delete loyalty card |
| [**DeleteReferral**](ManagementApi.md#deletereferral) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Delete referral |
| [**DeleteStore**](ManagementApi.md#deletestore) | **DELETE** /v1/applications/{applicationId}/stores/{storeId} | Delete store |
| [**DeleteUser**](ManagementApi.md#deleteuser) | **DELETE** /v1/users/{userId} | Delete user |
| [**DeleteUserByEmail**](ManagementApi.md#deleteuserbyemail) | **POST** /v1/users/delete | Delete user by email address |
| [**DestroySession**](ManagementApi.md#destroysession) | **DELETE** /v1/sessions | Destroy session |
| [**DisconnectCampaignStores**](ManagementApi.md#disconnectcampaignstores) | **DELETE** /v1/applications/{applicationId}/campaigns/{campaignId}/stores | Disconnect stores |
| [**ExportAccountCollectionItems**](ManagementApi.md#exportaccountcollectionitems) | **GET** /v1/collections/{collectionId}/export | Export account-level collection&#39;s items |
| [**ExportAchievements**](ManagementApi.md#exportachievements) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId}/export | Export achievement customer data |
| [**ExportAudiencesMemberships**](ManagementApi.md#exportaudiencesmemberships) | **GET** /v1/audiences/{audienceId}/memberships/export | Export audience members |
| [**ExportCampaignStoreBudgets**](ManagementApi.md#exportcampaignstorebudgets) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets/export | Export campaign store budgets |
| [**ExportCampaignStores**](ManagementApi.md#exportcampaignstores) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/export | Export stores |
| [**ExportCollectionItems**](ManagementApi.md#exportcollectionitems) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId}/export | Export campaign-level collection&#39;s items |
| [**ExportCoupons**](ManagementApi.md#exportcoupons) | **GET** /v1/applications/{applicationId}/export_coupons | Export coupons |
| [**ExportCustomerSessions**](ManagementApi.md#exportcustomersessions) | **GET** /v1/applications/{applicationId}/export_customer_sessions | Export customer sessions |
| [**ExportCustomersTiers**](ManagementApi.md#exportcustomerstiers) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customers_tiers | Export customers&#39; tier data |
| [**ExportEffects**](ManagementApi.md#exporteffects) | **GET** /v1/applications/{applicationId}/export_effects | Export triggered effects |
| [**ExportLoyaltyBalance**](ManagementApi.md#exportloyaltybalance) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customer_balance | Export customer loyalty balance to CSV |
| [**ExportLoyaltyBalances**](ManagementApi.md#exportloyaltybalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_customer_balances | Export customer loyalty balances |
| [**ExportLoyaltyCardBalances**](ManagementApi.md#exportloyaltycardbalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/export_card_balances | Export all card transaction logs |
| [**ExportLoyaltyCardLedger**](ManagementApi.md#exportloyaltycardledger) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/export_log | Export card&#39;s ledger log |
| [**ExportLoyaltyCards**](ManagementApi.md#exportloyaltycards) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/export | Export loyalty cards |
| [**ExportLoyaltyLedger**](ManagementApi.md#exportloyaltyledger) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/export_log | Export customer&#39;s transaction logs |
| [**ExportPoolGiveaways**](ManagementApi.md#exportpoolgiveaways) | **GET** /v1/giveaways/pools/{poolId}/export | Export giveaway codes of a giveaway pool |
| [**ExportReferrals**](ManagementApi.md#exportreferrals) | **GET** /v1/applications/{applicationId}/export_referrals | Export referrals |
| [**GenerateCouponRejections**](ManagementApi.md#generatecouponrejections) | **GET** /v1/coupon_rejections | Summarize coupon redemption failures in session |
| [**GetAccessLogsWithoutTotalCount**](ManagementApi.md#getaccesslogswithouttotalcount) | **GET** /v1/applications/{applicationId}/access_logs/no_total | Get access logs for Application |
| [**GetAccount**](ManagementApi.md#getaccount) | **GET** /v1/accounts/{accountId} | Get account details |
| [**GetAccountAnalytics**](ManagementApi.md#getaccountanalytics) | **GET** /v1/accounts/{accountId}/analytics | Get account analytics |
| [**GetAccountCollection**](ManagementApi.md#getaccountcollection) | **GET** /v1/collections/{collectionId} | Get account-level collection |
| [**GetAchievement**](ManagementApi.md#getachievement) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Get achievement |
| [**GetAdditionalCost**](ManagementApi.md#getadditionalcost) | **GET** /v1/additional_costs/{additionalCostId} | Get additional cost |
| [**GetAdditionalCosts**](ManagementApi.md#getadditionalcosts) | **GET** /v1/additional_costs | List additional costs |
| [**GetApplication**](ManagementApi.md#getapplication) | **GET** /v1/applications/{applicationId} | Get Application |
| [**GetApplicationApiHealth**](ManagementApi.md#getapplicationapihealth) | **GET** /v1/applications/{applicationId}/health_report | Get Application health |
| [**GetApplicationCustomer**](ManagementApi.md#getapplicationcustomer) | **GET** /v1/applications/{applicationId}/customers/{customerId} | Get application&#39;s customer |
| [**GetApplicationCustomerFriends**](ManagementApi.md#getapplicationcustomerfriends) | **GET** /v1/applications/{applicationId}/profile/{integrationId}/friends | List friends referred by customer profile |
| [**GetApplicationCustomers**](ManagementApi.md#getapplicationcustomers) | **GET** /v1/applications/{applicationId}/customers | List application&#39;s customers |
| [**GetApplicationCustomersByAttributes**](ManagementApi.md#getapplicationcustomersbyattributes) | **POST** /v1/applications/{applicationId}/customer_search | List application customers matching the given attributes |
| [**GetApplicationEventTypes**](ManagementApi.md#getapplicationeventtypes) | **GET** /v1/applications/{applicationId}/event_types | List Applications event types |
| [**GetApplicationEventsWithoutTotalCount**](ManagementApi.md#getapplicationeventswithouttotalcount) | **GET** /v1/applications/{applicationId}/events/no_total | List Applications events |
| [**GetApplicationSession**](ManagementApi.md#getapplicationsession) | **GET** /v1/applications/{applicationId}/sessions/{sessionId} | Get Application session |
| [**GetApplicationSessions**](ManagementApi.md#getapplicationsessions) | **GET** /v1/applications/{applicationId}/sessions | List Application sessions |
| [**GetApplications**](ManagementApi.md#getapplications) | **GET** /v1/applications | List Applications |
| [**GetAttribute**](ManagementApi.md#getattribute) | **GET** /v1/attributes/{attributeId} | Get custom attribute |
| [**GetAttributes**](ManagementApi.md#getattributes) | **GET** /v1/attributes | List custom attributes |
| [**GetAudienceMemberships**](ManagementApi.md#getaudiencememberships) | **GET** /v1/audiences/{audienceId}/memberships | List audience members |
| [**GetAudiences**](ManagementApi.md#getaudiences) | **GET** /v1/audiences | List audiences |
| [**GetAudiencesAnalytics**](ManagementApi.md#getaudiencesanalytics) | **GET** /v1/audiences/analytics | List audience analytics |
| [**GetCampaign**](ManagementApi.md#getcampaign) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId} | Get campaign |
| [**GetCampaignAnalytics**](ManagementApi.md#getcampaignanalytics) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/analytics | Get analytics of campaigns |
| [**GetCampaignByAttributes**](ManagementApi.md#getcampaignbyattributes) | **POST** /v1/applications/{applicationId}/campaigns_search | List campaigns that match the given attributes |
| [**GetCampaignGroup**](ManagementApi.md#getcampaigngroup) | **GET** /v1/campaign_groups/{campaignGroupId} | Get campaign access group |
| [**GetCampaignGroups**](ManagementApi.md#getcampaigngroups) | **GET** /v1/campaign_groups | List campaign access groups |
| [**GetCampaignTemplates**](ManagementApi.md#getcampaigntemplates) | **GET** /v1/campaign_templates | List campaign templates |
| [**GetCampaigns**](ManagementApi.md#getcampaigns) | **GET** /v1/applications/{applicationId}/campaigns | List campaigns |
| [**GetChanges**](ManagementApi.md#getchanges) | **GET** /v1/changes | Get audit logs for an account |
| [**GetCollection**](ManagementApi.md#getcollection) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Get campaign-level collection |
| [**GetCollectionItems**](ManagementApi.md#getcollectionitems) | **GET** /v1/collections/{collectionId}/items | Get collection items |
| [**GetCouponsWithoutTotalCount**](ManagementApi.md#getcouponswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/no_total | List coupons |
| [**GetCustomerActivityReport**](ManagementApi.md#getcustomeractivityreport) | **GET** /v1/applications/{applicationId}/customer_activity_reports/{customerId} | Get customer&#39;s activity report |
| [**GetCustomerActivityReportsWithoutTotalCount**](ManagementApi.md#getcustomeractivityreportswithouttotalcount) | **GET** /v1/applications/{applicationId}/customer_activity_reports/no_total | Get Activity Reports for Application Customers |
| [**GetCustomerAnalytics**](ManagementApi.md#getcustomeranalytics) | **GET** /v1/applications/{applicationId}/customers/{customerId}/analytics | Get customer&#39;s analytics report |
| [**GetCustomerProfile**](ManagementApi.md#getcustomerprofile) | **GET** /v1/customers/{customerId} | Get customer profile |
| [**GetCustomerProfileAchievementProgress**](ManagementApi.md#getcustomerprofileachievementprogress) | **GET** /v1/applications/{applicationId}/achievement_progress/{integrationId} | List customer achievements |
| [**GetCustomerProfiles**](ManagementApi.md#getcustomerprofiles) | **GET** /v1/customers/no_total | List customer profiles |
| [**GetCustomersByAttributes**](ManagementApi.md#getcustomersbyattributes) | **POST** /v1/customer_search/no_total | List customer profiles matching the given attributes |
| [**GetDashboardStatistics**](ManagementApi.md#getdashboardstatistics) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/dashboard | Get statistics for loyalty dashboard |
| [**GetEventTypes**](ManagementApi.md#geteventtypes) | **GET** /v1/event_types | List event types |
| [**GetExports**](ManagementApi.md#getexports) | **GET** /v1/exports | Get exports |
| [**GetLoyaltyCard**](ManagementApi.md#getloyaltycard) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Get loyalty card |
| [**GetLoyaltyCardTransactionLogs**](ManagementApi.md#getloyaltycardtransactionlogs) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/logs | List card&#39;s transactions |
| [**GetLoyaltyCards**](ManagementApi.md#getloyaltycards) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/cards | List loyalty cards |
| [**GetLoyaltyLedgerBalances**](ManagementApi.md#getloyaltyledgerbalances) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/ledger_balances | Get customer&#39;s loyalty balances |
| [**GetLoyaltyPoints**](ManagementApi.md#getloyaltypoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId} | Get customer&#39;s full loyalty ledger |
| [**GetLoyaltyProgram**](ManagementApi.md#getloyaltyprogram) | **GET** /v1/loyalty_programs/{loyaltyProgramId} | Get loyalty program |
| [**GetLoyaltyProgramProfileLedgerTransactions**](ManagementApi.md#getloyaltyprogramprofileledgertransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/ledger_transactions | List customer&#39;s loyalty transactions |
| [**GetLoyaltyProgramTransactions**](ManagementApi.md#getloyaltyprogramtransactions) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/transactions | List loyalty program transactions |
| [**GetLoyaltyPrograms**](ManagementApi.md#getloyaltyprograms) | **GET** /v1/loyalty_programs | List loyalty programs |
| [**GetLoyaltyStatistics**](ManagementApi.md#getloyaltystatistics) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/statistics | Get loyalty program statistics |
| [**GetMessageLogs**](ManagementApi.md#getmessagelogs) | **GET** /v1/message_logs | List message log entries |
| [**GetReferralsWithoutTotalCount**](ManagementApi.md#getreferralswithouttotalcount) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/no_total | List referrals |
| [**GetRoleV2**](ManagementApi.md#getrolev2) | **GET** /v2/roles/{roleId} | Get role |
| [**GetRuleset**](ManagementApi.md#getruleset) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets/{rulesetId} | Get ruleset |
| [**GetRulesets**](ManagementApi.md#getrulesets) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/rulesets | List campaign rulesets |
| [**GetStore**](ManagementApi.md#getstore) | **GET** /v1/applications/{applicationId}/stores/{storeId} | Get store |
| [**GetUser**](ManagementApi.md#getuser) | **GET** /v1/users/{userId} | Get user |
| [**GetUsers**](ManagementApi.md#getusers) | **GET** /v1/users | List users in account |
| [**GetWebhook**](ManagementApi.md#getwebhook) | **GET** /v1/webhooks/{webhookId} | Get webhook |
| [**GetWebhooks**](ManagementApi.md#getwebhooks) | **GET** /v1/webhooks | List webhooks |
| [**ImportAccountCollection**](ManagementApi.md#importaccountcollection) | **POST** /v1/collections/{collectionId}/import | Import data into existing account-level collection |
| [**ImportAllowedList**](ManagementApi.md#importallowedlist) | **POST** /v1/attributes/{attributeId}/allowed_list/import | Import allowed values for attribute |
| [**ImportAudiencesMemberships**](ManagementApi.md#importaudiencesmemberships) | **POST** /v1/audiences/{audienceId}/memberships/import | Import audience members |
| [**ImportCampaignStoreBudget**](ManagementApi.md#importcampaignstorebudget) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets/import | Import campaign store budgets |
| [**ImportCampaignStores**](ManagementApi.md#importcampaignstores) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/import | Import stores |
| [**ImportCollection**](ManagementApi.md#importcollection) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId}/import | Import data into existing campaign-level collection |
| [**ImportCoupons**](ManagementApi.md#importcoupons) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_coupons | Import coupons |
| [**ImportLoyaltyCards**](ManagementApi.md#importloyaltycards) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_cards | Import loyalty cards |
| [**ImportLoyaltyCustomersTiers**](ManagementApi.md#importloyaltycustomerstiers) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_customers_tiers | Import customers into loyalty tiers |
| [**ImportLoyaltyPoints**](ManagementApi.md#importloyaltypoints) | **POST** /v1/loyalty_programs/{loyaltyProgramId}/import_points | Import loyalty points |
| [**ImportPoolGiveaways**](ManagementApi.md#importpoolgiveaways) | **POST** /v1/giveaways/pools/{poolId}/import | Import giveaway codes into a giveaway pool |
| [**ImportReferrals**](ManagementApi.md#importreferrals) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/import_referrals | Import referrals |
| [**InviteUserExternal**](ManagementApi.md#inviteuserexternal) | **POST** /v1/users/invite | Invite user from identity provider |
| [**ListAccountCollections**](ManagementApi.md#listaccountcollections) | **GET** /v1/collections | List collections in account |
| [**ListAchievements**](ManagementApi.md#listachievements) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements | List achievements |
| [**ListAllRolesV2**](ManagementApi.md#listallrolesv2) | **GET** /v2/roles | List roles |
| [**ListCampaignStoreBudgetLimits**](ManagementApi.md#listcampaignstorebudgetlimits) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets | List campaign store budget limits |
| [**ListCatalogItems**](ManagementApi.md#listcatalogitems) | **GET** /v1/catalogs/{catalogId}/items | List items in a catalog |
| [**ListCollections**](ManagementApi.md#listcollections) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/collections | List collections in campaign |
| [**ListCollectionsInApplication**](ManagementApi.md#listcollectionsinapplication) | **GET** /v1/applications/{applicationId}/collections | List collections in Application |
| [**ListStores**](ManagementApi.md#liststores) | **GET** /v1/applications/{applicationId}/stores | List stores |
| [**OktaEventHandlerChallenge**](ManagementApi.md#oktaeventhandlerchallenge) | **GET** /v1/provisioning/okta | Validate Okta API ownership |
| [**RemoveLoyaltyPoints**](ManagementApi.md#removeloyaltypoints) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId}/deduct_points | Deduct points from customer profile |
| [**ResetPassword**](ManagementApi.md#resetpassword) | **POST** /v1/reset_password | Reset password |
| [**ScimCreateGroup**](ManagementApi.md#scimcreategroup) | **POST** /v1/provisioning/scim/Groups | Create SCIM group |
| [**ScimCreateUser**](ManagementApi.md#scimcreateuser) | **POST** /v1/provisioning/scim/Users | Create SCIM user |
| [**ScimDeleteGroup**](ManagementApi.md#scimdeletegroup) | **DELETE** /v1/provisioning/scim/Groups/{groupId} | Delete SCIM group |
| [**ScimDeleteUser**](ManagementApi.md#scimdeleteuser) | **DELETE** /v1/provisioning/scim/Users/{userId} | Delete SCIM user |
| [**ScimGetGroup**](ManagementApi.md#scimgetgroup) | **GET** /v1/provisioning/scim/Groups/{groupId} | Get SCIM group |
| [**ScimGetGroups**](ManagementApi.md#scimgetgroups) | **GET** /v1/provisioning/scim/Groups | List SCIM groups |
| [**ScimGetResourceTypes**](ManagementApi.md#scimgetresourcetypes) | **GET** /v1/provisioning/scim/ResourceTypes | List supported SCIM resource types |
| [**ScimGetSchemas**](ManagementApi.md#scimgetschemas) | **GET** /v1/provisioning/scim/Schemas | List supported SCIM schemas |
| [**ScimGetServiceProviderConfig**](ManagementApi.md#scimgetserviceproviderconfig) | **GET** /v1/provisioning/scim/ServiceProviderConfig | Get SCIM service provider configuration |
| [**ScimGetUser**](ManagementApi.md#scimgetuser) | **GET** /v1/provisioning/scim/Users/{userId} | Get SCIM user |
| [**ScimGetUsers**](ManagementApi.md#scimgetusers) | **GET** /v1/provisioning/scim/Users | List SCIM users |
| [**ScimPatchGroup**](ManagementApi.md#scimpatchgroup) | **PATCH** /v1/provisioning/scim/Groups/{groupId} | Update SCIM group attributes |
| [**ScimPatchUser**](ManagementApi.md#scimpatchuser) | **PATCH** /v1/provisioning/scim/Users/{userId} | Update SCIM user attributes |
| [**ScimReplaceGroupAttributes**](ManagementApi.md#scimreplacegroupattributes) | **PUT** /v1/provisioning/scim/Groups/{groupId} | Update SCIM group |
| [**ScimReplaceUserAttributes**](ManagementApi.md#scimreplaceuserattributes) | **PUT** /v1/provisioning/scim/Users/{userId} | Update SCIM user |
| [**SearchCouponsAdvancedApplicationWideWithoutTotalCount**](ManagementApi.md#searchcouponsadvancedapplicationwidewithouttotalcount) | **POST** /v1/applications/{applicationId}/coupons_search_advanced/no_total | List coupons that match the given attributes (without total count) |
| [**SearchCouponsAdvancedWithoutTotalCount**](ManagementApi.md#searchcouponsadvancedwithouttotalcount) | **POST** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons_search_advanced/no_total | List coupons that match the given attributes in campaign (without total count) |
| [**SummarizeCampaignStoreBudget**](ManagementApi.md#summarizecampaignstorebudget) | **GET** /v1/applications/{applicationId}/campaigns/{campaignId}/stores/budgets/summary | Get summary of campaign store budgets |
| [**TransferLoyaltyCard**](ManagementApi.md#transferloyaltycard) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId}/transfer | Transfer card data |
| [**UpdateAccountCollection**](ManagementApi.md#updateaccountcollection) | **PUT** /v1/collections/{collectionId} | Update account-level collection |
| [**UpdateAchievement**](ManagementApi.md#updateachievement) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/achievements/{achievementId} | Update achievement |
| [**UpdateAdditionalCost**](ManagementApi.md#updateadditionalcost) | **PUT** /v1/additional_costs/{additionalCostId} | Update additional cost |
| [**UpdateAttribute**](ManagementApi.md#updateattribute) | **PUT** /v1/attributes/{attributeId} | Update custom attribute |
| [**UpdateCampaign**](ManagementApi.md#updatecampaign) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId} | Update campaign |
| [**UpdateCollection**](ManagementApi.md#updatecollection) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/collections/{collectionId} | Update campaign-level collection&#39;s description |
| [**UpdateCoupon**](ManagementApi.md#updatecoupon) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons/{couponId} | Update coupon |
| [**UpdateCouponBatch**](ManagementApi.md#updatecouponbatch) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/coupons | Update coupons |
| [**UpdateLoyaltyCard**](ManagementApi.md#updateloyaltycard) | **PUT** /v1/loyalty_programs/{loyaltyProgramId}/cards/{loyaltyCardId} | Update loyalty card status |
| [**UpdateReferral**](ManagementApi.md#updatereferral) | **PUT** /v1/applications/{applicationId}/campaigns/{campaignId}/referrals/{referralId} | Update referral |
| [**UpdateRoleV2**](ManagementApi.md#updaterolev2) | **PUT** /v2/roles/{roleId} | Update role |
| [**UpdateStore**](ManagementApi.md#updatestore) | **PUT** /v1/applications/{applicationId}/stores/{storeId} | Update store |
| [**UpdateUser**](ManagementApi.md#updateuser) | **PUT** /v1/users/{userId} | Update user |

<a id="activateuserbyemail"></a>
# **ActivateUserByEmail**
> void ActivateUserByEmail (ActivateUserRequest activateUserRequest)

Enable user by email address

Enable a [disabled user](https://docs.talon.one/docs/product/account/account-settings/managing-users#disabling-a-user) by their email address. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activateUserRequest** | [**ActivateUserRequest**](ActivateUserRequest.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="addloyaltycardpoints"></a>
# **AddLoyaltyCardPoints**
> void AddLoyaltyCardPoints (long loyaltyProgramId, string loyaltyCardId, AddLoyaltyPoints addLoyaltyPoints)

Add points to card

Add points to the given loyalty card in the specified card-based loyalty program. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardId** | **string** | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  |  |
| **addLoyaltyPoints** | [**AddLoyaltyPoints**](AddLoyaltyPoints.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="addloyaltypoints"></a>
# **AddLoyaltyPoints**
> void AddLoyaltyPoints (string loyaltyProgramId, string integrationId, AddLoyaltyPoints addLoyaltyPoints)

Add points to customer profile

Add points in the specified loyalty program for the given customer.  To get the `integrationId` of the profile from a `sessionId`, use the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **string** | The identifier for the loyalty program. |  |
| **integrationId** | **string** | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  |  |
| **addLoyaltyPoints** | [**AddLoyaltyPoints**](AddLoyaltyPoints.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="copycampaigntoapplications"></a>
# **CopyCampaignToApplications**
> GetCampaigns200Response CopyCampaignToApplications (long applicationId, long campaignId, CampaignCopy campaignCopy)

Copy the campaign into the specified Application

Copy the campaign into all specified Applications.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **campaignCopy** | [**CampaignCopy**](CampaignCopy.md) | body |  |

### Return type

[**GetCampaigns200Response**](GetCampaigns200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createaccountcollection"></a>
# **CreateAccountCollection**
> Collection CreateAccountCollection (NewCollection newCollection)

Create account-level collection

Create an account-level collection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newCollection** | [**NewCollection**](NewCollection.md) | body |  |

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **409** | Conflict. A collection with this name already exists. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createachievement"></a>
# **CreateAchievement**
> Achievement CreateAchievement (long applicationId, long campaignId, CreateAchievement createAchievement)

Create achievement

Create a new achievement in a specific campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **createAchievement** | [**CreateAchievement**](CreateAchievement.md) | body |  |

### Return type

[**Achievement**](Achievement.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **409** | Conflict. An achievement with this name or title already exists. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createadditionalcost"></a>
# **CreateAdditionalCost**
> AccountAdditionalCost CreateAdditionalCost (NewAdditionalCost newAdditionalCost)

Create additional cost

Create an [additional cost](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs).  These additional costs are shared across all applications in your account, and are never required. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAdditionalCost** | [**NewAdditionalCost**](NewAdditionalCost.md) | body |  |

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createattribute"></a>
# **CreateAttribute**
> Attribute CreateAttribute (NewAttribute newAttribute)

Create custom attribute

Create a _custom attribute_ in this account. [Custom attributes](https://docs.talon.one/docs/dev/concepts/attributes) allow you to add data to Talon.One domain entities like campaigns, coupons, customers and so on.  These attributes can then be given values when creating/updating these entities, and these values can be used in your campaign rules.  For example, you could define a `zipCode` field for customer sessions, and add a rule to your campaign that only allows certain ZIP codes.  These attributes are shared across all Applications in your account and are never required. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAttribute** | [**NewAttribute**](NewAttribute.md) | body |  |

### Return type

[**Attribute**](Attribute.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createbatchloyaltycards"></a>
# **CreateBatchLoyaltyCards**
> LoyaltyCardBatchResponse CreateBatchLoyaltyCards (long loyaltyProgramId, LoyaltyCardBatch loyaltyCardBatch)

Create loyalty cards

Create a batch of loyalty cards in a specified [card-based loyalty program](https://docs.talon.one/docs/product/loyalty-programs/overview#loyalty-program-types).  Customers can use loyalty cards to collect and spend loyalty points.  **Important:**  - The specified card-based loyalty program must have a defined card code format that is used to generate the loyalty card codes. - Trying to create more than 20,000 loyalty cards in a single request returns an error message with a `400` status code. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardBatch** | [**LoyaltyCardBatch**](LoyaltyCardBatch.md) | body |  |

### Return type

[**LoyaltyCardBatchResponse**](LoyaltyCardBatchResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcampaignfromtemplate"></a>
# **CreateCampaignFromTemplate**
> CreateTemplateCampaignResponse CreateCampaignFromTemplate (long applicationId, CreateTemplateCampaign createTemplateCampaign)

Create campaign from campaign template

Use the campaign template referenced in the request body to create a new campaign in one of the connected Applications.  If the template was created from a campaign with rules referencing [campaign collections](https://docs.talon.one/docs/product/campaigns/managing-collections), the corresponding collections for the new campaign are created automatically. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **createTemplateCampaign** | [**CreateTemplateCampaign**](CreateTemplateCampaign.md) | body |  |

### Return type

[**CreateTemplateCampaignResponse**](CreateTemplateCampaignResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcampaignstorebudget"></a>
# **CreateCampaignStoreBudget**
> void CreateCampaignStoreBudget (long applicationId, long campaignId, NewCampaignStoreBudget newCampaignStoreBudget)

Create campaign store budget

Create a new store budget for a given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **newCampaignStoreBudget** | [**NewCampaignStoreBudget**](NewCampaignStoreBudget.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **409** | Conflict |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcollection"></a>
# **CreateCollection**
> Collection CreateCollection (long applicationId, long campaignId, NewCampaignCollection newCampaignCollection)

Create campaign-level collection

Create a campaign-level collection in a given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **newCampaignCollection** | [**NewCampaignCollection**](NewCampaignCollection.md) | body |  |

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcoupons"></a>
# **CreateCoupons**
> CreateCoupons200Response CreateCoupons (long applicationId, long campaignId, NewCoupons newCoupons, string silent = null)

Create coupons

Create coupons according to some pattern. Up to 20.000 coupons can be created without a unique prefix. When a unique prefix is provided, up to 200.000 coupons can be created.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **newCoupons** | [**NewCoupons**](NewCoupons.md) | body |  |
| **silent** | **string** | Possible values: &#x60;yes&#x60; or &#x60;no&#x60;. - &#x60;yes&#x60;: Increases the performance of the API call by returning a 204 response. - &#x60;no&#x60;: Returns a 200 response that contains the updated customer profiles.  | [optional] [default to &quot;yes&quot;] |

### Return type

[**CreateCoupons200Response**](CreateCoupons200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcouponsasync"></a>
# **CreateCouponsAsync**
> AsyncCouponCreationResponse CreateCouponsAsync (long applicationId, long campaignId, NewCouponCreationJob newCouponCreationJob)

Create coupons asynchronously

Create up to 5,000,000 coupons asynchronously. You should typically use this enpdoint when you create at least 20,001 coupons. You receive an email when the creation is complete.  If you want to create less than 20,001 coupons, you can use the [Create coupons](https://docs.talon.one/management-api#tag/Coupons/operation/createCoupons) endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **newCouponCreationJob** | [**NewCouponCreationJob**](NewCouponCreationJob.md) | body |  |

### Return type

[**AsyncCouponCreationResponse**](AsyncCouponCreationResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcouponsdeletionjob"></a>
# **CreateCouponsDeletionJob**
> AsyncCouponDeletionJobResponse CreateCouponsDeletionJob (long applicationId, long campaignId, NewCouponDeletionJob newCouponDeletionJob)

Creates a coupon deletion job

This endpoint handles creating a job to delete coupons asynchronously. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **newCouponDeletionJob** | [**NewCouponDeletionJob**](NewCouponDeletionJob.md) | body |  |

### Return type

[**AsyncCouponDeletionJobResponse**](AsyncCouponDeletionJobResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The deletion request has been accepted and will be processed asynchronously |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcouponsformultiplerecipients"></a>
# **CreateCouponsForMultipleRecipients**
> CreateCoupons200Response CreateCouponsForMultipleRecipients (long applicationId, long campaignId, NewCouponsForMultipleRecipients newCouponsForMultipleRecipients, string silent = null)

Create coupons for multiple recipients

Create coupons according to some pattern for up to 1000 recipients.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **newCouponsForMultipleRecipients** | [**NewCouponsForMultipleRecipients**](NewCouponsForMultipleRecipients.md) | body |  |
| **silent** | **string** | Possible values: &#x60;yes&#x60; or &#x60;no&#x60;. - &#x60;yes&#x60;: Increases the performance of the API call by returning a 204 response. - &#x60;no&#x60;: Returns a 200 response that contains the updated customer profiles.  | [optional] [default to &quot;yes&quot;] |

### Return type

[**CreateCoupons200Response**](CreateCoupons200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createinviteemail"></a>
# **CreateInviteEmail**
> NewInviteEmail CreateInviteEmail (NewInviteEmail newInviteEmail)

Resend invitation email

Resend an email invitation to an existing user.  **Note:** The invitation token is valid for 24 hours after the email has been sent. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newInviteEmail** | [**NewInviteEmail**](NewInviteEmail.md) | body |  |

### Return type

[**NewInviteEmail**](NewInviteEmail.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createinvitev2"></a>
# **CreateInviteV2**
> User CreateInviteV2 (NewInvitation newInvitation)

Invite user

Create a new user in the account and send an invitation to their email address.  **Note**: The invitation token is valid for 24 hours after the email has been sent. You can resend an invitation to a user with the [Resend invitation email](https://docs.talon.one/management-api#tag/Accounts-and-users/operation/createInviteEmail) endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newInvitation** | [**NewInvitation**](NewInvitation.md) | body |  |

### Return type

[**User**](User.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createpasswordrecoveryemail"></a>
# **CreatePasswordRecoveryEmail**
> NewPasswordEmail CreatePasswordRecoveryEmail (NewPasswordEmail newPasswordEmail)

Request a password reset

Send an email with a password recovery link to the email address of an existing account.  **Note:** The password recovery link expires 30 minutes after this endpoint is triggered. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newPasswordEmail** | [**NewPasswordEmail**](NewPasswordEmail.md) | body |  |

### Return type

[**NewPasswordEmail**](NewPasswordEmail.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createsession"></a>
# **CreateSession**
> Session CreateSession (LoginParams loginParams)

Create session

Create a session to use the Management API endpoints. Use the value of the `token` property provided in the response as bearer token in other API calls.  A token is valid for 3 months. In accordance with best pratices, use your generated token for all your API requests. Do **not** regenerate a token for each request.  This endpoint has a rate limit of 3 to 6 requests per second per account, depending on your setup.  <div class=\"redoc-section\">   <p class=\"title\">Granular API key</p>   Instead of using a session, you can also use the <a href=\"https://docs.talon.one/docs/product/account/dev-tools/managing-mapi-keys\">Management API key feature</a>   in the Campaign Manager to decide which endpoints can be used with a given key. </div> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loginParams** | [**LoginParams**](LoginParams.md) | body |  |

### Return type

[**Session**](Session.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createstore"></a>
# **CreateStore**
> Store CreateStore (long applicationId, NewStore newStore)

Create store

Create a new store in a specific Application.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **newStore** | [**NewStore**](NewStore.md) | body |  |

### Return type

[**Store**](Store.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **409** | Conflict. A store with this integration ID already exists for this application. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deactivateuserbyemail"></a>
# **DeactivateUserByEmail**
> void DeactivateUserByEmail (DeactivateUserRequest deactivateUserRequest)

Disable user by email address

[Disable a specific user](https://docs.talon.one/docs/product/account/account-settings/managing-users#disabling-a-user) by their email address. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deactivateUserRequest** | [**DeactivateUserRequest**](DeactivateUserRequest.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deductloyaltycardpoints"></a>
# **DeductLoyaltyCardPoints**
> void DeductLoyaltyCardPoints (long loyaltyProgramId, string loyaltyCardId, DeductLoyaltyPoints deductLoyaltyPoints)

Deduct points from card

Deduct points from the given loyalty card in the specified card-based loyalty program. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardId** | **string** | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  |  |
| **deductLoyaltyPoints** | [**DeductLoyaltyPoints**](DeductLoyaltyPoints.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteaccountcollection"></a>
# **DeleteAccountCollection**
> void DeleteAccountCollection (long collectionId)

Delete account-level collection

Delete a given account-level collection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteachievement"></a>
# **DeleteAchievement**
> void DeleteAchievement (long applicationId, long campaignId, long achievementId)

Delete achievement

Delete the specified achievement.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **achievementId** | **long** | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecampaign"></a>
# **DeleteCampaign**
> void DeleteCampaign (long applicationId, long campaignId)

Delete campaign

Delete the given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecampaignstorebudgets"></a>
# **DeleteCampaignStoreBudgets**
> void DeleteCampaignStoreBudgets (long applicationId, long campaignId, string action = null, string period = null)

Delete campaign store budgets

Delete the store budgets for a given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **action** | **string** | The action that this budget is limiting. | [optional]  |
| **period** | **string** | The period to which the limit applies.  **Note**: For budgets with no period, set this to &#x60;overall&#x60;.  | [optional]  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Deleted |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecollection"></a>
# **DeleteCollection**
> void DeleteCollection (long applicationId, long campaignId, long collectionId)

Delete campaign-level collection

Delete a given campaign-level collection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecoupon"></a>
# **DeleteCoupon**
> void DeleteCoupon (long applicationId, long campaignId, string couponId)

Delete coupon

Delete the specified coupon.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **couponId** | **string** | The internal ID of the coupon code. You can find this value in the &#x60;id&#x60; property from the [List coupons](https://docs.talon.one/management-api#tag/Coupons/operation/getCouponsWithoutTotalCount) endpoint response.  |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecoupons"></a>
# **DeleteCoupons**
> void DeleteCoupons (long applicationId, long campaignId, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, DateTime startsAfter = null, DateTime startsBefore = null, DateTime expiresAfter = null, DateTime expiresBefore = null, string valid = null, string batchId = null, string usable = null, long referralId = null, string recipientIntegrationId = null, bool exactMatch = null)

Delete coupons

Deletes all the coupons matching the specified criteria.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **value** | **string** | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **startsAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon start date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **startsBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon start date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **expiresAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon expiration date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **expiresBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon expiration date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **valid** | **string** | - &#x60;expired&#x60;: Matches coupons in which the expiration date is set and in the past. - &#x60;validNow&#x60;: Matches coupons in which start date is null or in the past and expiration date is null or in the future. - &#x60;validFuture&#x60;: Matches coupons in which start date is set and in the future.  | [optional]  |
| **batchId** | **string** | Filter results by batches of coupons | [optional]  |
| **usable** | **string** | - &#x60;true&#x60;: only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned. - &#x60;false&#x60;: only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60; will be returned.  | [optional]  |
| **referralId** | **long** | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional]  |
| **recipientIntegrationId** | **string** | Filter results by match with a profile ID specified in the coupon&#39;s &#x60;RecipientIntegrationId&#x60; field.  | [optional]  |
| **exactMatch** | **bool** | Filter results to an exact case-insensitive matching against the coupon code | [optional] [default to false] |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteloyaltycard"></a>
# **DeleteLoyaltyCard**
> void DeleteLoyaltyCard (long loyaltyProgramId, string loyaltyCardId)

Delete loyalty card

Delete the given loyalty card.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardId** | **string** | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletereferral"></a>
# **DeleteReferral**
> void DeleteReferral (long applicationId, long campaignId, string referralId)

Delete referral

Delete the specified referral.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **referralId** | **string** | The ID of the referral code. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletestore"></a>
# **DeleteStore**
> void DeleteStore (long applicationId, string storeId)

Delete store

Delete the specified store.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **storeId** | **string** | The ID of the store. You can get this ID with the [List stores](#tag/Stores/operation/listStores) endpoint.  |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (long userId)

Delete user

Delete a specific user.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The ID of the user. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteuserbyemail"></a>
# **DeleteUserByEmail**
> void DeleteUserByEmail (DeleteUserRequest deleteUserRequest)

Delete user by email address

[Delete a specific user](https://docs.talon.one/docs/product/account/account-settings/managing-users#deleting-a-user) by their email address. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteUserRequest** | [**DeleteUserRequest**](DeleteUserRequest.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="destroysession"></a>
# **DestroySession**
> void DestroySession ()

Destroy session

Destroys the session.


### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disconnectcampaignstores"></a>
# **DisconnectCampaignStores**
> void DisconnectCampaignStores (long applicationId, long campaignId)

Disconnect stores

Disconnect the stores linked to a specific campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportaccountcollectionitems"></a>
# **ExportAccountCollectionItems**
> string ExportAccountCollectionItems (long collectionId)

Export account-level collection's items

Download a CSV file containing items from a given account-level collection.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint. |  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportachievements"></a>
# **ExportAchievements**
> string ExportAchievements (long applicationId, long campaignId, long achievementId)

Export achievement customer data

Download a CSV file containing a list of all the customers who have participated in and are currently participating in the given achievement.  The CSV file contains the following columns: - `profileIntegrationID`: The integration ID of the customer profile participating in the achievement. - `title`: The display name of the achievement in the Campaign Manager. - `target`: The required number of actions or the transactional milestone to complete the achievement. - `progress`: The current progress of the customer in the achievement. - `status`: The status of the achievement. Can be one of: ['inprogress', 'completed', 'expired']. - `startDate`: The date on which the customer profile started the achievement in RFC3339. - `endDate`: The date on which the achievement ends and resets for the customer profile in RFC3339. - `completionDate`: The date on which the customer profile completed the achievement in RFC3339. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **achievementId** | **long** | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint. |  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportaudiencesmemberships"></a>
# **ExportAudiencesMemberships**
> string ExportAudiencesMemberships (long audienceId)

Export audience members

Download a CSV file containing the integration IDs of the members of an audience.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The file contains the following column: - `profileintegrationid`: The integration ID of the customer profile. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **audienceId** | **long** | The ID of the audience. |  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportcampaignstorebudgets"></a>
# **ExportCampaignStoreBudgets**
> string ExportCampaignStoreBudgets (long applicationId, long campaignId, string action = null, string period = null)

Export campaign store budgets

Download a CSV file containing the store budgets for a given campaign.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following columns:  - `store_integration_id`: The identifier of the store. - `limit`: The budget limit for the store. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **action** | **string** | The action that this budget is limiting. | [optional]  |
| **period** | **string** | The period to which the limit applies.  **Note**: For budgets with no period, set this to &#x60;overall&#x60;.  | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportcampaignstores"></a>
# **ExportCampaignStores**
> string ExportCampaignStores (long applicationId, long campaignId)

Export stores

Download a CSV file containing the stores linked to a specific campaign.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following column:  - `store_integration_id`: The identifier of the store. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportcollectionitems"></a>
# **ExportCollectionItems**
> string ExportCollectionItems (long applicationId, long campaignId, long collectionId)

Export campaign-level collection's items

Download a CSV file containing items from a given campaign-level collection.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint. |  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportcoupons"></a>
# **ExportCoupons**
> string ExportCoupons (long applicationId, decimal campaignId = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, long referralId = null, string recipientIntegrationId = null, string batchId = null, bool exactMatch = null, string dateFormat = null, string campaignState = null, bool valuesOnly = null)

Export coupons

Download a CSV file containing the coupons that match the given properties.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file can contain the following columns:  - `accountid`: The ID of your deployment. - `applicationid`: The ID of the Application this coupon is related to. - `attributes`: A json object describing _custom_ referral attribute names and their values. - `batchid`: The ID of the batch this coupon is part of. - `campaignid`: The ID of the campaign this coupon is related to. - `counter`: The number of times this coupon has been redeemed. - `created`: The creation date in RFC3339 of the coupon code. - `deleted`: Whether the coupon code is deleted. - `deleted_changelogid`: The ID of the delete event in the logs. - `discount_counter`: The amount of discount given by this coupon. - `discount_limitval`: The maximum discount amount that can be given be this coupon. - `expirydate`: The end date in RFC3339 of the code redemption period. - `id`: The internal ID of the coupon code. - `importid`: The ID of the import job that created this coupon. - `is_reservation_mandatory`: Whether this coupon requires a reservation to be redeemed. - `limits`: The limits set on this coupon. - `limitval`: The maximum number of redemptions of this code. - `recipientintegrationid`: The integration ID of the recipient of the coupon.   Only the customer with this integration ID can redeem this code. Available only for personal codes. - `referralid`: The ID of the referral code that triggered the creation of this coupon (create coupon effect). - `reservation`: Whether the coupon can be reserved for multiple customers. - `reservation_counter`: How many times this coupon has been reserved. - `reservation_limitval`: The maximum of number of reservations this coupon can have. - `startdate`: The start date in RFC3339 of the code redemption period. - `value`: The coupon code. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **decimal** | Filter results by campaign ID. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **value** | **string** | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **valid** | **string** | Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional]  |
| **usable** | **string** | Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional]  |
| **referralId** | **long** | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional]  |
| **recipientIntegrationId** | **string** | Filter results by match with a profile id specified in the coupon&#39;s RecipientIntegrationId field. | [optional]  |
| **batchId** | **string** | Filter results by batches of coupons | [optional]  |
| **exactMatch** | **bool** | Filter results to an exact case-insensitive matching against the coupon code. | [optional] [default to false] |
| **dateFormat** | **string** | Determines the format of dates in the export document. | [optional]  |
| **campaignState** | **string** | Filter results by the state of the campaign.  - &#x60;enabled&#x60;: Campaigns that are scheduled, running (activated), or expired. - &#x60;running&#x60;: Campaigns that are running (activated). - &#x60;disabled&#x60;: Campaigns that are disabled. - &#x60;expired&#x60;: Campaigns that are expired. - &#x60;archived&#x60;: Campaigns that are archived.  | [optional]  |
| **valuesOnly** | **bool** | Filter results to only return the coupon codes (&#x60;value&#x60; column) without the associated coupon data. | [optional] [default to false] |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportcustomersessions"></a>
# **ExportCustomerSessions**
> string ExportCustomerSessions (long applicationId, DateTime createdBefore = null, DateTime createdAfter = null, string profileIntegrationId = null, string dateFormat = null, string customerSessionState = null)

Export customer sessions

Download a CSV file containing the customer sessions that match the request.  **Important:** Archived sessions cannot be exported. See the [retention policy](https://docs.talon.one/docs/dev/server-infrastructure-and-data-retention).  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  - `id`: The internal ID of the session. - `firstsession`: Whether this is a first session. - `integrationid`: The integration ID of the session. - `applicationid`: The ID of the Application. - `profileid`: The internal ID of the customer profile. - `profileintegrationid`: The integration ID of the customer profile. - `created`: The timestamp when the session was created. - `state`: The [state](https://docs.talon.one/docs/dev/concepts/entities/customer-sessions#customer-session-states) of the session. - `cartitems`: The cart items in the session. - `discounts`: The discounts in the session. - `total`: The total value of cart items and additional costs in the session, before any discounts are applied. - `attributes`: The attributes set in the session. - `closedat`: Timestamp when the session was closed. - `cancelledat`: Timestamp when the session was cancelled. - `referral`: The referral code in the session. - `identifiers`: The identifiers in the session. - `additional_costs`: The [additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs) in the session. - `updated`: Timestamp of the last session update. - `store_integration_id`: The integration ID of the store. - `coupons`: Coupon codes in the session. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. | [optional]  |
| **profileIntegrationId** | **string** | Only return sessions for the customer that matches this customer integration ID. | [optional]  |
| **dateFormat** | **string** | Determines the format of dates in the export document. | [optional]  |
| **customerSessionState** | **string** | Filter results by state. | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportcustomerstiers"></a>
# **ExportCustomersTiers**
> string ExportCustomersTiers (string loyaltyProgramId, List<string> subledgerIds = null, List<string> tierNames = null)

Export customers' tier data

Download a CSV file containing the tier information for customers of the specified loyalty program.  The generated file contains the following columns:  - `programid`: The identifier of the loyalty program. It is displayed in your Talon.One deployment URL. - `subledgerid`: The ID of the subledger associated with the loyalty program. This column is empty if the loyalty program has no subledger. In this case, refer to the export file name to get the ID of the loyalty program. - `customerprofileid`: The ID used to integrate customer profiles with the loyalty program. - `tiername`: The name of the tier. - `startdate`: The tier start date in RFC3339. - `expirydate`: The tier expiry date in RFC3339.  You can filter the results by providing the following optional input parameters:  - `subledgerIds` (optional): Filter results by an array of subledger IDs. If no value is provided, all subledger data for the specified loyalty program will be exported. - `tierNames` (optional): Filter results by an array of tier names. If no value is provided, all tier data for the specified loyalty program will be exported. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **string** | The identifier for the loyalty program. |  |
| **subledgerIds** | [**List&lt;string&gt;**](string.md) | An array of subledgers IDs to filter the export by. | [optional]  |
| **tierNames** | [**List&lt;string&gt;**](string.md) | An array of tier names to filter the export by. | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exporteffects"></a>
# **ExportEffects**
> string ExportEffects (long applicationId, decimal campaignId = null, DateTime createdBefore = null, DateTime createdAfter = null, string dateFormat = null)

Export triggered effects

Download a CSV file containing the triggered effects that match the given attributes.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The generated file can contain the following columns:  - `applicationid`: The ID of the Application. - `campaignid`: The ID of the campaign. - `couponid`: The ID of the coupon, when applicable to the effect. - `created`: The timestamp of the effect. - `event_type`: The name of the event. See the [docs](https://docs.talon.one/docs/dev/concepts/entities/events). - `eventid`: The internal ID of the effect. - `name`: The effect name. See the [docs](https://docs.talon.one/docs/dev/integration-api/api-effects). - `profileintegrationid`: The ID of the customer profile, when applicable. - `props`: The [properties](https://docs.talon.one/docs/dev/integration-api/api-effects) of the effect. - `ruleindex`: The index of the rule. - `rulesetid`: The ID of the rule set. - `sessionid`: The internal ID of the session that triggered the effect. - `profileid`: The internal ID of the customer profile. - `sessionintegrationid`: The integration ID of the session. - `total_revenue`: The total revenue. - `store_integration_id`: The integration ID of the store. You choose this ID when you create a store. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **decimal** | Filter results by campaign ID. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **dateFormat** | **string** | Determines the format of dates in the export document. | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportloyaltybalance"></a>
# **ExportLoyaltyBalance**
> string ExportLoyaltyBalance (string loyaltyProgramId, DateTime endDate = null)

Export customer loyalty balance to CSV

⚠️ Deprecation notice: Support for requests to this endpoint will end soon. To export customer loyalty balances to CSV, use the [Export customer loyalty balances to CSV](/management-api#tag/Loyalty/operation/exportLoyaltyBalances) endpoint.  Download a CSV file containing the balance of each customer in the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **string** | The identifier for the loyalty program. |  |
| **endDate** | **DateTime** | Used to return expired, active, and pending loyalty balances before this timestamp. You can enter any past, present, or future timestamp value.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportloyaltybalances"></a>
# **ExportLoyaltyBalances**
> string ExportLoyaltyBalances (string loyaltyProgramId, DateTime endDate = null)

Export customer loyalty balances

Download a CSV file containing the balance of each customer in the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The generated file can contain the following columns:  - `loyaltyProgramID`: The ID of the loyalty program. - `loyaltySubledger`: The name of the subdleger, when applicatble. - `profileIntegrationID`: The integration ID of the customer profile. - `currentBalance`: The current point balance. - `pendingBalance`: The number of pending points. - `expiredBalance`: The number of expired points. - `spentBalance`: The number of spent points. - `currentTier`: The tier that the customer is in at the time of the export. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **string** | The identifier for the loyalty program. |  |
| **endDate** | **DateTime** | Used to return expired, active, and pending loyalty balances before this timestamp. You can enter any past, present, or future timestamp value.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportloyaltycardbalances"></a>
# **ExportLoyaltyCardBalances**
> string ExportLoyaltyCardBalances (long loyaltyProgramId, DateTime endDate = null)

Export all card transaction logs

Download a CSV file containing the balances of all cards in the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following columns: - `loyaltyProgramID`: The ID of the loyalty program. - `loyaltySubledger`: The name of the subdleger, when applicatble. - `cardIdentifier`: The alphanumeric identifier of the loyalty card. - `cardState`:The state of the loyalty card. It can be `active` or `inactive`. - `currentBalance`: The current point balance. - `pendingBalance`: The number of pending points. - `expiredBalance`: The number of expired points. - `spentBalance`: The number of spent points. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **endDate** | **DateTime** | Used to return expired, active, and pending loyalty balances before this timestamp. You can enter any past, present, or future timestamp value.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportloyaltycardledger"></a>
# **ExportLoyaltyCardLedger**
> string ExportLoyaltyCardLedger (long loyaltyProgramId, string loyaltyCardId, DateTime rangeStart, DateTime rangeEnd, string dateFormat = null)

Export card's ledger log

Download a CSV file containing a loyalty card ledger log of the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardId** | **string** | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  |  |
| **rangeStart** | **DateTime** | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **rangeEnd** | **DateTime** | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **dateFormat** | **string** | Determines the format of dates in the export document. | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportloyaltycards"></a>
# **ExportLoyaltyCards**
> string ExportLoyaltyCards (long loyaltyProgramId, string batchId = null, DateTime createdBefore = null, DateTime createdAfter = null, string dateFormat = null)

Export loyalty cards

Download a CSV file containing the loyalty cards from a specified loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following columns: - `identifier`: The unique identifier of the loyalty card. - `created`: The date and time the loyalty card was created. - `status`: The status of the loyalty card. - `userpercardlimit`: The maximum number of customer profiles that can be linked to the card. - `customerprofileids`: Integration IDs of the customer profiles linked to the card. - `blockreason`: The reason for transferring and blocking the loyalty card. - `generated`: An indicator of whether the loyalty card was generated. - `batchid`: The ID of the batch the loyalty card is in. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **batchId** | **string** | Filter results by loyalty card batch ID. | [optional]  |
| **createdBefore** | **DateTime** | Only return loyalty cards created before this timestamp.  **Note:** - This must be an RFC3339 timestamp string.  | [optional]  |
| **createdAfter** | **DateTime** | Only return loyalty cards created after this timestamp.  **Note:** - This must be an RFC3339 timestamp string.  | [optional]  |
| **dateFormat** | **string** | Determines the format of dates in the export document. | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportloyaltyledger"></a>
# **ExportLoyaltyLedger**
> string ExportLoyaltyLedger (DateTime rangeStart, DateTime rangeEnd, string loyaltyProgramId, string integrationId, string dateFormat = null)

Export customer's transaction logs

Download a CSV file containing a customer's transaction logs in the loyalty program.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The generated file can contain the following columns:  - `customerprofileid`: The ID of the profile. - `customersessionid`: The ID of the customer session. - `rulesetid`: The ID of the rule set. - `rulename`: The name of the rule. - `programid`: The ID of the loyalty program. - `type`: The transaction type, such as `addition` or `subtraction`. - `name`: The reason for the transaction. - `subledgerid`: The ID of the subledger, when applicable. - `startdate`: The start date of the program. - `expirydate`: The expiration date of the program. - `id`: The ID of the transaction. - `created`: The timestamp of the creation of the loyalty program. - `amount`: The number of points in that transaction. - `archived`: Whether the session related to the transaction is archived. - `campaignid`: The ID of the campaign. - `flags`: The flags of the transaction, when applicable. The `createsNegativeBalance` flag indicates whether the transaction results in a negative balance. - `transactionUUID`: Unique identifier of the transaction in the UUID format. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rangeStart** | **DateTime** | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **rangeEnd** | **DateTime** | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **loyaltyProgramId** | **string** | The identifier for the loyalty program. |  |
| **integrationId** | **string** | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  |  |
| **dateFormat** | **string** | Determines the format of dates in the export document. | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportpoolgiveaways"></a>
# **ExportPoolGiveaways**
> string ExportPoolGiveaways (long poolId, DateTime createdBefore = null, DateTime createdAfter = null)

Export giveaway codes of a giveaway pool

Download a CSV file containing the giveaway codes of a specific giveaway pool.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following columns:  - `id`: The internal ID of the giveaway. - `poolid`: The internal ID of the giveaway pool. - `code`: The giveaway code. - `startdate`: The validity start date in RFC3339 of the giveaway (can be empty). - `enddate`: The validity end date in RFC3339 of the giveaway (can be empty). - `attributes`: Any custom attributes associated with the giveaway code (can be empty). - `used`: An indication of whether the giveaway is already awarded. - `importid`: The ID of the import which created the giveaway. - `created`: The creation time of the giveaway code. - `profileintegrationid`: The third-party integration ID of the customer profile that was awarded the giveaway. Can be empty if the giveaway was not awarded. - `profileid`: The internal ID of the customer profile that was awarded the giveaway. Can be empty if the giveaway was not awarded or an internal ID does not exist. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **poolId** | **long** | The ID of the pool. You can find it in the Campaign Manager, in the **Giveaways** section. |  |
| **createdBefore** | **DateTime** | Timestamp that filters the results to only contain giveaways created before this date. Must be an RFC3339 timestamp string. | [optional]  |
| **createdAfter** | **DateTime** | Timestamp that filters the results to only contain giveaways created after this date. Must be an RFC3339 timestamp string. | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exportreferrals"></a>
# **ExportReferrals**
> string ExportReferrals (long applicationId, decimal campaignId = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, string batchId = null, string dateFormat = null)

Export referrals

Download a CSV file containing the referrals that match the given parameters.  **Tip:** If the exported CSV file is too large to view, you can [split it into multiple files](https://www.makeuseof.com/tag/how-to-split-a-huge-csv-excel-workbook-into-seperate-files/).  The CSV file contains the following columns:  - `code`: The referral code. - `advocateprofileintegrationid`: The profile ID of the advocate. - `startdate`: The start date in RFC3339 of the code redemption period. - `expirydate`: The end date in RFC3339 of the code redemption period. - `limitval`: The maximum number of redemptions of this code. Defaults to `1` when left blank. - `attributes`: A json object describing _custom_ referral attribute names and their values. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **decimal** | Filter results by campaign ID. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **valid** | **string** | - &#x60;expired&#x60;: Matches referrals in which the expiration date is set and in the past. - &#x60;validNow&#x60;: Matches referrals in which start date is null or in the past and expiration date is null or in the future. - &#x60;validFuture&#x60;: Matches referrals in which start date is set and in the future.  | [optional]  |
| **usable** | **string** | - &#x60;true&#x60;, only referrals where &#x60;usageCounter &lt; usageLimit&#x60; will be returned. - &#x60;false&#x60;, only referrals where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60; will be returned.  | [optional]  |
| **batchId** | **string** | Filter results by batches of referrals | [optional]  |
| **dateFormat** | **string** | Determines the format of dates in the export document. | [optional]  |

### Return type

**string**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="generatecouponrejections"></a>
# **GenerateCouponRejections**
> GenerateCouponRejections200Response GenerateCouponRejections (string sessionIntegrationId, decimal applicationId = null, string language = null, string couponCode = null)

Summarize coupon redemption failures in session

Create a summary of the reasons for coupon redemption failures in a given customer session. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionIntegrationId** | **string** | The integration ID of the session to summarize. |  |
| **applicationId** | **decimal** | Filter results by Application ID. | [optional]  |
| **language** | **string** | The [ISO-639](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) code of the language in which the summary will be generated.  | [optional]  |
| **couponCode** | **string** | The coupon code for which to get the rejection reason. | [optional]  |

### Return type

[**GenerateCouponRejections200Response**](GenerateCouponRejections200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaccesslogswithouttotalcount"></a>
# **GetAccessLogsWithoutTotalCount**
> GetAccessLogsWithoutTotalCount200Response GetAccessLogsWithoutTotalCount (long applicationId, DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, long pageSize = null, long skip = null, string sort = null)

Get access logs for Application

Retrieve the list of API calls sent to the specified Application. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **rangeStart** | **DateTime** | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **rangeEnd** | **DateTime** | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **path** | **string** | Only return results where the request path matches the given regular expression. | [optional]  |
| **method** | **string** | Only return results where the request method matches the given regular expression. | [optional]  |
| **status** | **string** | Filter results by HTTP status codes. | [optional]  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetAccessLogsWithoutTotalCount200Response**](GetAccessLogsWithoutTotalCount200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaccount"></a>
# **GetAccount**
> Account GetAccount (long accountId)

Get account details

Return the details of your companies Talon.One account. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **long** | The identifier of the account. Retrieve it via the [List users in account](https://docs.talon.one/management-api#operation/getUsers) endpoint in the &#x60;accountId&#x60; property.  |  |

### Return type

[**Account**](Account.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaccountanalytics"></a>
# **GetAccountAnalytics**
> AccountAnalytics GetAccountAnalytics (long accountId)

Get account analytics

Return the analytics of your Talon.One account. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **long** | The identifier of the account. Retrieve it via the [List users in account](https://docs.talon.one/management-api#operation/getUsers) endpoint in the &#x60;accountId&#x60; property.  |  |

### Return type

[**AccountAnalytics**](AccountAnalytics.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaccountcollection"></a>
# **GetAccountCollection**
> Collection GetAccountCollection (long collectionId)

Get account-level collection

Retrieve a given account-level collection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint. |  |

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getachievement"></a>
# **GetAchievement**
> Achievement GetAchievement (long applicationId, long campaignId, long achievementId)

Get achievement

Get the details of a specific achievement.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **achievementId** | **long** | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint. |  |

### Return type

[**Achievement**](Achievement.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getadditionalcost"></a>
# **GetAdditionalCost**
> AccountAdditionalCost GetAdditionalCost (long additionalCostId)

Get additional cost

Returns the additional cost. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **additionalCostId** | **long** | The ID of the additional cost. You can find the ID the the Campaign Manager&#39;s URL when you display the details of the cost in **Account** &gt; **Tools** &gt; **Additional costs**.  |  |

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getadditionalcosts"></a>
# **GetAdditionalCosts**
> GetAdditionalCosts200Response GetAdditionalCosts (long pageSize = null, long skip = null, string sort = null)

List additional costs

Returns all the defined additional costs for the account. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetAdditionalCosts200Response**](GetAdditionalCosts200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplication"></a>
# **GetApplication**
> Application GetApplication (long applicationId)

Get Application

Get the application specified by the ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |

### Return type

[**Application**](Application.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationapihealth"></a>
# **GetApplicationApiHealth**
> ApplicationApiHealth GetApplicationApiHealth (long applicationId)

Get Application health

Display the health of the Application and show the last time the Application was used.  You can also find this information in the Campaign Manager. In your Application, click **Settings** > **Integration API Keys**. See the [docs](https://docs.talon.one/docs/dev/tutorials/monitoring-integration-status). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |

### Return type

[**ApplicationApiHealth**](ApplicationApiHealth.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationcustomer"></a>
# **GetApplicationCustomer**
> ApplicationCustomer GetApplicationCustomer (long applicationId, long customerId)

Get application's customer

Retrieve the customers of the specified application. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **customerId** | **long** | The value of the &#x60;id&#x60; property of a customer profile. Get it with the [List Application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  |  |

### Return type

[**ApplicationCustomer**](ApplicationCustomer.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationcustomerfriends"></a>
# **GetApplicationCustomerFriends**
> GetApplicationCustomerFriends200Response GetApplicationCustomerFriends (long applicationId, string integrationId, long pageSize = null, long skip = null, string sort = null, bool withTotalResultSize = null)

List friends referred by customer profile

List the friends referred by the specified customer profile in this Application. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **integrationId** | **string** | The Integration ID of the Advocate&#39;s Profile. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |

### Return type

[**GetApplicationCustomerFriends200Response**](GetApplicationCustomerFriends200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationcustomers"></a>
# **GetApplicationCustomers**
> GetApplicationCustomers200Response GetApplicationCustomers (long applicationId, string integrationId = null, long pageSize = null, long skip = null, bool withTotalResultSize = null)

List application's customers

List all the customers of the specified application.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **integrationId** | **string** | Filter results performing an exact matching against the profile integration identifier. | [optional]  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |

### Return type

[**GetApplicationCustomers200Response**](GetApplicationCustomers200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationcustomersbyattributes"></a>
# **GetApplicationCustomersByAttributes**
> GetApplicationCustomersByAttributes200Response GetApplicationCustomersByAttributes (long applicationId, CustomerProfileSearchQuery customerProfileSearchQuery, long pageSize = null, long skip = null, bool withTotalResultSize = null)

List application customers matching the given attributes

Get a list of the application customers matching the provided criteria.  The match is successful if all the attributes of the request are found in a profile, even if the profile has more attributes that are not present on the request. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **customerProfileSearchQuery** | [**CustomerProfileSearchQuery**](CustomerProfileSearchQuery.md) | body |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |

### Return type

[**GetApplicationCustomersByAttributes200Response**](GetApplicationCustomersByAttributes200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationeventtypes"></a>
# **GetApplicationEventTypes**
> GetApplicationEventTypes200Response GetApplicationEventTypes (long applicationId, long pageSize = null, long skip = null, string sort = null)

List Applications event types

Get all of the distinct values of the Event `type` property for events recorded in the application.  See also: [Track an event](https://docs.talon.one/integration-api#tag/Events/operation/trackEventV2) 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetApplicationEventTypes200Response**](GetApplicationEventTypes200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationeventswithouttotalcount"></a>
# **GetApplicationEventsWithoutTotalCount**
> GetApplicationEventsWithoutTotalCount200Response GetApplicationEventsWithoutTotalCount (long applicationId, long pageSize = null, long skip = null, string sort = null, string type = null, DateTime createdBefore = null, DateTime createdAfter = null, string session = null, string profile = null, string customerName = null, string customerEmail = null, string couponCode = null, string referralCode = null, string ruleQuery = null, string campaignQuery = null, string effectType = null)

List Applications events

Lists all events recorded for an application. Instead of having the total number of results in the response, this endpoint only mentions whether there are more results. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **type** | **string** | Comma-separated list of types by which to filter events. Must be exact match(es). | [optional]  |
| **createdBefore** | **DateTime** | Only return events created before this date. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Only return events created after this date. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **session** | **string** | Session integration ID filter for events. Must be exact match. | [optional]  |
| **profile** | **string** | Profile integration ID filter for events. Must be exact match. | [optional]  |
| **customerName** | **string** | Customer name filter for events. Will match substrings case-insensitively. | [optional]  |
| **customerEmail** | **string** | Customer e-mail address filter for events. Will match substrings case-insensitively. | [optional]  |
| **couponCode** | **string** | Coupon code | [optional]  |
| **referralCode** | **string** | Referral code | [optional]  |
| **ruleQuery** | **string** | Rule name filter for events | [optional]  |
| **campaignQuery** | **string** | Campaign name filter for events | [optional]  |
| **effectType** | **string** | The type of effect that was triggered. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects). | [optional]  |

### Return type

[**GetApplicationEventsWithoutTotalCount200Response**](GetApplicationEventsWithoutTotalCount200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationsession"></a>
# **GetApplicationSession**
> ApplicationSession GetApplicationSession (long applicationId, long sessionId)

Get Application session

Get the details of the given session. You can list the sessions with the [List Application sessions](https://docs.talon.one/management-api#tag/Customer-data/operation/getApplicationSessions) endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **sessionId** | **long** | The **internal** ID of the session. You can get the ID with the [List Application sessions](https://docs.talon.one/management-api#tag/Customer-data/operation/getApplicationSessions) endpoint.  |  |

### Return type

[**ApplicationSession**](ApplicationSession.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplicationsessions"></a>
# **GetApplicationSessions**
> GetApplicationSessions200Response GetApplicationSessions (long applicationId, long pageSize = null, long skip = null, string sort = null, string profile = null, string state = null, DateTime createdBefore = null, DateTime createdAfter = null, string coupon = null, string referral = null, string integrationId = null, string storeIntegrationId = null)

List Application sessions

List all the sessions of the specified Application. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **profile** | **string** | Profile integration ID filter for sessions. Must be exact match. | [optional]  |
| **state** | **string** | Filter by sessions with this state. Must be exact match. | [optional]  |
| **createdBefore** | **DateTime** | Only return events created before this date. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Only return events created after this date. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **coupon** | **string** | Filter by sessions with this coupon. Must be exact match. | [optional]  |
| **referral** | **string** | Filter by sessions with this referral. Must be exact match. | [optional]  |
| **integrationId** | **string** | Filter by sessions with this integration ID. Must be exact match. | [optional]  |
| **storeIntegrationId** | **string** | The integration ID of the store. You choose this ID when you create a store. | [optional]  |

### Return type

[**GetApplicationSessions200Response**](GetApplicationSessions200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapplications"></a>
# **GetApplications**
> GetApplications200Response GetApplications (long pageSize = null, long skip = null, string sort = null)

List Applications

List all applications in the current account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetApplications200Response**](GetApplications200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getattribute"></a>
# **GetAttribute**
> Attribute GetAttribute (long attributeId)

Get custom attribute

Retrieve the specified custom attribute. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attributeId** | **long** | The ID of the attribute. You can find the ID in the Campaign Manager&#39;s URL when you display the details of an attribute in **Account** &gt; **Tools** &gt; **Attributes**. |  |

### Return type

[**Attribute**](Attribute.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getattributes"></a>
# **GetAttributes**
> GetAttributes200Response GetAttributes (long pageSize = null, long skip = null, string sort = null, string entity = null, string applicationIds = null, string type = null, string kind = null, string search = null)

List custom attributes

Return all the custom attributes for the account. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **entity** | **string** | Returned attributes will be filtered by supplied entity. | [optional]  |
| **applicationIds** | **string** | Returned attributes will be filtered by supplied application ids | [optional]  |
| **type** | **string** | Returned attributes will be filtered by supplied type | [optional]  |
| **kind** | **string** | Returned attributes will be filtered by supplied kind (builtin or custom) | [optional]  |
| **search** | **string** | Returned attributes will be filtered by searching case insensitive through Attribute name, description and type | [optional]  |

### Return type

[**GetAttributes200Response**](GetAttributes200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaudiencememberships"></a>
# **GetAudienceMemberships**
> GetAudienceMemberships200Response GetAudienceMemberships (long audienceId, long pageSize = null, long skip = null, string sort = null, string profileQuery = null)

List audience members

Get a paginated list of the customer profiles in a given audience.  A maximum of 1000 customer profiles per page is allowed. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **audienceId** | **long** | The ID of the audience. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **profileQuery** | **string** | The filter to select a profile. | [optional]  |

### Return type

[**GetAudienceMemberships200Response**](GetAudienceMemberships200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaudiences"></a>
# **GetAudiences**
> GetAudiences200Response GetAudiences (long pageSize = null, long skip = null, string sort = null, bool withTotalResultSize = null)

List audiences

Get all audiences created in the account. To create an audience, use [Create audience](https://docs.talon.one/integration-api#tag/Audiences/operation/createAudienceV2). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |

### Return type

[**GetAudiences200Response**](GetAudiences200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaudiencesanalytics"></a>
# **GetAudiencesAnalytics**
> GetAudiencesAnalytics200Response GetAudiencesAnalytics (string audienceIds, string sort = null)

List audience analytics

Get a list of audience IDs and their member count. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **audienceIds** | **string** | The IDs of one or more audiences, separated by commas, by which to filter results. |  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetAudiencesAnalytics200Response**](GetAudiencesAnalytics200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaign"></a>
# **GetCampaign**
> Campaign GetCampaign (long applicationId, long campaignId)

Get campaign

Retrieve the given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |

### Return type

[**Campaign**](Campaign.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaignanalytics"></a>
# **GetCampaignAnalytics**
> GetCampaignAnalytics200Response GetCampaignAnalytics (long applicationId, long campaignId, DateTime rangeStart, DateTime rangeEnd, string granularity = null)

Get analytics of campaigns

Retrieve statistical data about the performance of the given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **rangeStart** | **DateTime** | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **rangeEnd** | **DateTime** | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **granularity** | **string** | The time interval between the results in the returned time-series. | [optional]  |

### Return type

[**GetCampaignAnalytics200Response**](GetCampaignAnalytics200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaignbyattributes"></a>
# **GetCampaignByAttributes**
> GetCampaigns200Response GetCampaignByAttributes (long applicationId, CampaignSearch campaignSearch, long pageSize = null, long skip = null, string sort = null, string campaignState = null)

List campaigns that match the given attributes

Get a list of all the campaigns that match a set of attributes. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignSearch** | [**CampaignSearch**](CampaignSearch.md) | body |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **campaignState** | **string** | Filter results by the state of the campaign.  - &#x60;enabled&#x60;: Campaigns that are scheduled, running (activated), or expired. - &#x60;running&#x60;: Campaigns that are running (activated). - &#x60;disabled&#x60;: Campaigns that are disabled. - &#x60;expired&#x60;: Campaigns that are expired. - &#x60;archived&#x60;: Campaigns that are archived.  | [optional]  |

### Return type

[**GetCampaigns200Response**](GetCampaigns200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaigngroup"></a>
# **GetCampaignGroup**
> CampaignGroup GetCampaignGroup (long campaignGroupId)

Get campaign access group

Get a campaign access group specified by its ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignGroupId** | **long** | The ID of the campaign access group. |  |

### Return type

[**CampaignGroup**](CampaignGroup.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaigngroups"></a>
# **GetCampaignGroups**
> GetCampaignGroups200Response GetCampaignGroups (long pageSize = null, long skip = null, string sort = null)

List campaign access groups

List the campaign access groups in the current account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetCampaignGroups200Response**](GetCampaignGroups200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaigntemplates"></a>
# **GetCampaignTemplates**
> GetCampaignTemplates200Response GetCampaignTemplates (long pageSize = null, long skip = null, string sort = null, string state = null, string name = null, string tags = null, long userId = null)

List campaign templates

Retrieve a list of campaign templates.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **state** | **string** | Filter results by the state of the campaign template. | [optional]  |
| **name** | **string** | Filter results performing case-insensitive matching against the name of the campaign template. | [optional]  |
| **tags** | **string** | Filter results performing case-insensitive matching against the tags of the campaign template. When used in conjunction with the \&quot;name\&quot; query parameter, a logical OR will be performed to search both tags and name for the provided values.  | [optional]  |
| **userId** | **long** | Filter results by user ID. | [optional]  |

### Return type

[**GetCampaignTemplates200Response**](GetCampaignTemplates200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcampaigns"></a>
# **GetCampaigns**
> GetCampaigns200Response GetCampaigns (long applicationId, long pageSize = null, long skip = null, string sort = null, string campaignState = null, string name = null, string tags = null, DateTime createdBefore = null, DateTime createdAfter = null, DateTime startBefore = null, DateTime startAfter = null, DateTime endBefore = null, DateTime endAfter = null, long campaignGroupId = null, long templateId = null, long storeId = null)

List campaigns

List the campaigns of the specified application that match your filter criteria. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **campaignState** | **string** | Filter results by the state of the campaign.  - &#x60;enabled&#x60;: Campaigns that are scheduled, running (activated), or expired. - &#x60;running&#x60;: Campaigns that are running (activated). - &#x60;disabled&#x60;: Campaigns that are disabled. - &#x60;expired&#x60;: Campaigns that are expired. - &#x60;archived&#x60;: Campaigns that are archived.  | [optional]  |
| **name** | **string** | Filter results performing case-insensitive matching against the name of the campaign. | [optional]  |
| **tags** | **string** | Filter results performing case-insensitive matching against the tags of the campaign. When used in conjunction with the \&quot;name\&quot; query parameter, a logical OR will be performed to search both tags and name for the provided values  | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **startBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign start time timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **startAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign start time timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **endBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign end time timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **endAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign end time timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **campaignGroupId** | **long** | Filter results to campaigns owned by the specified campaign access group ID. | [optional]  |
| **templateId** | **long** | The ID of the campaign template this campaign was created from. | [optional]  |
| **storeId** | **long** | Filter results to campaigns linked to the specified store ID. | [optional]  |

### Return type

[**GetCampaigns200Response**](GetCampaigns200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchanges"></a>
# **GetChanges**
> GetChanges200Response GetChanges (long pageSize = null, long skip = null, string sort = null, decimal applicationId = null, string entityPath = null, long userId = null, DateTime createdBefore = null, DateTime createdAfter = null, bool withTotalResultSize = null, long managementKeyId = null, bool includeOld = null)

Get audit logs for an account

Retrieve the audit logs displayed in **Accounts > Audit logs**. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **applicationId** | **decimal** | Filter results by Application ID. | [optional]  |
| **entityPath** | **string** | Filter results on a case insensitive matching of the url path of the entity | [optional]  |
| **userId** | **long** | Filter results by user ID. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |
| **managementKeyId** | **long** | Filter results that match the given management key ID. | [optional]  |
| **includeOld** | **bool** | When this flag is set to false, the state without the change will not be returned. The default value is true. | [optional]  |

### Return type

[**GetChanges200Response**](GetChanges200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcollection"></a>
# **GetCollection**
> Collection GetCollection (long applicationId, long campaignId, long collectionId)

Get campaign-level collection

Retrieve a given campaign-level collection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint. |  |

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcollectionitems"></a>
# **GetCollectionItems**
> GetCollectionItems200Response GetCollectionItems (long collectionId, long pageSize = null, long skip = null)

Get collection items

Retrieve items from a given collection.  You can retrieve items from both account-level collections and campaign-level collections using this endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |

### Return type

[**GetCollectionItems200Response**](GetCollectionItems200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcouponswithouttotalcount"></a>
# **GetCouponsWithoutTotalCount**
> GetCouponsWithoutTotalCount200Response GetCouponsWithoutTotalCount (long applicationId, long campaignId, long pageSize = null, long skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, string redeemed = null, long referralId = null, string recipientIntegrationId = null, string batchId = null, bool exactMatch = null, DateTime expiresBefore = null, DateTime expiresAfter = null, DateTime startsBefore = null, DateTime startsAfter = null, bool valuesOnly = null)

List coupons

List all the coupons matching the specified criteria. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **value** | **string** | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **valid** | **string** | Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional]  |
| **usable** | **string** | Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional]  |
| **redeemed** | **string** | - &#x60;true&#x60;: only coupons where &#x60;usageCounter &gt; 0&#x60; will be returned. - &#x60;false&#x60;: only coupons where &#x60;usageCounter &#x3D; 0&#x60; will be returned. - This field cannot be used in conjunction with the &#x60;usable&#x60; query parameter.  | [optional]  |
| **referralId** | **long** | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional]  |
| **recipientIntegrationId** | **string** | Filter results by match with a profile ID specified in the coupon&#39;s RecipientIntegrationId field. | [optional]  |
| **batchId** | **string** | Filter results by batches of coupons | [optional]  |
| **exactMatch** | **bool** | Filter results to an exact case-insensitive matching against the coupon code. | [optional] [default to false] |
| **expiresBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon expiration date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **expiresAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon expiration date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **startsBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon start date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **startsAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon start date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **valuesOnly** | **bool** | Filter results to only return the coupon codes (&#x60;value&#x60; column) without the associated coupon data. | [optional] [default to false] |

### Return type

[**GetCouponsWithoutTotalCount200Response**](GetCouponsWithoutTotalCount200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcustomeractivityreport"></a>
# **GetCustomerActivityReport**
> CustomerActivityReport GetCustomerActivityReport (DateTime rangeStart, DateTime rangeEnd, long applicationId, long customerId, long pageSize = null, long skip = null)

Get customer's activity report

Fetch the summary report of a given customer in the given application, in a time range.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rangeStart** | **DateTime** | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **rangeEnd** | **DateTime** | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **customerId** | **long** | The value of the &#x60;id&#x60; property of a customer profile. Get it with the [List Application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |

### Return type

[**CustomerActivityReport**](CustomerActivityReport.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcustomeractivityreportswithouttotalcount"></a>
# **GetCustomerActivityReportsWithoutTotalCount**
> GetCustomerActivityReportsWithoutTotalCount200Response GetCustomerActivityReportsWithoutTotalCount (DateTime rangeStart, DateTime rangeEnd, long applicationId, long pageSize = null, long skip = null, string sort = null, string name = null, string integrationId = null, string campaignName = null, string advocateName = null)

Get Activity Reports for Application Customers

Fetch summary reports for all application customers based on a time range. Instead of having the total number of results in the response, this endpoint only mentions whether there are more results. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rangeStart** | **DateTime** | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **rangeEnd** | **DateTime** | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **name** | **string** | Only return reports matching the customer name. | [optional]  |
| **integrationId** | **string** | Filter results performing an exact matching against the profile integration identifier. | [optional]  |
| **campaignName** | **string** | Only return reports matching the campaign name. | [optional]  |
| **advocateName** | **string** | Only return reports matching the current customer referrer name. | [optional]  |

### Return type

[**GetCustomerActivityReportsWithoutTotalCount200Response**](GetCustomerActivityReportsWithoutTotalCount200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcustomeranalytics"></a>
# **GetCustomerAnalytics**
> CustomerAnalytics GetCustomerAnalytics (long applicationId, long customerId, long pageSize = null, long skip = null, string sort = null)

Get customer's analytics report

Fetch analytics for a given customer in the given application.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **customerId** | **long** | The value of the &#x60;id&#x60; property of a customer profile. Get it with the [List Application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**CustomerAnalytics**](CustomerAnalytics.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcustomerprofile"></a>
# **GetCustomerProfile**
> CustomerProfile GetCustomerProfile (long customerId)

Get customer profile

Return the details of the specified customer profile.  <div class=\"redoc-section\">   <p class=\"title\">Performance tips</p>    You can retrieve the same information via the Integration API, which can save you extra API requests. consider these options:    - Request the customer profile to be part of the response content using     [Update Customer Session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2).   - Send an empty update with the [Update Customer Profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint with `runRuleEngine=false`. </div> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **long** | The value of the &#x60;id&#x60; property of a customer profile. Get it with the [List Application&#39;s customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint.  |  |

### Return type

[**CustomerProfile**](CustomerProfile.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcustomerprofileachievementprogress"></a>
# **GetCustomerProfileAchievementProgress**
> GetCustomerProfileAchievementProgress200Response GetCustomerProfileAchievementProgress (long applicationId, string integrationId, long pageSize = null, long skip = null, long achievementId = null, string title = null)

List customer achievements

For the given customer profile, list all the achievements that match your filter criteria. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **integrationId** | **string** | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 50] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **achievementId** | **long** | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint. | [optional]  |
| **title** | **string** | Filter results by the &#x60;title&#x60; of an achievement. | [optional]  |

### Return type

[**GetCustomerProfileAchievementProgress200Response**](GetCustomerProfileAchievementProgress200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcustomerprofiles"></a>
# **GetCustomerProfiles**
> GetCustomerProfiles200Response GetCustomerProfiles (long pageSize = null, long skip = null, bool sandbox = null)

List customer profiles

List all customer profiles.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sandbox** | **bool** | Indicates whether you are pointing to a sandbox or live customer. | [optional] [default to false] |

### Return type

[**GetCustomerProfiles200Response**](GetCustomerProfiles200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcustomersbyattributes"></a>
# **GetCustomersByAttributes**
> GetCustomersByAttributes200Response GetCustomersByAttributes (CustomerProfileSearchQuery customerProfileSearchQuery, long pageSize = null, long skip = null, bool sandbox = null)

List customer profiles matching the given attributes

Get a list of the customer profiles matching the provided criteria.  The match is successful if all the attributes of the request are found in a profile, even if the profile has more attributes that are not present on the request. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerProfileSearchQuery** | [**CustomerProfileSearchQuery**](CustomerProfileSearchQuery.md) | body |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sandbox** | **bool** | Indicates whether you are pointing to a sandbox or live customer. | [optional] [default to false] |

### Return type

[**GetCustomersByAttributes200Response**](GetCustomersByAttributes200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdashboardstatistics"></a>
# **GetDashboardStatistics**
> GetDashboardStatistics200Response GetDashboardStatistics (long loyaltyProgramId, DateTime rangeStart, DateTime rangeEnd, string subledgerId = null)

Get statistics for loyalty dashboard

Retrieve the statistics displayed on the specified loyalty program's dashboard, such as the total active points, pending points, spent points, and expired points.  **Important:** The returned data does not include the current day. All statistics are updated daily at 11:59 PM in the loyalty program time zone. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **rangeStart** | **DateTime** | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **rangeEnd** | **DateTime** | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  |  |
| **subledgerId** | **string** | The ID of the subledger by which we filter the data. | [optional]  |

### Return type

[**GetDashboardStatistics200Response**](GetDashboardStatistics200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="geteventtypes"></a>
# **GetEventTypes**
> GetEventTypes200Response GetEventTypes (string name = null, bool includeOldVersions = null, long pageSize = null, long skip = null, string sort = null)

List event types

Fetch all event type definitions for your account. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Filter results to event types with the given name. This parameter implies &#x60;includeOldVersions&#x60;. | [optional]  |
| **includeOldVersions** | **bool** | Include all versions of every event type. | [optional] [default to false] |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetEventTypes200Response**](GetEventTypes200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getexports"></a>
# **GetExports**
> GetExports200Response GetExports (long pageSize = null, long skip = null, decimal applicationId = null, long campaignId = null, string entity = null)

Get exports

List all past exports 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **applicationId** | **decimal** | Filter results by Application ID. | [optional]  |
| **campaignId** | **long** | Filter by the campaign ID on which the limit counters are used. | [optional]  |
| **entity** | **string** | The name of the entity type that was exported. | [optional]  |

### Return type

[**GetExports200Response**](GetExports200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltycard"></a>
# **GetLoyaltyCard**
> LoyaltyCard GetLoyaltyCard (long loyaltyProgramId, string loyaltyCardId)

Get loyalty card

Get the given loyalty card.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardId** | **string** | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  |  |

### Return type

[**LoyaltyCard**](LoyaltyCard.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltycardtransactionlogs"></a>
# **GetLoyaltyCardTransactionLogs**
> GetLoyaltyCardTransactionLogs200Response GetLoyaltyCardTransactionLogs (long loyaltyProgramId, string loyaltyCardId, DateTime startDate = null, DateTime endDate = null, long pageSize = null, long skip = null, string subledgerId = null, List<string> customerSessionIDs = null, List<string> transactionUUIDs = null)

List card's transactions

Retrieve the transaction logs for the given [loyalty card](https://docs.talon.one/docs/product/loyalty-programs/card-based/card-based-overview) within the specified [card-based loyalty program](https://docs.talon.one/docs/product/loyalty-programs/overview#loyalty-program-types) with filtering options applied. If no filtering options are applied, the last 50 loyalty transactions for the given loyalty card are returned. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardId** | **string** | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  |  |
| **startDate** | **DateTime** | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |
| **endDate** | **DateTime** | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **subledgerId** | **string** | The ID of the subledger by which we filter the data. | [optional]  |
| **customerSessionIDs** | [**List&lt;string&gt;**](string.md) | Filter the results by a list of customer session IDs.   To include multiple IDs, repeat the parameter for each one, for example,  &#x60;?customerSessionIDs&#x3D;id1&amp;customerSessionIDs&#x3D;id2&#x60;.  The response contains only data associated with the specified sessions.  | [optional]  |
| **transactionUUIDs** | [**List&lt;string&gt;**](string.md) | Filter the results by a list of transaction UUIDs.  To include multiple IDs, repeat the parameter for each one, for example,  &#x60;?transactionUUIDs&#x3D;uuid1&amp;transactionUUIDs&#x3D;uuid2&#x60;.  The response contains only data associated with the specified transactions.  | [optional]  |

### Return type

[**GetLoyaltyCardTransactionLogs200Response**](GetLoyaltyCardTransactionLogs200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltycards"></a>
# **GetLoyaltyCards**
> GetLoyaltyCards200Response GetLoyaltyCards (long loyaltyProgramId, long pageSize = null, long skip = null, string sort = null, string identifier = null, long profileId = null, string batchId = null)

List loyalty cards

For the given card-based loyalty program, list the loyalty cards that match your filter criteria. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **identifier** | **string** | The card code by which to filter loyalty cards in the response. | [optional]  |
| **profileId** | **long** | Filter results by customer profile ID. | [optional]  |
| **batchId** | **string** | Filter results by loyalty card batch ID. | [optional]  |

### Return type

[**GetLoyaltyCards200Response**](GetLoyaltyCards200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltyledgerbalances"></a>
# **GetLoyaltyLedgerBalances**
> LoyaltyBalancesWithTiers GetLoyaltyLedgerBalances (long loyaltyProgramId, string integrationId, DateTime endDate = null, string subledgerId = null, bool includeTiers = null, bool includeProjectedTier = null)

Get customer's loyalty balances

Retrieve loyalty ledger balances for the given Integration ID in the specified loyalty program. You can filter balances by date and subledger ID, and include tier-related information in the response.  **Note**: If no filtering options are applied, you retrieve all loyalty balances on the current date for the given integration ID.  Loyalty balances are calculated when Talon.One receives your request using the points stored in our database, so retrieving a large number of balances at once can impact performance.  For more information, see: - [Managing card-based loyalty program data](https://docs.talon.one/docs/product/loyalty-programs/card-based/managing-loyalty-cards) - [Managing profile-based loyalty program data](https://docs.talon.one/docs/product/loyalty-programs/profile-based/managing-pb-lp-data) 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the profile-based loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **integrationId** | **string** | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  |  |
| **endDate** | **DateTime** | Used to return expired, active, and pending loyalty balances before this timestamp. You can enter any past, present, or future timestamp value.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |
| **subledgerId** | **string** | The ID of the subledger used to filter the data. Leave this value empty (\&quot;\&quot;) to query the main ledger. | [optional]  |
| **includeTiers** | **bool** | Indicates whether tier information is included in the response.  When set to &#x60;true&#x60;, the response includes information about the current tier and the number of points required to move to next tier.  | [optional] [default to false] |
| **includeProjectedTier** | **bool** | Indicates whether the customer&#39;s projected tier information is included in the response.  When set to &#x60;true&#x60;, the response includes information about the customer&#39;s active points and the name of the projected tier.  **Note** We recommend filtering by &#x60;subledgerId&#x60; for better performance.  | [optional] [default to false] |

### Return type

[**LoyaltyBalancesWithTiers**](LoyaltyBalancesWithTiers.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltypoints"></a>
# **GetLoyaltyPoints**
> LoyaltyLedger GetLoyaltyPoints (string loyaltyProgramId, string integrationId)

Get customer's full loyalty ledger

Get the loyalty ledger for this profile integration ID.  To get the `integrationId` of the profile from a `sessionId`, use the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint.  **Important:** To get loyalty transaction logs for a given Integration ID in a loyalty program, we recommend using the Integration API's [Get customer's loyalty logs](https://docs.talon.one/integration-api#tag/Loyalty/operation/getLoyaltyProgramProfileTransactions). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **string** | The identifier for the loyalty program. |  |
| **integrationId** | **string** | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  |  |

### Return type

[**LoyaltyLedger**](LoyaltyLedger.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltyprogram"></a>
# **GetLoyaltyProgram**
> LoyaltyProgram GetLoyaltyProgram (long loyaltyProgramId)

Get loyalty program

Get the specified [loyalty program](https://docs.talon.one/docs/product/loyalty-programs/overview). To list all loyalty programs in your Application, use [List loyalty programs](#operation/getLoyaltyPrograms).  To list the loyalty programs that a customer profile is part of, use the [List customer data](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/getCustomerInventory) 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |

### Return type

[**LoyaltyProgram**](LoyaltyProgram.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltyprogramprofileledgertransactions"></a>
# **GetLoyaltyProgramProfileLedgerTransactions**
> GetLoyaltyProgramProfileTransactions200Response GetLoyaltyProgramProfileLedgerTransactions (long loyaltyProgramId, string integrationId, List<string> customerSessionIDs = null, List<string> transactionUUIDs = null, string subledgerId = null, string loyaltyTransactionType = null, DateTime startDate = null, DateTime endDate = null, long pageSize = null, long skip = null, bool awaitsActivation = null)

List customer's loyalty transactions

Retrieve paginated results of loyalty transaction logs for the given Integration ID in the specified loyalty program.  You can filter transactions by date or by ledger (subledger or main ledger). If no filters are applied, the last 50 loyalty transactions for the given integration ID are returned.  **Note:** To retrieve all loyalty program transaction logs in a given loyalty program, use the [List loyalty program transactions](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyProgramTransactions) endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the profile-based loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **integrationId** | **string** | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  |  |
| **customerSessionIDs** | [**List&lt;string&gt;**](string.md) | Filter the results by a list of customer session IDs.   To include multiple IDs, repeat the parameter for each one, for example,  &#x60;?customerSessionIDs&#x3D;id1&amp;customerSessionIDs&#x3D;id2&#x60;.  The response contains only data associated with the specified sessions.  | [optional]  |
| **transactionUUIDs** | [**List&lt;string&gt;**](string.md) | Filter the results by a list of transaction UUIDs.  To include multiple IDs, repeat the parameter for each one, for example,  &#x60;?transactionUUIDs&#x3D;uuid1&amp;transactionUUIDs&#x3D;uuid2&#x60;.  The response contains only data associated with the specified transactions.  | [optional]  |
| **subledgerId** | **string** | The ID of the subledger used to filter the data. Leave this value empty (\&quot;\&quot;) to query the main ledger. | [optional]  |
| **loyaltyTransactionType** | **string** | Filter results by loyalty transaction type: - &#x60;manual&#x60;: Loyalty transaction that was done manually. - &#x60;session&#x60;: Loyalty transaction that resulted from a customer session. - &#x60;import&#x60;: Loyalty transaction that was imported from a CSV file.  | [optional]  |
| **startDate** | **DateTime** | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |
| **endDate** | **DateTime** | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 50] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **awaitsActivation** | **bool** | If &#x60;true&#x60;: Filters results to include only point transactions that have action-based activation and have not expired.  If &#x60;false&#x60;: Returns a &#x60;400&#x60; response.  | [optional]  |

### Return type

[**GetLoyaltyProgramProfileTransactions200Response**](GetLoyaltyProgramProfileTransactions200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltyprogramtransactions"></a>
# **GetLoyaltyProgramTransactions**
> GetLoyaltyProgramTransactions200Response GetLoyaltyProgramTransactions (long loyaltyProgramId, string loyaltyTransactionType = null, string subledgerId = null, List<string> customerSessionIDs = null, List<string> transactionUUIDs = null, DateTime startDate = null, DateTime endDate = null, long pageSize = null, long skip = null, bool awaitsActivation = null)

List loyalty program transactions

Retrieve loyalty program transaction logs in a given loyalty program with filtering options applied. Manual and imported transactions are also included. **Note:** If no filters are applied, the last 50 loyalty transactions for the given loyalty program are returned.  **Important:** To get loyalty transaction logs for a given Integration ID in a loyalty program, we recommend using the Integration API's [Get customer's loyalty logs](https://docs.talon.one/integration-api#tag/Loyalty/operation/getLoyaltyProgramProfileTransactions). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyTransactionType** | **string** | Filter results by loyalty transaction type: - &#x60;manual&#x60;: Loyalty transaction that was done manually. - &#x60;session&#x60;: Loyalty transaction that resulted from a customer session. - &#x60;import&#x60;: Loyalty transaction that was imported from a CSV file.  | [optional]  |
| **subledgerId** | **string** | The ID of the subledger by which we filter the data. | [optional]  |
| **customerSessionIDs** | [**List&lt;string&gt;**](string.md) | Filter the results by a list of customer session IDs.   To include multiple IDs, repeat the parameter for each one, for example,  &#x60;?customerSessionIDs&#x3D;id1&amp;customerSessionIDs&#x3D;id2&#x60;.  The response contains only data associated with the specified sessions.  | [optional]  |
| **transactionUUIDs** | [**List&lt;string&gt;**](string.md) | Filter the results by a list of transaction UUIDs.  To include multiple IDs, repeat the parameter for each one, for example,  &#x60;?transactionUUIDs&#x3D;uuid1&amp;transactionUUIDs&#x3D;uuid2&#x60;.  The response contains only data associated with the specified transactions.  | [optional]  |
| **startDate** | **DateTime** | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |
| **endDate** | **DateTime** | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, &#x60;T23:59:59&#x60; to specify the end of the day. The time zone setting considered is &#x60;UTC&#x60;. If you do not include a time component, a default time value of &#x60;T00:00:00&#x60; (midnight) in &#x60;UTC&#x60; is considered.  | [optional]  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 50] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **awaitsActivation** | **bool** | If &#x60;true&#x60;: Filters results to include only point transactions that have action-based activation and have not expired.  If &#x60;false&#x60;: Returns a &#x60;400&#x60; response.  | [optional]  |

### Return type

[**GetLoyaltyProgramTransactions200Response**](GetLoyaltyProgramTransactions200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltyprograms"></a>
# **GetLoyaltyPrograms**
> GetLoyaltyPrograms200Response GetLoyaltyPrograms ()

List loyalty programs

List the loyalty programs of the account.


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetLoyaltyPrograms200Response**](GetLoyaltyPrograms200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getloyaltystatistics"></a>
# **GetLoyaltyStatistics**
> LoyaltyDashboardData GetLoyaltyStatistics (long loyaltyProgramId)

Get loyalty program statistics

⚠️ Deprecation notice: Support for requests to this endpoint will end soon. To retrieve statistics for a loyalty program, use the [Get statistics for loyalty dashboard](/management-api#tag/Loyalty/operation/getDashboardStatistics) endpoint.  Retrieve the statistics of the specified loyalty program, such as the total active points, pending points, spent points, and expired points. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |

### Return type

[**LoyaltyDashboardData**](LoyaltyDashboardData.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmessagelogs"></a>
# **GetMessageLogs**
> MessageLogEntries GetMessageLogs (string entityType, string messageID = null, string changeType = null, string notificationIDs = null, DateTime createdBefore = null, DateTime createdAfter = null, byte[] cursor = null, string period = null, bool isSuccessful = null, decimal applicationId = null, decimal campaignId = null, long loyaltyProgramId = null, long responseCode = null, string webhookIDs = null)

List message log entries

Retrieve all message log entries.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The entity type the log is related to.  |  |
| **messageID** | **string** | Filter results by message ID. | [optional]  |
| **changeType** | **string** | Filter results by change type. | [optional]  |
| **notificationIDs** | **string** | Filter results by notification ID (include up to 30 values, separated by a comma). | [optional]  |
| **createdBefore** | **DateTime** | Filter results where request and response times to return entries before parameter value, expected to be an RFC3339 timestamp string. Use UTC time. | [optional]  |
| **createdAfter** | **DateTime** | Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. Use UTC time. | [optional]  |
| **cursor** | **byte[]** | A specific unique value in the database. If this value is not given, the server fetches results starting with the first record.  | [optional]  |
| **period** | **string** | Filter results by time period. Choose between the available relative time frames.  | [optional]  |
| **isSuccessful** | **bool** | Indicates whether to return log entries with either successful or unsuccessful HTTP response codes. When set to&#x60;true&#x60;, only log entries with &#x60;2xx&#x60; response codes are returned. When set to &#x60;false&#x60;, only log entries with &#x60;4xx&#x60; and &#x60;5xx&#x60; response codes are returned.  | [optional]  |
| **applicationId** | **decimal** | Filter results by Application ID. | [optional]  |
| **campaignId** | **decimal** | Filter results by campaign ID. | [optional]  |
| **loyaltyProgramId** | **long** | Identifier of the loyalty program. | [optional]  |
| **responseCode** | **long** | Filter results by response status code. | [optional]  |
| **webhookIDs** | **string** | Filter results by webhook ID (include up to 30 values, separated by a comma). | [optional]  |

### Return type

[**MessageLogEntries**](MessageLogEntries.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreferralswithouttotalcount"></a>
# **GetReferralsWithoutTotalCount**
> GetReferralsWithoutTotalCount200Response GetReferralsWithoutTotalCount (long applicationId, long campaignId, long pageSize = null, long skip = null, string sort = null, string code = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, string advocate = null)

List referrals

List all referrals of the specified campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **code** | **string** | Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **valid** | **string** | Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches referrals in which the expiration date is set and in the past. The second matches referrals in which start date is null or in the past and expiration date is null or in the future, the third matches referrals in which start date is set and in the future.  | [optional]  |
| **usable** | **string** | Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only referrals where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only referrals where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional]  |
| **advocate** | **string** | Filter results by match with a profile ID specified in the referral&#39;s AdvocateProfileIntegrationId field. | [optional]  |

### Return type

[**GetReferralsWithoutTotalCount200Response**](GetReferralsWithoutTotalCount200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getrolev2"></a>
# **GetRoleV2**
> RoleV2 GetRoleV2 (long roleId)

Get role

Get the details of a specific role. To see all the roles, use the [List roles](/management-api#tag/Roles/operation/listAllRolesV2) endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roleId** | **long** | The ID of role.  **Note**: To find the ID of a role, use the [List roles](/management-api#tag/Roles/operation/listAllRolesV2) endpoint.  |  |

### Return type

[**RoleV2**](RoleV2.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getruleset"></a>
# **GetRuleset**
> Ruleset GetRuleset (long applicationId, long campaignId, long rulesetId)

Get ruleset

Retrieve the specified ruleset.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **rulesetId** | **long** | The ID of the ruleset. |  |

### Return type

[**Ruleset**](Ruleset.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getrulesets"></a>
# **GetRulesets**
> GetRulesets200Response GetRulesets (long applicationId, long campaignId, long pageSize = null, long skip = null, string sort = null)

List campaign rulesets

List all rulesets of this campaign. A ruleset is a revision of the rules of a campaign. **Important:** The response also includes deleted rules. You should only consider the latest revision of the returned rulesets. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetRulesets200Response**](GetRulesets200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getstore"></a>
# **GetStore**
> Store GetStore (long applicationId, string storeId)

Get store

Get store details for a specific store ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **storeId** | **string** | The ID of the store. You can get this ID with the [List stores](#tag/Stores/operation/listStores) endpoint.  |  |

### Return type

[**Store**](Store.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getuser"></a>
# **GetUser**
> User GetUser (long userId)

Get user

Retrieve the data (including an invitation code) for a user. Non-admin users can only get their own profile. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The ID of the user. |  |

### Return type

[**User**](User.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusers"></a>
# **GetUsers**
> GetUsers200Response GetUsers (long pageSize = null, long skip = null, string sort = null)

List users in account

Retrieve all users in your account. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |

### Return type

[**GetUsers200Response**](GetUsers200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhook"></a>
# **GetWebhook**
> Webhook GetWebhook (long webhookId)

Get webhook

Returns a webhook by its id.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **long** | The ID of the webhook. You can find the ID in the Campaign Manager&#39;s URL when you display the details of the webhook in **Account** &gt; **Webhooks**.  |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhooks"></a>
# **GetWebhooks**
> GetWebhooks200Response GetWebhooks (string applicationIds = null, string sort = null, long pageSize = null, long skip = null, string creationType = null, string visibility = null, long outgoingIntegrationsTypeId = null, string title = null)

List webhooks

List all webhooks.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationIds** | **string** | Checks if the given catalog or its attributes are referenced in the specified Application ID.  **Note**: If no Application ID is provided, we check for all connected Applications.  | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **creationType** | **string** | Filter results by creation type. | [optional]  |
| **visibility** | **string** | Filter results by visibility. | [optional]  |
| **outgoingIntegrationsTypeId** | **long** | Filter results by outgoing integration type ID. | [optional]  |
| **title** | **string** | Filter results performing case-insensitive matching against the webhook title. | [optional]  |

### Return type

[**GetWebhooks200Response**](GetWebhooks200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importaccountcollection"></a>
# **ImportAccountCollection**
> Import ImportAccountCollection (long collectionId, string upFile = null)

Import data into existing account-level collection

Upload a CSV file containing the collection of string values that should be attached as payload for collection. The file should be sent as multipart data.  The import **replaces** the initial content of the collection.  The CSV file **must** only contain the following column:  - `item`: the values in your collection.  A collection is limited to 500,000 items.  Example:  ``` item Addidas Nike Asics ```  **Note:** Before sending a request to this endpoint, ensure the data in the CSV to import is different from the data currently stored in the collection. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint. |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importallowedlist"></a>
# **ImportAllowedList**
> Import ImportAllowedList (long attributeId, string upFile = null)

Import allowed values for attribute

Upload a CSV file containing a list of [picklist values](https://docs.talon.one/docs/product/account/dev-tools/managing-attributes#picklist-values) for the specified attribute.  The file should be sent as multipart data.  The import **replaces** the previous list of allowed values for this attribute, if any.  The CSV file **must** only contain the following column: - `item` (required): the values in your allowed list, for example a list of SKU's.  An allowed list is limited to 500,000 items.  Example:  ```text item CS-VG-04032021-UP-50D-10 CS-DV-04042021-UP-49D-12 CS-DG-02082021-UP-50G-07 ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attributeId** | **long** | The ID of the attribute. You can find the ID in the Campaign Manager&#39;s URL when you display the details of an attribute in **Account** &gt; **Tools** &gt; **Attributes**. |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importaudiencesmemberships"></a>
# **ImportAudiencesMemberships**
> Import ImportAudiencesMemberships (long audienceId, string upFile = null)

Import audience members

Upload a CSV file containing the integration IDs of the members you want to add to an audience.  The file should be sent as multipart data and should contain only the following column (required): - `profileintegrationid`: The integration ID of the customer profile.  The import **replaces** the previous list of audience members.  **Note:** We recommend limiting your file size to 500MB.  Example:  ```text profileintegrationid charles alexa ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **audienceId** | **long** | The ID of the audience. |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importcampaignstorebudget"></a>
# **ImportCampaignStoreBudget**
> Import ImportCampaignStoreBudget (long applicationId, long campaignId, string action = null, string period = null, string upFile = null)

Import campaign store budgets

Upload a CSV file containing store budgets for a given campaign.  Send the file as multipart data.  The CSV file **must** only contain the following columns: - `store_integration_id`: The identifier of the store. - `limit`: The budget limit for the store.  The import **replaces** the previous list of store budgets. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **action** | **string** | The action that this budget is limiting. | [optional]  |
| **period** | **string** | The period to which the limit applies.  **Note**: For budgets with no period, set this to &#x60;overall&#x60;.  | [optional]  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importcampaignstores"></a>
# **ImportCampaignStores**
> Import ImportCampaignStores (long applicationId, long campaignId, string upFile = null)

Import stores

Upload a CSV file containing the stores you want to link to a specific campaign.  Send the file as multipart data.  The CSV file **must** only contain the following column: - `store_integration_id`: The identifier of the store.  The import **replaces** the previous list of stores linked to the campaign. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importcollection"></a>
# **ImportCollection**
> Import ImportCollection (long applicationId, long campaignId, long collectionId, string upFile = null)

Import data into existing campaign-level collection

Upload a CSV file containing the collection of string values that should be attached as payload for collection. The file should be sent as multipart data.  The import **replaces** the initial content of the collection.  The CSV file **must** only contain the following column:  - `item`: the values in your collection.  A collection is limited to 500,000 items.  Example:  ``` item Addidas Nike Asics ```  **Note:** Before sending a request to this endpoint, ensure the data in the CSV to import is different from the data currently stored in the collection. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint. |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importcoupons"></a>
# **ImportCoupons**
> Import ImportCoupons (long applicationId, long campaignId, bool skipDuplicates = null, string upFile = null)

Import coupons

Upload a CSV file containing the coupons that should be created. The file should be sent as multipart data.  The CSV file contains the following columns:  - `value` (required): The coupon code. - `expirydate`: The end date in RFC3339 of the code redemption period. - `startdate`: The start date in RFC3339 of the code redemption period. - `recipientintegrationid`: The integration ID of the recipient of the coupon.   Only the customer with this integration ID can redeem this code. Available only for personal codes. - `limitval`: The maximum number of redemptions of this code. For unlimited redemptions, use `0`. Defaults to `1` when not provided. - `discountlimit`: The total discount value that the code can give. This is typically used to represent a gift card value. - `attributes`: A JSON object describing _custom_ coupon attribute names and their values, enclosed with double quotation marks.    For example, if you created a [custom attribute](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes)   called `category` associated with the coupon entity, the object in the CSV file, when opened in a text editor, must be: `\"{\"category\": \"10_off\"}\"`.  You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Note:** We recommend limiting your file size to 500MB.  **Example:**  ```text \"value\",\"expirydate\",\"startdate\",\"recipientintegrationid\",\"limitval\",\"attributes\",\"discountlimit\" COUP1,2018-07-01T04:00:00Z,2018-05-01T04:00:00Z,cust123,1,\"{\"\"Category\"\": \"\"10_off\"\"}\",2.4 ```  Once imported, you can find the `batchId` in the Campaign Manager or by using [List coupons](#tag/Coupons/operation/getCouponsWithoutTotalCount). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **skipDuplicates** | **bool** | An indicator of whether to skip duplicate coupon values instead of causing an error. Duplicate values are ignored when &#x60;skipDuplicates&#x3D;true&#x60;.  | [optional]  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importloyaltycards"></a>
# **ImportLoyaltyCards**
> Import ImportLoyaltyCards (long loyaltyProgramId, string upFile = null)

Import loyalty cards

Upload a CSV file containing the loyalty cards that you want to use in your card-based loyalty program. Send the file as multipart data.  It contains the following columns for each card:  - `identifier` (required): The alphanumeric identifier of the loyalty card. - `state` (required): The state of the loyalty card. It can be `active` or `inactive`. - `customerprofileids` (optional): An array of strings representing the identifiers of the customer profiles linked to the loyalty card. The identifiers should be separated with a semicolon (;).  **Note:** We recommend limiting your file size to 500MB.  **Example:**  ```csv identifier,state,customerprofileids 123-456-789AT,active,Alexa001;UserA ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importloyaltycustomerstiers"></a>
# **ImportLoyaltyCustomersTiers**
> Import ImportLoyaltyCustomersTiers (long loyaltyProgramId, string upFile = null)

Import customers into loyalty tiers

Upload a CSV file containing existing customers to be assigned to existing tiers. Send the file as multipart data.  **Important:** This endpoint only works with loyalty programs with advanced tiers (with expiration and downgrade policy) feature enabled.  The CSV file should contain the following columns: - `subledgerid` (optional): The ID of the subledger. If this field is empty, the main ledger will be used. - `customerprofileid`: The integration ID of the customer profile to whom the tier should be assigned. - `tiername`: The name of an existing tier to assign to the customer. - `expirydate`: The expiration date of the tier when the tier is reevaluated. It should be a future date.  About customer assignment to a tier: - If the customer isn't already in a tier, the customer is assigned to the specified tier during the tier import. - If the customer is already in the tier that's specified in the CSV file, only the expiration date is updated.  **Note:** We recommend not using this endpoint to update the tier of a customer. To update a customer's tier, you can [add](/management-api#tag/Loyalty/operation/addLoyaltyPoints) or [deduct](/management-api#tag/Loyalty/operation/removeLoyaltyPoints) their loyalty points.  You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Note:** We recommend limiting your file size to 500MB.  **Example:** ```csv subledgerid,customerprofileid,tiername,expirydate SUB1,alexa,Gold,2024-03-21T07:32:14Z ,george,Silver,2025-04-16T21:12:37Z SUB2,avocado,Bronze,2026-05-03T11:47:01Z ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importloyaltypoints"></a>
# **ImportLoyaltyPoints**
> Import ImportLoyaltyPoints (long loyaltyProgramId, bool notificationsEnabled = null, string upFile = null)

Import loyalty points

Upload a CSV file containing the loyalty points you want to import into a given loyalty program. Send the file as multipart data.  Depending on the type of loyalty program, you can import points into a given customer profile or loyalty card.  The CSV file contains the following columns:  - `customerprofileid` (optional): For profile-based loyalty programs, the integration ID of the customer profile where the loyalty points are imported.    **Note**: If the customer profile does not exist, it will be created. The profile will not be visible in any Application   until a session or profile update is received for that profile. - `identifier` (optional): For card-based loyalty programs, the identifier of the loyalty card where the loyalty points are imported. - `amount`: The amount of points to award to the customer profile. - `startdate` (optional): The earliest date when the points can be redeemed. The points are `active` from this date until the expiration date.    This parameter accepts one of the following values:   - A timestamp string in RFC3339 format.   - `immediate`   - `on_action`      **Note**:   Empty or missing values default to `immediate`. - `expirydate` (optional): The latest date when the points can be redeemed. The points are `expired` after this date.    **Note**: It must be an RFC3339 timestamp string or string `unlimited`. Empty or missing values are considered `unlimited`.      If passed, `validityDuration` should be omitted. - `validityDuration` (optional): The duration for which the points remain active, relative to the    activation date.    The time format is an **integer** followed by one letter indicating the time unit.     Examples: `30s`, `40m`, `1h`, `5D`, `7W`, `10M`, `15Y`.     Available units:     - `s`: seconds   - `m`: minutes   - `h`: hours   - `D`: days   - `W`: weeks   - `M`: months   - `Y`: years     You can round certain units up or down:    - `_D` for rounding down days only. Signifies the start of the day.   - `_U` for rounding up days, weeks, months and years. Signifies the end of   the day, week, month or year.    If passed, `expirydate` should be omitted. - `subledgerid` (optional): The ID of the subledger that should received the points. - `reason` (optional): The reason why these points are awarded.  You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Note:** For existing customer profiles and loyalty cards, the imported points are added to any previous active or pending points, depending on the value provided for `startdate`. If `startdate` matches the current date, the imported points are _active_. If it is later, the points are _pending_ until the date provided for `startdate` is reached.  **Note:** We recommend limiting your file size to 500MB.  **Example for profile-based programs:**  ```text customerprofileid,amount,startdate,expirydate,subledgerid,reason URNGV8294NV,100,2009-11-10T23:00:00Z,2009-11-11T23:00:00Z,subledger1,appeasement ```  **Example for card-based programs:**  ```text identifier,amount,startdate,expirydate,subledgerid,reason summer-loyalty-card-0543,100,2009-11-10T23:00:00Z,2009-11-11T23:00:00Z,subledger1,appeasement ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **notificationsEnabled** | **bool** | Indicates whether the points import triggers notifications about its effects. For example, a notification is sent if the import upgrades a customer&#39;s tier or offsets their negative points balance.  This parameter is optional and defaults to &#x60;true&#x60;.  | [optional]  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importpoolgiveaways"></a>
# **ImportPoolGiveaways**
> Import ImportPoolGiveaways (long poolId, string upFile = null)

Import giveaway codes into a giveaway pool

Upload a CSV file containing the giveaway codes that should be created. Send the file as multipart data.  The CSV file contains the following columns: - `code` (required): The code of your giveaway, for instance, a gift card redemption code. - `startdate`:  The start date in RFC3339 of the code redemption period. - `enddate`: The last date in RFC3339 of the code redemption period. - `attributes`: A JSON object describing _custom_ giveaway attribute names and their values, enclosed with double quotation marks.    For example, if you created a [custom attribute](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes)   called `provider` associated with the giveaway entity, the object in the CSV file, when opened in a text editor, must be: `\"{\"provider\": \"myPartnerCompany\"}\"`.  The `startdate` and `enddate` have nothing to do with the _validity_ of the codes. They are only used by the Rule Engine to award the codes or not. You can use the time zone setting of your choice. The values are converted to UTC internally by Talon.One.  **Note:**  - We recommend limiting your file size to 500MB. - You can import the same code multiple times. Duplicate codes are treated and distributed to customers as unique codes.  **Example:**  ```text code,startdate,enddate,attributes GIVEAWAY1,2020-11-10T23:00:00Z,2022-11-11T23:00:00Z,\"{\"\"provider\"\": \"\"Amazon\"\"}\" GIVEAWAY2,2020-11-10T23:00:00Z,2022-11-11T23:00:00Z,\"{\"\"provider\"\": \"\"Amazon\"\"}\" GIVEAWAY3,2021-01-10T23:00:00Z,2022-11-11T23:00:00Z,\"{\"\"provider\"\": \"\"Aliexpress\"\"}\" ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **poolId** | **long** | The ID of the pool. You can find it in the Campaign Manager, in the **Giveaways** section. |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importreferrals"></a>
# **ImportReferrals**
> Import ImportReferrals (long applicationId, long campaignId, string upFile = null)

Import referrals

Upload a CSV file containing the referrals that should be created. The file should be sent as multipart data.  The CSV file contains the following columns:  - `code` (required): The referral code. - `advocateprofileintegrationid` (required): The profile ID of the advocate. - `startdate`: The start date in RFC3339 of the code redemption period. - `expirydate`: The end date in RFC3339 of the code redemption period. - `limitval`: The maximum number of redemptions of this code. Defaults to `1` when left blank. - `attributes`: A JSON object describing _custom_ referral attribute names and their values, enclosed with double quotation marks.    For example, if you created a [custom attribute](https://docs.talon.one/docs/dev/concepts/attributes#custom-attributes)   called `category` associated with the referral entity, the object in the CSV file, when opened in a text editor, must be: `\"{\"category\": \"10_off\"}\"`.  You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Important:** When you import a CSV file with referrals, a [customer profile](https://docs.talon.one/docs/dev/concepts/entities/customer-profiles) is **not** automatically created for each `advocateprofileintegrationid` column value. Use the [Update customer profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint or the [Update multiple customer profiles](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfilesV2) endpoint to create the customer profiles.  **Note:** We recommend limiting your file size to 500MB.  **Example:**  ```text code,startdate,expirydate,advocateprofileintegrationid,limitval,attributes REFERRAL_CODE1,2020-11-10T23:00:00Z,2021-11-11T23:00:00Z,integid_4,1,\"{\"\"my_attribute\"\": \"\"10_off\"\"}\" REFERRAL_CODE2,2020-11-10T23:00:00Z,2021-11-11T23:00:00Z,integid1,1,\"{\"\"my_attribute\"\": \"\"20_off\"\"}\" ``` 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **upFile** | **string** | The file containing the data that is being imported. | [optional]  |

### Return type

[**Import**](Import.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="inviteuserexternal"></a>
# **InviteUserExternal**
> void InviteUserExternal (NewExternalInvitation newExternalInvitation)

Invite user from identity provider

[Invite a user](https://docs.talon.one/docs/product/account/account-settings/managing-users#inviting-a-user) from an external identity provider to Talon.One by sending an invitation to their email address. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newExternalInvitation** | [**NewExternalInvitation**](NewExternalInvitation.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Invitation email sent |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listaccountcollections"></a>
# **ListAccountCollections**
> ListAccountCollections200Response ListAccountCollections (long pageSize = null, long skip = null, string sort = null, bool withTotalResultSize = null, string name = null)

List collections in account

List account-level collections in the account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |
| **name** | **string** | Filter by collection name. | [optional]  |

### Return type

[**ListAccountCollections200Response**](ListAccountCollections200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listachievements"></a>
# **ListAchievements**
> ListAchievements200Response ListAchievements (long applicationId, long campaignId, long pageSize = null, long skip = null, string title = null)

List achievements

List all the achievements for a specific campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 50] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **title** | **string** | Filter by the display name for the achievement in the campaign manager.  **Note**: If no &#x60;title&#x60; is provided, all the achievements from the campaign are returned.  | [optional]  |

### Return type

[**ListAchievements200Response**](ListAchievements200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listallrolesv2"></a>
# **ListAllRolesV2**
> ListAllRolesV2200Response ListAllRolesV2 ()

List roles

List all roles.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ListAllRolesV2200Response**](ListAllRolesV2200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcampaignstorebudgetlimits"></a>
# **ListCampaignStoreBudgetLimits**
> ListCampaignStoreBudgetLimits200Response ListCampaignStoreBudgetLimits (long applicationId, long campaignId, string action = null, string period = null)

List campaign store budget limits

Return the store budget limits for a given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **action** | **string** | The action that this budget is limiting. | [optional]  |
| **period** | **string** | The period to which the limit applies.  **Note**: For budgets with no period, set this to &#x60;overall&#x60;.  | [optional]  |

### Return type

[**ListCampaignStoreBudgetLimits200Response**](ListCampaignStoreBudgetLimits200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcatalogitems"></a>
# **ListCatalogItems**
> ListCatalogItems200Response ListCatalogItems (long catalogId, long pageSize = null, long skip = null, bool withTotalResultSize = null, List<string> sku = null, List<string> productNames = null)

List items in a catalog

Return a paginated list of cart items in the given catalog. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **catalogId** | **long** | The ID of the catalog. You can find the ID in the Campaign Manager in **Account** &gt; **Tools** &gt; **Cart item catalogs**. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |
| **sku** | [**List&lt;string&gt;**](string.md) | Filter results by one or more SKUs. Must be exact match. | [optional]  |
| **productNames** | [**List&lt;string&gt;**](string.md) | Filter results by one or more product names. Must be exact match. | [optional]  |

### Return type

[**ListCatalogItems200Response**](ListCatalogItems200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcollections"></a>
# **ListCollections**
> ListAccountCollections200Response ListCollections (long applicationId, long campaignId, long pageSize = null, long skip = null, string sort = null, bool withTotalResultSize = null, string name = null)

List collections in campaign

List collections in a given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |
| **name** | **string** | Filter by collection name. | [optional]  |

### Return type

[**ListAccountCollections200Response**](ListAccountCollections200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcollectionsinapplication"></a>
# **ListCollectionsInApplication**
> ListAccountCollections200Response ListCollectionsInApplication (long applicationId, long pageSize = null, long skip = null, string sort = null, bool withTotalResultSize = null, string name = null)

List collections in Application

List campaign-level collections from all campaigns in a given Application.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |
| **name** | **string** | Filter by collection name. | [optional]  |

### Return type

[**ListAccountCollections200Response**](ListAccountCollections200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="liststores"></a>
# **ListStores**
> ListStores200Response ListStores (long applicationId, long pageSize = null, long skip = null, string sort = null, bool withTotalResultSize = null, decimal campaignId = null, string name = null, string integrationId = null, string query = null)

List stores

List all stores for a specific Application.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **withTotalResultSize** | **bool** | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When &#x60;true&#x60;: &#x60;hasMore&#x60; is true when there is a next page. &#x60;totalResultSize&#x60; is always zero. - When &#x60;false&#x60;: &#x60;hasMore&#x60; is always false. &#x60;totalResultSize&#x60; contains the total number of results for this query.  | [optional]  |
| **campaignId** | **decimal** | Filter results by campaign ID. | [optional]  |
| **name** | **string** | The name of the store. | [optional]  |
| **integrationId** | **string** | The integration ID of the store. | [optional]  |
| **query** | **string** | Filter results by &#x60;name&#x60; or &#x60;integrationId&#x60;. | [optional]  |

### Return type

[**ListStores200Response**](ListStores200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="oktaeventhandlerchallenge"></a>
# **OktaEventHandlerChallenge**
> void OktaEventHandlerChallenge ()

Validate Okta API ownership

Validate the ownership of the API through a challenge-response mechanism.  This challenger endpoint is used by Okta to confirm that communication between Talon.One and Okta is correctly configured and accessible for provisioning and deprovisioning of Talon.One users, and that only Talon.One can receive and respond to events from Okta. 


### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removeloyaltypoints"></a>
# **RemoveLoyaltyPoints**
> void RemoveLoyaltyPoints (string loyaltyProgramId, string integrationId, DeductLoyaltyPoints deductLoyaltyPoints)

Deduct points from customer profile

Deduct points from the specified loyalty program and specified customer profile.  **Important:** - Only active points can be deducted. - Only pending points are rolled back when a session is cancelled or reopened.  To get the `integrationId` of the profile from a `sessionId`, use the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **string** | The identifier for the loyalty program. |  |
| **integrationId** | **string** | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier.  |  |
| **deductLoyaltyPoints** | [**DeductLoyaltyPoints**](DeductLoyaltyPoints.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="resetpassword"></a>
# **ResetPassword**
> NewPassword ResetPassword (NewPassword newPassword)

Reset password

Consumes the supplied password reset token and updates the password for the associated account. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newPassword** | [**NewPassword**](NewPassword.md) | body |  |

### Return type

[**NewPassword**](NewPassword.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimcreategroup"></a>
# **ScimCreateGroup**
> ScimGroup ScimCreateGroup (ScimBaseGroup scimBaseGroup)

Create SCIM group

Create a new Talon.One group using the SCIM Group provisioning protocol with an identity provider, for example, Microsoft Entra ID, and assign members from the payload to the new group. In Talon.One, a `Group` corresponds to a [role](https://docs.talon.one/docs/product/account/account-settings/managing-roles), and `members` are the [users](https://docs.talon.one/docs/product/account/account-settings/managing-users) assigned to that role.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scimBaseGroup** | [**ScimBaseGroup**](ScimBaseGroup.md) | body |  |

### Return type

[**ScimGroup**](ScimGroup.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimcreateuser"></a>
# **ScimCreateUser**
> ScimUser ScimCreateUser (ScimNewUser scimNewUser)

Create SCIM user

Create a new Talon.One user using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scimNewUser** | [**ScimNewUser**](ScimNewUser.md) | body |  |

### Return type

[**ScimUser**](ScimUser.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimdeletegroup"></a>
# **ScimDeleteGroup**
> void ScimDeleteGroup (long groupId)

Delete SCIM group

Delete a specific group created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID. In Talon.One, a `Group` corresponds to a [role](https://docs.talon.one/docs/product/account/account-settings/managing-roles), and `members` are the [users](https://docs.talon.one/docs/product/account/account-settings/managing-users) assigned to that role.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | The ID of the group. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimdeleteuser"></a>
# **ScimDeleteUser**
> void ScimDeleteUser (long userId)

Delete SCIM user

Delete a specific Talon.One user created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The ID of the user. |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimgetgroup"></a>
# **ScimGetGroup**
> ScimGroup ScimGetGroup (long groupId)

Get SCIM group

Retrieve data for a specific group created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID. In Talon.One, a `Group` corresponds to a [role](https://docs.talon.one/docs/product/account/account-settings/managing-roles), and `members` are the [users](https://docs.talon.one/docs/product/account/account-settings/managing-users) assigned to that role.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | The ID of the group. |  |

### Return type

[**ScimGroup**](ScimGroup.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Group details |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimgetgroups"></a>
# **ScimGetGroups**
> ScimGroupsListResponse ScimGetGroups ()

List SCIM groups

Retrieve a paginated list of groups created using the SCIM protocol with an identity provider, for example, Microsoft Entra ID. In Talon.One, a `Group` corresponds to a [role](https://docs.talon.one/docs/product/account/account-settings/managing-roles), and `members` are the [users](https://docs.talon.one/docs/product/account/account-settings/managing-users) assigned to that role.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ScimGroupsListResponse**](ScimGroupsListResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of SCIM groups |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimgetresourcetypes"></a>
# **ScimGetResourceTypes**
> ScimResourceTypesListResponse ScimGetResourceTypes ()

List supported SCIM resource types

Retrieve a list of resource types supported by the SCIM provisioning protocol.  Resource types define the various kinds of resources that can be managed via the SCIM API, such as users, groups, or custom-defined resources. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**ScimResourceTypesListResponse**](ScimResourceTypesListResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of resource types |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimgetschemas"></a>
# **ScimGetSchemas**
> ScimSchemasListResponse ScimGetSchemas ()

List supported SCIM schemas

Retrieve a list of schemas supported by the SCIM provisioning protocol.  Schemas define the structure and attributes of the different resources that can be managed via the SCIM API, such as users, groups, and any custom-defined resources. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**ScimSchemasListResponse**](ScimSchemasListResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of schemas supported by the SCIM provisioning protocol |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimgetserviceproviderconfig"></a>
# **ScimGetServiceProviderConfig**
> ScimServiceProviderConfigResponse ScimGetServiceProviderConfig ()

Get SCIM service provider configuration

Retrieve the configuration settings of the SCIM service provider. It provides details about the features and capabilities supported by the SCIM API, such as the different operation settings. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**ScimServiceProviderConfigResponse**](ScimServiceProviderConfigResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service configuration |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimgetuser"></a>
# **ScimGetUser**
> ScimUser ScimGetUser (long userId)

Get SCIM user

Retrieve data for a specific Talon.One user created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The ID of the user. |  |

### Return type

[**ScimUser**](ScimUser.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User details |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimgetusers"></a>
# **ScimGetUsers**
> ScimUsersListResponse ScimGetUsers ()

List SCIM users

Retrieve a paginated list of users that have been provisioned using the SCIM protocol with an identity provider, for example, Microsoft Entra ID.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ScimUsersListResponse**](ScimUsersListResponse.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of SCIM users |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimpatchgroup"></a>
# **ScimPatchGroup**
> ScimGroup ScimPatchGroup (long groupId, ScimPatchRequest scimPatchRequest)

Update SCIM group attributes

Update certain attributes of a group created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID. This endpoint allows for selective adding, removing, or replacing of specific group attributes while other attributes remain unchanged. In Talon.One, a `Group` corresponds to a [role](https://docs.talon.one/docs/product/account/account-settings/managing-roles), and `members` are the [users](https://docs.talon.one/docs/product/account/account-settings/managing-users) assigned to that role. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | The ID of the group. |  |
| **scimPatchRequest** | [**ScimPatchRequest**](ScimPatchRequest.md) | body |  |

### Return type

[**ScimGroup**](ScimGroup.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Group details |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimpatchuser"></a>
# **ScimPatchUser**
> ScimUser ScimPatchUser (long userId, ScimPatchRequest scimPatchRequest)

Update SCIM user attributes

Update certain attributes of a specific Talon.One user created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID.  This endpoint allows for selective adding, removing, or replacing specific attributes while leaving other attributes unchanged. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The ID of the user. |  |
| **scimPatchRequest** | [**ScimPatchRequest**](ScimPatchRequest.md) | body |  |

### Return type

[**ScimUser**](ScimUser.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User details |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimreplacegroupattributes"></a>
# **ScimReplaceGroupAttributes**
> ScimGroup ScimReplaceGroupAttributes (long groupId, ScimBaseGroup scimBaseGroup)

Update SCIM group

Update the details of a specific group created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID. This endpoint replaces all attributes of the given group with the attributes provided in the request payload. In Talon.One, a `Group` corresponds to a [role](https://docs.talon.one/docs/product/account/account-settings/managing-roles), and `members` are the [users](https://docs.talon.one/docs/product/account/account-settings/managing-users) assigned to that role. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | The ID of the group. |  |
| **scimBaseGroup** | [**ScimBaseGroup**](ScimBaseGroup.md) | body |  |

### Return type

[**ScimGroup**](ScimGroup.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Group details |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="scimreplaceuserattributes"></a>
# **ScimReplaceUserAttributes**
> ScimUser ScimReplaceUserAttributes (long userId, ScimNewUser scimNewUser)

Update SCIM user

Update the details of a specific Talon.One user created using the SCIM provisioning protocol with an identity provider, for example, Microsoft Entra ID.  This endpoint replaces all attributes of the specific user with the attributes provided in the request payload. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The ID of the user. |  |
| **scimNewUser** | [**ScimNewUser**](ScimNewUser.md) | body |  |

### Return type

[**ScimUser**](ScimUser.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User details |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchcouponsadvancedapplicationwidewithouttotalcount"></a>
# **SearchCouponsAdvancedApplicationWideWithoutTotalCount**
> GetCouponsWithoutTotalCount200Response SearchCouponsAdvancedApplicationWideWithoutTotalCount (long applicationId, Object body, long pageSize = null, long skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, long referralId = null, string recipientIntegrationId = null, string batchId = null, bool exactMatch = null, string campaignState = null)

List coupons that match the given attributes (without total count)

List the coupons whose attributes match the query criteria in all the campaigns of the given Application.  The match is successful if all the attributes of the request are found in a coupon, even if the coupon has more attributes that are not present on the request.  **Note:** The total count is not included in the response. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **body** | **Object** | body |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **value** | **string** | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **valid** | **string** | Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional]  |
| **usable** | **string** | Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional]  |
| **referralId** | **long** | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional]  |
| **recipientIntegrationId** | **string** | Filter results by match with a profile ID specified in the coupon&#39;s RecipientIntegrationId field. | [optional]  |
| **batchId** | **string** | Filter results by batches of coupons | [optional]  |
| **exactMatch** | **bool** | Filter results to an exact case-insensitive matching against the coupon code. | [optional] [default to false] |
| **campaignState** | **string** | Filter results by the state of the campaign.  - &#x60;enabled&#x60;: Campaigns that are scheduled, running (activated), or expired. - &#x60;running&#x60;: Campaigns that are running (activated). - &#x60;disabled&#x60;: Campaigns that are disabled. - &#x60;expired&#x60;: Campaigns that are expired. - &#x60;archived&#x60;: Campaigns that are archived.  | [optional]  |

### Return type

[**GetCouponsWithoutTotalCount200Response**](GetCouponsWithoutTotalCount200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchcouponsadvancedwithouttotalcount"></a>
# **SearchCouponsAdvancedWithoutTotalCount**
> GetCouponsWithoutTotalCount200Response SearchCouponsAdvancedWithoutTotalCount (long applicationId, long campaignId, Object body, long pageSize = null, long skip = null, string sort = null, string value = null, DateTime createdBefore = null, DateTime createdAfter = null, string valid = null, string usable = null, long referralId = null, string recipientIntegrationId = null, bool exactMatch = null, string batchId = null)

List coupons that match the given attributes in campaign (without total count)

List the coupons whose attributes match the query criteria in the given campaign.  The match is successful if all the attributes of the request are found in a coupon, even if the coupon has more attributes that are not present on the request.  **Note:** The total count is not included in the response. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **body** | **Object** | body |  |
| **pageSize** | **long** | The number of items in the response. | [optional] [default to 1000] |
| **skip** | **long** | The number of items to skip when paging through large result sets. | [optional]  |
| **sort** | **string** | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with &#x60;-&#x60;.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  | [optional]  |
| **value** | **string** | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. | [optional]  |
| **createdBefore** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **createdAfter** | **DateTime** | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. | [optional]  |
| **valid** | **string** | Either \&quot;expired\&quot;, \&quot;validNow\&quot;, or \&quot;validFuture\&quot;. The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  | [optional]  |
| **usable** | **string** | Either \&quot;true\&quot; or \&quot;false\&quot;. If \&quot;true\&quot;, only coupons where &#x60;usageCounter &lt; usageLimit&#x60; will be returned, \&quot;false\&quot; will return only coupons where &#x60;usageCounter &gt;&#x3D; usageLimit&#x60;.  | [optional]  |
| **referralId** | **long** | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. | [optional]  |
| **recipientIntegrationId** | **string** | Filter results by match with a profile ID specified in the coupon&#39;s RecipientIntegrationId field. | [optional]  |
| **exactMatch** | **bool** | Filter results to an exact case-insensitive matching against the coupon code. | [optional] [default to false] |
| **batchId** | **string** | Filter results by batches of coupons | [optional]  |

### Return type

[**GetCouponsWithoutTotalCount200Response**](GetCouponsWithoutTotalCount200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="summarizecampaignstorebudget"></a>
# **SummarizeCampaignStoreBudget**
> SummarizeCampaignStoreBudget200Response SummarizeCampaignStoreBudget (long applicationId, long campaignId)

Get summary of campaign store budgets

Fetch a summary of all store budget information for a given campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |

### Return type

[**SummarizeCampaignStoreBudget200Response**](SummarizeCampaignStoreBudget200Response.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized - Invalid API key |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="transferloyaltycard"></a>
# **TransferLoyaltyCard**
> void TransferLoyaltyCard (long loyaltyProgramId, string loyaltyCardId, TransferLoyaltyCard transferLoyaltyCard)

Transfer card data

Transfer loyalty card data, such as linked customers, loyalty balances and transactions, from a given loyalty card to a new, automatically created loyalty card.  **Important:**  - The original card is automatically blocked once the new card is created, and it cannot be activated again. - The default status of the new card is _active_. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardId** | **string** | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  |  |
| **transferLoyaltyCard** | [**TransferLoyaltyCard**](TransferLoyaltyCard.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateaccountcollection"></a>
# **UpdateAccountCollection**
> Collection UpdateAccountCollection (long collectionId, UpdateCollection updateCollection)

Update account-level collection

Edit the description of a given account-level collection and enable or disable the collection in the specified Applications.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint. |  |
| **updateCollection** | [**UpdateCollection**](UpdateCollection.md) | body |  |

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **409** | Conflict. A collection with this name already exists. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateachievement"></a>
# **UpdateAchievement**
> Achievement UpdateAchievement (long applicationId, long campaignId, long achievementId, UpdateAchievement updateAchievement)

Update achievement

Update the details of a specific achievement.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **achievementId** | **long** | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint. |  |
| **updateAchievement** | [**UpdateAchievement**](UpdateAchievement.md) | body |  |

### Return type

[**Achievement**](Achievement.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateadditionalcost"></a>
# **UpdateAdditionalCost**
> AccountAdditionalCost UpdateAdditionalCost (long additionalCostId, NewAdditionalCost newAdditionalCost)

Update additional cost

Updates an existing additional cost. Once created, the only property of an additional cost that cannot be changed is the `name` property (or **API name** in the Campaign Manager). This restriction is in place to prevent accidentally breaking live integrations. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **additionalCostId** | **long** | The ID of the additional cost. You can find the ID the the Campaign Manager&#39;s URL when you display the details of the cost in **Account** &gt; **Tools** &gt; **Additional costs**.  |  |
| **newAdditionalCost** | [**NewAdditionalCost**](NewAdditionalCost.md) | body |  |

### Return type

[**AccountAdditionalCost**](AccountAdditionalCost.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateattribute"></a>
# **UpdateAttribute**
> Attribute UpdateAttribute (long attributeId, NewAttribute newAttribute)

Update custom attribute

Update an existing custom attribute. Once created, the only property of a custom attribute that can be changed is the description.  To change the `type` or `name` property of a custom attribute, create a new attribute and update any relevant integrations and rules to use the new attribute. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attributeId** | **long** | The ID of the attribute. You can find the ID in the Campaign Manager&#39;s URL when you display the details of an attribute in **Account** &gt; **Tools** &gt; **Attributes**. |  |
| **newAttribute** | [**NewAttribute**](NewAttribute.md) | body |  |

### Return type

[**Attribute**](Attribute.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecampaign"></a>
# **UpdateCampaign**
> Campaign UpdateCampaign (long applicationId, long campaignId, UpdateCampaign updateCampaign)

Update campaign

Update the given campaign.  **Important:** You cannot use this endpoint to update campaigns if [campaign staging and revisions](https://docs.talon.one/docs/product/applications/managing-general-settings#campaign-staging-and-revisions) is enabled for your Application. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **updateCampaign** | [**UpdateCampaign**](UpdateCampaign.md) | body |  |

### Return type

[**Campaign**](Campaign.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecollection"></a>
# **UpdateCollection**
> Collection UpdateCollection (long applicationId, long campaignId, long collectionId, UpdateCampaignCollection updateCampaignCollection)

Update campaign-level collection's description

Edit the description of a given campaign-level collection.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **collectionId** | **long** | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint. |  |
| **updateCampaignCollection** | [**UpdateCampaignCollection**](UpdateCampaignCollection.md) | body |  |

### Return type

**Collection**

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecoupon"></a>
# **UpdateCoupon**
> Coupon UpdateCoupon (long applicationId, long campaignId, string couponId, UpdateCoupon updateCoupon)

Update coupon

Update the specified coupon.  <div class=\"redoc-section\">   <p class=\"title\">Important</p>    <p>With this <code>PUT</code> endpoint, if you do not explicitly set a value for the <code>startDate</code>, <code>expiryDate</code>, and <code>recipientIntegrationId</code> properties in your request, it is automatically set to <code>null</code>.</p>  </div> 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **couponId** | **string** | The internal ID of the coupon code. You can find this value in the &#x60;id&#x60; property from the [List coupons](https://docs.talon.one/management-api#tag/Coupons/operation/getCouponsWithoutTotalCount) endpoint response.  |  |
| **updateCoupon** | [**UpdateCoupon**](UpdateCoupon.md) | body |  |

### Return type

[**Coupon**](Coupon.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecouponbatch"></a>
# **UpdateCouponBatch**
> void UpdateCouponBatch (long applicationId, long campaignId, UpdateCouponBatch updateCouponBatch)

Update coupons

Update all coupons or a specific batch of coupons in the given campaign. You can find the `batchId` on the **Coupons** page of your campaign in the Campaign Manager, or you can use [List coupons](#operation/getCouponsWithoutTotalCount).  <div class=\"redoc-section\">   <p class=\"title\">Important</p>    <ul>     <li>Only send sequential requests to this endpoint.</li>     <li>Requests to this endpoint time out after 30 minutes. If you hit a timeout, contact our support team.</li>     <li>With this <code>PUT</code> endpoint, if you do not explicitly set a value for the <code>startDate</code> and <code>expiryDate</code> properties in your request, it is automatically set to <code>null</code>.</li>   </ul>  </div>  To update a specific coupon, use [Update coupon](#operation/updateCoupon). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **updateCouponBatch** | [**UpdateCouponBatch**](UpdateCouponBatch.md) | body |  |

### Return type

void (empty response body)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateloyaltycard"></a>
# **UpdateLoyaltyCard**
> LoyaltyCard UpdateLoyaltyCard (long loyaltyProgramId, string loyaltyCardId, UpdateLoyaltyCard updateLoyaltyCard)

Update loyalty card status

Update the status of the given loyalty card. A card can be _active_ or _inactive_.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltyProgramId** | **long** | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint.  |  |
| **loyaltyCardId** | **string** | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint.  |  |
| **updateLoyaltyCard** | [**UpdateLoyaltyCard**](UpdateLoyaltyCard.md) | body |  |

### Return type

[**LoyaltyCard**](LoyaltyCard.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatereferral"></a>
# **UpdateReferral**
> Referral UpdateReferral (long applicationId, long campaignId, string referralId, UpdateReferral updateReferral)

Update referral

Update the specified referral.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **campaignId** | **long** | The ID of the campaign. It is displayed in your Talon.One deployment URL. |  |
| **referralId** | **string** | The ID of the referral code. |  |
| **updateReferral** | [**UpdateReferral**](UpdateReferral.md) | body |  |

### Return type

[**Referral**](Referral.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updaterolev2"></a>
# **UpdateRoleV2**
> RoleV2 UpdateRoleV2 (long roleId, RoleV2Base roleV2Base)

Update role

Update a specific role.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roleId** | **long** | The ID of role.  **Note**: To find the ID of a role, use the [List roles](/management-api#tag/Roles/operation/listAllRolesV2) endpoint.  |  |
| **roleV2Base** | [**RoleV2Base**](RoleV2Base.md) | body |  |

### Return type

[**RoleV2**](RoleV2.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatestore"></a>
# **UpdateStore**
> Store UpdateStore (long applicationId, string storeId, NewStore newStore)

Update store

Update store details for a specific store ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **long** | The ID of the Application. It is displayed in your Talon.One deployment URL. |  |
| **storeId** | **string** | The ID of the store. You can get this ID with the [List stores](#tag/Stores/operation/listStores) endpoint.  |  |
| **newStore** | [**NewStore**](NewStore.md) | body |  |

### Return type

[**Store**](Store.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateuser"></a>
# **UpdateUser**
> User UpdateUser (long userId, UpdateUser updateUser)

Update user

Update the details of a specific user.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The ID of the user. |  |
| **updateUser** | [**UpdateUser**](UpdateUser.md) | body |  |

### Return type

[**User**](User.md)

### Authorization

[management_key](../README.md#management_key), [manager_auth](../README.md#manager_auth), [api_key_v1](../README.md#api_key_v1)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

