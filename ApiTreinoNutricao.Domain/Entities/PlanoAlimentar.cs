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
            Alimentos = planoAlimentarDto.Alimentos;
            Observacoes = planoAlimentarDto.Observacoes;
            UsuarioId = planoAlimentarDto.UsuarioId;
            EmpresaId = planoAlimentarDto.EmpresaId;
            Ativo = planoAlimentarDto.Ativo;
        }

        public string? Descricao { get; set; }
        public string? Alimentos { get; set; }
        public string? Observacoes { get; set; }
        public long? UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
