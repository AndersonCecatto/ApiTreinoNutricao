using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class TreinoExercicioService : BaseService<TreinoExercicio>, ITreinoExercicioService
    {
        public TreinoExercicioService(ITreinoExercicioRepository treinoExercicioRepository) : base(treinoExercicioRepository)
        {
            
        }
    }
}
