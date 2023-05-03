using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class ArquivoTreino : BaseEntity
    {
        public string? Descricao { get; set; }
        public byte[]? Arquivo { get; set; }
        public long TreinoExercicioId { get; set; }
        public virtual TreinoExercicio TreinoExercicio { get; set; }
    }
}
