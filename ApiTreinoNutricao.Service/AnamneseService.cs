using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class AnamneseService : BaseService<Anamnese>, IAnamneseService
    {
        private readonly IAnamneseRepository _anamneseRepository;
        public AnamneseService(IAnamneseRepository anamneseRepository) : base(anamneseRepository)
        {
            _anamneseRepository = anamneseRepository;
        }

        public Anamnese Add(AnamneseDto anamnese)
        {
            return _baseRepository.Insert(new Anamnese(anamnese));
        }

        public Anamnese GetByUsuarioId(long usuarioId)
        {
            return _anamneseRepository.GetByUsuarioId(usuarioId);
        }

        public AnamneseDto UpdateWithRule(AnamneseDto anamneseDto)
        {
            _baseRepository.UpdateWithRule(new Anamnese(anamneseDto));

            return anamneseDto;
        }
    }
}
