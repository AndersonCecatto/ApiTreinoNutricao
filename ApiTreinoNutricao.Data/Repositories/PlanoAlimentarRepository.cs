using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class PlanoAlimentarRepository : BaseRepository<PlanoAlimentar>, IPlanoAlimentarRepository
    {
        public PlanoAlimentarRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<PlanoAlimentar> GetByUsuarioId(long usuarioId)
        {
            return _apiBaseContext.Set<PlanoAlimentar>().Where(x => x.UsuarioId == usuarioId).AsNoTracking();
        }
    }
}
