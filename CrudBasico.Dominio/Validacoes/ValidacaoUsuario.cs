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
            List<Usuario> listaUsuarios = _usuarioRepositorio.Listar();
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
  