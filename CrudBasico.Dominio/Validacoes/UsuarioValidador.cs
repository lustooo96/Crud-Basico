using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;
using FluentValidation;
using System.Text.RegularExpressions;

namespace CrudBasico.Dominio.Validacoes
{
    public class UsuarioValidador : AbstractValidator<Usuario>
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioValidador(IUsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;

            RuleFor(usuario => usuario.Nome)
                .NotEmpty()
                .WithMessage("Necessario informar o Nome");

            RuleFor(usuario => usuario.Senha)
                .NotEmpty()
                .WithMessage("Necessario informar a Senha");

            RuleFor(usuario => usuario.Email)
                .NotEmpty()
                .WithMessage("Nécessario informar o Email")
                .Must(ValidarEmail)
                .WithMessage("Email inválido , informe um email @ e .com")
                .Must((usuario , email) => EmailPodeSerCriado(usuario , email))
                .WithMessage("Email já Cadastrado");

            RuleFor(usuario => usuario.DataNascimento)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Data de nascimento invalida")
                .GreaterThan(DateTime.Parse("19/08/1900"))
                .WithMessage("Data de nascimento invalida , informe uma data maior que 19/08/1900")
                .Equals("");
        }

        private bool EmailPodeSerCriado(Usuario usuario , string email)
        {
            var resultadoUsuario = _usuarioRepositorio.BuscarUmUsuarioComEmailRepetido(email);
            if (resultadoUsuario != null && usuario.IdUsuario != resultadoUsuario.IdUsuario)
            {
                return false;
            }

            return true;
        }
        private static bool ValidarEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email)) 
            {
                string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

                if (!new Regex(pattern, RegexOptions.IgnoreCase).IsMatch(email)) return false;
            }
            return true;
        }

    }
}
