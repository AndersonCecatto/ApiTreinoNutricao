using ApiTreinoNutricao.Data.Mapping;
using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Context
{
    public class ApiBaseContext : DbContext
    {
        public ApiBaseContext(DbContextOptions<ApiBaseContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alimento>(new AlimentoMap().Configure);
            //modelBuilder.Entity<ArquivoPlanoAlimentar>(new ArquivoPlanoAlimentarMap().Configure);
            //modelBuilder.Entity<ArquivoTreino>(new ArquivoTreinoMap().Configure);
            modelBuilder.Entity<Empresa>(new EmpresaMap().Configure);
            modelBuilder.Entity<Exercicio>(new ExercicioMap().Configure);
            modelBuilder.Entity<PlanoAlimentar>(new PlanoAlimentarMap().Configure);
            modelBuilder.Entity<PlanoAlimentarAlimento>(new PlanoAlimentarAlimentoMap().Configure);
            modelBuilder.Entity<Projeto>(new ProjetoMap().Configure);
            modelBuilder.Entity<ProjetoAluno>(new ProjetoAlunoMap().Configure);
            modelBuilder.Entity<Treino>(new TreinoMap().Configure);
            modelBuilder.Entity<TreinoExercicio>(new TreinoExercicioMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Menu>(new MenuMap().Configure);
            modelBuilder.Entity<MenuUsuario>(new MenuUsuarioMap().Configure);
            modelBuilder.Entity<Anamnese>(new AnamnesiaMap().Configure);
            modelBuilder.Entity<Avaliacao>(new AvaliacaoMap().Configure);
        }
    }
}
