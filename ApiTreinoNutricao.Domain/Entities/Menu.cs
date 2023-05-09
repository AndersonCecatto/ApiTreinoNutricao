using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string? Titulo { get; set; }
        public string? Icone { get; set; }
    }
}
