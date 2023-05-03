using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Inserir(UsuarioDto usuario)
        {
            return Execute(() => _usuarioService.Add(usuario));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _usuarioService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(UsuarioDto usuario)
        {
            return Execute(() => _usuarioService.UpdateWithRule(usuario));
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(UsuarioLoginDto usuarioLogin)
        {
            return Execute(() => _usuarioService.Login(usuarioLogin));
        }

        [HttpGet]
        [Route("GetById/{usuarioId}")]
        public IActionResult GetById(long usuarioId)
        {
            return Execute(() => _usuarioService.GetById(usuarioId));
        }

        [HttpGet]
        [Route("GetByEmpresaId/{empresaId}")]
        public IActionResult GetByEmpresaId(long empresaId)
        {
            return Execute(() => _usuarioService.GetByEmpresaId(empresaId));
        }
    }
}
