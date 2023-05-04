using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IPlanoAlimentarAlimentoService : IBaseService<PlanoAlimentarAlimento>
    {
        IEnumerable<PlanoAlimentarAlimento> Add(IEnumerable<PlanoAlimentarAlimentoDto> planoAlimentarAlimentoDtos);

        bool UpdateWithRule(IEnumerable<PlanoAlimentarAlimentoDto> planoAlimentarAlimentoDtos);

        IEnumerable<PlanoAlimentarAlimento> GetByPlanoAlimentarId(long planoAlimentarId);
    }
}
