using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IAvaliacaoRepository : IBaseRepository<Avaliacao>
    {
        IEnumerable<Avaliacao> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca);
        IEnumerable<Avaliacao> GetByUsuarioId(long usuarioId, BuscarUsuarioEnum tipoBusca);
    }
}
