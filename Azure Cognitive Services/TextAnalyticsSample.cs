using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureDemos.CognitiveServices
{
    public class TextAnalyticsSample
    {
        private static string subscriptionKey = "YOUR_KEY";
        private static string endpoint = "YOUR_ENDPOINT";

        public async Task AnalyzeSentimentAsync(string text)
        {
            var credentials = new ApiKeyServiceClientCredentials(subscriptionKey);
            var client = new TextAnalyticsClient(credentials)
            {
                Endpoint = endpoint
            };

            var result = await client.SentimentAsync(
                text,
                "en"
            );

            Console.WriteLine($"Sentiment Score: {result.Score:0.00}");
            Console.WriteLine(result.Score >= 0.6 ? "Positive sentiment" : 
                             result.Score <= 0.4 ? "Negative sentiment" : 
                             "Neutral sentiment");
        }

        public async Task ExtractKeyPhrasesAsync(string text)
        {
            var credentials = new ApiKeyServiceClientCredentials(subscriptionKey);
            var client = new TextAnalyticsClient(credentials)
            {
                Endpoint = endpoint
            };

            var result = await client.KeyPhrasesAsync(text, "en");

            Console.WriteLine("Key Phrases:");
            foreach (var phrase in result.KeyPhrases)
            {
                Console.WriteLine($"  - {phrase}");
            }
        }
    }
}
