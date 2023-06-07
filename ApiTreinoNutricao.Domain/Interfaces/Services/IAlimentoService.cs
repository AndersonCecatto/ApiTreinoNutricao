using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IAlimentoService : IBaseService<Alimento>
    {
        Alimento Add(AlimentoDto alimentoDto);
        AlimentoDto UpdateWithRule(AlimentoDto alimentoDto);
        IEnumerable<Alimento> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca);
        IEnumerable<Alimento> BuscarPorIdsAlimentos(IEnumerable<int> idsAlimentos);
    }
}
