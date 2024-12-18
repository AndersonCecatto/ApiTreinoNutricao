﻿using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface ITreinoExercicioRepository : IBaseRepository<TreinoExercicio>
    {
        IEnumerable<TreinoExercicio> GetByTreinoId(long treinoId);
    }
}
