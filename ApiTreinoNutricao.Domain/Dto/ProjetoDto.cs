using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class ProjetoDto : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Observacoes { get; set; }
        public long EmpresaId { get; set; }
        public string? PlanosAlimentares { get; set; }
        public string? Treinos { get; set; }
        public string? Exames { get; set; }
    }
}
