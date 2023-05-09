using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class MenuUsuarioRepository : BaseRepository<MenuUsuario>, IMenuUsuarioRepository
    {
        public MenuUsuarioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<MenuUsuario> GetByUsuarioIdEmpresaId(long usuarioId, long empresaId) 
            => _apiBaseContext.Set<MenuUsuario>()
                              .Where(x => x.UsuarioId == usuarioId && x.EmpresaId == empresaId)
                              .Include(x => x.Menu)
                              .AsNoTracking();
    }
}
