using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanoAlimentarAlimentoController : BaseController
    {
        private readonly IPlanoAlimentarAlimentoService _planoAlimentarAlimentoService;

        public PlanoAlimentarAlimentoController(IPlanoAlimentarAlimentoService planoAlimentarAlimentoService)
        {
            _planoAlimentarAlimentoService = planoAlimentarAlimentoService;
        }

        [HttpPost]
        public IActionResult Inserir(PlanoAlimentarAlimentoDto planoAlimentarAlimentoDtos)
        {
            return Execute(() => _planoAlimentarAlimentoService.Add(planoAlimentarAlimentoDtos));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _planoAlimentarAlimentoService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(PlanoAlimentarAlimentoDto planoAlimentarAlimentoDtos)
        {
            return Execute(() => _planoAlimentarAlimentoService.UpdateWithRule(planoAlimentarAlimentoDtos));
        }

        [HttpGet]
        [Route("{planoAlimentarId}")]
        public IActionResult GetByPlanoAlimentarId(long planoAlimentarId)
        {
            return Execute(() => _planoAlimentarAlimentoService.GetByPlanoAlimentarId(planoAlimentarId));
        }
    }
}
