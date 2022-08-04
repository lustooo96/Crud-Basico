using Crud_Basico.Dominio.Modelos;
using Crud_Basico.Infra.Repositorios;

namespace Crud_Basico.Infra.Validacoes
{
    public class ValidacaoUsuario
    {
        public static (bool validacao, string mensagem) EmailPodeSerCriado(string email, int id = 0)
        {
            RepositorioUsuarioSqlServer repositorioSqlServer = new RepositorioUsuarioSqlServer();
            List<Usuario> listaUsuarios = repositorioSqlServer.Listar();

            Usuario? resultadoUsuario = listaUsuarios.FirstOrDefault(
                usuario => usuario.Email.ToLower().Contains(email.ToLower()));

            if (resultadoUsuario == null || resultadoUsuario.IdUsuario == id)
            {
                return (true, "");
            }
            else
            {
                return (false, "Email já Cadastrado");
            }
        }
    }
}
