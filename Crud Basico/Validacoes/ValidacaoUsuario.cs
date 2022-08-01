using Crud_Basico.Modelo;
using Crud_Basico.Servicos;

namespace Crud_Basico.Validacoes
{
    public class ValidacaoUsuario
    {
        public static (bool validacao, string mensagem) EmailPodeSerCriado(string email, int id = 0)
        {
            var resultadoUsuario = ListaUsuario<Usuario>.ObterInstanciaDaListaUsuario.FirstOrDefault(
                usuario => usuario.Email.ToLower().Contains(email.ToLower()));

            if (resultadoUsuario == null || resultadoUsuario.Id == id)
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
