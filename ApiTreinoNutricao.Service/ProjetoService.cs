using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class ProjetoService : BaseService<Projeto>, IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;
        private readonly IProjetoAlunoRepository _projetoAlunoRepository;

        public ProjetoService(IProjetoRepository projetoRepository, IProjetoAlunoRepository projetoAlunoRepository) : base(projetoRepository)
        {
            _projetoRepository = projetoRepository;
            _projetoAlunoRepository = projetoAlunoRepository;
        }

        public Projeto Add(ProjetoDto projetoDto) => _baseRepository.Insert(new Projeto(projetoDto));

        public bool AddProjetoAluno(IEnumerable<ProjetoAlunoDto> projetos)
        {
            foreach (ProjetoAlunoDto projeto in projetos)
            {
                _projetoAlunoRepository.Insert(new ProjetoAluno(projeto));
            }

            return true;
        }

        public IEnumerable<Projeto> GetByEmpresaId(long empresaId) => _projetoRepository.GetByEmpresaId(empresaId);

        public ProjetoDto UpdateWithRule(ProjetoDto projetoDto)
        {
            _baseRepository.UpdateWithRule(new Projeto(projetoDto));
            return projetoDto;
        }
    }
}
