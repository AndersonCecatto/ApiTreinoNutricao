using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("menu");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Titulo).HasColumnName("titulo").HasColumnType("varchar(30)");
            builder.Property(p => p.Icone).HasColumnName("icone").HasColumnType("varchar(30)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");
        }
    }
}
