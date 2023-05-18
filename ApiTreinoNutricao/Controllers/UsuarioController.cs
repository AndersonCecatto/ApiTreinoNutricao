using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
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

        /// <summary>
        /// Buscar Todos, Ativos e Inativos
        /// </summary>
        /// <param name="tipoBusca">1 - Todos</param>
        /// <param name="tipoBusca">2 - Ativos</param>
        /// <param name="tipoBusca">3 - Inativos</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetByEmpresaId/{empresaId}/TipoBusca/{tipoBusca}")]
        public IActionResult GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca)
        {
            return Execute(() => _usuarioService.GetByEmpresaId(empresaId, tipoBusca));
        }
    }
}
