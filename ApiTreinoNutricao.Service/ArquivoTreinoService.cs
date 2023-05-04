using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class ArquivoTreinoService : BaseService<ArquivoTreino>, IArquivoTreinoService
    {
        public ArquivoTreinoService(IArquivoTreinoRepository arquivoTreinoRepository) : base(arquivoTreinoRepository)
        {
            
        }
    }
}
