using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class ProjetoMap : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.ToTable("projeto");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(250)");
            builder.Property(p => p.PlanoAlimentar).HasColumnName("planoalimentar").HasColumnType("bool");
            builder.Property(p => p.Treino).HasColumnName("treino").HasColumnType("bool");
            builder.Property(p => p.Foto).HasColumnName("foto").HasColumnType("bool");
            builder.Property(p => p.Exame).HasColumnName("exame").HasColumnType("bool");
            builder.Property(p => p.Avaliacao).HasColumnName("avaliacao").HasColumnType("bool");
            builder.Property(p => p.Anamnese).HasColumnName("anamnese").HasColumnType("bool");
            builder.Property(p => p.Observacoes).HasColumnName("observacoes").HasColumnType("varchar(350)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.EmpresaId).HasColumnName("empresa_id").HasColumnType("int");
            builder.HasOne(p => p.Empresa);
        }
    }
}
