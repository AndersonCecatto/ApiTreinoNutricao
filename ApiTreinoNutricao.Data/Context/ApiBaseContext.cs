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

            modelBuilder.Entity<Empresa>(new EmpresaMap().Configure);
        }
    }
}
