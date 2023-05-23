using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class AlimentoRepository : BaseRepository<Alimento>, IAlimentoRepository
    {
        public AlimentoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Alimento> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca)
        {
            var consulta = _apiBaseContext.Set<Alimento>().Where(x => x.EmpresaId == empresaId);

            return GetByAtivoInativo(consulta, tipoBusca);
        }
            
    }
}
