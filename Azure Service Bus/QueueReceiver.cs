using Azure.Messaging.ServiceBus;
using System;
using System.Threading.Tasks;

namespace AzureDemos.ServiceBus
{
    public class QueueReceiver
    {
        private const string connectionString = "YOUR_CONNECTION_STRING";
        private const string queueName = "myqueue";

        public async Task ReceiveMessagesAsync()
        {
            await using var client = new ServiceBusClient(connectionString);
            ServiceBusReceiver receiver = client.CreateReceiver(queueName);

            // Receive messages using Peek-Lock mode (default)
            while (true)
            {
                ServiceBusReceivedMessage message = await receiver.ReceiveMessageAsync(TimeSpan.FromSeconds(5));
                
                if (message != null)
                {
                    try
                    {
                        Console.WriteLine($"Received: {message.Body}");
                        
                        // Process the message here
                        
                        // Complete the message (removes it from the queue)
                        await receiver.CompleteMessageAsync(message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing message: {ex.Message}");
                        
                        // Abandon the message (returns it to the queue for reprocessing)
                        await receiver.AbandonMessageAsync(message);
                        
                        // Or move to Dead Letter Queue if it's a poison message
                        // await receiver.DeadLetterMessageAsync(message, "ProcessingFailed", ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No messages available.");
                    break;
                }
            }
        }
    }
}
