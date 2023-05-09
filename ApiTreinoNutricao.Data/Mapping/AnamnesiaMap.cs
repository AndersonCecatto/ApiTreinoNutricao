using ApiTreinoNutricao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTreinoNutricao.Data.Mapping
{
    public class AnamnesiaMap : IEntityTypeConfiguration<Anamnese>
    {
        public void Configure(EntityTypeBuilder<Anamnese> builder)
        {
            builder.ToTable("anamnese");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(100)");
            builder.Property(p => p.DataNascimento).HasColumnName("datanascimento").HasColumnType("varchar(12)");
            builder.Property(p => p.Genero).HasColumnName("genero").HasColumnType("int");
            builder.Property(p => p.Ocupacao).HasColumnName("ocupacao").HasColumnType("varchar(100)");
            builder.Property(p => p.Objetivo).HasColumnName("objetivo").HasColumnType("varchar(200)");
            builder.Property(p => p.Diabetes).HasColumnName("diabetes").HasColumnType("bool");
            builder.Property(p => p.PreDiabetes).HasColumnName("pre_diabetes").HasColumnType("bool");
            builder.Property(p => p.Hipotireoidismo).HasColumnName("hipotireoidismo").HasColumnType("bool");
            builder.Property(p => p.Gastrite).HasColumnName("gastrite").HasColumnType("bool");
            builder.Property(p => p.Hipertensao).HasColumnName("hipertensao").HasColumnType("bool");
            builder.Property(p => p.Dislipidemia).HasColumnName("dislipidemia").HasColumnType("bool");
            builder.Property(p => p.Ansiedade).HasColumnName("ansiedade").HasColumnType("bool");
            builder.Property(p => p.DoencaRenalCronica).HasColumnName("doenca_renal_cronica").HasColumnType("bool");
            builder.Property(p => p.DoencasRespiratorias).HasColumnName("doencas_respiratorias").HasColumnType("bool");
            builder.Property(p => p.Colite).HasColumnName("colite").HasColumnType("bool");
            builder.Property(p => p.Triglicerides).HasColumnName("triglicerides").HasColumnType("bool");
            builder.Property(p => p.DoencasCardiovasculares).HasColumnName("doencas_cardiovasculares").HasColumnType("bool");
            builder.Property(p => p.TranstornosAlimentares).HasColumnName("transtornos_alimentares").HasColumnType("bool");
            builder.Property(p => p.Fumante).HasColumnName("fumante").HasColumnType("bool");
            builder.Property(p => p.BebidaAlcoolica).HasColumnName("bebidaalcoolica").HasColumnType("bool");
            builder.Property(p => p.FrequenciaBebidaAlcoolica).HasColumnName("frequencia_bebida_alcoolica").HasColumnType("int");
            builder.Property(p => p.PraticaAtividadeFisica).HasColumnName("praticaatividadefisica").HasColumnType("bool");
            builder.Property(p => p.FrequenciaAtividadeFisica).HasColumnName("frequencia_atividadefisica").HasColumnType("varchar(200)");
            builder.Property(p => p.QualidadeSono).HasColumnName("qualidade_sono").HasColumnType("int");
            builder.Property(p => p.HorasCostumaDormir).HasColumnName("horas_costuma_dormir").HasColumnType("int");
            builder.Property(p => p.UsaMedicamentosSuplementos).HasColumnName("usa_medicamentos_suplementos").HasColumnType("bool");
            builder.Property(p => p.QuaisMedicamentoSuplementos).HasColumnName("quais_medicamento_suplementos").HasColumnType("varchar(200)");
            builder.Property(p => p.RealizouProcedimentoCirurgico).HasColumnName("realizou_procedimento_cirurgico").HasColumnType("bool");
            builder.Property(p => p.QualProcedimentoCirurgico).HasColumnName("qual_procedimento_cirurgico").HasColumnType("varchar(200)");
            builder.Property(p => p.AlergiaAlimento).HasColumnName("alergia_alimento").HasColumnType("bool");
            builder.Property(p => p.QualAlimentoAlergia).HasColumnName("qual_alimento_alergia").HasColumnType("varchar(200)");
            builder.Property(p => p.ClassificaApetite).HasColumnName("classifica_apetite").HasColumnType("int");
            builder.Property(p => p.CadenciaMastigacao).HasColumnName("cadencia_mastigacao").HasColumnType("int");
            builder.Property(p => p.PreparaRefeicaoCasa).HasColumnName("prepara_refeicaocasa").HasColumnType("int");
            builder.Property(p => p.ComeFora).HasColumnName("come_fora").HasColumnType("int");
            builder.Property(p => p.FrequenciaDefecacao).HasColumnName("frequencia_defecacao").HasColumnType("int");
            builder.Property(p => p.FraquenciaHabitoUrinario).HasColumnName("fraquencia_habito_urinario").HasColumnType("int");
            builder.Property(p => p.HistoricoDoencaFamiliar).HasColumnName("historico_doenca_familiar").HasColumnType("varchar(300)");
            builder.Property(p => p.ObjetivoMetaPlano).HasColumnName("objetivo_meta_plano").HasColumnType("varchar(350)");
            builder.Property(p => p.Observacoes).HasColumnName("observacoes").HasColumnType("varchar(500)");

            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");

            builder.Property(p => p.UsuarioId).HasColumnName("usuario_id").HasColumnType("int");
            builder.HasOne(p => p.Usuario);
        }
    }
}
