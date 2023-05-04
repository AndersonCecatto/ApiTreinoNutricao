using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        [Route("{treinoId}")]
        public IActionResult GetById(long treinoId)
        {
            return Execute(() => _treinoService.GetById(treinoId));
        }
    }
}
