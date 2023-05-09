using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class TreinoExercicioService : BaseService<TreinoExercicio>, ITreinoExercicioService
    {
        private readonly ITreinoExercicioRepository _treinoExercicioRepository;
        public TreinoExercicioService(ITreinoExercicioRepository treinoExercicioRepository) : base(treinoExercicioRepository)
        {
            _treinoExercicioRepository = treinoExercicioRepository;
        }

        public IEnumerable<TreinoExercicio> Add(IEnumerable<TreinoExercicioDto> treinoExercicioDtos)
        {
            var retorno = new List<TreinoExercicio>();

            foreach (TreinoExercicioDto treinoExercicio in treinoExercicioDtos)
                retorno.Add(_baseRepository.Insert(new TreinoExercicio(treinoExercicio)));

            return retorno;
        }

        public IEnumerable<TreinoExercicio> GetByTreinoId(long treinoId) => _treinoExercicioRepository.GetByTreinoId(treinoId);

        public bool UpdateWithRule(IEnumerable<TreinoExercicioDto> treinoExercicioDtos)
        {
            foreach (TreinoExercicioDto treinoExercicio in treinoExercicioDtos)
                _baseRepository.UpdateWithRule(new TreinoExercicio(treinoExercicio));

            return true;
        }
    }
}
