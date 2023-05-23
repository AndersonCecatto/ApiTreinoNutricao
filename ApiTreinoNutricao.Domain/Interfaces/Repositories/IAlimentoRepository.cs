using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IAlimentoRepository : IBaseRepository<Alimento>
    {
        IEnumerable<Alimento> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca);
    }
}
