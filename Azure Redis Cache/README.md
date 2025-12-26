# Azure Redis Cache Demo

Azure Cache for Redis provides an in-memory data store based on the Redis software.

## Key Concepts for Interviews

- **Distributed Caching**: Shared cache across multiple application instances to improve performance and scalability.
- **Cache-Aside Pattern**: 
    1. App checks cache for data.
    2. If found (Cache Hit), return data.
    3. If not found (Cache Miss), fetch from DB, update cache, and return data.
- **Data Types**: Strings, Lists, Sets, Hashes, Sorted Sets.
- **Eviction Policies**: How Redis chooses what to delete when memory is full (e.g., LRU - Least Recently Used).
- **TTL (Time to Live)**: Expiration time for cached items to prevent stale data.

## Included Demos

1. **RedisService.cs**: Implementation using `StackExchange.Redis` for basic CRUD operations and the Cache-Aside pattern.
