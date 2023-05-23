using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IExercicioService : IBaseService<Exercicio>
    {
        IEnumerable<Exercicio> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca);
    }
}
