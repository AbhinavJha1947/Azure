# Azure Storage Patterns

## Storage Account Types

- **Blob Storage**: Object storage (images, videos, backups)
- **File Storage**: SMB file shares
- **Queue Storage**: Simple message queuing
- **Table Storage**: NoSQL key-value store

## Access Tiers (Blob)

- **Hot**: Frequently accessed data, higher storage cost, lower access cost
- **Cool**: Infrequently accessed (30 days minimum), lower storage cost
- **Archive**: Rarely accessed (180 days minimum), lowest cost, retrieval takes hours

## Common Patterns

### 1. Static Website Hosting
```bash
# Enable static website hosting on storage account
az storage blob service-properties update \
    --account-name mystorageaccount \
    --static-website \
    --index-document index.html \
    --404-document 404.html
```

### 2. Blob Lifecycle Management
Automatically transition blobs between tiers or delete them:
```json
{
  "rules": [
    {
      "name": "moveToArchive",
      "type": "Lifecycle",
      "definition": {
        "filters": {
          "blobTypes": ["blockBlob"]
        },
        "actions": {
          "baseBlob": {
            "tierToCool": { "daysAfterModificationGreaterThan": 30 },
            "tierToArchive": { "daysAfterModificationGreaterThan": 90 },
            "delete": { "daysAfterModificationGreaterThan": 365 }
          }
        }
      }
    }
  ]
}
```

### 3. SAS Tokens (Shared Access Signature)
Grant limited access to storage resources without exposing account keys:

```csharp
using Azure.Storage.Blobs;
using Azure.Storage.Sas;

public string GenerateSasToken(string containerName, string blobName)
{
    var blobClient = new BlobClient(connectionString, containerName, blobName);
    
    var sasBuilder = new BlobSasBuilder
    {
        BlobContainerName = containerName,
        BlobName = blobName,
        Resource = "b",
        ExpiresOn = DateTimeOffset.UtcNow.AddHours(1)
    };
    
    sasBuilder.SetPermissions(BlobSasPermissions.Read);
    
    return blobClient.GenerateSasUri(sasBuilder).ToString();
}
```

## Interview Tips

- **Redundancy**: LRS (3 copies locally) → ZRS (3 zones) → GRS (secondary region) → RA-GRS (read access to secondary)
- **Performance**: Standard (HDD) vs Premium (SSD)
- **Use Queue Storage** for simple messaging; **Service Bus** for enterprise features
