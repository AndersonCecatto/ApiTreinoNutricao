using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TreinoController : BaseController
    {
        private readonly ITreinoService _treinoService;

        public TreinoController(ITreinoService treinoService)
        {
            _treinoService = treinoService;
        }

        [HttpPost]
        public IActionResult Inserir(TreinoDto treino)
        {
            return Execute(() => _treinoService.Add(treino));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _treinoService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(TreinoDto treino)
        {
            return Execute(() => _treinoService.UpdateWithRule(treino));
        }

        [HttpPost]
        [Route("BuscarPorIdsTreinos")]
        public IActionResult BuscarPorIdsTreinos(IEnumerable<int> idsTreinos)
        {
            return Execute(() => _treinoService.BuscarPorIdsTreinos(idsTreinos));
        }

        [HttpGet]
        [Route("{usuarioId}")]
        public IActionResult GetByUsuarioId(long usuarioId)
        {
            return Execute(() => _treinoService.GetByUsuarioId(usuarioId));
        }

        [HttpGet]
        [Route("EmpresaId/{empresaId}")]
        public IActionResult GetByEmpresaId(long empresaId)
        {
            return Execute(() => _treinoService.GetByEmpresaId(empresaId));
        }
    }
}
