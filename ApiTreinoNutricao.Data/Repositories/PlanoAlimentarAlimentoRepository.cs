using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class PlanoAlimentarAlimentoRepository : BaseRepository<PlanoAlimentarAlimento>, IPlanoAlimentarAlimentoRepository
    {
        public PlanoAlimentarAlimentoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }
    }
}
