# TalonOne.Api.ManagementApi

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
| [**GetLoyaltyPoints**](ManagementApi.md#getloyaltypoints) | **GET** /v1/loyalty_programs/{loyaltyProgramId}/profile/{integrationId} | Get customer&#39;s full loyalty ledger |
| [**GetLoyaltyProgram**](ManagementApi.md#getloyaltyprogram) | **GET** /v1/loyalty_programs/{loyaltyProgramId} | Get loyalty program |
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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ActivateUserByEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var activateUserRequest = new ActivateUserRequest(); // ActivateUserRequest | body

            try
            {
                // Enable user by email address
                apiInstance.ActivateUserByEmail(activateUserRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ActivateUserByEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateUserByEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable user by email address
    apiInstance.ActivateUserByEmailWithHttpInfo(activateUserRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ActivateUserByEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class AddLoyaltyCardPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = "loyaltyCardId_example";  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var addLoyaltyPoints = new AddLoyaltyPoints(); // AddLoyaltyPoints | body

            try
            {
                // Add points to card
                apiInstance.AddLoyaltyCardPoints(loyaltyProgramId, loyaltyCardId, addLoyaltyPoints);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.AddLoyaltyCardPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLoyaltyCardPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add points to card
    apiInstance.AddLoyaltyCardPointsWithHttpInfo(loyaltyProgramId, loyaltyCardId, addLoyaltyPoints);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.AddLoyaltyCardPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class AddLoyaltyPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = "loyaltyProgramId_example";  // string | The identifier for the loyalty program.
            var integrationId = "integrationId_example";  // string | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier. 
            var addLoyaltyPoints = new AddLoyaltyPoints(); // AddLoyaltyPoints | body

            try
            {
                // Add points to customer profile
                apiInstance.AddLoyaltyPoints(loyaltyProgramId, integrationId, addLoyaltyPoints);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.AddLoyaltyPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLoyaltyPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add points to customer profile
    apiInstance.AddLoyaltyPointsWithHttpInfo(loyaltyProgramId, integrationId, addLoyaltyPoints);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.AddLoyaltyPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CopyCampaignToApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var campaignCopy = new CampaignCopy(); // CampaignCopy | body

            try
            {
                // Copy the campaign into the specified Application
                GetCampaigns200Response result = apiInstance.CopyCampaignToApplications(applicationId, campaignId, campaignCopy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CopyCampaignToApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopyCampaignToApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy the campaign into the specified Application
    ApiResponse<GetCampaigns200Response> response = apiInstance.CopyCampaignToApplicationsWithHttpInfo(applicationId, campaignId, campaignCopy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CopyCampaignToApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var newCollection = new NewCollection(); // NewCollection | body

            try
            {
                // Create account-level collection
                Collection result = apiInstance.CreateAccountCollection(newCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateAccountCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAccountCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create account-level collection
    ApiResponse<Collection> response = apiInstance.CreateAccountCollectionWithHttpInfo(newCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateAccountCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateAchievementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var createAchievement = new CreateAchievement(); // CreateAchievement | body

            try
            {
                // Create achievement
                Achievement result = apiInstance.CreateAchievement(applicationId, campaignId, createAchievement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateAchievement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAchievementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create achievement
    ApiResponse<Achievement> response = apiInstance.CreateAchievementWithHttpInfo(applicationId, campaignId, createAchievement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateAchievementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateAdditionalCostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var newAdditionalCost = new NewAdditionalCost(); // NewAdditionalCost | body

            try
            {
                // Create additional cost
                AccountAdditionalCost result = apiInstance.CreateAdditionalCost(newAdditionalCost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateAdditionalCost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAdditionalCostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create additional cost
    ApiResponse<AccountAdditionalCost> response = apiInstance.CreateAdditionalCostWithHttpInfo(newAdditionalCost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateAdditionalCostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var newAttribute = new NewAttribute(); // NewAttribute | body

            try
            {
                // Create custom attribute
                Attribute result = apiInstance.CreateAttribute(newAttribute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create custom attribute
    ApiResponse<Attribute> response = apiInstance.CreateAttributeWithHttpInfo(newAttribute);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateBatchLoyaltyCardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardBatch = new LoyaltyCardBatch(); // LoyaltyCardBatch | body

            try
            {
                // Create loyalty cards
                LoyaltyCardBatchResponse result = apiInstance.CreateBatchLoyaltyCards(loyaltyProgramId, loyaltyCardBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateBatchLoyaltyCards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBatchLoyaltyCardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create loyalty cards
    ApiResponse<LoyaltyCardBatchResponse> response = apiInstance.CreateBatchLoyaltyCardsWithHttpInfo(loyaltyProgramId, loyaltyCardBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateBatchLoyaltyCardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCampaignFromTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var createTemplateCampaign = new CreateTemplateCampaign(); // CreateTemplateCampaign | body

            try
            {
                // Create campaign from campaign template
                CreateTemplateCampaignResponse result = apiInstance.CreateCampaignFromTemplate(applicationId, createTemplateCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCampaignFromTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCampaignFromTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create campaign from campaign template
    ApiResponse<CreateTemplateCampaignResponse> response = apiInstance.CreateCampaignFromTemplateWithHttpInfo(applicationId, createTemplateCampaign);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateCampaignFromTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCampaignStoreBudgetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var newCampaignStoreBudget = new NewCampaignStoreBudget(); // NewCampaignStoreBudget | body

            try
            {
                // Create campaign store budget
                apiInstance.CreateCampaignStoreBudget(applicationId, campaignId, newCampaignStoreBudget);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCampaignStoreBudget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCampaignStoreBudgetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create campaign store budget
    apiInstance.CreateCampaignStoreBudgetWithHttpInfo(applicationId, campaignId, newCampaignStoreBudget);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateCampaignStoreBudgetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var newCampaignCollection = new NewCampaignCollection(); // NewCampaignCollection | body

            try
            {
                // Create campaign-level collection
                Collection result = apiInstance.CreateCollection(applicationId, campaignId, newCampaignCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create campaign-level collection
    ApiResponse<Collection> response = apiInstance.CreateCollectionWithHttpInfo(applicationId, campaignId, newCampaignCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var newCoupons = new NewCoupons(); // NewCoupons | body
            var silent = "\"yes\"";  // string | Possible values: `yes` or `no`. - `yes`: Increases the performance of the API call by returning a 204 response. - `no`: Returns a 200 response that contains the updated customer profiles.  (optional)  (default to "yes")

            try
            {
                // Create coupons
                CreateCoupons200Response result = apiInstance.CreateCoupons(applicationId, campaignId, newCoupons, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCoupons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCouponsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create coupons
    ApiResponse<CreateCoupons200Response> response = apiInstance.CreateCouponsWithHttpInfo(applicationId, campaignId, newCoupons, silent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateCouponsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var newCouponCreationJob = new NewCouponCreationJob(); // NewCouponCreationJob | body

            try
            {
                // Create coupons asynchronously
                AsyncCouponCreationResponse result = apiInstance.CreateCouponsAsync(applicationId, campaignId, newCouponCreationJob);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCouponsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCouponsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create coupons asynchronously
    ApiResponse<AsyncCouponCreationResponse> response = apiInstance.CreateCouponsAsyncWithHttpInfo(applicationId, campaignId, newCouponCreationJob);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateCouponsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponsDeletionJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var newCouponDeletionJob = new NewCouponDeletionJob(); // NewCouponDeletionJob | body

            try
            {
                // Creates a coupon deletion job
                AsyncCouponDeletionJobResponse result = apiInstance.CreateCouponsDeletionJob(applicationId, campaignId, newCouponDeletionJob);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCouponsDeletionJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCouponsDeletionJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a coupon deletion job
    ApiResponse<AsyncCouponDeletionJobResponse> response = apiInstance.CreateCouponsDeletionJobWithHttpInfo(applicationId, campaignId, newCouponDeletionJob);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateCouponsDeletionJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponsForMultipleRecipientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var newCouponsForMultipleRecipients = new NewCouponsForMultipleRecipients(); // NewCouponsForMultipleRecipients | body
            var silent = "\"yes\"";  // string | Possible values: `yes` or `no`. - `yes`: Increases the performance of the API call by returning a 204 response. - `no`: Returns a 200 response that contains the updated customer profiles.  (optional)  (default to "yes")

            try
            {
                // Create coupons for multiple recipients
                CreateCoupons200Response result = apiInstance.CreateCouponsForMultipleRecipients(applicationId, campaignId, newCouponsForMultipleRecipients, silent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCouponsForMultipleRecipients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCouponsForMultipleRecipientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create coupons for multiple recipients
    ApiResponse<CreateCoupons200Response> response = apiInstance.CreateCouponsForMultipleRecipientsWithHttpInfo(applicationId, campaignId, newCouponsForMultipleRecipients, silent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateCouponsForMultipleRecipientsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateInviteEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var newInviteEmail = new NewInviteEmail(); // NewInviteEmail | body

            try
            {
                // Resend invitation email
                NewInviteEmail result = apiInstance.CreateInviteEmail(newInviteEmail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateInviteEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInviteEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend invitation email
    ApiResponse<NewInviteEmail> response = apiInstance.CreateInviteEmailWithHttpInfo(newInviteEmail);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateInviteEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateInviteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var newInvitation = new NewInvitation(); // NewInvitation | body

            try
            {
                // Invite user
                User result = apiInstance.CreateInviteV2(newInvitation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateInviteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInviteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite user
    ApiResponse<User> response = apiInstance.CreateInviteV2WithHttpInfo(newInvitation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateInviteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreatePasswordRecoveryEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var newPasswordEmail = new NewPasswordEmail(); // NewPasswordEmail | body

            try
            {
                // Request a password reset
                NewPasswordEmail result = apiInstance.CreatePasswordRecoveryEmail(newPasswordEmail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreatePasswordRecoveryEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePasswordRecoveryEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request a password reset
    ApiResponse<NewPasswordEmail> response = apiInstance.CreatePasswordRecoveryEmailWithHttpInfo(newPasswordEmail);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreatePasswordRecoveryEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loginParams = new LoginParams(); // LoginParams | body

            try
            {
                // Create session
                Session result = apiInstance.CreateSession(loginParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create session
    ApiResponse<Session> response = apiInstance.CreateSessionWithHttpInfo(loginParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var newStore = new NewStore(); // NewStore | body

            try
            {
                // Create store
                Store result = apiInstance.CreateStore(applicationId, newStore);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateStore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateStoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create store
    ApiResponse<Store> response = apiInstance.CreateStoreWithHttpInfo(applicationId, newStore);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateStoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeactivateUserByEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var deactivateUserRequest = new DeactivateUserRequest(); // DeactivateUserRequest | body

            try
            {
                // Disable user by email address
                apiInstance.DeactivateUserByEmail(deactivateUserRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeactivateUserByEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeactivateUserByEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable user by email address
    apiInstance.DeactivateUserByEmailWithHttpInfo(deactivateUserRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeactivateUserByEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeductLoyaltyCardPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = "loyaltyCardId_example";  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var deductLoyaltyPoints = new DeductLoyaltyPoints(); // DeductLoyaltyPoints | body

            try
            {
                // Deduct points from card
                apiInstance.DeductLoyaltyCardPoints(loyaltyProgramId, loyaltyCardId, deductLoyaltyPoints);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeductLoyaltyCardPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeductLoyaltyCardPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deduct points from card
    apiInstance.DeductLoyaltyCardPointsWithHttpInfo(loyaltyProgramId, loyaltyCardId, deductLoyaltyPoints);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeductLoyaltyCardPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint.

            try
            {
                // Delete account-level collection
                apiInstance.DeleteAccountCollection(collectionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteAccountCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAccountCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete account-level collection
    apiInstance.DeleteAccountCollectionWithHttpInfo(collectionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteAccountCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteAchievementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var achievementId = 789L;  // long | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint.

            try
            {
                // Delete achievement
                apiInstance.DeleteAchievement(applicationId, campaignId, achievementId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteAchievement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAchievementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete achievement
    apiInstance.DeleteAchievementWithHttpInfo(applicationId, campaignId, achievementId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteAchievementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.

            try
            {
                // Delete campaign
                apiInstance.DeleteCampaign(applicationId, campaignId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete campaign
    apiInstance.DeleteCampaignWithHttpInfo(applicationId, campaignId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCampaignStoreBudgetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var action = "setDiscount";  // string | The action that this budget is limiting. (optional) 
            var period = "overall";  // string | The period to which the limit applies.  **Note**: For budgets with no period, set this to `overall`.  (optional) 

            try
            {
                // Delete campaign store budgets
                apiInstance.DeleteCampaignStoreBudgets(applicationId, campaignId, action, period);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCampaignStoreBudgets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCampaignStoreBudgetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete campaign store budgets
    apiInstance.DeleteCampaignStoreBudgetsWithHttpInfo(applicationId, campaignId, action, period);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteCampaignStoreBudgetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Delete campaign-level collection
                apiInstance.DeleteCollection(applicationId, campaignId, collectionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete campaign-level collection
    apiInstance.DeleteCollectionWithHttpInfo(applicationId, campaignId, collectionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var couponId = "couponId_example";  // string | The internal ID of the coupon code. You can find this value in the `id` property from the [List coupons](https://docs.talon.one/management-api#tag/Coupons/operation/getCouponsWithoutTotalCount) endpoint response. 

            try
            {
                // Delete coupon
                apiInstance.DeleteCoupon(applicationId, campaignId, couponId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCoupon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCouponWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete coupon
    apiInstance.DeleteCouponWithHttpInfo(applicationId, campaignId, couponId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteCouponWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var value = "value_example";  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var startsAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon start date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var startsBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon start date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var expiresAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon expiration date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var expiresBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon expiration date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var valid = "expired";  // string | - `expired`: Matches coupons in which the expiration date is set and in the past. - `validNow`: Matches coupons in which start date is null or in the past and expiration date is null or in the future. - `validFuture`: Matches coupons in which start date is set and in the future.  (optional) 
            var batchId = "batchId_example";  // string | Filter results by batches of coupons (optional) 
            var usable = "true";  // string | - `true`: only coupons where `usageCounter < usageLimit` will be returned. - `false`: only coupons where `usageCounter >= usageLimit` will be returned.  (optional) 
            var referralId = 789L;  // long | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = "recipientIntegrationId_example";  // string | Filter results by match with a profile ID specified in the coupon's `RecipientIntegrationId` field.  (optional) 
            var exactMatch = false;  // bool | Filter results to an exact case-insensitive matching against the coupon code (optional)  (default to false)

            try
            {
                // Delete coupons
                apiInstance.DeleteCoupons(applicationId, campaignId, value, createdBefore, createdAfter, startsAfter, startsBefore, expiresAfter, expiresBefore, valid, batchId, usable, referralId, recipientIntegrationId, exactMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCoupons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCouponsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete coupons
    apiInstance.DeleteCouponsWithHttpInfo(applicationId, campaignId, value, createdBefore, createdAfter, startsAfter, startsBefore, expiresAfter, expiresBefore, valid, batchId, usable, referralId, recipientIntegrationId, exactMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteCouponsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteLoyaltyCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = "loyaltyCardId_example";  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 

            try
            {
                // Delete loyalty card
                apiInstance.DeleteLoyaltyCard(loyaltyProgramId, loyaltyCardId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteLoyaltyCard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLoyaltyCardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete loyalty card
    apiInstance.DeleteLoyaltyCardWithHttpInfo(loyaltyProgramId, loyaltyCardId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteLoyaltyCardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteReferralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var referralId = "referralId_example";  // string | The ID of the referral code.

            try
            {
                // Delete referral
                apiInstance.DeleteReferral(applicationId, campaignId, referralId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteReferral: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReferralWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete referral
    apiInstance.DeleteReferralWithHttpInfo(applicationId, campaignId, referralId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteReferralWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var storeId = "storeId_example";  // string | The ID of the store. You can get this ID with the [List stores](#tag/Stores/operation/listStores) endpoint. 

            try
            {
                // Delete store
                apiInstance.DeleteStore(applicationId, storeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteStore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete store
    apiInstance.DeleteStoreWithHttpInfo(applicationId, storeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteStoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var userId = 789L;  // long | The ID of the user.

            try
            {
                // Delete user
                apiInstance.DeleteUser(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete user
    apiInstance.DeleteUserWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteUserByEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var deleteUserRequest = new DeleteUserRequest(); // DeleteUserRequest | body

            try
            {
                // Delete user by email address
                apiInstance.DeleteUserByEmail(deleteUserRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteUserByEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserByEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete user by email address
    apiInstance.DeleteUserByEmailWithHttpInfo(deleteUserRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteUserByEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DestroySessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // Destroy session
                apiInstance.DestroySession();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DestroySession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DestroySessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Destroy session
    apiInstance.DestroySessionWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DestroySessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DisconnectCampaignStoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.

            try
            {
                // Disconnect stores
                apiInstance.DisconnectCampaignStores(applicationId, campaignId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DisconnectCampaignStores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisconnectCampaignStoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disconnect stores
    apiInstance.DisconnectCampaignStoresWithHttpInfo(applicationId, campaignId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DisconnectCampaignStoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportAccountCollectionItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint.

            try
            {
                // Export account-level collection's items
                string result = apiInstance.ExportAccountCollectionItems(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportAccountCollectionItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportAccountCollectionItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export account-level collection's items
    ApiResponse<string> response = apiInstance.ExportAccountCollectionItemsWithHttpInfo(collectionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportAccountCollectionItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportAchievementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var achievementId = 789L;  // long | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint.

            try
            {
                // Export achievement customer data
                string result = apiInstance.ExportAchievements(applicationId, campaignId, achievementId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportAchievements: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportAchievementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export achievement customer data
    ApiResponse<string> response = apiInstance.ExportAchievementsWithHttpInfo(applicationId, campaignId, achievementId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportAchievementsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportAudiencesMembershipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var audienceId = 789L;  // long | The ID of the audience.

            try
            {
                // Export audience members
                string result = apiInstance.ExportAudiencesMemberships(audienceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportAudiencesMemberships: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportAudiencesMembershipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export audience members
    ApiResponse<string> response = apiInstance.ExportAudiencesMembershipsWithHttpInfo(audienceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportAudiencesMembershipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCampaignStoreBudgetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var action = "setDiscount";  // string | The action that this budget is limiting. (optional) 
            var period = "overall";  // string | The period to which the limit applies.  **Note**: For budgets with no period, set this to `overall`.  (optional) 

            try
            {
                // Export campaign store budgets
                string result = apiInstance.ExportCampaignStoreBudgets(applicationId, campaignId, action, period);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCampaignStoreBudgets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportCampaignStoreBudgetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export campaign store budgets
    ApiResponse<string> response = apiInstance.ExportCampaignStoreBudgetsWithHttpInfo(applicationId, campaignId, action, period);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportCampaignStoreBudgetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCampaignStoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.

            try
            {
                // Export stores
                string result = apiInstance.ExportCampaignStores(applicationId, campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCampaignStores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportCampaignStoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export stores
    ApiResponse<string> response = apiInstance.ExportCampaignStoresWithHttpInfo(applicationId, campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportCampaignStoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCollectionItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Export campaign-level collection's items
                string result = apiInstance.ExportCollectionItems(applicationId, campaignId, collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCollectionItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportCollectionItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export campaign-level collection's items
    ApiResponse<string> response = apiInstance.ExportCollectionItemsWithHttpInfo(applicationId, campaignId, collectionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportCollectionItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 8.14D;  // decimal | Filter results by campaign ID. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var value = "value_example";  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var valid = "expired";  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = "true";  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 789L;  // long | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = "recipientIntegrationId_example";  // string | Filter results by match with a profile id specified in the coupon's RecipientIntegrationId field. (optional) 
            var batchId = "batchId_example";  // string | Filter results by batches of coupons (optional) 
            var exactMatch = false;  // bool | Filter results to an exact case-insensitive matching against the coupon code. (optional)  (default to false)
            var dateFormat = "excel";  // string | Determines the format of dates in the export document. (optional) 
            var campaignState = "enabled";  // string | Filter results by the state of the campaign.  - `enabled`: Campaigns that are scheduled, running (activated), or expired. - `running`: Campaigns that are running (activated). - `disabled`: Campaigns that are disabled. - `expired`: Campaigns that are expired. - `archived`: Campaigns that are archived.  (optional) 
            var valuesOnly = false;  // bool | Filter results to only return the coupon codes (`value` column) without the associated coupon data. (optional)  (default to false)

            try
            {
                // Export coupons
                string result = apiInstance.ExportCoupons(applicationId, campaignId, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, dateFormat, campaignState, valuesOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCoupons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportCouponsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export coupons
    ApiResponse<string> response = apiInstance.ExportCouponsWithHttpInfo(applicationId, campaignId, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, dateFormat, campaignState, valuesOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportCouponsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCustomerSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. (optional) 
            var profileIntegrationId = "profileIntegrationId_example";  // string | Only return sessions for the customer that matches this customer integration ID. (optional) 
            var dateFormat = "excel";  // string | Determines the format of dates in the export document. (optional) 
            var customerSessionState = "open";  // string | Filter results by state. (optional) 

            try
            {
                // Export customer sessions
                string result = apiInstance.ExportCustomerSessions(applicationId, createdBefore, createdAfter, profileIntegrationId, dateFormat, customerSessionState);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCustomerSessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportCustomerSessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export customer sessions
    ApiResponse<string> response = apiInstance.ExportCustomerSessionsWithHttpInfo(applicationId, createdBefore, createdAfter, profileIntegrationId, dateFormat, customerSessionState);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportCustomerSessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportCustomersTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = "loyaltyProgramId_example";  // string | The identifier for the loyalty program.
            var subledgerIds = new List<string>(); // List<string> | An array of subledgers IDs to filter the export by. (optional) 
            var tierNames = new List<string>(); // List<string> | An array of tier names to filter the export by. (optional) 

            try
            {
                // Export customers' tier data
                string result = apiInstance.ExportCustomersTiers(loyaltyProgramId, subledgerIds, tierNames);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportCustomersTiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportCustomersTiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export customers' tier data
    ApiResponse<string> response = apiInstance.ExportCustomersTiersWithHttpInfo(loyaltyProgramId, subledgerIds, tierNames);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportCustomersTiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportEffectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 8.14D;  // decimal | Filter results by campaign ID. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var dateFormat = "excel";  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export triggered effects
                string result = apiInstance.ExportEffects(applicationId, campaignId, createdBefore, createdAfter, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportEffects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportEffectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export triggered effects
    ApiResponse<string> response = apiInstance.ExportEffectsWithHttpInfo(applicationId, campaignId, createdBefore, createdAfter, dateFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportEffectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = "loyaltyProgramId_example";  // string | The identifier for the loyalty program.
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Used to return expired, active, and pending loyalty balances before this timestamp. You can enter any past, present, or future timestamp value.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered.  (optional) 

            try
            {
                // Export customer loyalty balance to CSV
                string result = apiInstance.ExportLoyaltyBalance(loyaltyProgramId, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export customer loyalty balance to CSV
    ApiResponse<string> response = apiInstance.ExportLoyaltyBalanceWithHttpInfo(loyaltyProgramId, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportLoyaltyBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = "loyaltyProgramId_example";  // string | The identifier for the loyalty program.
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Used to return expired, active, and pending loyalty balances before this timestamp. You can enter any past, present, or future timestamp value.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered.  (optional) 

            try
            {
                // Export customer loyalty balances
                string result = apiInstance.ExportLoyaltyBalances(loyaltyProgramId, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyBalances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyBalancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export customer loyalty balances
    ApiResponse<string> response = apiInstance.ExportLoyaltyBalancesWithHttpInfo(loyaltyProgramId, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportLoyaltyBalancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyCardBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Used to return expired, active, and pending loyalty balances before this timestamp. You can enter any past, present, or future timestamp value.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered.  (optional) 

            try
            {
                // Export all card transaction logs
                string result = apiInstance.ExportLoyaltyCardBalances(loyaltyProgramId, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyCardBalances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyCardBalancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export all card transaction logs
    ApiResponse<string> response = apiInstance.ExportLoyaltyCardBalancesWithHttpInfo(loyaltyProgramId, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportLoyaltyCardBalancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyCardLedgerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = "loyaltyCardId_example";  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var rangeStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var rangeEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var dateFormat = "excel";  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export card's ledger log
                string result = apiInstance.ExportLoyaltyCardLedger(loyaltyProgramId, loyaltyCardId, rangeStart, rangeEnd, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyCardLedger: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyCardLedgerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export card's ledger log
    ApiResponse<string> response = apiInstance.ExportLoyaltyCardLedgerWithHttpInfo(loyaltyProgramId, loyaltyCardId, rangeStart, rangeEnd, dateFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportLoyaltyCardLedgerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyCardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var batchId = "batchId_example";  // string | Filter results by loyalty card batch ID. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return loyalty cards created before this timestamp.  **Note:** - This must be an RFC3339 timestamp string.  (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return loyalty cards created after this timestamp.  **Note:** - This must be an RFC3339 timestamp string.  (optional) 
            var dateFormat = "excel";  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export loyalty cards
                string result = apiInstance.ExportLoyaltyCards(loyaltyProgramId, batchId, createdBefore, createdAfter, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyCards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyCardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export loyalty cards
    ApiResponse<string> response = apiInstance.ExportLoyaltyCardsWithHttpInfo(loyaltyProgramId, batchId, createdBefore, createdAfter, dateFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportLoyaltyCardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportLoyaltyLedgerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var rangeStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var rangeEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var loyaltyProgramId = "loyaltyProgramId_example";  // string | The identifier for the loyalty program.
            var integrationId = "integrationId_example";  // string | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier. 
            var dateFormat = "excel";  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export customer's transaction logs
                string result = apiInstance.ExportLoyaltyLedger(rangeStart, rangeEnd, loyaltyProgramId, integrationId, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportLoyaltyLedger: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyLedgerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export customer's transaction logs
    ApiResponse<string> response = apiInstance.ExportLoyaltyLedgerWithHttpInfo(rangeStart, rangeEnd, loyaltyProgramId, integrationId, dateFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportLoyaltyLedgerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportPoolGiveawaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var poolId = 789L;  // long | The ID of the pool. You can find it in the Campaign Manager, in the **Giveaways** section.
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Timestamp that filters the results to only contain giveaways created before this date. Must be an RFC3339 timestamp string. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Timestamp that filters the results to only contain giveaways created after this date. Must be an RFC3339 timestamp string. (optional) 

            try
            {
                // Export giveaway codes of a giveaway pool
                string result = apiInstance.ExportPoolGiveaways(poolId, createdBefore, createdAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportPoolGiveaways: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportPoolGiveawaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export giveaway codes of a giveaway pool
    ApiResponse<string> response = apiInstance.ExportPoolGiveawaysWithHttpInfo(poolId, createdBefore, createdAfter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportPoolGiveawaysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ExportReferralsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 8.14D;  // decimal | Filter results by campaign ID. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var valid = "expired";  // string | - `expired`: Matches referrals in which the expiration date is set and in the past. - `validNow`: Matches referrals in which start date is null or in the past and expiration date is null or in the future. - `validFuture`: Matches referrals in which start date is set and in the future.  (optional) 
            var usable = "true";  // string | - `true`, only referrals where `usageCounter < usageLimit` will be returned. - `false`, only referrals where `usageCounter >= usageLimit` will be returned.  (optional) 
            var batchId = "batchId_example";  // string | Filter results by batches of referrals (optional) 
            var dateFormat = "excel";  // string | Determines the format of dates in the export document. (optional) 

            try
            {
                // Export referrals
                string result = apiInstance.ExportReferrals(applicationId, campaignId, createdBefore, createdAfter, valid, usable, batchId, dateFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ExportReferrals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportReferralsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export referrals
    ApiResponse<string> response = apiInstance.ExportReferralsWithHttpInfo(applicationId, campaignId, createdBefore, createdAfter, valid, usable, batchId, dateFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ExportReferralsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

<a id="getaccesslogswithouttotalcount"></a>
# **GetAccessLogsWithoutTotalCount**
> GetAccessLogsWithoutTotalCount200Response GetAccessLogsWithoutTotalCount (long applicationId, DateTime rangeStart, DateTime rangeEnd, string path = null, string method = null, string status = null, long pageSize = null, long skip = null, string sort = null)

Get access logs for Application

Retrieve the list of API calls sent to the specified Application. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccessLogsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var rangeStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var rangeEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var path = "path_example";  // string | Only return results where the request path matches the given regular expression. (optional) 
            var method = "get";  // string | Only return results where the request method matches the given regular expression. (optional) 
            var status = "success";  // string | Filter results by HTTP status codes. (optional) 
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // Get access logs for Application
                GetAccessLogsWithoutTotalCount200Response result = apiInstance.GetAccessLogsWithoutTotalCount(applicationId, rangeStart, rangeEnd, path, method, status, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccessLogsWithoutTotalCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccessLogsWithoutTotalCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get access logs for Application
    ApiResponse<GetAccessLogsWithoutTotalCount200Response> response = apiInstance.GetAccessLogsWithoutTotalCountWithHttpInfo(applicationId, rangeStart, rangeEnd, path, method, status, pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAccessLogsWithoutTotalCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var accountId = 789L;  // long | The identifier of the account. Retrieve it via the [List users in account](https://docs.talon.one/management-api#operation/getUsers) endpoint in the `accountId` property. 

            try
            {
                // Get account details
                Account result = apiInstance.GetAccount(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account details
    ApiResponse<Account> response = apiInstance.GetAccountWithHttpInfo(accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccountAnalyticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var accountId = 789L;  // long | The identifier of the account. Retrieve it via the [List users in account](https://docs.talon.one/management-api#operation/getUsers) endpoint in the `accountId` property. 

            try
            {
                // Get account analytics
                AccountAnalytics result = apiInstance.GetAccountAnalytics(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccountAnalytics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountAnalyticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account analytics
    ApiResponse<AccountAnalytics> response = apiInstance.GetAccountAnalyticsWithHttpInfo(accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAccountAnalyticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint.

            try
            {
                // Get account-level collection
                Collection result = apiInstance.GetAccountCollection(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAccountCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account-level collection
    ApiResponse<Collection> response = apiInstance.GetAccountCollectionWithHttpInfo(collectionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAccountCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAchievementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var achievementId = 789L;  // long | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint.

            try
            {
                // Get achievement
                Achievement result = apiInstance.GetAchievement(applicationId, campaignId, achievementId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAchievement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAchievementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get achievement
    ApiResponse<Achievement> response = apiInstance.GetAchievementWithHttpInfo(applicationId, campaignId, achievementId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAchievementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAdditionalCostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var additionalCostId = 789L;  // long | The ID of the additional cost. You can find the ID the the Campaign Manager's URL when you display the details of the cost in **Account** > **Tools** > **Additional costs**. 

            try
            {
                // Get additional cost
                AccountAdditionalCost result = apiInstance.GetAdditionalCost(additionalCostId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAdditionalCost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdditionalCostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get additional cost
    ApiResponse<AccountAdditionalCost> response = apiInstance.GetAdditionalCostWithHttpInfo(additionalCostId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAdditionalCostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAdditionalCostsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // List additional costs
                GetAdditionalCosts200Response result = apiInstance.GetAdditionalCosts(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAdditionalCosts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdditionalCostsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List additional costs
    ApiResponse<GetAdditionalCosts200Response> response = apiInstance.GetAdditionalCostsWithHttpInfo(pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAdditionalCostsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.

            try
            {
                // Get Application
                Application result = apiInstance.GetApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Application
    ApiResponse<Application> response = apiInstance.GetApplicationWithHttpInfo(applicationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationApiHealthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.

            try
            {
                // Get Application health
                ApplicationApiHealth result = apiInstance.GetApplicationApiHealth(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationApiHealth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationApiHealthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Application health
    ApiResponse<ApplicationApiHealth> response = apiInstance.GetApplicationApiHealthWithHttpInfo(applicationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationApiHealthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationCustomerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var customerId = 789L;  // long | The value of the `id` property of a customer profile. Get it with the [List Application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 

            try
            {
                // Get application's customer
                ApplicationCustomer result = apiInstance.GetApplicationCustomer(applicationId, customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get application's customer
    ApiResponse<ApplicationCustomer> response = apiInstance.GetApplicationCustomerWithHttpInfo(applicationId, customerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationCustomerFriendsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var integrationId = "integrationId_example";  // string | The Integration ID of the Advocate's Profile.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 

            try
            {
                // List friends referred by customer profile
                GetApplicationCustomerFriends200Response result = apiInstance.GetApplicationCustomerFriends(applicationId, integrationId, pageSize, skip, sort, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationCustomerFriends: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationCustomerFriendsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List friends referred by customer profile
    ApiResponse<GetApplicationCustomerFriends200Response> response = apiInstance.GetApplicationCustomerFriendsWithHttpInfo(applicationId, integrationId, pageSize, skip, sort, withTotalResultSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationCustomerFriendsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationCustomersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var integrationId = "integrationId_example";  // string | Filter results performing an exact matching against the profile integration identifier. (optional) 
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 

            try
            {
                // List application's customers
                GetApplicationCustomers200Response result = apiInstance.GetApplicationCustomers(applicationId, integrationId, pageSize, skip, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationCustomers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationCustomersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List application's customers
    ApiResponse<GetApplicationCustomers200Response> response = apiInstance.GetApplicationCustomersWithHttpInfo(applicationId, integrationId, pageSize, skip, withTotalResultSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationCustomersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationCustomersByAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var customerProfileSearchQuery = new CustomerProfileSearchQuery(); // CustomerProfileSearchQuery | body
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 

            try
            {
                // List application customers matching the given attributes
                GetApplicationCustomersByAttributes200Response result = apiInstance.GetApplicationCustomersByAttributes(applicationId, customerProfileSearchQuery, pageSize, skip, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationCustomersByAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationCustomersByAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List application customers matching the given attributes
    ApiResponse<GetApplicationCustomersByAttributes200Response> response = apiInstance.GetApplicationCustomersByAttributesWithHttpInfo(applicationId, customerProfileSearchQuery, pageSize, skip, withTotalResultSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationCustomersByAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationEventTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // List Applications event types
                GetApplicationEventTypes200Response result = apiInstance.GetApplicationEventTypes(applicationId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationEventTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationEventTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Applications event types
    ApiResponse<GetApplicationEventTypes200Response> response = apiInstance.GetApplicationEventTypesWithHttpInfo(applicationId, pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationEventTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationEventsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var type = "type_example";  // string | Comma-separated list of types by which to filter events. Must be exact match(es). (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return events created before this date. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return events created after this date. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var session = "session_example";  // string | Session integration ID filter for events. Must be exact match. (optional) 
            var profile = "profile_example";  // string | Profile integration ID filter for events. Must be exact match. (optional) 
            var customerName = "customerName_example";  // string | Customer name filter for events. Will match substrings case-insensitively. (optional) 
            var customerEmail = "customerEmail_example";  // string | Customer e-mail address filter for events. Will match substrings case-insensitively. (optional) 
            var couponCode = "couponCode_example";  // string | Coupon code (optional) 
            var referralCode = "referralCode_example";  // string | Referral code (optional) 
            var ruleQuery = "ruleQuery_example";  // string | Rule name filter for events (optional) 
            var campaignQuery = "campaignQuery_example";  // string | Campaign name filter for events (optional) 
            var effectType = "effectType_example";  // string | The type of effect that was triggered. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects). (optional) 

            try
            {
                // List Applications events
                GetApplicationEventsWithoutTotalCount200Response result = apiInstance.GetApplicationEventsWithoutTotalCount(applicationId, pageSize, skip, sort, type, createdBefore, createdAfter, session, profile, customerName, customerEmail, couponCode, referralCode, ruleQuery, campaignQuery, effectType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationEventsWithoutTotalCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationEventsWithoutTotalCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Applications events
    ApiResponse<GetApplicationEventsWithoutTotalCount200Response> response = apiInstance.GetApplicationEventsWithoutTotalCountWithHttpInfo(applicationId, pageSize, skip, sort, type, createdBefore, createdAfter, session, profile, customerName, customerEmail, couponCode, referralCode, ruleQuery, campaignQuery, effectType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationEventsWithoutTotalCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var sessionId = 789L;  // long | The **internal** ID of the session. You can get the ID with the [List Application sessions](https://docs.talon.one/management-api#tag/Customer-data/operation/getApplicationSessions) endpoint. 

            try
            {
                // Get Application session
                ApplicationSession result = apiInstance.GetApplicationSession(applicationId, sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Application session
    ApiResponse<ApplicationSession> response = apiInstance.GetApplicationSessionWithHttpInfo(applicationId, sessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var profile = "profile_example";  // string | Profile integration ID filter for sessions. Must be exact match. (optional) 
            var state = "open";  // string | Filter by sessions with this state. Must be exact match. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return events created before this date. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return events created after this date. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var coupon = "coupon_example";  // string | Filter by sessions with this coupon. Must be exact match. (optional) 
            var referral = "referral_example";  // string | Filter by sessions with this referral. Must be exact match. (optional) 
            var integrationId = "integrationId_example";  // string | Filter by sessions with this integration ID. Must be exact match. (optional) 
            var storeIntegrationId = "storeIntegrationId_example";  // string | The integration ID of the store. You choose this ID when you create a store. (optional) 

            try
            {
                // List Application sessions
                GetApplicationSessions200Response result = apiInstance.GetApplicationSessions(applicationId, pageSize, skip, sort, profile, state, createdBefore, createdAfter, coupon, referral, integrationId, storeIntegrationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplicationSessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationSessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Application sessions
    ApiResponse<GetApplicationSessions200Response> response = apiInstance.GetApplicationSessionsWithHttpInfo(applicationId, pageSize, skip, sort, profile, state, createdBefore, createdAfter, coupon, referral, integrationId, storeIntegrationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationSessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // List Applications
                GetApplications200Response result = apiInstance.GetApplications(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Applications
    ApiResponse<GetApplications200Response> response = apiInstance.GetApplicationsWithHttpInfo(pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var attributeId = 789L;  // long | The ID of the attribute. You can find the ID in the Campaign Manager's URL when you display the details of an attribute in **Account** > **Tools** > **Attributes**.

            try
            {
                // Get custom attribute
                Attribute result = apiInstance.GetAttribute(attributeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get custom attribute
    ApiResponse<Attribute> response = apiInstance.GetAttributeWithHttpInfo(attributeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var entity = "entity_example";  // string | Returned attributes will be filtered by supplied entity. (optional) 
            var applicationIds = "applicationIds_example";  // string | Returned attributes will be filtered by supplied application ids (optional) 
            var type = "type_example";  // string | Returned attributes will be filtered by supplied type (optional) 
            var kind = "builtin";  // string | Returned attributes will be filtered by supplied kind (builtin or custom) (optional) 
            var search = "search_example";  // string | Returned attributes will be filtered by searching case insensitive through Attribute name, description and type (optional) 

            try
            {
                // List custom attributes
                GetAttributes200Response result = apiInstance.GetAttributes(pageSize, skip, sort, entity, applicationIds, type, kind, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List custom attributes
    ApiResponse<GetAttributes200Response> response = apiInstance.GetAttributesWithHttpInfo(pageSize, skip, sort, entity, applicationIds, type, kind, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAudienceMembershipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var audienceId = 789L;  // long | The ID of the audience.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var profileQuery = "profileQuery_example";  // string | The filter to select a profile. (optional) 

            try
            {
                // List audience members
                GetAudienceMemberships200Response result = apiInstance.GetAudienceMemberships(audienceId, pageSize, skip, sort, profileQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAudienceMemberships: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAudienceMembershipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List audience members
    ApiResponse<GetAudienceMemberships200Response> response = apiInstance.GetAudienceMembershipsWithHttpInfo(audienceId, pageSize, skip, sort, profileQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAudienceMembershipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAudiencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 

            try
            {
                // List audiences
                GetAudiences200Response result = apiInstance.GetAudiences(pageSize, skip, sort, withTotalResultSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAudiences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAudiencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List audiences
    ApiResponse<GetAudiences200Response> response = apiInstance.GetAudiencesWithHttpInfo(pageSize, skip, sort, withTotalResultSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAudiencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetAudiencesAnalyticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var audienceIds = "audienceIds_example";  // string | The IDs of one or more audiences, separated by commas, by which to filter results.
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // List audience analytics
                GetAudiencesAnalytics200Response result = apiInstance.GetAudiencesAnalytics(audienceIds, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetAudiencesAnalytics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAudiencesAnalyticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List audience analytics
    ApiResponse<GetAudiencesAnalytics200Response> response = apiInstance.GetAudiencesAnalyticsWithHttpInfo(audienceIds, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetAudiencesAnalyticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.

            try
            {
                // Get campaign
                Campaign result = apiInstance.GetCampaign(applicationId, campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get campaign
    ApiResponse<Campaign> response = apiInstance.GetCampaignWithHttpInfo(applicationId, campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignAnalyticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var rangeStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var rangeEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var granularity = "1 hour";  // string | The time interval between the results in the returned time-series. (optional) 

            try
            {
                // Get analytics of campaigns
                GetCampaignAnalytics200Response result = apiInstance.GetCampaignAnalytics(applicationId, campaignId, rangeStart, rangeEnd, granularity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaignAnalytics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignAnalyticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get analytics of campaigns
    ApiResponse<GetCampaignAnalytics200Response> response = apiInstance.GetCampaignAnalyticsWithHttpInfo(applicationId, campaignId, rangeStart, rangeEnd, granularity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCampaignAnalyticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignByAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignSearch = new CampaignSearch(); // CampaignSearch | body
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var campaignState = "enabled";  // string | Filter results by the state of the campaign.  - `enabled`: Campaigns that are scheduled, running (activated), or expired. - `running`: Campaigns that are running (activated). - `disabled`: Campaigns that are disabled. - `expired`: Campaigns that are expired. - `archived`: Campaigns that are archived.  (optional) 

            try
            {
                // List campaigns that match the given attributes
                GetCampaigns200Response result = apiInstance.GetCampaignByAttributes(applicationId, campaignSearch, pageSize, skip, sort, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaignByAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignByAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List campaigns that match the given attributes
    ApiResponse<GetCampaigns200Response> response = apiInstance.GetCampaignByAttributesWithHttpInfo(applicationId, campaignSearch, pageSize, skip, sort, campaignState);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCampaignByAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var campaignGroupId = 789L;  // long | The ID of the campaign access group.

            try
            {
                // Get campaign access group
                CampaignGroup result = apiInstance.GetCampaignGroup(campaignGroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaignGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get campaign access group
    ApiResponse<CampaignGroup> response = apiInstance.GetCampaignGroupWithHttpInfo(campaignGroupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCampaignGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // List campaign access groups
                GetCampaignGroups200Response result = apiInstance.GetCampaignGroups(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaignGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List campaign access groups
    ApiResponse<GetCampaignGroups200Response> response = apiInstance.GetCampaignGroupsWithHttpInfo(pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCampaignGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var state = "draft";  // string | Filter results by the state of the campaign template. (optional) 
            var name = "name_example";  // string | Filter results performing case-insensitive matching against the name of the campaign template. (optional) 
            var tags = "tags_example";  // string | Filter results performing case-insensitive matching against the tags of the campaign template. When used in conjunction with the \"name\" query parameter, a logical OR will be performed to search both tags and name for the provided values.  (optional) 
            var userId = 789L;  // long | Filter results by user ID. (optional) 

            try
            {
                // List campaign templates
                GetCampaignTemplates200Response result = apiInstance.GetCampaignTemplates(pageSize, skip, sort, state, name, tags, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaignTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List campaign templates
    ApiResponse<GetCampaignTemplates200Response> response = apiInstance.GetCampaignTemplatesWithHttpInfo(pageSize, skip, sort, state, name, tags, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCampaignTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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
> GetCampaigns200Response GetCampaigns (long applicationId, long pageSize = null, long skip = null, string sort = null, string campaignState = null, string name = null, string tags = null, DateTime createdBefore = null, DateTime createdAfter = null, long campaignGroupId = null, long templateId = null, long storeId = null)

List campaigns

List the campaigns of the specified application that match your filter criteria. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var campaignState = "enabled";  // string | Filter results by the state of the campaign.  - `enabled`: Campaigns that are scheduled, running (activated), or expired. - `running`: Campaigns that are running (activated). - `disabled`: Campaigns that are disabled. - `expired`: Campaigns that are expired. - `archived`: Campaigns that are archived.  (optional) 
            var name = "name_example";  // string | Filter results performing case-insensitive matching against the name of the campaign. (optional) 
            var tags = "tags_example";  // string | Filter results performing case-insensitive matching against the tags of the campaign. When used in conjunction with the \"name\" query parameter, a logical OR will be performed to search both tags and name for the provided values  (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the campaign creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var campaignGroupId = 789L;  // long | Filter results to campaigns owned by the specified campaign access group ID. (optional) 
            var templateId = 789L;  // long | The ID of the campaign template this campaign was created from. (optional) 
            var storeId = 789L;  // long | Filter results to campaigns linked to the specified store ID. (optional) 

            try
            {
                // List campaigns
                GetCampaigns200Response result = apiInstance.GetCampaigns(applicationId, pageSize, skip, sort, campaignState, name, tags, createdBefore, createdAfter, campaignGroupId, templateId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List campaigns
    ApiResponse<GetCampaigns200Response> response = apiInstance.GetCampaignsWithHttpInfo(applicationId, pageSize, skip, sort, campaignState, name, tags, createdBefore, createdAfter, campaignGroupId, templateId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetChangesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var applicationId = 8.14D;  // decimal | Filter results by Application ID. (optional) 
            var entityPath = "entityPath_example";  // string | Filter results on a case insensitive matching of the url path of the entity (optional) 
            var userId = 789L;  // long | Filter results by user ID. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the change creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var managementKeyId = 789L;  // long | Filter results that match the given management key ID. (optional) 
            var includeOld = true;  // bool | When this flag is set to false, the state without the change will not be returned. The default value is true. (optional) 

            try
            {
                // Get audit logs for an account
                GetChanges200Response result = apiInstance.GetChanges(pageSize, skip, sort, applicationId, entityPath, userId, createdBefore, createdAfter, withTotalResultSize, managementKeyId, includeOld);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetChanges: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChangesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get audit logs for an account
    ApiResponse<GetChanges200Response> response = apiInstance.GetChangesWithHttpInfo(pageSize, skip, sort, applicationId, entityPath, userId, createdBefore, createdAfter, withTotalResultSize, managementKeyId, includeOld);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetChangesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint.

            try
            {
                // Get campaign-level collection
                Collection result = apiInstance.GetCollection(applicationId, campaignId, collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get campaign-level collection
    ApiResponse<Collection> response = apiInstance.GetCollectionWithHttpInfo(applicationId, campaignId, collectionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCollectionItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 

            try
            {
                // Get collection items
                GetCollectionItems200Response result = apiInstance.GetCollectionItems(collectionId, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCollectionItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCollectionItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get collection items
    ApiResponse<GetCollectionItems200Response> response = apiInstance.GetCollectionItemsWithHttpInfo(collectionId, pageSize, skip);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCollectionItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCouponsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var value = "value_example";  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var valid = "expired";  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = "true";  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var redeemed = "true";  // string | - `true`: only coupons where `usageCounter > 0` will be returned. - `false`: only coupons where `usageCounter = 0` will be returned. - This field cannot be used in conjunction with the `usable` query parameter.  (optional) 
            var referralId = 789L;  // long | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = "recipientIntegrationId_example";  // string | Filter results by match with a profile ID specified in the coupon's RecipientIntegrationId field. (optional) 
            var batchId = "batchId_example";  // string | Filter results by batches of coupons (optional) 
            var exactMatch = false;  // bool | Filter results to an exact case-insensitive matching against the coupon code. (optional)  (default to false)
            var expiresBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon expiration date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var expiresAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon expiration date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var startsBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon start date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var startsAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon start date timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var valuesOnly = false;  // bool | Filter results to only return the coupon codes (`value` column) without the associated coupon data. (optional)  (default to false)

            try
            {
                // List coupons
                GetCouponsWithoutTotalCount200Response result = apiInstance.GetCouponsWithoutTotalCount(applicationId, campaignId, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, redeemed, referralId, recipientIntegrationId, batchId, exactMatch, expiresBefore, expiresAfter, startsBefore, startsAfter, valuesOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCouponsWithoutTotalCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCouponsWithoutTotalCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List coupons
    ApiResponse<GetCouponsWithoutTotalCount200Response> response = apiInstance.GetCouponsWithoutTotalCountWithHttpInfo(applicationId, campaignId, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, redeemed, referralId, recipientIntegrationId, batchId, exactMatch, expiresBefore, expiresAfter, startsBefore, startsAfter, valuesOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCouponsWithoutTotalCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerActivityReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var rangeStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var rangeEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var customerId = 789L;  // long | The value of the `id` property of a customer profile. Get it with the [List Application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 

            try
            {
                // Get customer's activity report
                CustomerActivityReport result = apiInstance.GetCustomerActivityReport(rangeStart, rangeEnd, applicationId, customerId, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerActivityReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerActivityReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get customer's activity report
    ApiResponse<CustomerActivityReport> response = apiInstance.GetCustomerActivityReportWithHttpInfo(rangeStart, rangeEnd, applicationId, customerId, pageSize, skip);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCustomerActivityReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerActivityReportsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var rangeStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var rangeEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var name = "name_example";  // string | Only return reports matching the customer name. (optional) 
            var integrationId = "integrationId_example";  // string | Filter results performing an exact matching against the profile integration identifier. (optional) 
            var campaignName = "campaignName_example";  // string | Only return reports matching the campaign name. (optional) 
            var advocateName = "advocateName_example";  // string | Only return reports matching the current customer referrer name. (optional) 

            try
            {
                // Get Activity Reports for Application Customers
                GetCustomerActivityReportsWithoutTotalCount200Response result = apiInstance.GetCustomerActivityReportsWithoutTotalCount(rangeStart, rangeEnd, applicationId, pageSize, skip, sort, name, integrationId, campaignName, advocateName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerActivityReportsWithoutTotalCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerActivityReportsWithoutTotalCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Activity Reports for Application Customers
    ApiResponse<GetCustomerActivityReportsWithoutTotalCount200Response> response = apiInstance.GetCustomerActivityReportsWithoutTotalCountWithHttpInfo(rangeStart, rangeEnd, applicationId, pageSize, skip, sort, name, integrationId, campaignName, advocateName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCustomerActivityReportsWithoutTotalCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerAnalyticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var customerId = 789L;  // long | The value of the `id` property of a customer profile. Get it with the [List Application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // Get customer's analytics report
                CustomerAnalytics result = apiInstance.GetCustomerAnalytics(applicationId, customerId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerAnalytics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerAnalyticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get customer's analytics report
    ApiResponse<CustomerAnalytics> response = apiInstance.GetCustomerAnalyticsWithHttpInfo(applicationId, customerId, pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCustomerAnalyticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var customerId = 789L;  // long | The value of the `id` property of a customer profile. Get it with the [List Application's customers](https://docs.talon.one/management-api#operation/getApplicationCustomers) endpoint. 

            try
            {
                // Get customer profile
                CustomerProfile result = apiInstance.GetCustomerProfile(customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get customer profile
    ApiResponse<CustomerProfile> response = apiInstance.GetCustomerProfileWithHttpInfo(customerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCustomerProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerProfileAchievementProgressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var integrationId = "integrationId_example";  // string | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier. 
            var pageSize = 50L;  // long | The number of items in the response. (optional)  (default to 50)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var achievementId = 789L;  // long | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint. (optional) 
            var title = "title_example";  // string | Filter results by the `title` of an achievement. (optional) 

            try
            {
                // List customer achievements
                GetCustomerProfileAchievementProgress200Response result = apiInstance.GetCustomerProfileAchievementProgress(applicationId, integrationId, pageSize, skip, achievementId, title);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerProfileAchievementProgress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerProfileAchievementProgressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List customer achievements
    ApiResponse<GetCustomerProfileAchievementProgress200Response> response = apiInstance.GetCustomerProfileAchievementProgressWithHttpInfo(applicationId, integrationId, pageSize, skip, achievementId, title);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCustomerProfileAchievementProgressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomerProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sandbox = false;  // bool | Indicates whether you are pointing to a sandbox or live customer. (optional)  (default to false)

            try
            {
                // List customer profiles
                GetCustomerProfiles200Response result = apiInstance.GetCustomerProfiles(pageSize, skip, sandbox);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomerProfiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerProfilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List customer profiles
    ApiResponse<GetCustomerProfiles200Response> response = apiInstance.GetCustomerProfilesWithHttpInfo(pageSize, skip, sandbox);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCustomerProfilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetCustomersByAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var customerProfileSearchQuery = new CustomerProfileSearchQuery(); // CustomerProfileSearchQuery | body
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sandbox = false;  // bool | Indicates whether you are pointing to a sandbox or live customer. (optional)  (default to false)

            try
            {
                // List customer profiles matching the given attributes
                GetCustomersByAttributes200Response result = apiInstance.GetCustomersByAttributes(customerProfileSearchQuery, pageSize, skip, sandbox);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomersByAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomersByAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List customer profiles matching the given attributes
    ApiResponse<GetCustomersByAttributes200Response> response = apiInstance.GetCustomersByAttributesWithHttpInfo(customerProfileSearchQuery, pageSize, skip, sandbox);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCustomersByAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetDashboardStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var rangeStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from after this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var rangeEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Only return results from before this timestamp.  **Note:** - This must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered. 
            var subledgerId = "subledgerId_example";  // string | The ID of the subledger by which we filter the data. (optional) 

            try
            {
                // Get statistics for loyalty dashboard
                GetDashboardStatistics200Response result = apiInstance.GetDashboardStatistics(loyaltyProgramId, rangeStart, rangeEnd, subledgerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetDashboardStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDashboardStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get statistics for loyalty dashboard
    ApiResponse<GetDashboardStatistics200Response> response = apiInstance.GetDashboardStatisticsWithHttpInfo(loyaltyProgramId, rangeStart, rangeEnd, subledgerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetDashboardStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetEventTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var name = "name_example";  // string | Filter results to event types with the given name. This parameter implies `includeOldVersions`. (optional) 
            var includeOldVersions = false;  // bool | Include all versions of every event type. (optional)  (default to false)
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // List event types
                GetEventTypes200Response result = apiInstance.GetEventTypes(name, includeOldVersions, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetEventTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List event types
    ApiResponse<GetEventTypes200Response> response = apiInstance.GetEventTypesWithHttpInfo(name, includeOldVersions, pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetEventTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetExportsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var applicationId = 8.14D;  // decimal | Filter results by Application ID. (optional) 
            var campaignId = 789L;  // long | Filter by the campaign ID on which the limit counters are used. (optional) 
            var entity = "Coupon";  // string | The name of the entity type that was exported. (optional) 

            try
            {
                // Get exports
                GetExports200Response result = apiInstance.GetExports(pageSize, skip, applicationId, campaignId, entity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetExports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get exports
    ApiResponse<GetExports200Response> response = apiInstance.GetExportsWithHttpInfo(pageSize, skip, applicationId, campaignId, entity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetExportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = "loyaltyCardId_example";  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 

            try
            {
                // Get loyalty card
                LoyaltyCard result = apiInstance.GetLoyaltyCard(loyaltyProgramId, loyaltyCardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyCard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyCardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get loyalty card
    ApiResponse<LoyaltyCard> response = apiInstance.GetLoyaltyCardWithHttpInfo(loyaltyProgramId, loyaltyCardId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetLoyaltyCardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyCardTransactionLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = "loyaltyCardId_example";  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered.  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered.  (optional) 
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var subledgerId = "subledgerId_example";  // string | The ID of the subledger by which we filter the data. (optional) 
            var customerSessionIDs = new List<string>(); // List<string> | Filter the results by a list of customer session IDs.   To include multiple IDs, repeat the parameter for each one, for example,  `?customerSessionIDs=id1&customerSessionIDs=id2`.  The response contains only data associated with the specified sessions.  (optional) 
            var transactionUUIDs = new List<string>(); // List<string> | Filter the results by a list of transaction UUIDs.  To include multiple IDs, repeat the parameter for each one, for example,  `?transactionUUIDs=uuid1&transactionUUIDs=uuid2`.  The response contains only data associated with the specified transactions.  (optional) 

            try
            {
                // List card's transactions
                GetLoyaltyCardTransactionLogs200Response result = apiInstance.GetLoyaltyCardTransactionLogs(loyaltyProgramId, loyaltyCardId, startDate, endDate, pageSize, skip, subledgerId, customerSessionIDs, transactionUUIDs);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyCardTransactionLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyCardTransactionLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List card's transactions
    ApiResponse<GetLoyaltyCardTransactionLogs200Response> response = apiInstance.GetLoyaltyCardTransactionLogsWithHttpInfo(loyaltyProgramId, loyaltyCardId, startDate, endDate, pageSize, skip, subledgerId, customerSessionIDs, transactionUUIDs);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetLoyaltyCardTransactionLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyCardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var identifier = "identifier_example";  // string | The card code by which to filter loyalty cards in the response. (optional) 
            var profileId = 789L;  // long | Filter results by customer profile ID. (optional) 
            var batchId = "batchId_example";  // string | Filter results by loyalty card batch ID. (optional) 

            try
            {
                // List loyalty cards
                GetLoyaltyCards200Response result = apiInstance.GetLoyaltyCards(loyaltyProgramId, pageSize, skip, sort, identifier, profileId, batchId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyCards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyCardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List loyalty cards
    ApiResponse<GetLoyaltyCards200Response> response = apiInstance.GetLoyaltyCardsWithHttpInfo(loyaltyProgramId, pageSize, skip, sort, identifier, profileId, batchId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetLoyaltyCardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

<a id="getloyaltypoints"></a>
# **GetLoyaltyPoints**
> LoyaltyLedger GetLoyaltyPoints (string loyaltyProgramId, string integrationId)

Get customer's full loyalty ledger

Get the loyalty ledger for this profile integration ID.  To get the `integrationId` of the profile from a `sessionId`, use the [Update customer session](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint.  **Important:** To get loyalty transaction logs for a given Integration ID in a loyalty program, we recommend using the Integration API's [Get customer's loyalty logs](https://docs.talon.one/integration-api#tag/Loyalty/operation/getLoyaltyProgramProfileTransactions). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = "loyaltyProgramId_example";  // string | The identifier for the loyalty program.
            var integrationId = "integrationId_example";  // string | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier. 

            try
            {
                // Get customer's full loyalty ledger
                LoyaltyLedger result = apiInstance.GetLoyaltyPoints(loyaltyProgramId, integrationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get customer's full loyalty ledger
    ApiResponse<LoyaltyLedger> response = apiInstance.GetLoyaltyPointsWithHttpInfo(loyaltyProgramId, integrationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetLoyaltyPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyProgramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 

            try
            {
                // Get loyalty program
                LoyaltyProgram result = apiInstance.GetLoyaltyProgram(loyaltyProgramId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyProgram: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyProgramWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get loyalty program
    ApiResponse<LoyaltyProgram> response = apiInstance.GetLoyaltyProgramWithHttpInfo(loyaltyProgramId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetLoyaltyProgramWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

<a id="getloyaltyprogramtransactions"></a>
# **GetLoyaltyProgramTransactions**
> GetLoyaltyProgramTransactions200Response GetLoyaltyProgramTransactions (long loyaltyProgramId, string loyaltyTransactionType = null, string subledgerId = null, List<string> customerSessionIDs = null, List<string> transactionUUIDs = null, DateTime startDate = null, DateTime endDate = null, long pageSize = null, long skip = null)

List loyalty program transactions

Retrieve loyalty program transaction logs in a given loyalty program with filtering options applied. Manual and imported transactions are also included. **Note:** If no filters are applied, the last 50 loyalty transactions for the given loyalty program are returned.  **Important:** To get loyalty transaction logs for a given Integration ID in a loyalty program, we recommend using the Integration API's [Get customer's loyalty logs](https://docs.talon.one/integration-api#tag/Loyalty/operation/getLoyaltyProgramProfileTransactions). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyProgramTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyTransactionType = "manual";  // string | Filter results by loyalty transaction type: - `manual`: Loyalty transaction that was done manually. - `session`: Loyalty transaction that resulted from a customer session. - `import`: Loyalty transaction that was imported from a CSV file.  (optional) 
            var subledgerId = "subledgerId_example";  // string | The ID of the subledger by which we filter the data. (optional) 
            var customerSessionIDs = new List<string>(); // List<string> | Filter the results by a list of customer session IDs.   To include multiple IDs, repeat the parameter for each one, for example,  `?customerSessionIDs=id1&customerSessionIDs=id2`.  The response contains only data associated with the specified sessions.  (optional) 
            var transactionUUIDs = new List<string>(); // List<string> | Filter the results by a list of transaction UUIDs.  To include multiple IDs, repeat the parameter for each one, for example,  `?transactionUUIDs=uuid1&transactionUUIDs=uuid2`.  The response contains only data associated with the specified transactions.  (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Date and time from which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered.  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Date and time by which results are returned. Results are filtered by transaction creation date.  **Note:**  - It must be an RFC3339 timestamp string. - You can include a time component in your string, for example, `T23:59:59` to specify the end of the day. The time zone setting considered is `UTC`. If you do not include a time component, a default time value of `T00:00:00` (midnight) in `UTC` is considered.  (optional) 
            var pageSize = 50L;  // long | The number of items in the response. (optional)  (default to 50)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 

            try
            {
                // List loyalty program transactions
                GetLoyaltyProgramTransactions200Response result = apiInstance.GetLoyaltyProgramTransactions(loyaltyProgramId, loyaltyTransactionType, subledgerId, customerSessionIDs, transactionUUIDs, startDate, endDate, pageSize, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyProgramTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyProgramTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List loyalty program transactions
    ApiResponse<GetLoyaltyProgramTransactions200Response> response = apiInstance.GetLoyaltyProgramTransactionsWithHttpInfo(loyaltyProgramId, loyaltyTransactionType, subledgerId, customerSessionIDs, transactionUUIDs, startDate, endDate, pageSize, skip);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetLoyaltyProgramTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyProgramsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List loyalty programs
                GetLoyaltyPrograms200Response result = apiInstance.GetLoyaltyPrograms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyPrograms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyProgramsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List loyalty programs
    ApiResponse<GetLoyaltyPrograms200Response> response = apiInstance.GetLoyaltyProgramsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetLoyaltyProgramsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetLoyaltyStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 

            try
            {
                // Get loyalty program statistics
                LoyaltyDashboardData result = apiInstance.GetLoyaltyStatistics(loyaltyProgramId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetLoyaltyStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get loyalty program statistics
    ApiResponse<LoyaltyDashboardData> response = apiInstance.GetLoyaltyStatisticsWithHttpInfo(loyaltyProgramId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetLoyaltyStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetMessageLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var entityType = "application";  // string | The entity type the log is related to. 
            var messageID = "messageID_example";  // string | Filter results by message ID. (optional) 
            var changeType = "CampaignEvaluationTreeChanged";  // string | Filter results by change type. (optional) 
            var notificationIDs = "notificationIDs_example";  // string | Filter results by notification ID (include up to 30 values, separated by a comma). (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results where request and response times to return entries before parameter value, expected to be an RFC3339 timestamp string. Use UTC time. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results where request and response times to return entries after parameter value, expected to be an RFC3339 timestamp string. Use UTC time. (optional) 
            var cursor = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | A specific unique value in the database. If this value is not given, the server fetches results starting with the first record.  (optional) 
            var period = "15m";  // string | Filter results by time period. Choose between the available relative time frames.  (optional) 
            var isSuccessful = true;  // bool | Indicates whether to return log entries with either successful or unsuccessful HTTP response codes. When set to`true`, only log entries with `2xx` response codes are returned. When set to `false`, only log entries with `4xx` and `5xx` response codes are returned.  (optional) 
            var applicationId = 8.14D;  // decimal | Filter results by Application ID. (optional) 
            var campaignId = 8.14D;  // decimal | Filter results by campaign ID. (optional) 
            var loyaltyProgramId = 789L;  // long | Identifier of the loyalty program. (optional) 
            var responseCode = 789L;  // long | Filter results by response status code. (optional) 
            var webhookIDs = "webhookIDs_example";  // string | Filter results by webhook ID (include up to 30 values, separated by a comma). (optional) 

            try
            {
                // List message log entries
                MessageLogEntries result = apiInstance.GetMessageLogs(entityType, messageID, changeType, notificationIDs, createdBefore, createdAfter, cursor, period, isSuccessful, applicationId, campaignId, loyaltyProgramId, responseCode, webhookIDs);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetMessageLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List message log entries
    ApiResponse<MessageLogEntries> response = apiInstance.GetMessageLogsWithHttpInfo(entityType, messageID, changeType, notificationIDs, createdBefore, createdAfter, cursor, period, isSuccessful, applicationId, campaignId, loyaltyProgramId, responseCode, webhookIDs);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetMessageLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetReferralsWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var code = "code_example";  // string | Filter results performing case-insensitive matching against the referral code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the referral creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var valid = "expired";  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches referrals in which the expiration date is set and in the past. The second matches referrals in which start date is null or in the past and expiration date is null or in the future, the third matches referrals in which start date is set and in the future.  (optional) 
            var usable = "true";  // string | Either \"true\" or \"false\". If \"true\", only referrals where `usageCounter < usageLimit` will be returned, \"false\" will return only referrals where `usageCounter >= usageLimit`.  (optional) 
            var advocate = "advocate_example";  // string | Filter results by match with a profile ID specified in the referral's AdvocateProfileIntegrationId field. (optional) 

            try
            {
                // List referrals
                GetReferralsWithoutTotalCount200Response result = apiInstance.GetReferralsWithoutTotalCount(applicationId, campaignId, pageSize, skip, sort, code, createdBefore, createdAfter, valid, usable, advocate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetReferralsWithoutTotalCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReferralsWithoutTotalCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List referrals
    ApiResponse<GetReferralsWithoutTotalCount200Response> response = apiInstance.GetReferralsWithoutTotalCountWithHttpInfo(applicationId, campaignId, pageSize, skip, sort, code, createdBefore, createdAfter, valid, usable, advocate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetReferralsWithoutTotalCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetRoleV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var roleId = 789L;  // long | The ID of role.  **Note**: To find the ID of a role, use the [List roles](/management-api#tag/Roles/operation/listAllRolesV2) endpoint. 

            try
            {
                // Get role
                RoleV2 result = apiInstance.GetRoleV2(roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetRoleV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoleV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get role
    ApiResponse<RoleV2> response = apiInstance.GetRoleV2WithHttpInfo(roleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetRoleV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetRulesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var rulesetId = 789L;  // long | The ID of the ruleset.

            try
            {
                // Get ruleset
                Ruleset result = apiInstance.GetRuleset(applicationId, campaignId, rulesetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetRuleset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get ruleset
    ApiResponse<Ruleset> response = apiInstance.GetRulesetWithHttpInfo(applicationId, campaignId, rulesetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetRulesetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetRulesetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // List campaign rulesets
                GetRulesets200Response result = apiInstance.GetRulesets(applicationId, campaignId, pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetRulesets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRulesetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List campaign rulesets
    ApiResponse<GetRulesets200Response> response = apiInstance.GetRulesetsWithHttpInfo(applicationId, campaignId, pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetRulesetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var storeId = "storeId_example";  // string | The ID of the store. You can get this ID with the [List stores](#tag/Stores/operation/listStores) endpoint. 

            try
            {
                // Get store
                Store result = apiInstance.GetStore(applicationId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetStore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get store
    ApiResponse<Store> response = apiInstance.GetStoreWithHttpInfo(applicationId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetStoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var userId = 789L;  // long | The ID of the user.

            try
            {
                // Get user
                User result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get user
    ApiResponse<User> response = apiInstance.GetUserWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 

            try
            {
                // List users in account
                GetUsers200Response result = apiInstance.GetUsers(pageSize, skip, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List users in account
    ApiResponse<GetUsers200Response> response = apiInstance.GetUsersWithHttpInfo(pageSize, skip, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var webhookId = 789L;  // long | The ID of the webhook. You can find the ID in the Campaign Manager's URL when you display the details of the webhook in **Account** > **Webhooks**. 

            try
            {
                // Get webhook
                Webhook result = apiInstance.GetWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get webhook
    ApiResponse<Webhook> response = apiInstance.GetWebhookWithHttpInfo(webhookId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationIds = "applicationIds_example";  // string | Checks if the given catalog or its attributes are referenced in the specified Application ID.  **Note**: If no Application ID is provided, we check for all connected Applications.  (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var creationType = "templateWebhooks";  // string | Filter results by creation type. (optional) 
            var visibility = "visible";  // string | Filter results by visibility. (optional) 
            var outgoingIntegrationsTypeId = 789L;  // long | Filter results by outgoing integration type ID. (optional) 
            var title = "title_example";  // string | Filter results performing case-insensitive matching against the webhook title. (optional) 

            try
            {
                // List webhooks
                GetWebhooks200Response result = apiInstance.GetWebhooks(applicationIds, sort, pageSize, skip, creationType, visibility, outgoingIntegrationsTypeId, title);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List webhooks
    ApiResponse<GetWebhooks200Response> response = apiInstance.GetWebhooksWithHttpInfo(applicationIds, sort, pageSize, skip, creationType, visibility, outgoingIntegrationsTypeId, title);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint.
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import data into existing account-level collection
                Import result = apiInstance.ImportAccountCollection(collectionId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportAccountCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportAccountCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import data into existing account-level collection
    ApiResponse<Import> response = apiInstance.ImportAccountCollectionWithHttpInfo(collectionId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportAccountCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportAllowedListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var attributeId = 789L;  // long | The ID of the attribute. You can find the ID in the Campaign Manager's URL when you display the details of an attribute in **Account** > **Tools** > **Attributes**.
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import allowed values for attribute
                Import result = apiInstance.ImportAllowedList(attributeId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportAllowedList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportAllowedListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import allowed values for attribute
    ApiResponse<Import> response = apiInstance.ImportAllowedListWithHttpInfo(attributeId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportAllowedListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportAudiencesMembershipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var audienceId = 789L;  // long | The ID of the audience.
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import audience members
                Import result = apiInstance.ImportAudiencesMemberships(audienceId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportAudiencesMemberships: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportAudiencesMembershipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import audience members
    ApiResponse<Import> response = apiInstance.ImportAudiencesMembershipsWithHttpInfo(audienceId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportAudiencesMembershipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportCampaignStoreBudgetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var action = "setDiscount";  // string | The action that this budget is limiting. (optional) 
            var period = "overall";  // string | The period to which the limit applies.  **Note**: For budgets with no period, set this to `overall`.  (optional) 
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import campaign store budgets
                Import result = apiInstance.ImportCampaignStoreBudget(applicationId, campaignId, action, period, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportCampaignStoreBudget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCampaignStoreBudgetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import campaign store budgets
    ApiResponse<Import> response = apiInstance.ImportCampaignStoreBudgetWithHttpInfo(applicationId, campaignId, action, period, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportCampaignStoreBudgetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportCampaignStoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import stores
                Import result = apiInstance.ImportCampaignStores(applicationId, campaignId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportCampaignStores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCampaignStoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import stores
    ApiResponse<Import> response = apiInstance.ImportCampaignStoresWithHttpInfo(applicationId, campaignId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportCampaignStoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint.
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import data into existing campaign-level collection
                Import result = apiInstance.ImportCollection(applicationId, campaignId, collectionId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import data into existing campaign-level collection
    ApiResponse<Import> response = apiInstance.ImportCollectionWithHttpInfo(applicationId, campaignId, collectionId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var skipDuplicates = true;  // bool | An indicator of whether to skip duplicate coupon values instead of causing an error. Duplicate values are ignored when `skipDuplicates=true`.  (optional) 
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import coupons
                Import result = apiInstance.ImportCoupons(applicationId, campaignId, skipDuplicates, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportCoupons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCouponsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import coupons
    ApiResponse<Import> response = apiInstance.ImportCouponsWithHttpInfo(applicationId, campaignId, skipDuplicates, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportCouponsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportLoyaltyCardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import loyalty cards
                Import result = apiInstance.ImportLoyaltyCards(loyaltyProgramId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportLoyaltyCards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportLoyaltyCardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import loyalty cards
    ApiResponse<Import> response = apiInstance.ImportLoyaltyCardsWithHttpInfo(loyaltyProgramId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportLoyaltyCardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportLoyaltyCustomersTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import customers into loyalty tiers
                Import result = apiInstance.ImportLoyaltyCustomersTiers(loyaltyProgramId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportLoyaltyCustomersTiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportLoyaltyCustomersTiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import customers into loyalty tiers
    ApiResponse<Import> response = apiInstance.ImportLoyaltyCustomersTiersWithHttpInfo(loyaltyProgramId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportLoyaltyCustomersTiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

Upload a CSV file containing the loyalty points you want to import into a given loyalty program. Send the file as multipart data.  Depending on the type of loyalty program, you can import points into a given customer profile or loyalty card.  The CSV file contains the following columns:  - `customerprofileid` (optional): For profile-based loyalty programs, the integration ID of the customer profile where the loyalty points are imported.    **Note**: If the customer profile does not exist, it will be created. The profile will not be visible in any Application   until a session or profile update is received for that profile. - `identifier` (optional): For card-based loyalty programs, the identifier of the loyalty card where the loyalty points are imported. - `amount`: The amount of points to award to the customer profile. - `startdate` (optional): The earliest date when the points can be redeemed. The points are `active` from this date until the expiration date.    This parameter accepts one of the following values:   - A timestamp string in RFC3339 format.   - `immediate`   - `on_action`      **Note**:   Empty or missing values default to `immediate`. - `expirydate` (optional): The latest date when the points can be redeemed. The points are `expired` after this date.    **Note**: It must be an RFC3339 timestamp string or string `unlimited`. Empty or missing values are considered `unlimited`. - `subledgerid` (optional): The ID of the subledger that should received the points. - `reason` (optional): The reason why these points are awarded.  You can use the time zone of your choice. It is converted to UTC internally by Talon.One.  **Note:** For existing customer profiles and loyalty cards, the imported points are added to any previous active or pending points, depending on the value provided for `startdate`. If `startdate` matches the current date, the imported points are _active_. If it is later, the points are _pending_ until the date provided for `startdate` is reached.  **Note:** We recommend limiting your file size to 500MB.  **Example for profile-based programs:**  ```text customerprofileid,amount,startdate,expirydate,subledgerid,reason URNGV8294NV,100,2009-11-10T23:00:00Z,2009-11-11T23:00:00Z,subledger1,appeasement ```  **Example for card-based programs:**  ```text identifier,amount,startdate,expirydate,subledgerid,reason summer-loyalty-card-0543,100,2009-11-10T23:00:00Z,2009-11-11T23:00:00Z,subledger1,appeasement ``` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportLoyaltyPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the loyalty program. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var notificationsEnabled = true;  // bool | Indicates whether the points import triggers notifications about its effects. For example, a notification is sent if the import upgrades a customer's tier or offsets their negative points balance.  This parameter is optional and defaults to `true`.  (optional) 
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import loyalty points
                Import result = apiInstance.ImportLoyaltyPoints(loyaltyProgramId, notificationsEnabled, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportLoyaltyPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportLoyaltyPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import loyalty points
    ApiResponse<Import> response = apiInstance.ImportLoyaltyPointsWithHttpInfo(loyaltyProgramId, notificationsEnabled, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportLoyaltyPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportPoolGiveawaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var poolId = 789L;  // long | The ID of the pool. You can find it in the Campaign Manager, in the **Giveaways** section.
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import giveaway codes into a giveaway pool
                Import result = apiInstance.ImportPoolGiveaways(poolId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportPoolGiveaways: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportPoolGiveawaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import giveaway codes into a giveaway pool
    ApiResponse<Import> response = apiInstance.ImportPoolGiveawaysWithHttpInfo(poolId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportPoolGiveawaysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ImportReferralsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var upFile = "upFile_example";  // string | The file containing the data that is being imported. (optional) 

            try
            {
                // Import referrals
                Import result = apiInstance.ImportReferrals(applicationId, campaignId, upFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ImportReferrals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportReferralsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import referrals
    ApiResponse<Import> response = apiInstance.ImportReferralsWithHttpInfo(applicationId, campaignId, upFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ImportReferralsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class InviteUserExternalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var newExternalInvitation = new NewExternalInvitation(); // NewExternalInvitation | body

            try
            {
                // Invite user from identity provider
                apiInstance.InviteUserExternal(newExternalInvitation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.InviteUserExternal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InviteUserExternalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite user from identity provider
    apiInstance.InviteUserExternalWithHttpInfo(newExternalInvitation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.InviteUserExternalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListAccountCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var name = "name_example";  // string | Filter by collection name. (optional) 

            try
            {
                // List collections in account
                ListAccountCollections200Response result = apiInstance.ListAccountCollections(pageSize, skip, sort, withTotalResultSize, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListAccountCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccountCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List collections in account
    ApiResponse<ListAccountCollections200Response> response = apiInstance.ListAccountCollectionsWithHttpInfo(pageSize, skip, sort, withTotalResultSize, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListAccountCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListAchievementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 50L;  // long | The number of items in the response. (optional)  (default to 50)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var title = "title_example";  // string | Filter by the display name for the achievement in the campaign manager.  **Note**: If no `title` is provided, all the achievements from the campaign are returned.  (optional) 

            try
            {
                // List achievements
                ListAchievements200Response result = apiInstance.ListAchievements(applicationId, campaignId, pageSize, skip, title);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListAchievements: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAchievementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List achievements
    ApiResponse<ListAchievements200Response> response = apiInstance.ListAchievementsWithHttpInfo(applicationId, campaignId, pageSize, skip, title);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListAchievementsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListAllRolesV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List roles
                ListAllRolesV2200Response result = apiInstance.ListAllRolesV2();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListAllRolesV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllRolesV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List roles
    ApiResponse<ListAllRolesV2200Response> response = apiInstance.ListAllRolesV2WithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListAllRolesV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListCampaignStoreBudgetLimitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var action = "setDiscount";  // string | The action that this budget is limiting. (optional) 
            var period = "overall";  // string | The period to which the limit applies.  **Note**: For budgets with no period, set this to `overall`.  (optional) 

            try
            {
                // List campaign store budget limits
                ListCampaignStoreBudgetLimits200Response result = apiInstance.ListCampaignStoreBudgetLimits(applicationId, campaignId, action, period);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListCampaignStoreBudgetLimits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCampaignStoreBudgetLimitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List campaign store budget limits
    ApiResponse<ListCampaignStoreBudgetLimits200Response> response = apiInstance.ListCampaignStoreBudgetLimitsWithHttpInfo(applicationId, campaignId, action, period);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListCampaignStoreBudgetLimitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListCatalogItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var catalogId = 789L;  // long | The ID of the catalog. You can find the ID in the Campaign Manager in **Account** > **Tools** > **Cart item catalogs**.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var sku = new List<string>(); // List<string> | Filter results by one or more SKUs. Must be exact match. (optional) 
            var productNames = new List<string>(); // List<string> | Filter results by one or more product names. Must be exact match. (optional) 

            try
            {
                // List items in a catalog
                ListCatalogItems200Response result = apiInstance.ListCatalogItems(catalogId, pageSize, skip, withTotalResultSize, sku, productNames);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListCatalogItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCatalogItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List items in a catalog
    ApiResponse<ListCatalogItems200Response> response = apiInstance.ListCatalogItemsWithHttpInfo(catalogId, pageSize, skip, withTotalResultSize, sku, productNames);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListCatalogItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var name = "name_example";  // string | Filter by collection name. (optional) 

            try
            {
                // List collections in campaign
                ListAccountCollections200Response result = apiInstance.ListCollections(applicationId, campaignId, pageSize, skip, sort, withTotalResultSize, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List collections in campaign
    ApiResponse<ListAccountCollections200Response> response = apiInstance.ListCollectionsWithHttpInfo(applicationId, campaignId, pageSize, skip, sort, withTotalResultSize, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListCollectionsInApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var name = "name_example";  // string | Filter by collection name. (optional) 

            try
            {
                // List collections in Application
                ListAccountCollections200Response result = apiInstance.ListCollectionsInApplication(applicationId, pageSize, skip, sort, withTotalResultSize, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListCollectionsInApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCollectionsInApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List collections in Application
    ApiResponse<ListAccountCollections200Response> response = apiInstance.ListCollectionsInApplicationWithHttpInfo(applicationId, pageSize, skip, sort, withTotalResultSize, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListCollectionsInApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ListStoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var withTotalResultSize = true;  // bool | When this flag is set, the result includes the total size of the result, across all pages. This might decrease performance on large data sets.  - When `true`: `hasMore` is true when there is a next page. `totalResultSize` is always zero. - When `false`: `hasMore` is always false. `totalResultSize` contains the total number of results for this query.  (optional) 
            var campaignId = 8.14D;  // decimal | Filter results by campaign ID. (optional) 
            var name = "name_example";  // string | The name of the store. (optional) 
            var integrationId = "integrationId_example";  // string | The integration ID of the store. (optional) 
            var query = "query_example";  // string | Filter results by `name` or `integrationId`. (optional) 

            try
            {
                // List stores
                ListStores200Response result = apiInstance.ListStores(applicationId, pageSize, skip, sort, withTotalResultSize, campaignId, name, integrationId, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListStores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListStoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List stores
    ApiResponse<ListStores200Response> response = apiInstance.ListStoresWithHttpInfo(applicationId, pageSize, skip, sort, withTotalResultSize, campaignId, name, integrationId, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListStoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class OktaEventHandlerChallengeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // Validate Okta API ownership
                apiInstance.OktaEventHandlerChallenge();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.OktaEventHandlerChallenge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OktaEventHandlerChallengeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate Okta API ownership
    apiInstance.OktaEventHandlerChallengeWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.OktaEventHandlerChallengeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class RemoveLoyaltyPointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = "loyaltyProgramId_example";  // string | The identifier for the loyalty program.
            var integrationId = "integrationId_example";  // string | The integration identifier for this customer profile. Must be: - Unique within the deployment. - Stable for the customer. Do not use an ID that the customer can update themselves. For example, you can use a database ID.  Once set, you cannot update this identifier. 
            var deductLoyaltyPoints = new DeductLoyaltyPoints(); // DeductLoyaltyPoints | body

            try
            {
                // Deduct points from customer profile
                apiInstance.RemoveLoyaltyPoints(loyaltyProgramId, integrationId, deductLoyaltyPoints);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.RemoveLoyaltyPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveLoyaltyPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deduct points from customer profile
    apiInstance.RemoveLoyaltyPointsWithHttpInfo(loyaltyProgramId, integrationId, deductLoyaltyPoints);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.RemoveLoyaltyPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ResetPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var newPassword = new NewPassword(); // NewPassword | body

            try
            {
                // Reset password
                NewPassword result = apiInstance.ResetPassword(newPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ResetPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset password
    ApiResponse<NewPassword> response = apiInstance.ResetPasswordWithHttpInfo(newPassword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ResetPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimCreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var scimBaseGroup = new ScimBaseGroup(); // ScimBaseGroup | body

            try
            {
                // Create SCIM group
                ScimGroup result = apiInstance.ScimCreateGroup(scimBaseGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimCreateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimCreateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create SCIM group
    ApiResponse<ScimGroup> response = apiInstance.ScimCreateGroupWithHttpInfo(scimBaseGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimCreateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimCreateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var scimNewUser = new ScimNewUser(); // ScimNewUser | body

            try
            {
                // Create SCIM user
                ScimUser result = apiInstance.ScimCreateUser(scimNewUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimCreateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimCreateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create SCIM user
    ApiResponse<ScimUser> response = apiInstance.ScimCreateUserWithHttpInfo(scimNewUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimCreateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimDeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var groupId = 789L;  // long | The ID of the group.

            try
            {
                // Delete SCIM group
                apiInstance.ScimDeleteGroup(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimDeleteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimDeleteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete SCIM group
    apiInstance.ScimDeleteGroupWithHttpInfo(groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimDeleteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimDeleteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var userId = 789L;  // long | The ID of the user.

            try
            {
                // Delete SCIM user
                apiInstance.ScimDeleteUser(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimDeleteUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimDeleteUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete SCIM user
    apiInstance.ScimDeleteUserWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimDeleteUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimGetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var groupId = 789L;  // long | The ID of the group.

            try
            {
                // Get SCIM group
                ScimGroup result = apiInstance.ScimGetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimGetGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimGetGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SCIM group
    ApiResponse<ScimGroup> response = apiInstance.ScimGetGroupWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimGetGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimGetGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List SCIM groups
                ScimGroupsListResponse result = apiInstance.ScimGetGroups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimGetGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimGetGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List SCIM groups
    ApiResponse<ScimGroupsListResponse> response = apiInstance.ScimGetGroupsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimGetGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimGetResourceTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List supported SCIM resource types
                ScimResourceTypesListResponse result = apiInstance.ScimGetResourceTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimGetResourceTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimGetResourceTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List supported SCIM resource types
    ApiResponse<ScimResourceTypesListResponse> response = apiInstance.ScimGetResourceTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimGetResourceTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimGetSchemasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List supported SCIM schemas
                ScimSchemasListResponse result = apiInstance.ScimGetSchemas();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimGetSchemas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimGetSchemasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List supported SCIM schemas
    ApiResponse<ScimSchemasListResponse> response = apiInstance.ScimGetSchemasWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimGetSchemasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimGetServiceProviderConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // Get SCIM service provider configuration
                ScimServiceProviderConfigResponse result = apiInstance.ScimGetServiceProviderConfig();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimGetServiceProviderConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimGetServiceProviderConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SCIM service provider configuration
    ApiResponse<ScimServiceProviderConfigResponse> response = apiInstance.ScimGetServiceProviderConfigWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimGetServiceProviderConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimGetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var userId = 789L;  // long | The ID of the user.

            try
            {
                // Get SCIM user
                ScimUser result = apiInstance.ScimGetUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimGetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimGetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SCIM user
    ApiResponse<ScimUser> response = apiInstance.ScimGetUserWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimGetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimGetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List SCIM users
                ScimUsersListResponse result = apiInstance.ScimGetUsers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimGetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimGetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List SCIM users
    ApiResponse<ScimUsersListResponse> response = apiInstance.ScimGetUsersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimGetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimPatchGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var groupId = 789L;  // long | The ID of the group.
            var scimPatchRequest = new ScimPatchRequest(); // ScimPatchRequest | body

            try
            {
                // Update SCIM group attributes
                ScimGroup result = apiInstance.ScimPatchGroup(groupId, scimPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimPatchGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimPatchGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SCIM group attributes
    ApiResponse<ScimGroup> response = apiInstance.ScimPatchGroupWithHttpInfo(groupId, scimPatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimPatchGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimPatchUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var userId = 789L;  // long | The ID of the user.
            var scimPatchRequest = new ScimPatchRequest(); // ScimPatchRequest | body

            try
            {
                // Update SCIM user attributes
                ScimUser result = apiInstance.ScimPatchUser(userId, scimPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimPatchUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimPatchUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SCIM user attributes
    ApiResponse<ScimUser> response = apiInstance.ScimPatchUserWithHttpInfo(userId, scimPatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimPatchUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimReplaceGroupAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var groupId = 789L;  // long | The ID of the group.
            var scimBaseGroup = new ScimBaseGroup(); // ScimBaseGroup | body

            try
            {
                // Update SCIM group
                ScimGroup result = apiInstance.ScimReplaceGroupAttributes(groupId, scimBaseGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimReplaceGroupAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimReplaceGroupAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SCIM group
    ApiResponse<ScimGroup> response = apiInstance.ScimReplaceGroupAttributesWithHttpInfo(groupId, scimBaseGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimReplaceGroupAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class ScimReplaceUserAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var userId = 789L;  // long | The ID of the user.
            var scimNewUser = new ScimNewUser(); // ScimNewUser | body

            try
            {
                // Update SCIM user
                ScimUser result = apiInstance.ScimReplaceUserAttributes(userId, scimNewUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ScimReplaceUserAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScimReplaceUserAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SCIM user
    ApiResponse<ScimUser> response = apiInstance.ScimReplaceUserAttributesWithHttpInfo(userId, scimNewUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ScimReplaceUserAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class SearchCouponsAdvancedApplicationWideWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var body = null;  // Object | body
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var value = "value_example";  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var valid = "expired";  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = "true";  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 789L;  // long | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = "recipientIntegrationId_example";  // string | Filter results by match with a profile ID specified in the coupon's RecipientIntegrationId field. (optional) 
            var batchId = "batchId_example";  // string | Filter results by batches of coupons (optional) 
            var exactMatch = false;  // bool | Filter results to an exact case-insensitive matching against the coupon code. (optional)  (default to false)
            var campaignState = "enabled";  // string | Filter results by the state of the campaign.  - `enabled`: Campaigns that are scheduled, running (activated), or expired. - `running`: Campaigns that are running (activated). - `disabled`: Campaigns that are disabled. - `expired`: Campaigns that are expired. - `archived`: Campaigns that are archived.  (optional) 

            try
            {
                // List coupons that match the given attributes (without total count)
                GetCouponsWithoutTotalCount200Response result = apiInstance.SearchCouponsAdvancedApplicationWideWithoutTotalCount(applicationId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, campaignState);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.SearchCouponsAdvancedApplicationWideWithoutTotalCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchCouponsAdvancedApplicationWideWithoutTotalCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List coupons that match the given attributes (without total count)
    ApiResponse<GetCouponsWithoutTotalCount200Response> response = apiInstance.SearchCouponsAdvancedApplicationWideWithoutTotalCountWithHttpInfo(applicationId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, batchId, exactMatch, campaignState);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.SearchCouponsAdvancedApplicationWideWithoutTotalCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class SearchCouponsAdvancedWithoutTotalCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var body = null;  // Object | body
            var pageSize = 1000L;  // long | The number of items in the response. (optional)  (default to 1000)
            var skip = 789L;  // long | The number of items to skip when paging through large result sets. (optional) 
            var sort = "sort_example";  // string | The field by which results should be sorted. By default, results are sorted in ascending order. To sort them in descending order, prefix the field name with `-`.  **Note:** You may not be able to use all fields for sorting. This is due to performance limitations.  (optional) 
            var value = "value_example";  // string | Filter results performing case-insensitive matching against the coupon code. Both the code and the query are folded to remove all non-alpha-numeric characters. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter results comparing the parameter value, expected to be an RFC3339 timestamp string, to the coupon creation timestamp. You can use any time zone setting. Talon.One will convert to UTC internally. (optional) 
            var valid = "expired";  // string | Either \"expired\", \"validNow\", or \"validFuture\". The first option matches coupons in which the expiration date is set and in the past. The second matches coupons in which start date is null or in the past and expiration date is null or in the future, the third matches coupons in which start date is set and in the future.  (optional) 
            var usable = "true";  // string | Either \"true\" or \"false\". If \"true\", only coupons where `usageCounter < usageLimit` will be returned, \"false\" will return only coupons where `usageCounter >= usageLimit`.  (optional) 
            var referralId = 789L;  // long | Filter the results by matching them with the ID of a referral. This filter shows the coupons created by redeeming a referral code. (optional) 
            var recipientIntegrationId = "recipientIntegrationId_example";  // string | Filter results by match with a profile ID specified in the coupon's RecipientIntegrationId field. (optional) 
            var exactMatch = false;  // bool | Filter results to an exact case-insensitive matching against the coupon code. (optional)  (default to false)
            var batchId = "batchId_example";  // string | Filter results by batches of coupons (optional) 

            try
            {
                // List coupons that match the given attributes in campaign (without total count)
                GetCouponsWithoutTotalCount200Response result = apiInstance.SearchCouponsAdvancedWithoutTotalCount(applicationId, campaignId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, exactMatch, batchId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.SearchCouponsAdvancedWithoutTotalCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchCouponsAdvancedWithoutTotalCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List coupons that match the given attributes in campaign (without total count)
    ApiResponse<GetCouponsWithoutTotalCount200Response> response = apiInstance.SearchCouponsAdvancedWithoutTotalCountWithHttpInfo(applicationId, campaignId, body, pageSize, skip, sort, value, createdBefore, createdAfter, valid, usable, referralId, recipientIntegrationId, exactMatch, batchId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.SearchCouponsAdvancedWithoutTotalCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class SummarizeCampaignStoreBudgetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.

            try
            {
                // Get summary of campaign store budgets
                SummarizeCampaignStoreBudget200Response result = apiInstance.SummarizeCampaignStoreBudget(applicationId, campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.SummarizeCampaignStoreBudget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SummarizeCampaignStoreBudgetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get summary of campaign store budgets
    ApiResponse<SummarizeCampaignStoreBudget200Response> response = apiInstance.SummarizeCampaignStoreBudgetWithHttpInfo(applicationId, campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.SummarizeCampaignStoreBudgetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class TransferLoyaltyCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = "loyaltyCardId_example";  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var transferLoyaltyCard = new TransferLoyaltyCard(); // TransferLoyaltyCard | body

            try
            {
                // Transfer card data
                apiInstance.TransferLoyaltyCard(loyaltyProgramId, loyaltyCardId, transferLoyaltyCard);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.TransferLoyaltyCard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransferLoyaltyCardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transfer card data
    apiInstance.TransferLoyaltyCardWithHttpInfo(loyaltyProgramId, loyaltyCardId, transferLoyaltyCard);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.TransferLoyaltyCardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAccountCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in account](#operation/listAccountCollections) endpoint.
            var updateCollection = new UpdateCollection(); // UpdateCollection | body

            try
            {
                // Update account-level collection
                Collection result = apiInstance.UpdateAccountCollection(collectionId, updateCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateAccountCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAccountCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update account-level collection
    ApiResponse<Collection> response = apiInstance.UpdateAccountCollectionWithHttpInfo(collectionId, updateCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateAccountCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAchievementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var achievementId = 789L;  // long | The ID of the achievement. You can get this ID with the [List achievement](https://docs.talon.one/management-api#tag/Achievements/operation/listAchievements) endpoint.
            var updateAchievement = new UpdateAchievement(); // UpdateAchievement | body

            try
            {
                // Update achievement
                Achievement result = apiInstance.UpdateAchievement(applicationId, campaignId, achievementId, updateAchievement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateAchievement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAchievementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update achievement
    ApiResponse<Achievement> response = apiInstance.UpdateAchievementWithHttpInfo(applicationId, campaignId, achievementId, updateAchievement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateAchievementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAdditionalCostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var additionalCostId = 789L;  // long | The ID of the additional cost. You can find the ID the the Campaign Manager's URL when you display the details of the cost in **Account** > **Tools** > **Additional costs**. 
            var newAdditionalCost = new NewAdditionalCost(); // NewAdditionalCost | body

            try
            {
                // Update additional cost
                AccountAdditionalCost result = apiInstance.UpdateAdditionalCost(additionalCostId, newAdditionalCost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateAdditionalCost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAdditionalCostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update additional cost
    ApiResponse<AccountAdditionalCost> response = apiInstance.UpdateAdditionalCostWithHttpInfo(additionalCostId, newAdditionalCost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateAdditionalCostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var attributeId = 789L;  // long | The ID of the attribute. You can find the ID in the Campaign Manager's URL when you display the details of an attribute in **Account** > **Tools** > **Attributes**.
            var newAttribute = new NewAttribute(); // NewAttribute | body

            try
            {
                // Update custom attribute
                Attribute result = apiInstance.UpdateAttribute(attributeId, newAttribute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update custom attribute
    ApiResponse<Attribute> response = apiInstance.UpdateAttributeWithHttpInfo(attributeId, newAttribute);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var updateCampaign = new UpdateCampaign(); // UpdateCampaign | body

            try
            {
                // Update campaign
                Campaign result = apiInstance.UpdateCampaign(applicationId, campaignId, updateCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update campaign
    ApiResponse<Campaign> response = apiInstance.UpdateCampaignWithHttpInfo(applicationId, campaignId, updateCampaign);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var collectionId = 789L;  // long | The ID of the collection. You can get it with the [List collections in Application](#operation/listCollectionsInApplication) endpoint.
            var updateCampaignCollection = new UpdateCampaignCollection(); // UpdateCampaignCollection | body

            try
            {
                // Update campaign-level collection's description
                Collection result = apiInstance.UpdateCollection(applicationId, campaignId, collectionId, updateCampaignCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update campaign-level collection's description
    ApiResponse<Collection> response = apiInstance.UpdateCollectionWithHttpInfo(applicationId, campaignId, collectionId, updateCampaignCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var couponId = "couponId_example";  // string | The internal ID of the coupon code. You can find this value in the `id` property from the [List coupons](https://docs.talon.one/management-api#tag/Coupons/operation/getCouponsWithoutTotalCount) endpoint response. 
            var updateCoupon = new UpdateCoupon(); // UpdateCoupon | body

            try
            {
                // Update coupon
                Coupon result = apiInstance.UpdateCoupon(applicationId, campaignId, couponId, updateCoupon);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCoupon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCouponWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update coupon
    ApiResponse<Coupon> response = apiInstance.UpdateCouponWithHttpInfo(applicationId, campaignId, couponId, updateCoupon);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateCouponWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCouponBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var updateCouponBatch = new UpdateCouponBatch(); // UpdateCouponBatch | body

            try
            {
                // Update coupons
                apiInstance.UpdateCouponBatch(applicationId, campaignId, updateCouponBatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCouponBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCouponBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update coupons
    apiInstance.UpdateCouponBatchWithHttpInfo(applicationId, campaignId, updateCouponBatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateCouponBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateLoyaltyCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var loyaltyProgramId = 789L;  // long | Identifier of the card-based loyalty program containing the loyalty card. You can get the ID with the [List loyalty programs](https://docs.talon.one/management-api#tag/Loyalty/operation/getLoyaltyPrograms) endpoint. 
            var loyaltyCardId = "loyaltyCardId_example";  // string | Identifier of the loyalty card. You can get the identifier with the [List loyalty cards](https://docs.talon.one/management-api#tag/Loyalty-cards/operation/getLoyaltyCards) endpoint. 
            var updateLoyaltyCard = new UpdateLoyaltyCard(); // UpdateLoyaltyCard | body

            try
            {
                // Update loyalty card status
                LoyaltyCard result = apiInstance.UpdateLoyaltyCard(loyaltyProgramId, loyaltyCardId, updateLoyaltyCard);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateLoyaltyCard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLoyaltyCardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update loyalty card status
    ApiResponse<LoyaltyCard> response = apiInstance.UpdateLoyaltyCardWithHttpInfo(loyaltyProgramId, loyaltyCardId, updateLoyaltyCard);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateLoyaltyCardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateReferralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var campaignId = 789L;  // long | The ID of the campaign. It is displayed in your Talon.One deployment URL.
            var referralId = "referralId_example";  // string | The ID of the referral code.
            var updateReferral = new UpdateReferral(); // UpdateReferral | body

            try
            {
                // Update referral
                Referral result = apiInstance.UpdateReferral(applicationId, campaignId, referralId, updateReferral);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateReferral: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateReferralWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update referral
    ApiResponse<Referral> response = apiInstance.UpdateReferralWithHttpInfo(applicationId, campaignId, referralId, updateReferral);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateReferralWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateRoleV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var roleId = 789L;  // long | The ID of role.  **Note**: To find the ID of a role, use the [List roles](/management-api#tag/Roles/operation/listAllRolesV2) endpoint. 
            var roleV2Base = new RoleV2Base(); // RoleV2Base | body

            try
            {
                // Update role
                RoleV2 result = apiInstance.UpdateRoleV2(roleId, roleV2Base);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateRoleV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRoleV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update role
    ApiResponse<RoleV2> response = apiInstance.UpdateRoleV2WithHttpInfo(roleId, roleV2Base);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateRoleV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateStoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var applicationId = 789L;  // long | The ID of the Application. It is displayed in your Talon.One deployment URL.
            var storeId = "storeId_example";  // string | The ID of the store. You can get this ID with the [List stores](#tag/Stores/operation/listStores) endpoint. 
            var newStore = new NewStore(); // NewStore | body

            try
            {
                // Update store
                Store result = apiInstance.UpdateStore(applicationId, storeId, newStore);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateStore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateStoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update store
    ApiResponse<Store> response = apiInstance.UpdateStoreWithHttpInfo(applicationId, storeId, newStore);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateStoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://yourbaseurl.talon.one";
            // Configure API key authorization: management_key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: manager_auth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: api_key_v1
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var userId = 789L;  // long | The ID of the user.
            var updateUser = new UpdateUser(); // UpdateUser | body

            try
            {
                // Update user
                User result = apiInstance.UpdateUser(userId, updateUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update user
    ApiResponse<User> response = apiInstance.UpdateUserWithHttpInfo(userId, updateUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

