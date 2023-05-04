using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Exercicio : BaseEntity
    {
        public string? Descricao { get; set; }
        public string? Serie { get; set; }
        public string? TempoDescanso { get; set; }
        public string? Repeticoes { get; set; }
        public string? Tecnica { get; set; }
    }
}
