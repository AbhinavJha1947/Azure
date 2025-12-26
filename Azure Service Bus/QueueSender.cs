using Azure.Messaging.ServiceBus;
using System;
using System.Threading.Tasks;

namespace AzureDemos.ServiceBus
{
    public class QueueSender
    {
        private const string connectionString = "YOUR_CONNECTION_STRING";
        private const string queueName = "myqueue";

        public async Task SendMessageAsync(string messageBody)
        {
            await using var client = new ServiceBusClient(connectionString);
            ServiceBusSender sender = client.CreateSender(queueName);

            ServiceBusMessage message = new ServiceBusMessage(messageBody);
            await sender.SendMessageAsync(message);

            Console.WriteLine($"Sent message: {messageBody}");
        }
    }
}
