# Azure Key Vault Integration Pattern

## Overview
Azure Key Vault is used to safeguard cryptographic keys and secrets used by cloud applications and services.

## Key Concepts

- **Secrets**: Connection strings, API keys, passwords
- **Keys**: Encryption keys (RSA, EC)
- **Certificates**: SSL/TLS certificates
- **Access Policies vs RBAC**: Two ways to control access to vault resources
- **Managed Identity**: Apps can access Key Vault without storing credentials

## Integration Example (C#)

```csharp
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

public class KeyVaultService
{
    private readonly SecretClient _client;

    public KeyVaultService(string keyVaultUrl)
    {
        // Uses DefaultAzureCredential which works with Managed Identity
        _client = new SecretClient(
            new Uri(keyVaultUrl), 
            new DefaultAzureCredential()
        );
    }

    public async Task<string> GetSecretAsync(string secretName)
    {
        KeyVaultSecret secret = await _client.GetSecretAsync(secretName);
        return secret.Value;
    }
}
```

## App Service Integration

In App Service, reference Key Vault secrets directly in Application Settings:

```
@Microsoft.KeyVault(SecretUri=https://myvault.vault.azure.net/secrets/DatabasePassword/)
```

## Interview Questions

1. **Q: What's the difference between Access Policies and RBAC?**
   - Access Policies: Vault-level permissions (legacy)
   - RBAC: Azure AD-based, more granular, recommended

2. **Q: How does Managed Identity work with Key Vault?**
   - App gets an identity in Azure AD
   - No credentials needed in code
   - Azure handles token exchange automatically
