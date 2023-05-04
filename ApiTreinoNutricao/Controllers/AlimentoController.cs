using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlimentoController : BaseController
    {
        private readonly IAlimentoService _alimentoService;

        public AlimentoController(IAlimentoService alimentoService)
        {
            _alimentoService = alimentoService;
        }

        [HttpPost]
        public IActionResult Inserir(Alimento alimento)
        {
            return Execute(() => _alimentoService.Add(alimento));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _alimentoService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(Alimento alimento)
        {
            return Execute(() => _alimentoService.UpdateWithRule(alimento));
        }

        [HttpGet]
        [Route("{alimentoId}")]
        public IActionResult GetById(long alimentoId)
        {
            return Execute(() => _alimentoService.GetById(alimentoId));
        }
    }
}
