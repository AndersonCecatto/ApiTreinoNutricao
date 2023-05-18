using ApiTreinoNutricao.Controllers.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinoNutricao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetoAlunoController : BaseController
    {
        private readonly IProjetoAlunoService _projetoAlunoService;

        public ProjetoAlunoController(IProjetoAlunoService projetoAlunoService)
        {
            _projetoAlunoService = projetoAlunoService;
        }

        [HttpPost]
        public IActionResult Inserir(ProjetoAlunoDto projeto)
        {
            return Execute(() => _projetoAlunoService.Add(projeto));
        }

        [HttpDelete]
        [Route("{projetoAlunoId}")]
        public IActionResult Delete(long projetoAlunoId) 
        {
            return Execute(() => {
                _projetoAlunoService.Delete(projetoAlunoId);
                return true;
            });
        }

        [HttpGet]
        [Route("{projetoId}")]
        public IActionResult GetByProjetoId(long projetoId)
        {
            return Execute(() => _projetoAlunoService.GetByProjetoId(projetoId));
        }
    }
}
