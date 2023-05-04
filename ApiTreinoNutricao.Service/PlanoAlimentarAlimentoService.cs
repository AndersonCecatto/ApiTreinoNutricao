using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class PlanoAlimentarAlimentoService : BaseService<PlanoAlimentarAlimento>, IPlanoAlimentarAlimentoService
    {
        public PlanoAlimentarAlimentoService(IPlanoAlimentarAlimentoRepository planoAlimentarAlimentoRepository) : base(planoAlimentarAlimentoRepository)
        {
            
        }
    }
}
