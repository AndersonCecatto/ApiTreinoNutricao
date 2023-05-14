using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class TreinoService : BaseService<Treino>, ITreinoService
    {
        private readonly ITreinoRepository _treinoRepository;

        public TreinoService(ITreinoRepository treinoRepository) : base(treinoRepository)
        {
            _treinoRepository = treinoRepository;
        }

        public Treino Add(TreinoDto treinoDto) => _baseRepository.Insert(new Treino(treinoDto));

        public IEnumerable<Treino> GetByEmpresaId(long empresaId)
        {
            return _treinoRepository.GetByEmpresaId(empresaId);
        }

        public IEnumerable<Treino> GetByUsuarioId(long usuarioId)
        {
            return _treinoRepository.GetByUsuarioId(usuarioId);
        }

        public TreinoDto UpdateWithRule(TreinoDto treinoDto)
        {
            _baseRepository.UpdateWithRule(new Treino(treinoDto));
            return treinoDto;
        }
    }
}
