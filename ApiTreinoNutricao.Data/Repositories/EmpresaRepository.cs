using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public override Empresa Insert(Empresa entity)
        {
            entity.Ativo = true;
            entity.DataCadastro = DateTime.Now;
            return base.Insert(entity);
        }
    }
}
