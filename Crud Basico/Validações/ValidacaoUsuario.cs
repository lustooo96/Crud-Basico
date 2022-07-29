using Crud_Basico.Serviços;

namespace Crud_Basico.Validação
{
    public class ValidacaoUsuario
    {
        public static (bool validacao, string mensagem) EmailPodeSerCriado(string email, int id = 0)
        {
            var resultadoUsuario = ListaUsuario.ObterInstanciaDaListaUsuario.FirstOrDefault(
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
