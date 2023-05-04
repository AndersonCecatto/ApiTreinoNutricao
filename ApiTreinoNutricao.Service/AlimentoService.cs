using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class AlimentoService : BaseService<Alimento>, IAlimentoService
    {
        public AlimentoService(IAlimentoRepository alimentoRepository) : base(alimentoRepository)
        {
            
        }
    }
}
