using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class MenuUsuarioDto : BaseEntity
    {
        public long UsuarioId { get; set; }
        public long MenuId { get; set; }
        public long EmpresaId { get; set; }
    }
}
