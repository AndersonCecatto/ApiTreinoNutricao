using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Services.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Services
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        IEnumerable<Usuario> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca);
        Usuario Add(UsuarioDto usuarioDto);
        UsuarioDto UpdateWithRule(UsuarioDto usuarioDto);
        ResponseDto<Usuario> Login(UsuarioLoginDto usuarioLogin);
    }
}
