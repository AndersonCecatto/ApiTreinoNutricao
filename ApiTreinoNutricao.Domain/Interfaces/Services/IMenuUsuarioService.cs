using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IMenuUsuarioService : IBaseService<MenuUsuario>
    {
        MenuUsuario Add(MenuUsuarioDto menuUsuarioDto);
        MenuUsuarioDto UpdateWithRule(MenuUsuarioDto menuUsuarioDto);
        IEnumerable<MenuUsuario> GetByUsuarioIdEmpresaId(long usuarioId, long empresaId);
    }
}
