using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class PlanoAlimentarAlimentoRepository : BaseRepository<PlanoAlimentarAlimento>, IPlanoAlimentarAlimentoRepository
    {
        public PlanoAlimentarAlimentoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<PlanoAlimentarAlimento> GetByPlanoAlimentarId(long planoAlimentarId)
        {
            return _apiBaseContext.Set<PlanoAlimentarAlimento>()
                                  .AsNoTracking()
                                  .Include(x => x.Alimento)
                                  .Where(x => x.PlanoAlimentarId == planoAlimentarId && x.Alimento.Ativo == true);
        }
    }
}
