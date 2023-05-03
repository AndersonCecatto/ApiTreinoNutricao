using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class PlanoAlimentarAlimento : BaseEntity
    {
        public long AlimentoId { get; set; }
        public virtual Alimento Alimento { get; set; }
        public long PlanoAlimentarId { get; set; }
        public virtual PlanoAlimentar PlanoAlimentar { get; set; }
        public string? Observacoes { get; set; }
    }
}
