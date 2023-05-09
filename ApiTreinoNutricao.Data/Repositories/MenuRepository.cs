using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {
        public MenuRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }
    }
}
