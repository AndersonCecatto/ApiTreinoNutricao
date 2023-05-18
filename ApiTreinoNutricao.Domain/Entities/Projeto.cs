using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Projeto : BaseEntity
    {
        public Projeto() { }

        public Projeto(ProjetoDto projetoDto)
        {
            Id = projetoDto.Id;
            Nome = projetoDto.Nome;
            EmpresaId = projetoDto.EmpresaId;
            Observacoes = projetoDto.Observacoes;
            PlanosAlimentares = projetoDto.PlanosAlimentares;
            Treinos = projetoDto.Treinos;
            Exames = projetoDto.Exames;
            Ativo = projetoDto.Ativo;
        }

        public string? Nome { get; set; }
        public string? Observacoes { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa? Empresa { get; set; }
        public string? PlanosAlimentares { get; set; }
        public string? Treinos { get; set; }
        public string? Exames { get; set; }
    }
}
