using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class ProjetoAluno : BaseEntity
    {
        public long ProjetoId { get; set; }
        public virtual Projeto? Projeto { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public long? PlanoAlimentarId { get; set; }
        public virtual PlanoAlimentar? PlanoAlimentar { get; set; }
        public long? TreinoId { get; set; }
        public virtual Treino? Treino { get; set; }
    }
}
