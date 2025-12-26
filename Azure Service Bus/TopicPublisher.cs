using Azure.Messaging.ServiceBus;
using System;
using System.Threading.Tasks;

namespace AzureDemos.ServiceBus
{
    public class TopicPublisher
    {
        private const string connectionString = "YOUR_CONNECTION_STRING";
        private const string topicName = "mytopic";

        public async Task PublishMessageAsync(string messageBody, string category)
        {
            await using var client = new ServiceBusClient(connectionString);
            ServiceBusSender sender = client.CreateSender(topicName);

            ServiceBusMessage message = new ServiceBusMessage(messageBody);
            
            // Add custom properties for subscription filtering
            message.ApplicationProperties.Add("Category", category);

            await sender.SendMessageAsync(message);

            Console.WriteLine($"Published message to topic '{topicName}': {messageBody} (Category: {category})");
        }
    }
}
