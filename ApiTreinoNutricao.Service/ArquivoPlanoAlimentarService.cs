using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class ArquivoPlanoAlimentarService : BaseService<ArquivoPlanoAlimentar>, IArquivoPlanoAlimentarService
    {
        public ArquivoPlanoAlimentarService(IArquivoPlanoAlimentarRepository arquivoPlanoAlimentarRepository) : base(arquivoPlanoAlimentarRepository)
        {
            
        }
    }
}
