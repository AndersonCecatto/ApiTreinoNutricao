using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario() { }

        public Usuario(UsuarioDto usuarioDto) 
        {
            Id = usuarioDto.Id;
            Nome = usuarioDto.Nome;
            Cpf = usuarioDto.Cpf;
            Telefone = usuarioDto.Telefone;
            DataNascimento = usuarioDto.DataNascimento;
            Email = usuarioDto.Email;
            Senha = usuarioDto.Senha;
            EmpresaId = usuarioDto.EmpresaId;
            Ativo = usuarioDto.Ativo;
        }

        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}
