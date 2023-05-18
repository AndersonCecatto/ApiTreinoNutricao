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
            builder.Property(p => p.PlanosAlimentares).HasColumnName("planos_alimentares").HasColumnType("varchar(1000)");
            builder.Property(p => p.Treinos).HasColumnName("treinos").HasColumnType("varchar(350)");
            builder.Property(p => p.Exames).HasColumnName("exames").HasColumnType("varchar(350)");
            builder.Property(p => p.Observacoes).HasColumnName("observacoes").HasColumnType("varchar(350)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.EmpresaId).HasColumnName("empresa_id").HasColumnType("int");
            builder.HasOne(p => p.Empresa);
        }
    }
}
