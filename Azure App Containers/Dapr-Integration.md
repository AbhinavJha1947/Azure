# Azure App Containers - Dapr Integration

Azure Container Apps has first-class support for Dapr (Distributed Application Runtime).

## Why Dapr for Interviews?
- **State Management**: Abstracting away the database.
- **Service-to-Service Discovery**: Securely calling other containers.
- **Pub/Sub**: Event-driven communication between services.

## Example Dapr Component (Statestore)
This YAML defines a Redis state store component for ACA.

```yaml
# dapr-statestore.yaml
apiVersion: dapr.io/v1alpha1
kind: Component
metadata:
  name: statestore
spec:
  type: state.redis
  version: v1
  metadata:
  - name: redisHost
    value: my-redis.redis.cache.windows.net:6380
  - name: redisPassword
    secretRef: redis-password
auth:
  secretStore: azurekeyvault
```

## C# Code Usage
```csharp
using Dapr.Client;

public class MyService
{
    private readonly DaprClient _daprClient;

    public MyService(DaprClient daprClient)
    {
        _daprClient = daprClient;
    }

    public async Task SaveStateAsync(string key, string value)
    {
        await _daprClient.SaveStateAsync("statestore", key, value);
    }
}
```
