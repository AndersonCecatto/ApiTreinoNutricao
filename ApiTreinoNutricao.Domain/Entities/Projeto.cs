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
            PlanoAlimentar = projetoDto.PlanoAlimentar;
            Treino = projetoDto.Treino;
            Foto = projetoDto.Foto;
            Avaliacao = projetoDto.Avaliacao;
            Exame = projetoDto.Exame;
            Anamnese = projetoDto.Anamnese;
            EmpresaId = projetoDto.EmpresaId;
            Observacoes = projetoDto.Observacoes;
            Ativo = projetoDto.Ativo;
        }

        public string? Nome { get; set; }
        public bool PlanoAlimentar { get; set; }
        public bool Treino { get; set; }
        public bool Foto { get; set; }
        public bool Avaliacao { get; set; }
        public bool Exame { get; set; }
        public bool Anamnese { get; set; }
        public string? Observacoes { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}
