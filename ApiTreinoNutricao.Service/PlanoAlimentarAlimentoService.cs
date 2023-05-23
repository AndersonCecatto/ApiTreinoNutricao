using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class PlanoAlimentarAlimentoService : BaseService<PlanoAlimentarAlimento>, IPlanoAlimentarAlimentoService
    {
        private readonly IPlanoAlimentarAlimentoRepository _planoAlimentarAlimentoRepository;
        public PlanoAlimentarAlimentoService(IPlanoAlimentarAlimentoRepository planoAlimentarAlimentoRepository) : base(planoAlimentarAlimentoRepository)
        {
            _planoAlimentarAlimentoRepository = planoAlimentarAlimentoRepository;
        }

        public IEnumerable<PlanoAlimentarAlimento> Add(PlanoAlimentarAlimentoDto planoAlimentarAlimentoDto)
        {
            var retorno = new List<PlanoAlimentarAlimento>();

            //foreach (long AlimentoId in planoAlimentarAlimentoDto.AlimentoIds) 
            //    retorno.Add(_baseRepository.Insert(new PlanoAlimentarAlimento(planoAlimentarAlimentoDto));

            return retorno;
        }

        public IEnumerable<PlanoAlimentarAlimento> GetByPlanoAlimentarId(long planoAlimentarId) => _planoAlimentarAlimentoRepository.GetByPlanoAlimentarId(planoAlimentarId);

        public bool UpdateWithRule(PlanoAlimentarAlimentoDto planoAlimentarAlimentoDto)
        {
            //foreach (long AlimentoId in planoAlimentarAlimentoDto.AlimentoIds)
            //    _baseRepository.UpdateWithRule(new PlanoAlimentarAlimento(planoAlimentarAlimentoDto) { AlimentoId = AlimentoId });

            return true;
        }
    }
}
