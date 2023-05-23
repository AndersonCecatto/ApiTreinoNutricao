using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class ExercicioRepository : BaseRepository<Exercicio>, IExercicioRepository
    {
        public ExercicioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Exercicio> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca)
        {
            var consulta = _apiBaseContext.Set<Exercicio>().Where(x => x.EmpresaId == empresaId);

            return GetByAtivoInativo(consulta, tipoBusca);
        }
    }
}
