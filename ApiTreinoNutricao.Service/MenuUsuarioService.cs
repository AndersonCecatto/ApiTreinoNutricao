using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using ApiTreinoNutricao.Domain.Interfaces.Services;
using ApiTreinoNutricao.Service.Common;

namespace ApiTreinoNutricao.Service
{
    public class MenuUsuarioService : BaseService<MenuUsuario>, IMenuUsuarioService
    {
        private readonly IMenuUsuarioRepository _menuUsuarioRepository;

        public MenuUsuarioService(IMenuUsuarioRepository menuUsuarioRepository) : base(menuUsuarioRepository)
        {
            _menuUsuarioRepository = menuUsuarioRepository;
        }

        public MenuUsuario Add(MenuUsuarioDto menuUsuarioDto) => _baseRepository.Insert(new MenuUsuario(menuUsuarioDto));

        public IEnumerable<MenuUsuario> GetByUsuarioIdEmpresaId(long usuarioId, long empresaId)
        {
            return _menuUsuarioRepository.GetByUsuarioIdEmpresaId(usuarioId, empresaId);
        }

        public MenuUsuarioDto UpdateWithRule(MenuUsuarioDto menuUsuarioDto)
        {
            _baseRepository.UpdateWithRule(new MenuUsuario(menuUsuarioDto));
            return menuUsuarioDto;
        }
    }
}
