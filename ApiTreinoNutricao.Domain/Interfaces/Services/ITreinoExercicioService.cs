using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface ITreinoExercicioService : IBaseService<TreinoExercicio>
    {
        IEnumerable<TreinoExercicio> Add(IEnumerable<TreinoExercicioDto> treinoExercicioDtos);
        bool UpdateWithRule(IEnumerable<TreinoExercicioDto> treinoExercicioDtos);
        IEnumerable<TreinoExercicio> GetByTreinoId(long treinoId);
    }
}
