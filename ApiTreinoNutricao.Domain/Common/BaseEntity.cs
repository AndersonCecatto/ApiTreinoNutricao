namespace ApiTreinoNutricao.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual long Id { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool? Ativo { get; set; }
    }
}
