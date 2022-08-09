using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;
using CrudBasico.Infra.Validacoes;

namespace CrudBasico.Dominio.Validacoes
{
    public class ValidacaoUsuario
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ValidacaoUsuario(IUsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;

        }

        public (bool validacao, string mensagem) EmailPodeSerCriado(string email, int id)
        {
            var resultadoUsuario = _usuarioRepositorio.BuscarUmUsuarioComEmailRepetido(email);
            if (resultadoUsuario != null && resultadoUsuario.IdUsuario != id)
            {
                return (false, "Email já Cadastrado");
            }
            else 
            {
                return Validacao.ValidarEmail(email);
            }
        }
    }
}
  