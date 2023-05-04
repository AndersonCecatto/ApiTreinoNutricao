using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class TreinoExercicioDto : BaseEntity
    {
        public long TreinoId { get; set; }
        public long ExercicioId { get; set; }
        public string? Observacoes { get; set; }
    }
}
