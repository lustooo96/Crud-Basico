using System.Text.RegularExpressions;

namespace Crud_Basico.Validations
{
    class Validacao
    {
        public static (bool validacao, string mensagem) ValidarNome(string nome)
        {
            if (nome.Length == 0 || string.IsNullOrWhiteSpace(nome)) return (false, "Informe o seu Nome");
            return (true, "");
        }
        public static (bool validacao, string mensagem) ValidarSenha(string senha)
        {
            if (senha.Length == decimal.Zero || string.IsNullOrWhiteSpace(senha)) return (false, "Informe sua senha");
            return (true, "");
        }

        public static (bool validacao, string mensagem) ValidarEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            if (email.Length == 0 || string.IsNullOrWhiteSpace(email)) return (false, "Informe seu email");
            else if (!new Regex(pattern, RegexOptions.IgnoreCase).IsMatch(email)) return (false, "Digite um email válido");

            return (true, "");
        }

        public static (bool validacao, string mensagem) ValidarDataNascimento(string data)
        {
            if (data.Replace("/", "").Trim().Length != decimal.Zero)
            {
                if (!ValidarData(data)) return (false, "Digite uma data válida");
                else if (DateTime.Parse(data) > DateTime.Today || DateTime.Parse(data) < new DateTime(1930, 12, 30))
                    return (false, "Digite uma data Válida");
            }
            return (true, "");
        }
        public static bool ValidarData(string data)
        {
            var regex = new Regex(@"(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/((1[2-9]|[2-9][0-9])[0-9]{2})");
            return regex.Match(data).Success;

        }
    }
}
