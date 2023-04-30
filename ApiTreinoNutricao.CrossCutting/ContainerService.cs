using ApiTreinoNutricao.Data.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ApiTreinoNutricao.CrossCutting
{
    public static class ContainerService
    {
        public static IServiceCollection AddApplicationServicesCollections(this IServiceCollection services)
        {
            services.AddServices();
            services.AddRepositories();
            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEmpresaService, EmpresaService>();
            return services;
        }
    }
}
