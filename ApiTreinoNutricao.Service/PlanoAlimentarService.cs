using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class PlanoAlimentarService : BaseService<PlanoAlimentar>, IPlanoAlimentarService
    {
        public PlanoAlimentarService(IPlanoAlimentarRepository planoAlimentarRepository) : base(planoAlimentarRepository)
        {
            
        }

        public PlanoAlimentar Add(PlanoAlimentarDto planoAlimentarDto) => _baseRepository.Insert(new PlanoAlimentar(planoAlimentarDto));

        public PlanoAlimentarDto UpdateWithRule(PlanoAlimentarDto planoAlimentarDto)
        {
            _baseRepository.UpdateWithRule(new PlanoAlimentar(planoAlimentarDto));
            return planoAlimentarDto;
        }
    }
}
