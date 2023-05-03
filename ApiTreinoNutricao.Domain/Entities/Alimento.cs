using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Alimento : BaseEntity
    {
        public string? Nome { get; set; }
        public decimal Quantidade { get; set; }
    }
}
