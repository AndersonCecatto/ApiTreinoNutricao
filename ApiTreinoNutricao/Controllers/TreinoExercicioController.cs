using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TreinoExercicioController : BaseController
    {
        private readonly ITreinoExercicioService _treinoExercicioService;

        public TreinoExercicioController(ITreinoExercicioService treinoExercicioService)
        {
            _treinoExercicioService = treinoExercicioService;
        }

        [HttpPost]
        public IActionResult Inserir(IEnumerable<TreinoExercicioDto> treinoExercicioDto)
        {
            return Execute(() => _treinoExercicioService.Add(treinoExercicioDto));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _treinoExercicioService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(IEnumerable<TreinoExercicioDto> treinoExercicioDto)
        {
            return Execute(() => _treinoExercicioService.UpdateWithRule(treinoExercicioDto));
        }

        [HttpGet]
        [Route("{treinoId}")]
        public IActionResult GetByTreinoId(long treinoId)
        {
            return Execute(() => _treinoExercicioService.GetByTreinoId(treinoId));
        }
    }
}
