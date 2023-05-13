using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto.Enum;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class AnamneseDto : BaseEntity
    {
        public long UsuarioId { get; set; }
        public string? Nome { get; set; }
        public string? DataNascimento { get; set; }
        public GeneroEnum Genero { get; set; }
        public string? Ocupacao { get; set; }
        public string? Objetivo { get; set; }
        public bool Diabetes { get; set; }
        public bool PreDiabetes { get; set; }
        public bool Hipotireoidismo { get; set; }
        public bool Gastrite { get; set; }
        public bool Hipertensao { get; set; }
        public bool Dislipidemia { get; set; }
        public bool Ansiedade { get; set; }
        public bool DoencaRenalCronica { get; set; }
        public bool DoencasRespiratorias { get; set; }
        public bool Colite { get; set; }
        public bool Triglicerides { get; set; }
        public bool DoencasCardiovasculares { get; set; }
        public bool TranstornosAlimentares { get; set; }
        public bool Fumante { get; set; }
        public bool BebidaAlcoolica { get; set; }
        public int? FrequenciaBebidaAlcoolica { get; set; }
        public bool PraticaAtividadeFisica { get; set; }
        public string? FrequenciaAtividadeFisica { get; set; }
        public QualidadeSonoEnum QualidadeSono { get; set; }
        public HorasCostumaDormirEnum HorasCostumaDormir { get; set; }
        public bool UsaMedicamentosSuplementos { get; set; }
        public string? QuaisMedicamentoSuplementos { get; set; }
        public bool RealizouProcedimentoCirurgico { get; set; }
        public string? QualProcedimentoCirurgico { get; set; }
        public bool AlergiaAlimento { get; set; }
        public string? QualAlimentoAlergia { get; set; }
        public ClassificaApetiteEnum ClassificaApetite { get; set; }
        public CadenciaMastigacaoEnum CadenciaMastigacao { get; set; }
        public PreparaRefeicoesEnum PreparaRefeicaoCasa { get; set; }
        public ComeForaEnum ComeFora { get; set; }
        public DefecacaoEnum FrequenciaDefecacao { get; set; }
        public HabitoUrinarioEnum FraquenciaHabitoUrinario { get; set; }
        public string? HistoricoDoencaFamiliar { get; set; }
        public string? ObjetivoMetaPlano { get; set; }
        public string? Observacoes { get; set; }
    }
}
