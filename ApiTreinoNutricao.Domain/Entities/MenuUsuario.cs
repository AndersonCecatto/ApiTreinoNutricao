using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class MenuUsuario : BaseEntity
    {
        public MenuUsuario() { }

        public MenuUsuario(MenuUsuarioDto menuUsuarioDto)
        {
            Id = menuUsuarioDto.Id;
            UsuarioId = menuUsuarioDto.UsuarioId;
            MenuId = menuUsuarioDto.MenuId;
            EmpresaId = menuUsuarioDto.EmpresaId;
        }
        public long UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public long MenuId { get; set; }
        public virtual Menu? Menu { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}
