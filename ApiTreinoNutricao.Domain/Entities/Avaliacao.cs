using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Avaliacao : BaseEntity
    {
        public string? Descricao { get; set; }
        public decimal MetabolismoBasal { get; set; }
        public decimal TreinoKcal { get; set; }
        public decimal Cardio { get; set; }

        //Composição Corporal
        public DateTime Data { get; set; }
        public decimal Peso { get; set; }
        public decimal MassaMuscular { get; set; }
        public int IdadeCorporal { get; set; }
        public decimal IMC { get; set; }
        public decimal GorduraCorporal { get; set; }
        public decimal GorduraViceral { get; set; }
        public decimal Pernas { get; set; }
        public decimal KgMassaMagra { get; set; }
        public decimal KgGordura { get; set; }
        public decimal RelacaoAbdomenOmbro { get; set; }
        public decimal RelacaoAbdomenPeito { get; set; }

        //Medidas Superires
        public decimal Ombro { get; set; }
        public decimal Peito { get; set; }
        public decimal BracoDireito { get; set; }
        public decimal BrasoEsquerdo { get; set; }
        public decimal Cintura { get; set; }
        public decimal Abdomen { get; set; }

        //Medidas Inferiores
        public decimal PernasInferiores { get; set; }
        public decimal PernaDireita { get; set; }
        public decimal PernaEsquerda { get; set; }
        public decimal PanturilhaDireita { get; set; }
        public decimal PanturilhaEsquerda { get; set; }

        public long UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}
