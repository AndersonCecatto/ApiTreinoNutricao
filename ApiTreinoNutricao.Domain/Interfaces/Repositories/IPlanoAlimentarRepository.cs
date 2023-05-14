using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IPlanoAlimentarRepository : IBaseRepository<PlanoAlimentar>
    {
        IEnumerable<PlanoAlimentar> GetByUsuarioId(long usuarioId);
        IEnumerable<PlanoAlimentar> GetByEmpresaId(long empresaId);
    }
}
