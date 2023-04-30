using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class EmpresaService : BaseService<Empresa>, IEmpresaService
    {
        public EmpresaService(IEmpresaRepository empresaRepository) : base(empresaRepository)
        {
            
        }
    }
}
