using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IAvaliacaoService : IBaseService<Avaliacao>
    {
        Avaliacao UpdateWithRule(Avaliacao avalicao);
        IEnumerable<Avaliacao> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca);
        IEnumerable<Avaliacao> GetByUsuarioId(long usuarioId, BuscarUsuarioEnum tipoBusca);
    }
}
