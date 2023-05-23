using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IPlanoAlimentarAlimentoService : IBaseService<PlanoAlimentarAlimento>
    {
        IEnumerable<PlanoAlimentarAlimento> Add(PlanoAlimentarAlimentoDto planoAlimentarAlimentoDto);

        bool UpdateWithRule(PlanoAlimentarAlimentoDto planoAlimentarAlimentoDto);

        IEnumerable<PlanoAlimentarAlimento> GetByPlanoAlimentarId(long planoAlimentarId);
    }
}
