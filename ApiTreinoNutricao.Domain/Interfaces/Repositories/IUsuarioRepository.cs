using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;

namespace ApiTreinoNutricao.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        IEnumerable<Usuario> GetByEmpresaId(long empresaId);
        ResponseDto<Usuario> Login(UsuarioLoginDto usuarioLogin);
    }
}
