using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Enum;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Alimento : BaseEntity
    {
        public string? Nome { get; set; }
        public decimal Quantidade { get; set; }
        public MedidaEnum Medida { get; set; }
    }
}
