using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class AvaliacaoService : BaseService<Avaliacao>, IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository) : base(avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }

        public Avaliacao UpdateWithRule(Avaliacao avaliacao)
        {
            _baseRepository.UpdateWithRule(avaliacao);

            return avaliacao;
        }

        public IEnumerable<Avaliacao> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca) => _avaliacaoRepository.GetByEmpresaId(empresaId, tipoBusca);

        public IEnumerable<Avaliacao> GetByUsuarioId(long usuarioId, BuscarUsuarioEnum tipoBusca) => _avaliacaoRepository.GetByUsuarioId(usuarioId, tipoBusca);
    }
}
