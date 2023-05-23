﻿using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class ExercicioService : BaseService<Exercicio>, IExercicioService
    {
        private readonly IExercicioRepository _exercicioRepository;
        public ExercicioService(IExercicioRepository exercicioRepository) : base(exercicioRepository)
        {
            _exercicioRepository = exercicioRepository;
        }

        public IEnumerable<Exercicio> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca) => _exercicioRepository.GetByEmpresaId(empresaId, tipoBusca);
    }
}
