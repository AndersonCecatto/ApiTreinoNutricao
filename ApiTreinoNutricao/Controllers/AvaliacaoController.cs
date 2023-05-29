using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacaoController : BaseController
    {
        private readonly IAvaliacaoService _avaliacaoService;

        public AvaliacaoController(IAvaliacaoService avaliacaoService)
        {
            _avaliacaoService = avaliacaoService;
        }

        [HttpPost]
        public IActionResult Inserir(Avaliacao avaliacao)
        {
            return Execute(() => _avaliacaoService.Add(avaliacao));
        }

        [HttpDelete]
        public IActionResult Delete(long avaliacaoId)
        {
            return Execute(() => {
                _avaliacaoService.Delete(avaliacaoId);
                return true;
            });
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _avaliacaoService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(Avaliacao avaliacao)
        {
            return Execute(() => _avaliacaoService.UpdateWithRule(avaliacao));
        }

        [HttpGet]
        [Route("EmpresaId/{empresaId}/TipoBusca/{tipoBusca}")]
        public IActionResult GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca)
        {
            return Execute(() => _avaliacaoService.GetByEmpresaId(empresaId, tipoBusca));
        }

        [HttpGet]
        [Route("{avaliacaoId}")]
        public IActionResult GetById(long avaliacaoId)
        {
            return Execute(() => _avaliacaoService.GetById(avaliacaoId));
        }

        [HttpGet]
        [Route("UsuarioId/{usuarioId}/TipoBusca/{tipoBusca}")]
        public IActionResult GetByUsuarioId(long usuarioId, BuscarUsuarioEnum tipoBusca)
        {
            return Execute(() => _avaliacaoService.GetByUsuarioId(usuarioId, tipoBusca));
        }
    }
}
