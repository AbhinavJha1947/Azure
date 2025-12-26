using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace AzureDemos.Redis
{
    public class RedisPubSubDemo
    {
        private readonly ConnectionMultiplexer _redis;

        public RedisPubSubDemo(string connectionString)
        {
            _redis = ConnectionMultiplexer.Connect(connectionString);
        }

        public async Task PublishMessageAsync(string channel, string message)
        {
            var pub = _redis.GetSubscriber();
            await pub.PublishAsync(channel, message);
            Console.WriteLine($"Published to {channel}: {message}");
        }

        public void SubscribeToChannel(string channel)
        {
            var sub = _redis.GetSubscriber();
            sub.Subscribe(channel, (ch, msg) => {
                Console.WriteLine($"Received on {ch}: {msg}");
            });
            Console.WriteLine($"Subscribed to {channel}");
        }
    }
}
