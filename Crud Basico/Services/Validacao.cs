using System.Text.RegularExpressions;

namespace Crud_Basico.Services
{
    class Validacao
    {
        public static bool ValidarSenha(string senha)
        {
            return new Regex(@"^[A-Za-z0-9]*\d+[A-Za-z0-9]*$").IsMatch(senha);
        }

        public static bool ValidarEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase).IsMatch(email);
        }

        public static bool ValidarData(string data) 
        {
            return new Regex(@"(\d{2}\/\d{2}\/\d{4})").Match(data).Success;
        }
    }
}
