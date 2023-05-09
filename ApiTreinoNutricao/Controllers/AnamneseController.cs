using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnamneseController : BaseController
    {
        private readonly IAnamneseService _anamneseService;

        public AnamneseController(IAnamneseService anamneseService)
        {
            _anamneseService = anamneseService;
        }

        [HttpPost]
        public IActionResult Inserir(AnamneseDto anamneseDto)
        {
            return Execute(() => _anamneseService.Add(anamneseDto));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _anamneseService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(AnamneseDto anamneseDto)
        {
            return Execute(() => _anamneseService.UpdateWithRule(anamneseDto));
        }

        [HttpGet]
        [Route("{usuarioId}")]
        public IActionResult GetByUsuarioId(long usuarioId)
        {
            return Execute(() => _anamneseService.GetByUsuarioId(usuarioId));
        }
    }
}
