using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IPlanoAlimentarAlimentoRepository : IBaseRepository<PlanoAlimentarAlimento>
    {
        IEnumerable<PlanoAlimentarAlimento> GetByPlanoAlimentarId(long planoAlimentarId);
    }
}
