using Azure.Messaging.ServiceBus.Administration;
using System.Threading.Tasks;

namespace AzureDemos.ServiceBus
{
    public class TopicFilterManager
    {
        private const string connectionString = "YOUR_CONNECTION_STRING";
        private const string topicName = "mytopic";

        public async Task CreateSubscriptionWithFilterAsync(string subscriptionName, string category)
        {
            var adminClient = new ServiceBusAdministrationClient(connectionString);

            if (!await adminClient.SubscriptionExistsAsync(topicName, subscriptionName))
            {
                var options = new CreateSubscriptionOptions(topicName, subscriptionName);
                
                // Create subscription with a SQL Filter
                // This subscription will ONLY receive messages where Category = 'category'
                var filterOptions = new CreateRuleOptions
                {
                    Name = "CategoryFilter",
                    Filter = new SqlRuleFilter($"Category = '{category}'")
                };

                await adminClient.CreateSubscriptionAsync(options, filterOptions);
            }
        }

        public async Task AddCorrelationFilterAsync(string subscriptionName, string correlationId)
        {
            var adminClient = new ServiceBusAdministrationClient(connectionString);

            // Correlation filters are more efficient than SQL filters for simple ID matching
            await adminClient.CreateRuleAsync(topicName, subscriptionName, new CreateRuleOptions
            {
                Name = "CorrelationFilter",
                Filter = new CorrelationRuleFilter { CorrelationId = correlationId }
            });
        }
    }
}
