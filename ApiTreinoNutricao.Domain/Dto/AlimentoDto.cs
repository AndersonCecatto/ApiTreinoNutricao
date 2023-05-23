using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Enum;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class AlimentoDto : BaseEntity
    {
        public string? Nome { get; set; }
        public decimal Quantidade { get; set; }
        public MedidaEnum Medida { get; set; }
        public string Observacoes { get; set; }
        public long EmpresaId { get; set; }
    }
}
