using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class TreinoExercicioRepository : BaseRepository<TreinoExercicio>, ITreinoExercicioRepository
    {
        public TreinoExercicioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<TreinoExercicio> GetByTreinoId(long treinoId)
        {
            return _apiBaseContext.Set<TreinoExercicio>()
                                  .AsNoTracking()
                                  .Include(x => x.Exercicio)
                                  .Where(x => x.TreinoId == treinoId && x.Exercicio.Ativo);
        }
    }
}
