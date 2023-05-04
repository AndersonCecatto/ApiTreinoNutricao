using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class ArquivoPlanoAlimentar : BaseEntity
    {
        public string? Descricao { get; set; }
        public byte[]? Arquivo { get; set; }
        public long PlanoAlimentarAlimentoId { get; set; }
        public virtual PlanoAlimentarAlimento? PlanoAlimentarAlimento { get; set; }
    }
}
