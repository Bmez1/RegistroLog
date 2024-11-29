using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Newtonsoft.Json.Linq;

namespace InformacionLogsBots.DataAccess.DataBase.Factory
{
    /// <summary>
    /// Necesaria en tiempo de diseño para que al ejecutar las migraciones consuma el secreto y se conecte a la DB
    /// </summary>
    public class LogContextFactory : IDesignTimeDbContextFactory<LogContext>
    {
        public LogContext CreateDbContext(string[] args)
        {
            var launchSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "Properties", "launchSettings.json");

            if (!File.Exists(launchSettingsPath))
            {
                throw new FileNotFoundException($"No se encontró el archivo {launchSettingsPath}.");
            }

            var json = File.ReadAllText(launchSettingsPath);
            var jObject = JObject.Parse(json);

            var environmentVariables = jObject["profiles"]?["https"]?["environmentVariables"] ??
                throw new InvalidOperationException("No se encontraron las variables de entorno en el archivo launchSettings.json.");

            var optionsBuilder = new DbContextOptionsBuilder<LogContext>();
            var connectionString = DataBaseConfiguration.ObtenerCadenaConexionBaseDatos(DataBaseConfiguration.ObtenerParametrosKeyVault(environmentVariables));

            Console.WriteLine(connectionString);
            optionsBuilder.UseSqlServer(connectionString);

            return new LogContext(optionsBuilder.Options);
        }
    }
}
