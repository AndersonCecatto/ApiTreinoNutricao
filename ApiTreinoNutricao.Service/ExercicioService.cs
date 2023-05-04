﻿using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class ExercicioService : BaseService<Exercicio>, IExercicioService
    {
        public ExercicioService(IExercicioRepository exercicioRepository) : base(exercicioRepository)
        {
            
        }
    }
}
