﻿using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IProjetoService : IBaseService<Projeto>
    {
        Projeto Add(ProjetoDto projetoDto);
        ProjetoDto UpdateWithRule(ProjetoDto projetoDto);
        IEnumerable<Projeto> GetByEmpresaId(long empresaId);
    }
}
