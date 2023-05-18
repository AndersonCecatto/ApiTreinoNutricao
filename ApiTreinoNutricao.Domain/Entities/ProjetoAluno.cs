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
        }

        public long ProjetoId { get; set; }
        public virtual Projeto? Projeto { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }        
    }
}
