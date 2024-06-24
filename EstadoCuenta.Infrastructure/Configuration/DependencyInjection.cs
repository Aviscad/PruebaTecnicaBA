using EstadoCuenta.Domain.Interfaces;
using EstadoCuenta.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace EstadoCuenta.Infrastructure.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
