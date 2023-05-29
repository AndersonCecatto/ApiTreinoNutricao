using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class AvaliacaoRepository : BaseRepository<Avaliacao>, IAvaliacaoRepository
    {
        public AvaliacaoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Avaliacao> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca)
        {
            var consulta = _apiBaseContext.Set<Avaliacao>().Where(x => x.EmpresaId == empresaId);

            return GetByAtivoInativo(consulta, tipoBusca);
        }

        public IEnumerable<Avaliacao> GetByUsuarioId(long usuarioId, BuscarUsuarioEnum tipoBusca)
        {
            var consulta = _apiBaseContext.Set<Avaliacao>()
                                          .Where(x => x.UsuarioId == usuarioId)
                                          .Select(x => new Avaliacao 
                                          { 
                                              Id = x.Id,
                                              Descricao = x.Descricao,
                                              Ativo = x.Ativo
                                          });

            return GetByAtivoInativo(consulta, tipoBusca);
        }
    }
}
