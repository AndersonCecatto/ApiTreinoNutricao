using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;
using System.Reflection.Metadata;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class TreinoExercicio : BaseEntity
    {
        public TreinoExercicio()
        {
        }

        public TreinoExercicio(TreinoExercicioDto treinoExercicioDto)
        {
            Id = treinoExercicioDto.Id;
            TreinoId = treinoExercicioDto.TreinoId;
            ExercicioId = treinoExercicioDto.ExercicioId;
            Observacoes = treinoExercicioDto.Observacoes;
            Ativo = treinoExercicioDto.Ativo;
        }

        public long TreinoId { get; set; }
        public virtual Treino? Treino { get; set; }
        public long ExercicioId { get; set; }
        public virtual Exercicio? Exercicio { get; set; }
        public string? Observacoes { get; set; }
    }
}
