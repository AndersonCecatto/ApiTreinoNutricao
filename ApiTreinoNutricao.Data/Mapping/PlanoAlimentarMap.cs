using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class PlanoAlimentarMap : IEntityTypeConfiguration<PlanoAlimentar>
    {
        public void Configure(EntityTypeBuilder<PlanoAlimentar> builder)
        {
            builder.ToTable("plano_alimentar");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(250)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.UsuarioId).HasColumnName("usuario_id").HasColumnType("int");
            builder.HasOne(p => p.Usuario);

            builder.Property(p => p.EmpresaId).HasColumnName("empresa_id").HasColumnType("int");
            builder.HasOne(p => p.Empresa);
        }
    }
}
