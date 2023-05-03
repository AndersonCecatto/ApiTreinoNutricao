using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Usuario> GetByEmpresaId(long empresaId) 
            => _apiBaseContext.Set<Usuario>().Where(x => x.EmpresaId == empresaId);

        public ResponseDto<Usuario> Login(UsuarioLoginDto usuarioLogin)
        {
            var usuario = _apiBaseContext.Set<Usuario>().FirstOrDefault(x => x.Email == usuarioLogin.Email && x.Senha == usuarioLogin.Senha);

            if (usuario != null)
                return new ResponseDto<Usuario> { Dados = usuario, Sucesso = true };

            return new ResponseDto<Usuario>
            {
                Sucesso = false,
                Mensagem = "Usuário não encontrado!"
            };
        }
    }
}
