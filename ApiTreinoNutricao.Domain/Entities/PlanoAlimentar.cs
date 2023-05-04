using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class PlanoAlimentar : BaseEntity
    {
        public PlanoAlimentar() { }

        public PlanoAlimentar(PlanoAlimentarDto planoAlimentarDto)
        {
            Id = planoAlimentarDto.Id;
            Descricao = planoAlimentarDto.Descricao;
            UsuarioId = planoAlimentarDto.UsuarioId;
            Ativo = planoAlimentarDto.Ativo;
        }

        public string? Descricao { get; set; }
        public long? UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
