using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Enum;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Alimento : BaseEntity
    {
        public Alimento()
        {
        }

        public Alimento(AlimentoDto alimentoDto)
        {
            Id = alimentoDto.Id;
            Nome = alimentoDto.Nome;
            Quantidade = alimentoDto.Quantidade;
            Medida = alimentoDto.Medida;
            Observacoes = alimentoDto.Observacoes;
            EmpresaId = alimentoDto.EmpresaId;
            Ativo = alimentoDto.Ativo;
        }

        public string? Nome { get; set; }
        public decimal Quantidade { get; set; }
        public MedidaEnum Medida { get; set; }
        public string? Observacoes { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
