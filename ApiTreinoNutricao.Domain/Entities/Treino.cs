using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Treino : BaseEntity
    {
        public string? Nome { get; set; }
        public long? UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
