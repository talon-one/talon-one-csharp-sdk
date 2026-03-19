using System;
using System.Collections.Generic;
using TalonOneSdk.Api;
using TalonOneSdk.Client;
using TalonOneSdk.Model;
using Microsoft.Extensions.DependencyInjection;

namespace _example
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            // Configure services and API key authorization
            var services = new ServiceCollection();

            var hostConfiguration = new HostConfiguration(services)
                .AddApiHttpClients(client => client.BaseAddress = new System.Uri("http://localhost:9000"))
                .AddTokens(new ApiKeyToken(
                    System.Environment.GetEnvironmentVariable("TALON_API_KEY"),
                    ClientUtils.ApiKeyHeader.Authorization,
                    "ApiKey-v1 "
                ))
                .UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

            var serviceProvider = services.BuildServiceProvider();
            var apiFactory = serviceProvider.GetRequiredService<IApiFactory>();

            // ************************************************
            // Integration API example to send a session update
            // ************************************************

            Console.WriteLine("Testing session update");

            // Create the Integration API instance using the factory
            var integrationApi = apiFactory.Create<IIntegrationApi>();
            var customerSessionId = "my_unique_session_integration_id_2";  // string | The custom identifier for this session, must be unique within the account.

            // Preparing a NewCustomerSessionV2 object
            NewCustomerSessionV2 customerSession = new NewCustomerSessionV2
            {
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
            // See src/TalonOneSdk/Model/IntegrationRequest#ResponseContentEnum for full list of supported values
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
            foreach (Effect effect in result.Effects)
            {
                switch (effect.EffectType)
                {
                    case "setDiscount":
                        // Initiating right props instance according to the effect type
                        SetDiscountEffectProps setDiscountEffectProps = (SetDiscountEffectProps)Newtonsoft.Json.JsonConvert.DeserializeObject(effect.Props.ToString(), typeof(SetDiscountEffectProps));

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

            //
            // Run test for enum casing
            //

            Console.WriteLine("Testing Integration Request Enum casing issue");

            string customerSession2Id = Guid.NewGuid().ToString();

            // Intentionally no State set here to reproduce the nullable enum serialization path.
            var customerSession2 = new NewCustomerSessionV2
            {
                CouponCodes = new List<string> { "JXHBAH5L" }
            };

            var integrationRequest = new IntegrationRequest(
                customerSession2,
                new List<IntegrationRequest.ResponseContentEnum>
                {
                    IntegrationRequest.ResponseContentEnum.Coupons,
                }
            );

            IUpdateCustomerSessionV2ApiResponse response2 =
                await integrationApi.UpdateCustomerSessionV2Async(customerSession2Id, integrationRequest);

            if (response2.IsBadRequest)
            {
                Console.WriteLine($"{response2.ReasonPhrase}{Environment.NewLine}{response2.RawContent}");
                return;
            }

            Console.WriteLine("The response is ok");
            IntegrationStateV2 result2 = response2.Ok();
            Console.WriteLine(result2);

            //
            // Run test for custom session attributes serialization
            //

            Console.WriteLine("Testing UpdateCustomerSessionV2 custom attributes");

            string customerSession3Id = Guid.NewGuid().ToString();

            var customerSession3 = new NewCustomerSessionV2
            {
                Attributes = new Dictionary<string, object>
                {
                    ["shippingPostalCode"] = "12345"
                }
            };

            var integrationRequestWithAttributes = new IntegrationRequest(customerSession3);

            IUpdateCustomerSessionV2ApiResponse response3 =
                await integrationApi.UpdateCustomerSessionV2Async(customerSession3Id, integrationRequestWithAttributes, dry: true);

            if (response3.IsBadRequest)
            {
                throw new Exception($"Custom attributes scenario failed with a bad request.{Environment.NewLine}{response3.ReasonPhrase}{Environment.NewLine}{response3.RawContent}");
            }

            if (!response3.IsOk)
            {
                throw new Exception($"Custom attributes scenario returned unexpected status {(int)response3.StatusCode} ({response3.ReasonPhrase}).{Environment.NewLine}{response3.RawContent}");
            }

            Console.WriteLine("The custom attributes response is ok");
            Console.WriteLine(response3.Ok());

            //
            // Run test for bad request error deserialization
            //

            Console.WriteLine("Testing UpdateCustomerSessionV2 bad request error handling");

            string customerSession4Id = Guid.NewGuid().ToString();

            var customerSession4 = new NewCustomerSessionV2
            {
                StoreIntegrationId = "invalid"
            };

            var integrationRequestWithInvalidStore = new IntegrationRequest(customerSession4);

            IUpdateCustomerSessionV2ApiResponse response4 =
                await integrationApi.UpdateCustomerSessionV2Async(customerSession4Id, integrationRequestWithInvalidStore);

            if (!response4.IsBadRequest)
            {
                throw new Exception($"Invalid store scenario was expected to return a bad request but returned status {(int)response4.StatusCode} ({response4.ReasonPhrase}).{Environment.NewLine}{response4.RawContent}");
            }

            var badRequest = response4.BadRequest();
            if (string.IsNullOrWhiteSpace(badRequest.Message))
                throw new Exception("Invalid store scenario returned a bad request without a readable error message.");

            Console.WriteLine(badRequest.Message);
        }
    }
}
