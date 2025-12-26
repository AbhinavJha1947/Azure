using Azure;
using Azure.Messaging.EventGrid;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureDemos.EventGrid
{
    public class EventPublisher
    {
        private readonly string _topicEndpoint;
        private readonly string _topicKey;

        public EventPublisher(string topicEndpoint, string topicKey)
        {
            _topicEndpoint = topicEndpoint;
            _topicKey = topicKey;
        }

        public async Task PublishEventAsync(string eventType, string subject, object data)
        {
            EventGridPublisherClient client = new EventGridPublisherClient(
                new Uri(_topicEndpoint),
                new AzureKeyCredential(_topicKey));

            EventGridEvent egEvent = new EventGridEvent(
                subject: subject,
                eventType: eventType,
                dataVersion: "1.0",
                data: data);

            await client.SendEventAsync(egEvent);
            Console.WriteLine($"Published event: {eventType} - {subject}");
        }
    }
}
