using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("avaliacao");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(500)");
            builder.Property(p => p.MetabolismoBasal).HasColumnName("metabolismo_basal").HasColumnType("numeric(18,2)");
            builder.Property(p => p.TreinoKcal).HasColumnName("treino_kcal").HasColumnType("numeric(18,2)");
            builder.Property(p => p.Cardio).HasColumnName("cardio").HasColumnType("numeric(18,2)");
            builder.Property(p => p.Data).HasColumnName("data_avaliacao").HasColumnType("timestamp");
            builder.Property(p => p.Peso).HasColumnName("peso").HasColumnType("numeric(18,2)");
            builder.Property(p => p.MassaMuscular).HasColumnName("massa_muscular").HasColumnType("numeric(18,2)");
            builder.Property(p => p.IdadeCorporal).HasColumnName("idade_corporal").HasColumnType("int");
            builder.Property(p => p.IMC).HasColumnName("imc").HasColumnType("numeric(18,2)");
            builder.Property(p => p.GorduraCorporal).HasColumnName("gordura_corporal").HasColumnType("numeric(18,2)");
            builder.Property(p => p.GorduraViceral).HasColumnName("gordura_viceral").HasColumnType("numeric(18,2)");
            builder.Property(p => p.Pernas).HasColumnName("pernas").HasColumnType("numeric(18,2)");
            builder.Property(p => p.KgMassaMagra).HasColumnName("kg_massa_magra").HasColumnType("numeric(18,2)");
            builder.Property(p => p.KgGordura).HasColumnName("kg_gordura").HasColumnType("numeric(18,2)");
            builder.Property(p => p.RelacaoAbdomenOmbro).HasColumnName("relacao_abdomen_ombro").HasColumnType("numeric(18,2)");
            builder.Property(p => p.RelacaoAbdomenPeito).HasColumnName("relacao_abdomen_peito").HasColumnType("numeric(18,2)");
            builder.Property(p => p.Ombro).HasColumnName("ombro").HasColumnType("numeric(18,2)");
            builder.Property(p => p.Peito).HasColumnName("peito").HasColumnType("numeric(18,2)");
            builder.Property(p => p.BracoDireito).HasColumnName("braco_direito").HasColumnType("numeric(18,2)");
            builder.Property(p => p.BrasoEsquerdo).HasColumnName("braco_esquerdo").HasColumnType("numeric(18,2)");
            builder.Property(p => p.Cintura).HasColumnName("cintura").HasColumnType("numeric(18,2)");
            builder.Property(p => p.Abdomen).HasColumnName("abdomen").HasColumnType("numeric(18,2)");
            builder.Property(p => p.PernasInferiores).HasColumnName("pernas_inferior").HasColumnType("numeric(18,2)");
            builder.Property(p => p.PernaDireita).HasColumnName("perna_direita").HasColumnType("numeric(18,2)");
            builder.Property(p => p.PernaEsquerda).HasColumnName("perna_esquerda").HasColumnType("numeric(18,2)");
            builder.Property(p => p.PanturilhaDireita).HasColumnName("panturilha_direita").HasColumnType("numeric(18,2)");
            builder.Property(p => p.PanturilhaEsquerda).HasColumnName("panturilha_esquerda").HasColumnType("numeric(18,2)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.EmpresaId).HasColumnName("empresa_id").HasColumnType("int");
            builder.HasOne(p => p.Empresa);

            builder.Property(p => p.UsuarioId).HasColumnName("usuario_id").HasColumnType("int");
            builder.HasOne(p => p.Usuario);
        }
    }
}
