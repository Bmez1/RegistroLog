using InformacionLogsBots.Application.Interfaces;
using InformacionLogsBots.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InformacionLogsBots.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ILogService, LogService>();
            return services;
        }
    }
}
