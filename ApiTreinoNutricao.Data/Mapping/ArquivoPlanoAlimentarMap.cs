using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class ArquivoPlanoAlimentarMap : IEntityTypeConfiguration<ArquivoPlanoAlimentar>
    {
        public void Configure(EntityTypeBuilder<ArquivoPlanoAlimentar> builder)
        {
            builder.ToTable("arquivo_plano_alimentar");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(250)");
            builder.Property(p => p.Arquivo).HasColumnName("cpfcnpj").HasColumnType("bytea");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.PlanoAlimentarAlimentoId).HasColumnName("plano_alimentar_id").HasColumnType("int");
            builder.HasOne(p => p.PlanoAlimentarAlimento);
        }
    }
}
