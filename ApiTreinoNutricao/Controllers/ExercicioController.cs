using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExercicioController : BaseController
    {
        private readonly IExercicioService _exercicioService;

        public ExercicioController(IExercicioService exercicioService)
        {
            _exercicioService = exercicioService;
        }

        [HttpPost]
        public IActionResult Inserir(Exercicio exercicio)
        {
            return Execute(() => _exercicioService.Add(exercicio));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _exercicioService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(Exercicio exercicio)
        {
            return Execute(() => _exercicioService.UpdateWithRule(exercicio));
        }

        [HttpGet]
        [Route("{exercicioId}")]
        public IActionResult GetById(long exercicioId)
        {
            return Execute(() => _exercicioService.GetById(exercicioId));
        }
    }
}
