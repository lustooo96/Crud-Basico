using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;

namespace CrudBasico.Dominio.Validacoes
{
    public class ValidacaoUsuario
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ValidacaoUsuario(IUsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;

        }
        public (bool validacao, string mensagem) EmailPodeSerCriado(string email, int id = 0)
        {
            var resultadoUsuario = _usuarioRepositorio.BuscarUsuarioComEmailRepetido(email);
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
  