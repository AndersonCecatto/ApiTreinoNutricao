using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class ArquivoPlanoAlimentarRepository : BaseRepository<ArquivoPlanoAlimentar>, IArquivoPlanoAlimentarRepository
    {
        public ArquivoPlanoAlimentarRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }
    }
}
