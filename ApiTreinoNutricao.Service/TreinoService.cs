using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class TreinoService : BaseService<Treino>, ITreinoService
    {
        public TreinoService(ITreinoRepository treinoRepository) : base(treinoRepository)
        {
            
        }

        public Treino Add(TreinoDto treinoDto) => _baseRepository.Insert(new Treino(treinoDto));

        public TreinoDto UpdateWithRule(TreinoDto treinoDto)
        {
            _baseRepository.UpdateWithRule(new Treino(treinoDto));
            return treinoDto;
        }
    }
}
