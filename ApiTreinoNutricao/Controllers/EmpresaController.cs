using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : BaseController
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        [HttpPost]
        public IActionResult Inserir(Empresa empresa)
        {
            return Execute(() => _empresaService.Add(empresa));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _empresaService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(Empresa empresa)
        {
            return Execute(() => _empresaService.Update(empresa));
        }

        [HttpGet]
        [Route("{empresaId}")]
        public IActionResult GetById(long empresaId)
        {
            return Execute(() => _empresaService.GetById(empresaId));
        }
    }
}
