using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class ProjetoAlunoService : BaseService<ProjetoAluno>, IProjetoAlunoService
    {
        public ProjetoAlunoService(IProjetoAlunoRepository projetoAlunoRepository) : base(projetoAlunoRepository)
        {
            
        }
    }
}
