using System.Text.RegularExpressions;

namespace Crud_Basico.Services
{
    class Validacao
    {
        public static (bool validacao, string messagem) ValidarNome(string nome) 
        {
            if (nome.Length == 0) return (false,"Informe o seu Nome");

            return (true, "");
        }
        public static (bool validacao, string messagem) ValidarSenha(string senha) 
        {
            if (senha.Length == decimal.Zero) return (false, "Informe sua senha");

            return (true, "");
        }
        public static (bool validacao , string messagem) ValidarEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if (email.Length == 0) 
            {
                return (false, "Informe seu email");
            } 
            else if (!UsuarioAcao.BuscarEmailRepetido(email.ToLower()))
            {
                return (false, "Email já cadastrado");
            } else if (!new Regex(pattern, RegexOptions.IgnoreCase).IsMatch(email)) 
            {
                return (false, "Digite um email válido");
            }
            return (true , "");
        }
    }
}
