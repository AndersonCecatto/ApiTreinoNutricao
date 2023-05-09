using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class AnamneseRepository : BaseRepository<Anamnese>, IAnamneseRepository
    {
        public AnamneseRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public Anamnese GetByUsuarioId(long usuarioId) => _apiBaseContext.Set<Anamnese>().AsNoTracking().FirstOrDefault(x => usuarioId == usuarioId);
    }
}
