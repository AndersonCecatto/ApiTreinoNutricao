using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetoController : BaseController
    {
        private readonly IProjetoService _projetoService;

        public ProjetoController(IProjetoService projetoService)
        {
            _projetoService = projetoService;
        }

        [HttpPost]
        public IActionResult Inserir(ProjetoDto projeto)
        {
            return Execute(() => _projetoService.Add(projeto));
        }

        [HttpPost]
        [Route("ProjetoAluno")]
        public IActionResult Inserir(IEnumerable<ProjetoAlunoDto> projetos)
        {
            return Execute(() => _projetoService.AddProjetoAluno(projetos));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _projetoService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(ProjetoDto projeto)
        {
            return Execute(() => _projetoService.UpdateWithRule(projeto));
        }

        [HttpGet]
        [Route("{empresaId}")]
        public IActionResult GetByEmpresaId(long empresaId)
        {
            return Execute(() => _projetoService.GetByEmpresaId(empresaId));
        }
    }
}
