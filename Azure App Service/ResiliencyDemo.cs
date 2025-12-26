using Polly;
using Polly.Retry;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzureDemos.AppService
{
    public class ResiliencyDemo
    {
        private readonly HttpClient _httpClient;
        private readonly AsyncRetryPolicy<HttpResponseMessage> _retryPolicy;

        public ResiliencyDemo(HttpClient httpClient)
        {
            _httpClient = httpClient;

            // Define a retry policy: Retry 3 times with exponential backoff
            // Handles transient HTTP errors (5xx, 408)
            _retryPolicy = Policy
                .HandleResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                .WaitAndRetryAsync(3, retryAttempt => 
                    TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))
                );
        }

        public async Task<string> GetDataWithRetryAsync(string url)
        {
            return await _retryPolicy.ExecuteAsync(async () =>
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            });
        }
        
        // Circuit Breaker Pattern Example
        public void ConfigureCircuitBreaker()
        {
            var circuitBreaker = Policy
                .Handle<Exception>()
                .CircuitBreakerAsync(
                    exceptionsAllowedBeforeBreaking: 5,
                    durationOfBreak: TimeSpan.FromMinutes(1)
                );
        }
    }
}
