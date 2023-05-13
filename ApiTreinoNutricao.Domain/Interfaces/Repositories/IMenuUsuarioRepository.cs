﻿using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IMenuUsuarioRepository : IBaseRepository<MenuUsuario>
    {
        IEnumerable<MenuUsuario> GetByUsuarioIdEmpresaId(long usuarioId, long empresaId);
    }
}