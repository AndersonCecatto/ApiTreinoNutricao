using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class PlanoAlimentar : BaseEntity
    {
        public string? Descricao { get; set; }
        public long? UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
