using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class ResponseDto<T> where T : BaseEntity
    {
        public T? Dados { get; set; }
        public bool Sucesso { get; set; }
        public string? Mensagem { get; set; }
    }
}
