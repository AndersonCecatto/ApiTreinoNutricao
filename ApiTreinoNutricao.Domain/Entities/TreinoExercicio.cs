using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class TreinoExercicio : BaseEntity
    {
        public long TreinoId { get; set; }
        public virtual Treino Treino { get; set; }
        public long ExercicioId { get; set; }
        public virtual Exercicio Exercicio { get; set; }
        public string Observacoes { get; set; }
    }
}
