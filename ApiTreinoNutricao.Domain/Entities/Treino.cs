using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Treino : BaseEntity
    {
        public Treino() { }

        public Treino(TreinoDto treinoDto)
        {
            Id = treinoDto.Id;
            Descricao = treinoDto.Descricao;
            UsuarioId = treinoDto.UsuarioId;
            Ativo = treinoDto.Ativo;
        }

        public string? Descricao { get; set; }
        public long? UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
