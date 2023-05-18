using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class ProjetoAlunoDto : BaseEntity
    {
        public long ProjetoId { get; set; }
        public long UsuarioId { get; set; }
    }
}
