using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class ProjetoDto : BaseEntity
    {
        public string? Nome { get; set; }
        public bool PlanoAlimentar { get; set; }
        public bool Treino { get; set; }
        public bool Foto { get; set; }
        public bool Avaliacao { get; set; }
        public bool Exame { get; set; }
        public bool Anamnese { get; set; }
        public string? Observacoes { get; set; }
        public long EmpresaId { get; set; }
    }
}
