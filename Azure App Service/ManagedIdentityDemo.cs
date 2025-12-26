using Azure.Identity;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace AzureDemos.AppService
{
    public class ManagedIdentityDemo
    {
        private const string sqlServerConnectionString = "Server=tcp:myserver.database.windows.net,1433;Initial Catalog=mydb;";

        public async Task ConnectToSqlWithoutPasswordAsync()
        {
            // The magic happens here: DefaultAzureCredential automatically picks up
            // the System-Assigned or User-Assigned Managed Identity in Azure.
            var credential = new DefaultAzureCredential();
            
            // For older SQL Client versions, we'd use the token manually.
            // Modern Microsoft.Data.SqlClient supports AAD authentication in the connection string:
            // "Server=...; Authentication=Active Directory Managed Identity;"
            
            using var connection = new SqlConnection(sqlServerConnectionString);
            
            // If using older libraries or specific token requirements:
            // var token = await credential.GetTokenAsync(new Azure.Core.TokenRequestContext(new[] { "https://database.windows.net/.default" }));
            // connection.AccessToken = token.Token;

            await connection.OpenAsync();
            // Perform DB operations...
        }
    }
}
