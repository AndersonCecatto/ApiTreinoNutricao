using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IProjetoAlunoRepository : IBaseRepository<ProjetoAluno>
    {
        IEnumerable<ProjetoAluno> GetByProjetoId(long projetoId);
        IEnumerable<ProjetoAluno> GetByUsuarioId(long usuarioId);
    }
}
