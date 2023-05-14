using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class TreinoRepository : BaseRepository<Treino>, ITreinoRepository
    {
        public TreinoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Treino> GetByEmpresaId(long empresaId)
        {
            return _apiBaseContext.Set<Treino>().Include(x => x.Usuario).Where(x => x.EmpresaId == empresaId);
        }

        public IEnumerable<Treino> GetByUsuarioId(long usuarioId)
        {
            return _apiBaseContext.Set<Treino>().Include(x => x.Usuario) .Where(x => x.UsuarioId == usuarioId);
        }
    }
}
