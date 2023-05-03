using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Dto
{
    public class UsuarioDto : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public long EmpresaId { get; set; }
    }
}
