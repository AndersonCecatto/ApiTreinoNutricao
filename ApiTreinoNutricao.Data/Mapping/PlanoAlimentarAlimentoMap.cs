using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class PlanoAlimentarAlimentoMap : IEntityTypeConfiguration<PlanoAlimentarAlimento>
    {
        public void Configure(EntityTypeBuilder<PlanoAlimentarAlimento> builder)
        {
            builder.ToTable("plano_alimentar_alimento");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Observacoes).HasColumnName("observacoes").HasColumnType("varchar(500)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.AlimentoId).HasColumnName("alimento_id").HasColumnType("int");
            builder.HasOne(p => p.Alimento);

            builder.Property(p => p.PlanoAlimentarId).HasColumnName("plano_alimentar_id").HasColumnType("int");
            builder.HasOne(p => p.PlanoAlimentar);
        }
    }
}
