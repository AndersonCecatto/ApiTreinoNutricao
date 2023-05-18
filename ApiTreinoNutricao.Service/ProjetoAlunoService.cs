using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class ProjetoAlunoService : BaseService<ProjetoAluno>, IProjetoAlunoService
    {
        private readonly IProjetoAlunoRepository _projetoAlunoRepository;
        public ProjetoAlunoService(IProjetoAlunoRepository projetoAlunoRepository) : base(projetoAlunoRepository)
        {
            _projetoAlunoRepository = projetoAlunoRepository;
        }

        public ProjetoAluno Add(ProjetoAlunoDto projetoAlunoDto) => _baseRepository.Insert(new ProjetoAluno(projetoAlunoDto));

        public IEnumerable<ProjetoAluno> GetByProjetoId(long projetoId) => _projetoAlunoRepository.GetByProjetoId(projetoId);
    }
}
