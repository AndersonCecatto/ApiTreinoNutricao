using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class PlanoAlimentarService : BaseService<PlanoAlimentar>, IPlanoAlimentarService
    {
        private readonly IPlanoAlimentarRepository _planoAlimentarRepository;
        private readonly IPlanoAlimentarAlimentoRepository _planoAlimentarAlimentoRepository;

        public PlanoAlimentarService(IPlanoAlimentarRepository planoAlimentarRepository, IPlanoAlimentarAlimentoRepository planoAlimentarAlimentoRepository) : base(planoAlimentarRepository)
        {
            _planoAlimentarRepository = planoAlimentarRepository;
            _planoAlimentarAlimentoRepository = planoAlimentarAlimentoRepository;
        }

        public PlanoAlimentar Add(PlanoAlimentarDto planoAlimentarDto) => _baseRepository.Insert(new PlanoAlimentar(planoAlimentarDto));

        public IEnumerable<PlanoAlimentar> GetByEmpresaId(long empresaId) => _planoAlimentarRepository.GetByEmpresaId(empresaId);

        public IEnumerable<PlanoAlimentar> GetByUsuarioId(long usuarioId) => _planoAlimentarRepository.GetByUsuarioId(usuarioId);

        public PlanoAlimentarDto UpdateWithRule(PlanoAlimentarDto planoAlimentarDto)
        {
            _baseRepository.UpdateWithRule(new PlanoAlimentar(planoAlimentarDto));
            return planoAlimentarDto;
        }
    }
}
