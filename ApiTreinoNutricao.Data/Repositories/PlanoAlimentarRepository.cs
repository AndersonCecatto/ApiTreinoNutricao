using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
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

        public IEnumerable<PlanoAlimentar> GetByEmpresaId(long empresaId) => _apiBaseContext.Set<PlanoAlimentar>().Where(x => x.EmpresaId == empresaId).AsNoTracking();
        

        public IEnumerable<PlanoAlimentar> GetByUsuarioId(long usuarioId) => _apiBaseContext.Set<PlanoAlimentar>().Where(x => x.UsuarioId == usuarioId).AsNoTracking();
    }
}
