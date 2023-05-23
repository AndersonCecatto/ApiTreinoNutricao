using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class AlimentoService : BaseService<Alimento>, IAlimentoService
    {
        private readonly IAlimentoRepository _alimentoRepository;
        public AlimentoService(IAlimentoRepository alimentoRepository) : base(alimentoRepository)
        {
            _alimentoRepository = alimentoRepository;
        }

        public Alimento Add(AlimentoDto alimentoDto)
        {
            return _baseRepository.Insert(new Alimento(alimentoDto));
        }

        public AlimentoDto UpdateWithRule(AlimentoDto alimentoDto)
        {
            _baseRepository.UpdateWithRule(new Alimento( alimentoDto));

            return alimentoDto;
        }

        public IEnumerable<Alimento> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca) => _alimentoRepository.GetByEmpresaId(empresaId, tipoBusca);

    }
}
