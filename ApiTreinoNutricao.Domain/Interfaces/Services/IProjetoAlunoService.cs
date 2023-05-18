using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IProjetoAlunoService : IBaseService<ProjetoAluno>
    {
        ProjetoAluno Add(ProjetoAlunoDto projetoAlunoDto);
        IEnumerable<ProjetoAluno> GetByProjetoId(long projetoId);
    }
}
