using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class TreinoDto : BaseEntity
    {
        public string? Descricao { get; set; }
        public long? UsuarioId { get; set; }
        public long EmpresaId { get; set; }
    }
}
