using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Data.Repositories.Common;
using ApiTreinoNutricao.Domain.Dto;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories;

namespace ApiTreinoNutricao.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Usuario> GetByEmpresaId(long empresaId, BuscarUsuarioEnum tipoBusca)
        {
            var consulta = _apiBaseContext.Set<Usuario>().Where(x => x.EmpresaId == empresaId);

            switch (tipoBusca)
            {
                case BuscarUsuarioEnum.Ativos:
                    consulta = consulta.Where(x => x.Ativo == true);
                    break;
                case BuscarUsuarioEnum.Inativos:
                    consulta = consulta.Where(x => x.Ativo == false);
                    break;
                default: 
                    return consulta;
            }

            return consulta;
        } 

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
