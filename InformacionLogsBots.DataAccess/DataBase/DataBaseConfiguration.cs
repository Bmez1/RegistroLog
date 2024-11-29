using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using InformacionLogsBots.DataAccess.Dtos;
using Newtonsoft.Json.Linq;

namespace InformacionLogsBots.DataAccess.DataBase
{
    internal static class DataBaseConfiguration
    {
        public const string Schema = "logs";

        public static string ObtenerCadenaConexionBaseDatos(CredencialesKeyVaultDto credencialesKeyVault)
        {
            var secreto = ObtenerSecretoAsync(credencialesKeyVault);
            var secretData = JObject.Parse(secreto);
            var server = secretData["host"]?.ToString() ?? string.Empty;
            var port = secretData["port"]?.ToString() ?? string.Empty;
            var database = secretData["database"]?.ToString() ?? string.Empty;
            var username = secretData["user"]?.ToString() ?? string.Empty;
            var password = secretData["password"]?.ToString() ?? string.Empty;

            return $"Server={server},{port};Database={database};User Id={username};Password={password};TrustServerCertificate=True";
        }

        private static string ObtenerSecretoAsync(CredencialesKeyVaultDto credencialesKeyVault)
        {
            try
            {
                var secretClient = new SecretClient(credencialesKeyVault.KeyVaultUri, new ClientSecretCredential(
                    credencialesKeyVault.TenantId, credencialesKeyVault.ClientId, credencialesKeyVault.ClientSecret));

                var secreto = secretClient.GetSecret(credencialesKeyVault.NameSecret);

                return secreto.Value.Value;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error al consumir el secreto {credencialesKeyVault.NameSecret}", ex);
            }

        }

        public static CredencialesKeyVaultDto ObtenerParametrosKeyVault()
        {
            // Obtener la configuración de Key Vault desde variables de entorno
            var keyVaultUri = new Uri(Environment.GetEnvironmentVariable("AZURE_KEY_VAULT_URL")!);
            var tenantId = Environment.GetEnvironmentVariable("AZURE_TENANT_ID")!;
            var clientId = Environment.GetEnvironmentVariable("AZURE_CLIENT_ID")!;
            var clientSecret = Environment.GetEnvironmentVariable("AZURE_SECRET_ID")!;
            var secretKeyName = Environment.GetEnvironmentVariable("AZURE_SECRET_DB")!;

            return new CredencialesKeyVaultDto(keyVaultUri, tenantId, clientId, clientSecret, secretKeyName);
        }

        public static CredencialesKeyVaultDto ObtenerParametrosKeyVault(JToken environmentVariables)
        {
            string azureKeyVaultUrl = environmentVariables["AZURE_KEY_VAULT_URL"]?.ToString() ?? string.Empty;
            string tenantId = environmentVariables["AZURE_TENANT_ID"]?.ToString() ?? string.Empty;
            string clientId = environmentVariables["AZURE_CLIENT_ID"]?.ToString() ?? string.Empty;
            string clientSecret = environmentVariables["AZURE_SECRET_ID"]?.ToString() ?? string.Empty;
            string azureSecretDb = environmentVariables["AZURE_SECRET_DB"]?.ToString() ?? string.Empty;

            var keyVaultUri = new Uri(azureKeyVaultUrl!);

            return new CredencialesKeyVaultDto(keyVaultUri, tenantId, clientId, clientSecret, azureSecretDb);
        }
    }
}
