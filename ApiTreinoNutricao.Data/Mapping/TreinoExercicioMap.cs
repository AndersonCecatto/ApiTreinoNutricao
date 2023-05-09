using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class TreinoExercicioMap : IEntityTypeConfiguration<TreinoExercicio>
    {
        public void Configure(EntityTypeBuilder<TreinoExercicio> builder)
        {
            builder.ToTable("treino_exercicio");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Observacoes).HasColumnName("observacoes").HasColumnType("varchar(500)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.TreinoId).HasColumnName("treino_id").HasColumnType("int");
            builder.HasOne(p => p.Treino);

            builder.Property(p => p.ExercicioId).HasColumnName("exercicio_id").HasColumnType("int");
            builder.HasOne(p => p.Exercicio);
        }
    }
}
