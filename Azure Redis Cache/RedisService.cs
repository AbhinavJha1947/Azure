using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace AzureDemos.Redis
{
    public class RedisService
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _db;

        public RedisService(string connectionString)
        {
            _redis = ConnectionMultiplexer.Connect(connectionString);
            _db = _redis.GetDatabase();
        }

        public async Task SetCacheValueAsync(string key, string value, TimeSpan? expiry = null)
        {
            await _db.StringSetAsync(key, value, expiry);
        }

        public async Task<string> GetCacheValueAsync(string key)
        {
            return await _db.StringGetAsync(key);
        }

        // Cache-Aside Pattern Example
        public async Task<string> GetOrSetAsync(string key, Func<Task<string>> dbFetch, TimeSpan expiry)
        {
            var value = await GetCacheValueAsync(key);
            if (value != null) return value;

            value = await dbFetch();
            await SetCacheValueAsync(key, value, expiry);
            return value;
        }
    }
}
