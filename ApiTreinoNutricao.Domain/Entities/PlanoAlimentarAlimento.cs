using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class PlanoAlimentarAlimento : BaseEntity
    {
        public PlanoAlimentarAlimento()
        {
        }

        public PlanoAlimentarAlimento(PlanoAlimentarAlimentoDto planoAlimentarAlimentoDto)
        {
            Id = planoAlimentarAlimentoDto.Id;
            PlanoAlimentarId = planoAlimentarAlimentoDto.PlanoAlimentarId;
            AlimentoId = planoAlimentarAlimentoDto.AlimentoId;
            Observacoes = planoAlimentarAlimentoDto.Observacoes;
            Ativo = planoAlimentarAlimentoDto.Ativo;
        }

        public long AlimentoId { get; set; }
        public virtual Alimento? Alimento { get; set; }
        public long PlanoAlimentarId { get; set; }
        public virtual PlanoAlimentar? PlanoAlimentar { get; set; }
        public string? Observacoes { get; set; }
    }
}
