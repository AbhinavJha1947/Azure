using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Azure.Security.KeyVault.Keys;
using System;
using System.Threading.Tasks;

namespace AzureDemos.KeyVault
{
    public class KeyVaultManager
    {
        private readonly SecretClient _secretClient;
        private readonly KeyClient _keyClient;

        public KeyVaultManager(string vaultUri)
        {
            var uri = new Uri(vaultUri);
            // Uses Managed Identity in Azure, or local credentials (VS, CLI) during development
            var credential = new DefaultAzureCredential();

            _secretClient = new SecretClient(uri, credential);
            _keyClient = new KeyClient(uri, credential);
        }

        public async Task<string> GetSecretAsync(string secretName)
        {
            KeyVaultSecret secret = await _secretClient.GetSecretAsync(secretName);
            return secret.Value;
        }

        public async Task SetSecretAsync(string secretName, string secretValue)
        {
            await _secretClient.SetSecretAsync(secretName, secretValue);
        }

        public async Task CreateRsaKeyAsync(string keyName)
        {
            await _keyClient.CreateRsaKeyAsync(new CreateRsaKeyOptions(keyName)
            {
                KeySize = 2048
            });
        }
    }
}
