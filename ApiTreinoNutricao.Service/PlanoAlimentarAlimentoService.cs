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

        public IEnumerable<PlanoAlimentarAlimento> Add(IEnumerable<PlanoAlimentarAlimentoDto> planoAlimentarAlimentoDtos)
        {
            var retorno = new List<PlanoAlimentarAlimento>();

            foreach (PlanoAlimentarAlimentoDto planoAlimentarDto in planoAlimentarAlimentoDtos)
                retorno.Add(_baseRepository.Insert(new PlanoAlimentarAlimento(planoAlimentarDto)));

            return retorno;
        }

        public IEnumerable<PlanoAlimentarAlimento> GetByPlanoAlimentarId(long planoAlimentarId) => _planoAlimentarAlimentoRepository.GetByPlanoAlimentarId(planoAlimentarId);

        public bool UpdateWithRule(IEnumerable<PlanoAlimentarAlimentoDto> planoAlimentarAlimentoDtos)
        {
            foreach (PlanoAlimentarAlimentoDto planoAlimentarDto in planoAlimentarAlimentoDtos)
                _baseRepository.UpdateWithRule(new PlanoAlimentarAlimento(planoAlimentarDto));

            return true;
        }
    }
}
