using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface ITreinoRepository : IBaseRepository<Treino>
    {
        IEnumerable<Treino> GetByUsuarioId(long usuarioId);
        IEnumerable<Treino> GetByEmpresaId(long empresaId);
    }
}
