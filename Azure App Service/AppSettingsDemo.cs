using Microsoft.Extensions.Configuration;

namespace AzureDemos.AppService
{
    public class ConfigurationDemo
    {
        private readonly IConfiguration _config;

        public ConfigurationDemo(IConfiguration config)
        {
            _config = config;
        }

        public string GetDatabaseConnectionString()
        {
            // In Azure App Service, this value is typically set in the "Configuration" blade
            // and overrides any value in appsettings.json
            return _config.GetConnectionString("DefaultConnection");
        }

        public string GetCustomSecret()
        {
            // Accessing a custom setting (Environment Variable)
            return _config["MySecretKey"];
        }
    }
}
