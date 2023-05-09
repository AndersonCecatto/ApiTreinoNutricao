using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuUsuarioController : BaseController
    {
        private readonly IMenuUsuarioService _menuUsuarioService;

        public MenuUsuarioController(IMenuUsuarioService menuUsuarioService)
        {
            _menuUsuarioService = menuUsuarioService;
        }

        [HttpPost]
        public IActionResult Inserir(MenuUsuarioDto menuUsuarioDto)
        {
            return Execute(() => _menuUsuarioService.Add(menuUsuarioDto));
        }

        [HttpPut]
        public IActionResult Alterar(MenuUsuarioDto menuUsuarioDto)
        {
            return Execute(() => _menuUsuarioService.UpdateWithRule(menuUsuarioDto));
        }

        [HttpGet]
        [Route("Usuario/{usuarioId}/Empresa/{empresaId}")]
        public IActionResult GetByUsuarioIdEmpresaId(long usuarioId, long empresaId)
        {
            return Execute(() => _menuUsuarioService.GetByUsuarioIdEmpresaId(usuarioId, empresaId));
        }
    }
}
