using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IAnamneseRepository : IBaseRepository<Anamnese>
    {
        Anamnese GetByUsuarioId(long usuarioId);
    }
}
