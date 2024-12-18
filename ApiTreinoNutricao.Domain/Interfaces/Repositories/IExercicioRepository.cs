﻿using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IExercicioRepository : IBaseRepository<Exercicio>
    {
        IEnumerable<Exercicio> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca);
    }
}
