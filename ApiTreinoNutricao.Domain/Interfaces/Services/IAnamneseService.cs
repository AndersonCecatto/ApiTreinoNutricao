using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IAnamneseService : IBaseService<Anamnese>
    {
        Anamnese Add(AnamneseDto anamnese);

        AnamneseDto UpdateWithRule(AnamneseDto anamneseDto);

        Anamnese GetByUsuarioId(long usuarioId);
    }
}
