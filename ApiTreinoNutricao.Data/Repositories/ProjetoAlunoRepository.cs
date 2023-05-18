using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class ProjetoAlunoRepository : BaseRepository<ProjetoAluno>, IProjetoAlunoRepository
    {
        public ProjetoAlunoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<ProjetoAluno> GetByProjetoId(long projetoId)
        {
            return _apiBaseContext.Set<ProjetoAluno>().Include(x => x.Usuario).Where(x => x.ProjetoId == projetoId);
        }
    }
}
