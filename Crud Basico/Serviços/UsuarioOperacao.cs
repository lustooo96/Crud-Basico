using Crud_Basico.Model;

namespace Crud_Basico.Services
{
    class UsuarioOperacao
    {
        public static void SalvarRegistroUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não informado");
            ListaUsuario.ObterInstanciaListaUsuario.Add(usuario);
        }

        public static void EditarRegistroUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não informado");
            var indexUsuarioEditar = ListaUsuario.ObterInstanciaListaUsuario.FindIndex(listaUsuario => listaUsuario.Id == usuario.Id);
            ListaUsuario.ObterInstanciaListaUsuario[indexUsuarioEditar] = usuario;
        }

        public static void DeletarRegistroUsuario(int id)
        {
            if (id == decimal.Zero) throw new Exception("O id não foi informado");
            ListaUsuario.ObterInstanciaListaUsuario.RemoveAll(usuario => usuario.Id == id);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return ListaUsuario.ObterInstanciaListaUsuario.ToList();
        }
    }
}
