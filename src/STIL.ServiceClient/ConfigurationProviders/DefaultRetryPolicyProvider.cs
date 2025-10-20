using System;
using System.Net.Http;

using Polly;
using Polly.Extensions.Http;
using Polly.Retry;

namespace STIL.ServiceClient.ConfigurationProviders
{
    /// <summary>
    /// Default retry policy provider.
    /// </summary>
    public class DefaultRetryPolicyProvider : IRetryPolicyProvider
    {
        private static AsyncRetryPolicy<HttpResponseMessage> DefaultRetryPolicy { get; } = Policy.Handle<HttpRequestException>()
            .OrTransientHttpError()
            .WaitAndRetryAsync(
                retryCount: 1,
                sleepDurationProvider: retryAttempt =>
                    TimeSpan.FromSeconds(5));

        /// <inheritdoc />
        public AsyncRetryPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return DefaultRetryPolicy;
        }
    }
}
