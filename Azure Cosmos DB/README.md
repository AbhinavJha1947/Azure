# Azure Cosmos DB Demo

Azure Cosmos DB is a globally distributed, multi-model database service.

## Key Concepts for Interviews

- **Partitioning**: 
    - **Partition Key**: Critical for scalability. Choose a key with high cardinality.
    - **Logical Partitions**: Grouped by partition key.
    - **Physical Partitions**: Azure manages these based on throughput and storage.
- **Request Units (RUs)**: The currency of Cosmos DB. Measures CPU, IOPS, and memory.
- **Consistency Levels**:
    - **Strong**: Linearizable.
    - **Bounded Staleness**: Lag by time or versions.
    - **Session**: Consistent prefix (Default and most popular).
    - **Consistent Prefix**: No gaps in order.
    - **Eventual**: No ordering guarantee.
- **Throughput**: Provisioned (Manual or Autoscale) vs. Serverless.
- **Change Feed**: Listen for changes in a container and trigger actions.

## Included Demos

1. **CosmosService.cs**: Basic CRUD operations using the .NET SDK.
2. **README.md**: Detailed consistency and partitioning guide.
