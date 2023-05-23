using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class ExercicioMap : IEntityTypeConfiguration<Exercicio>
    {
        public void Configure(EntityTypeBuilder<Exercicio> builder)
        {
            builder.ToTable("exercicio");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(250)");
            builder.Property(p => p.Serie).HasColumnName("serie").HasColumnType("varchar(50)");
            builder.Property(p => p.TempoDescanso).HasColumnName("tempo_descanso").HasColumnType("varchar(50)");
            builder.Property(p => p.Repeticoes).HasColumnName("repeticoes").HasColumnType("varchar(50)");
            builder.Property(p => p.Tecnica).HasColumnName("tecnica").HasColumnType("varchar(50)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.EmpresaId).HasColumnName("empresa_id").HasColumnType("int");
            builder.HasOne(p => p.Empresa);
        }
    }
}
