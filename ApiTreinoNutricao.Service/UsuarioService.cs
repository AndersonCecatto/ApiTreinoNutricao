using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Add(UsuarioDto usuarioDto) => _baseRepository.Insert(new Usuario(usuarioDto));

        public IEnumerable<Usuario> GetByEmpresaId(long empresaId) => _usuarioRepository.GetByEmpresaId(empresaId);

        public ResponseDto<Usuario> Login(UsuarioLoginDto usuarioLogin) => _usuarioRepository.Login(usuarioLogin);

        public UsuarioDto UpdateWithRule(UsuarioDto usuarioDto)
        {
            _baseRepository.UpdateWithRule(new Usuario(usuarioDto));
            return usuarioDto;
        }
    }
}
