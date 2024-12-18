﻿using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IPlanoAlimentarService : IBaseService<PlanoAlimentar>
    {
        PlanoAlimentar Add(PlanoAlimentarDto planoAlimentarDto);
        PlanoAlimentarDto UpdateWithRule(PlanoAlimentarDto planoAlimentarDto);
        IEnumerable<PlanoAlimentar> GetByUsuarioId(long usuarioId);
        IEnumerable<PlanoAlimentar> GetByEmpresaId(long empresaId);
        IEnumerable<PlanoAlimentar> BuscarPorIdsPlanosAlimentares(IEnumerable<int> idsPlanosAlimentares);
    }
}
