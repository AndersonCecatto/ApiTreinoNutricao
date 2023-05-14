using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanoAlimentarController : BaseController
    {
        private readonly IPlanoAlimentarService _planoAlimentarService;

        public PlanoAlimentarController(IPlanoAlimentarService planoAlimentarService)
        {
            _planoAlimentarService = planoAlimentarService;
        }

        [HttpPost]
        public IActionResult Inserir(PlanoAlimentarDto planoAlimentar)
        {
            return Execute(() => _planoAlimentarService.Add(planoAlimentar));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _planoAlimentarService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(PlanoAlimentarDto planoAlimentar)
        {
            return Execute(() => _planoAlimentarService.UpdateWithRule(planoAlimentar));
        }

        [HttpGet]
        [Route("PlanoAlimentarId/{planoAlimentarId}")]
        public IActionResult GetById(long planoAlimentarId)
        {
            return Execute(() => _planoAlimentarService.GetById(planoAlimentarId));
        }

        [HttpGet]
        [Route("UsuarioId/{usuarioId}")]
        public IActionResult GetByUsuarioId(long usuarioId)
        {
            return Execute(() => _planoAlimentarService.GetByUsuarioId(usuarioId));
        }

        [HttpGet]
        [Route("EmpresaId/{empresaId}")]
        public IActionResult GetByEmpresaId(long empresaId)
        {
            return Execute(() => _planoAlimentarService.GetByEmpresaId(empresaId));
        }
    }
}
