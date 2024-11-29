using InformacionLogsBots.Common.Interfaces;
using InformacionLogsBots.Common.Services;
using InformacionLogsBots.DataAccess.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InformacionLogsBots.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IRegistroLogService, RegistroLogService>();

            var connectionString = DataBaseConfiguration.ObtenerCadenaConexionBaseDatos(DataBaseConfiguration.ObtenerParametrosKeyVault());
            services.AddDbContext<LogContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }
    }
}
