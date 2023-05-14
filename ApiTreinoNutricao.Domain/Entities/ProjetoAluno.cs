using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class ProjetoAluno : BaseEntity
    {
        public ProjetoAluno()
        {
            
        }

        public ProjetoAluno(ProjetoAlunoDto projetoAlunoDto)
        {
            Id = projetoAlunoDto.Id;
            ProjetoId = projetoAlunoDto.ProjetoId;
            UsuarioId = projetoAlunoDto.UsuarioId;
            PlanoAlimentarId = projetoAlunoDto.PlanoAlimentarId;
            TreinoId = projetoAlunoDto.TreinoId;
        }

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
