using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;
using System.Reflection;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Anamnese : BaseEntity
    {
        public Anamnese() { }

        public Anamnese(AnamneseDto anamneseDto)
        {
            Id = anamneseDto.Id;
            Ativo = anamneseDto.Ativo;
            DataCadastro = DateTime.Now;
            UsuarioId = anamneseDto.UsuarioId;
            Nome = anamneseDto.Nome;
            DataNascimento = anamneseDto.DataNascimento;
            Genero = (int)anamneseDto.Genero;
            Ocupacao = anamneseDto.Ocupacao;
            Objetivo = anamneseDto.Objetivo;
            Diabetes = anamneseDto.Diabetes;
            PreDiabetes = anamneseDto.PreDiabetes;
            Hipotireoidismo = anamneseDto.Hipotireoidismo;
            Gastrite = anamneseDto.Gastrite;
            Hipertensao = anamneseDto.Hipertensao;
            Dislipidemia = anamneseDto.Dislipidemia;
            Ansiedade = anamneseDto.Ansiedade;
            DoencaRenalCronica = anamneseDto.DoencaRenalCronica;
            DoencasRespiratorias = anamneseDto.DoencasRespiratorias;
            Colite = anamneseDto.Colite;
            Triglicerides = anamneseDto.Triglicerides;
            DoencasCardiovasculares = anamneseDto.DoencasCardiovasculares;
            TranstornosAlimentares = anamneseDto.TranstornosAlimentares;
            Fumante = anamneseDto.Fumante;
            BebidaAlcoolica = anamneseDto.BebidaAlcoolica;
            FrequenciaBebidaAlcoolica = anamneseDto.FrequenciaBebidaAlcoolica;
            PraticaAtividadeFisica = anamneseDto.PraticaAtividadeFisica;
            QualidadeSono = (int)anamneseDto.QualidadeSono;
            HorasCostumaDormir = (int)anamneseDto.HorasCostumaDormir;
            UsaMedicamentosSuplementos = anamneseDto.UsaMedicamentosSuplementos;
            QuaisMedicamentoSuplementos = anamneseDto.QuaisMedicamentoSuplementos;
            RealizouProcedimentoCirurgico = anamneseDto.RealizouProcedimentoCirurgico;
            QualProcedimentoCirurgico = anamneseDto.QualProcedimentoCirurgico;
            AlergiaAlimento = anamneseDto.AlergiaAlimento;
            QualAlimentoAlergia = anamneseDto.QualAlimentoAlergia;
            ClassificaApetite = (int)anamneseDto.ClassificaApetite;
            CadenciaMastigacao = (int)anamneseDto.CadenciaMastigacao;
            PreparaRefeicaoCasa = (int)anamneseDto.PreparaRefeicaoCasa;
            ComeFora = (int)anamneseDto.ComeFora;
            FrequenciaDefecacao = (int)anamneseDto.FrequenciaDefecacao;
            FraquenciaHabitoUrinario = (int)anamneseDto.FraquenciaHabitoUrinario;
            HistoricoDoencaFamiliar = anamneseDto.HistoricoDoencaFamiliar;
            ObjetivoMetaPlano = anamneseDto.ObjetivoMetaPlano;
            Observacoes = anamneseDto.Observacoes;
            FrequenciaAtividadeFisica = anamneseDto.FrequenciaAtividadeFisica;
        }

        public long UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public string? Nome { get; set; }
        public string? DataNascimento { get; set; }
        public int Genero { get; set; }
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
        public int QualidadeSono { get; set; }
        public int HorasCostumaDormir { get; set; }
        public bool UsaMedicamentosSuplementos { get; set; }
        public string? QuaisMedicamentoSuplementos { get; set; }
        public bool RealizouProcedimentoCirurgico { get; set; }
        public string? QualProcedimentoCirurgico { get; set; }
        public bool AlergiaAlimento { get; set; }
        public string? QualAlimentoAlergia { get; set; }
        public int ClassificaApetite { get; set; }
        public int CadenciaMastigacao { get; set; }
        public int PreparaRefeicaoCasa { get; set; }
        public int ComeFora { get; set; }
        public int FrequenciaDefecacao { get; set; }
        public int FraquenciaHabitoUrinario { get; set; }
        public string? HistoricoDoencaFamiliar { get; set; }
        public string? ObjetivoMetaPlano { get; set; }
        public string? Observacoes { get; set; }
    }
}
