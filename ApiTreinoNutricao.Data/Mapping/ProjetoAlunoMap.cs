using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class ProjetoAlunoMap : IEntityTypeConfiguration<ProjetoAluno>
    {
        public void Configure(EntityTypeBuilder<ProjetoAluno> builder)
        {
            builder.ToTable("projeto_aluno");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.ProjetoId).HasColumnName("projeto_id").HasColumnType("int");
            builder.HasOne(p => p.Projeto);

            builder.Property(p => p.UsuarioId).HasColumnName("usuario_id").HasColumnType("int");
            builder.HasOne(p => p.Usuario);

            builder.Property(p => p.PlanoAlimentarId).HasColumnName("plano_alimentar_id").HasColumnType("int");
            builder.HasOne(p => p.PlanoAlimentar);

            builder.Property(p => p.TreinoId).HasColumnName("treino_id").HasColumnType("int");
            builder.HasOne(p => p.Treino);

        }
    }
}
