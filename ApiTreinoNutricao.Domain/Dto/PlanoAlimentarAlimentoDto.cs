using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class PlanoAlimentarAlimentoDto : BaseEntity
    {
        public long AlimentoId { get; set; }
        public long PlanoAlimentarId { get; set; }
        public string? Observacoes { get; set; }
    }
}
