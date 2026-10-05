using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TalonOneSdk.Api;
using TalonOneSdk.Client;
using TalonOneSdk.Model;
using Microsoft.Extensions.DependencyInjection;

/*

Rate-limit comparison: http://127.0.0.1:19090/, 1s per rate, dry-run session updates.
Calls are evenly scheduled without waiting for earlier responses. Each stage drains before the next.
Finished RPS counts completed attempts and includes draining queued calls; latency includes client-side token waits.
Each call has a 30s deadline. Stages have a 6s cooldown. Ctrl+C stops the run.

enableRateLimiting: true
Target | Calls | OK | 429 | Other HTTP | Timeouts | Errors | Finished RPS | Avg ms | Max ms | Queued/in-flight at stage end
    10 |    10 |  10 |   0 |          0 |        0 |      0 |         10,0 |      9 |     78 | 0
    15 |    15 |  15 |   0 |          0 |        0 |      0 |         15,0 |      2 |      7 | 0
    20 |    20 |  20 |   0 |          0 |        0 |      0 |         20,0 |      2 |      4 | 0
    25 |    25 |  25 |   0 |          0 |        0 |      0 |         25,0 |      3 |     10 | 0
    30 |    30 |  30 |   0 |          0 |        0 |      0 |         26,2 |     83 |    178 | 4
    35 |    35 |  35 |   0 |          0 |        0 |      0 |         25,7 |    196 |    390 | 10
    40 |    40 |  40 |   0 |          0 |        0 |      0 |         25,7 |    290 |    584 | 14
    45 |    45 |  45 |   0 |          0 |        0 |      0 |         25,6 |    389 |    779 | 20
    50 |    50 |  50 |   0 |          0 |        0 |      0 |         25,5 |    491 |    982 | 25

enableRateLimiting: false
Target | Calls | OK | 429 | Other HTTP | Timeouts | Errors | Finished RPS | Avg ms | Max ms | Queued/in-flight at stage end
    10 |    10 |  10 |   0 |          0 |        0 |      0 |         10,0 |      3 |      7 | 0
    15 |    15 |  15 |   0 |          0 |        0 |      0 |         15,0 |      3 |      6 | 0
    20 |    20 |  20 |   0 |          0 |        0 |      0 |         20,0 |      2 |      3 | 0
    25 |    25 |  25 |   0 |          0 |        0 |      0 |         25,0 |      2 |      5 | 0
    30 |    30 |  30 |   0 |          0 |        0 |      0 |         30,0 |      2 |      3 | 0
    35 |    35 |  35 |   0 |          0 |        0 |      0 |         35,0 |      2 |      3 | 0
    40 |    40 |  40 |   0 |          0 |        0 |      0 |         40,0 |      2 |      7 | 0
    45 |    45 |  45 |   0 |          0 |        0 |      0 |         45,0 |      2 |      4 | 0
    50 |    50 |  50 |   0 |          0 |        0 |      0 |         50,0 |      2 |      7 | 0


*/
namespace _example
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            // The rate-limit comparison is the default. Keep the previous examples
            // available with --examples (these include Management API writes).
            if (!args.Contains("--examples"))
            {
                await RunRateLimitComparisonAsync(args);
                return;
            }

            // Configure services with separate tokens for Integration API and Management API.
            // Both APIs use the Authorization header but each gets its own typed provider,
            // so their tokens are resolved independently by the DI container.
            var services = new ServiceCollection();

            // Client-side rate limiting is enabled by default. Pass
            // enableRateLimiting: false after a token to disable it for that API provider.
            var hostConfiguration = new HostConfiguration(services)
                .AddApiHttpClients(client => client.BaseAddress = new System.Uri("http://localhost:9000"))
                .AddTokens<IntegrationApiKeyProvider>(new ApiKeyToken(
                    System.Environment.GetEnvironmentVariable("TALON_API_KEY"),
                    ClientUtils.ApiKeyHeader.Authorization,
                    "ApiKey-v1 "
                ),
                enableRateLimiting: false)
                .AddTokens<ManagementApiKeyProvider>(new ApiKeyToken(
                    System.Environment.GetEnvironmentVariable("TALON_MGMT_KEY"),
                    ClientUtils.ApiKeyHeader.Authorization,
                    "ManagementKey-v1 "
                ));

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
                switch (effect)
                {
                    case Effect setDiscountEffect when setDiscountEffect.EffectSetDiscount?.EffectType == EffectSetDiscount.EffectTypeEnum.SetDiscount:
                        // Each effect variant exposes its already typed properties through the corresponding union member.
                        SetDiscountEffectProps setDiscountEffectProps = setDiscountEffect.EffectSetDiscount.Props;

                        // Access the specific effect's properties
                        Console.WriteLine("Set a discount '{0}' of {1:00.000}", setDiscountEffectProps.Name, setDiscountEffectProps.Value);
                        break;
                    // case Effect acceptCouponEffect when acceptCouponEffect.EffectAcceptCoupon?.EffectType == EffectAcceptCoupon.EffectTypeEnum.AcceptCoupon:
                    //     AcceptCouponEffectProps acceptCouponEffectProps = acceptCouponEffect.EffectAcceptCoupon.Props;

                    //     // Work with AcceptCouponEffectProps' properties
                    //     // ...
                    //     break;
                    default:
                        Console.WriteLine("Encountered an effect other than setDiscount: {0}", effect);
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

            //
            // Management API — resolved from the same service provider (Issue #25)
            //

            var managementApi = apiFactory.Create<IManagementApi>();

            int applicationId = int.Parse(System.Environment.GetEnvironmentVariable("TALON_APPLICATION_ID"));
            int campaignId = int.Parse(System.Environment.GetEnvironmentVariable("TALON_CAMPAIGN_ID"));

            //
            // Test Issue #25 Problem 1: CreateCoupons with UTC expiry date
            //

            Console.WriteLine("Testing CreateCoupons with UTC expiry date");

            var newCouponsWithExpiry = new NewCoupons(
                numberOfCoupons: 1,
                usageLimit: 0
            )
            {
                ExpiryDate = DateTime.UtcNow.AddYears(1)
            };

            ICreateCouponsApiResponse createCouponsResponse1 =
                await managementApi.CreateCouponsAsync(applicationId, campaignId, newCouponsWithExpiry, silent: "no");

            if (!createCouponsResponse1.IsOk)
            {
                throw new Exception($"CreateCoupons with UTC expiry failed with status {(int)createCouponsResponse1.StatusCode} ({createCouponsResponse1.ReasonPhrase}).{Environment.NewLine}{createCouponsResponse1.RawContent}");
            }

            Console.WriteLine("CreateCoupons with UTC expiry date succeeded");
            Console.WriteLine(createCouponsResponse1.Ok());

            //
            // Test Issue #25 Problem 2: CreateCoupons with Dictionary<string, object> attributes
            //

            Console.WriteLine("Testing CreateCoupons with Dictionary<string, object> attributes");

            var newCouponsWithAttrs = new NewCoupons(
                numberOfCoupons: 1,
                usageLimit: 0
            )
            {
                Attributes = new Dictionary<string, object>
                {
                    ["couponIsActive"] = true
                }
            };

            ICreateCouponsApiResponse createCouponsResponse2 =
                await managementApi.CreateCouponsAsync(applicationId, campaignId, newCouponsWithAttrs, silent: "no");

            if (!createCouponsResponse2.IsOk)
            {
                throw new Exception($"CreateCoupons with Dictionary attributes failed with status {(int)createCouponsResponse2.StatusCode} ({createCouponsResponse2.ReasonPhrase}).{Environment.NewLine}{createCouponsResponse2.RawContent}");
            }

            Console.WriteLine("CreateCoupons with Dictionary<string, object> attributes succeeded");
            Console.WriteLine(createCouponsResponse2.Ok());

            //
            // Test Issue sc-71616: DateTime deserialization of coupon timestamps
            // The API can return timestamps with 9 fractional digit seconds (nanoseconds).
            // DateTimeJsonConverter previously threw NotSupportedException for these, as it
            // only handled up to 7 fractional digits via TryParseExact format strings.
            //

            Console.WriteLine("Testing DateTime deserialization from coupon Created timestamp");

            var createdCoupon = createCouponsResponse1.Ok().Data.First();

            Console.WriteLine($"Coupon Created timestamp parsed successfully: {createdCoupon.Created:O}");
            Console.WriteLine("DateTime deserialization from API response succeeded");
        }

        private static async Task RunRateLimitComparisonAsync(string[] args)
        {
            // Usage: dotnet run --project .github/.example/.example.csproj -- [seconds-per-rate]
            // TALON_BASE_URL defaults to the local proxy used by the original example.
            int secondsPerRate = 10;
            if (args.Length > 1 || (args.Length == 1 &&
                (!int.TryParse(args[0], out secondsPerRate) || secondsPerRate < 1 || secondsPerRate > 60)))
            {
                throw new ArgumentException("Pass a stage duration from 1 to 60 seconds, or --examples.");
            }

            string apiKey = Environment.GetEnvironmentVariable("TALON_API_KEY");
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new InvalidOperationException("Set TALON_API_KEY before running the comparison.");

            var baseUri = new Uri(Environment.GetEnvironmentVariable("TALON_BASE_URL") ?? "http://localhost:9000");
            using var cancellation = new CancellationTokenSource();
            ConsoleCancelEventHandler cancelHandler = (sender, e) =>
            {
                e.Cancel = true;
                cancellation.Cancel();
            };
            Console.CancelKeyPress += cancelHandler;

            Console.WriteLine($"Rate-limit comparison: {baseUri}, {secondsPerRate}s per rate, dry-run session updates.");
            Console.WriteLine("Calls are evenly scheduled without waiting for earlier responses. Each stage drains before the next.");
            Console.WriteLine("Finished RPS counts completed attempts and includes draining queued calls; latency includes client-side token waits.");
            Console.WriteLine("Each call has a 30s deadline. Stages have a 6s cooldown. Ctrl+C stops the run.");

            try
            {
                foreach (bool enableRateLimiting in new[] { true, false })
                {
                    var services = new ServiceCollection();
                    new HostConfiguration(services)
                        .AddApiHttpClients(client => client.BaseAddress = baseUri)
                        .AddTokens<IntegrationApiKeyProvider>(new ApiKeyToken(
                            apiKey, ClientUtils.ApiKeyHeader.Authorization, "ApiKey-v1 "),
                            enableRateLimiting: enableRateLimiting);

                    using var serviceProvider = services.BuildServiceProvider();
                    var api = serviceProvider.GetRequiredService<IApiFactory>().Create<IIntegrationApi>();
                    int? firstFailureRate = null;
                    int? first429Rate = null;

                    Console.WriteLine($"\nenableRateLimiting: {enableRateLimiting.ToString().ToLowerInvariant()}");
                    Console.WriteLine("Target | Calls | OK | 429 | Other HTTP | Timeouts | Errors | Finished RPS | Avg ms | Max ms | Queued/in-flight at stage end");
                    for (int rate = 10; rate <= 50; rate += 5)
                    {
                        cancellation.Token.ThrowIfCancellationRequested();
                        var results = await RunRateAsync(api, rate, secondsPerRate, cancellation.Token);
                        if (results.Any(r => r.StatusCode != 200))
                            firstFailureRate ??= rate;
                        if (results.Any(r => r.StatusCode == 429))
                            first429Rate ??= rate;
                        await Task.Delay(TimeSpan.FromSeconds(6), cancellation.Token);
                    }

                    Console.WriteLine($"First failure: {(firstFailureRate.HasValue ? firstFailureRate + " RPS" : "none")}; " +
                        $"first HTTP 429: {(first429Rate.HasValue ? first429Rate + " RPS" : "none")}");
                }
            }
            catch (OperationCanceledException) when (cancellation.IsCancellationRequested)
            {
                Console.WriteLine("Comparison stopped.");
            }
            finally
            {
                Console.CancelKeyPress -= cancelHandler;
            }
        }

        private static async Task<RequestResult[]> RunRateAsync(
            IIntegrationApi api, int rate, int seconds, CancellationToken cancellation)
        {
            int count = rate * seconds;
            var requests = new List<Task<RequestResult>>(count);
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                // Absolute deadlines prevent response latency from slowing the load generator.
                var delay = TimeSpan.FromSeconds((double)i / rate) - stopwatch.Elapsed;
                if (delay > TimeSpan.Zero)
                    await Task.Delay(delay, cancellation);
                cancellation.ThrowIfCancellationRequested();
                requests.Add(SendSessionUpdateAsync(api, cancellation));
            }

            var remaining = TimeSpan.FromSeconds(seconds) - stopwatch.Elapsed;
            if (remaining > TimeSpan.Zero)
                await Task.Delay(remaining, cancellation);
            int pending = requests.Count(task => !task.IsCompleted);
            double schedulingSeconds = stopwatch.Elapsed.TotalSeconds;
            var results = await Task.WhenAll(requests);
            stopwatch.Stop();
            cancellation.ThrowIfCancellationRequested();

            int ok = results.Count(r => r.StatusCode == 200);
            int tooManyRequests = results.Count(r => r.StatusCode == 429);
            int otherHttp = results.Count(r => r.StatusCode.HasValue && r.StatusCode != 200 && r.StatusCode != 429);
            int timeouts = results.Count(r => r.TimedOut);
            int errors = results.Count(r => !r.StatusCode.HasValue && !r.TimedOut);
            Console.WriteLine($"{rate,6} | {count,5} | {ok,3} | {tooManyRequests,3} | {otherHttp,10} | " +
                $"{timeouts,8} | {errors,6} | {count / stopwatch.Elapsed.TotalSeconds,12:F1} | " +
                $"{results.Average(r => r.Milliseconds),6:F0} | {results.Max(r => r.Milliseconds),6:F0} | {pending}");
            if (schedulingSeconds > seconds + 0.5)
                Console.WriteLine($"  Scheduling overran: {schedulingSeconds:F1}s for a {seconds}s stage; target rate was not sustained.");
            foreach (var group in results.Where(r => r.StatusCode != 200).GroupBy(r => r.Detail))
                Console.WriteLine($"  {group.Count()} x {group.Key}");
            return results;
        }

        private static async Task<RequestResult> SendSessionUpdateAsync(IIntegrationApi api, CancellationToken cancellation)
        {
            using var deadline = CancellationTokenSource.CreateLinkedTokenSource(cancellation);
            deadline.CancelAfter(TimeSpan.FromSeconds(30));
            var stopwatch = Stopwatch.StartNew();
            try
            {
                // Unique IDs avoid concurrent updates to the same session. Dry runs
                // evaluate the request without persisting thousands of test sessions.
                var body = new IntegrationRequest(new NewCustomerSessionV2
                {
                    CartItems = new List<CartItem>
                    {
                        new CartItem(name: "Rate-limit test", sku: "rate-limit-test", quantity: 1, price: 5.5m)
                    }
                });
                var response = await api.UpdateCustomerSessionV2Async(
                    "rate-limit-" + Guid.NewGuid().ToString("N"), body, dry: true, cancellationToken: deadline.Token);
                return new RequestResult
                {
                    StatusCode = (int)response.StatusCode,
                    Milliseconds = stopwatch.Elapsed.TotalMilliseconds,
                    Detail = $"HTTP {(int)response.StatusCode} ({response.ReasonPhrase})"
                };
            }
            catch (OperationCanceledException) when (!cancellation.IsCancellationRequested)
            {
                return new RequestResult { TimedOut = true, Milliseconds = stopwatch.Elapsed.TotalMilliseconds, Detail = "Request timed out" };
            }
            catch (Exception exception) when (!(exception is OperationCanceledException))
            {
                return new RequestResult
                {
                    Milliseconds = stopwatch.Elapsed.TotalMilliseconds,
                    Detail = exception.GetType().Name + ": " + exception.Message
                };
            }
        }

        private sealed class RequestResult
        {
            public int? StatusCode { get; set; }
            public bool TimedOut { get; set; }
            public double Milliseconds { get; set; }
            public string Detail { get; set; }
        }
    }
}
