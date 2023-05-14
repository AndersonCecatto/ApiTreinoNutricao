using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface ITreinoService : IBaseService<Treino>
    {
        Treino Add(TreinoDto treinoDto);
        TreinoDto UpdateWithRule(TreinoDto treinoDto);
        IEnumerable<Treino> GetByUsuarioId(long usuarioId);
        IEnumerable<Treino> GetByEmpresaId(long empresaId);
    }
}
