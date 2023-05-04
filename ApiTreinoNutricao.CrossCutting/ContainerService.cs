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
            services.AddScoped<IAlimentoRepository, AlimentoRepository>();
            services.AddScoped<IArquivoPlanoAlimentarRepository, ArquivoPlanoAlimentarRepository>();
            services.AddScoped<IArquivoTreinoRepository, ArquivoTreinoRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IExercicioRepository, ExercicioRepository>();
            services.AddScoped<IPlanoAlimentarAlimentoRepository, PlanoAlimentarAlimentoRepository>();
            services.AddScoped<IPlanoAlimentarRepository, PlanoAlimentarRepository>();
            services.AddScoped<IProjetoRepository, ProjetoRepository>();
            services.AddScoped<IProjetoAlunoRepository, ProjetoAlunoRepository>();
            services.AddScoped<ITreinoExercicioRepository, TreinoExercicioRepository>();
            services.AddScoped<ITreinoRepository, TreinoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAlimentoService, AlimentoService>();
            services.AddScoped<IArquivoPlanoAlimentarService, ArquivoPlanoAlimentarService>();
            services.AddScoped<IArquivoTreinoService, ArquivoTreinoService>();
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IExercicioService, ExercicioService>();
            services.AddScoped<IPlanoAlimentarAlimentoService, PlanoAlimentarAlimentoService>();
            services.AddScoped<IPlanoAlimentarService, PlanoAlimentarService>();
            services.AddScoped<IProjetoService, ProjetoService>();
            services.AddScoped<IProjetoAlunoService, ProjetoAlunoService>();
            services.AddScoped<ITreinoExercicioService, TreinoExercicioService>();
            services.AddScoped<ITreinoService, TreinoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            return services;
        }
    }
}
