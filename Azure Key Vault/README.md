# Azure Key Vault Demo

Azure Key Vault is a cloud service for securely storing and accessing secrets.

## Key Concepts for Interviews

- **Secrets**: Passwords, connection strings, API keys.
- **Keys**: Cryptographic keys (RSA, EC).
- **Certificates**: X.509 certificates.
- **Security**:
    - **Managed Identity**: Access Key Vault without credentials in code.
    - **Access Policies**: Legacy vault-level access.
    - **Azure RBAC**: Modern, granular identity-based access.
- **Soft Delete & Purge Protection**: Prevents accidental or malicious deletion.
- **Network Isolation**: Use Private Endpoints to restrict access.

## Included Demos

1. **KeyVaultManager.cs**: Fetching secrets and managing keys.
2. **README.md**: Managed Identity integration and security best practices.
