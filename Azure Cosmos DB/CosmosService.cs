using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;

namespace AzureDemos.Cosmos
{
    public class CosmosService
    {
        private readonly CosmosClient _client;
        private readonly Container _container;

        public CosmosService(string connectionString, string databaseId, string containerId)
        {
            _client = new CosmosClient(connectionString);
            _container = _client.GetContainer(databaseId, containerId);
        }

        public async Task AddItemAsync<T>(T item, string partitionKey)
        {
            await _container.CreateItemAsync(item, new PartitionKey(partitionKey));
        }

        public async Task<T> GetItemAsync<T>(string id, string partitionKey)
        {
            try
            {
                ItemResponse<T> response = await _container.ReadItemAsync<T>(id, new PartitionKey(partitionKey));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return default;
            }
        }

        public async Task QueryItemsAsync(string queryString)
        {
            var queryDefinition = new QueryDefinition(queryString);
            using FeedIterator<dynamic> queryResultSetIterator = _container.GetItemQueryIterator<dynamic>(queryDefinition);

            while (queryResultSetIterator.HasMoreResults)
            {
                FeedResponse<dynamic> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                foreach (var item in currentResultSet)
                {
                    // Process item
                }
            }
        }
    }
}
