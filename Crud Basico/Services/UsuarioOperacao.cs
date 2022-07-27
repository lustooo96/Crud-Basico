using Crud_Basico.Model;

namespace Crud_Basico.Services
{
    class UsuarioOperacao : ListaUsuario
    {
        public static void SalvarRegistroUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não informado");
            ListaUsuarios.Add(usuario);
        }

        public static void EditarRegistroUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não informado");
            var indexUsuarioEditar = ListaUsuarios.FindIndex(listaUsuario => listaUsuario.Id == usuario.Id);
            ListaUsuarios[indexUsuarioEditar] = usuario;
        }

        public static void DeletarRegistroUsuario(int id)
        {
            if (id == decimal.Zero) throw new Exception("O id não foi informado");
            ListaUsuarios.RemoveAll(usuario => usuario.Id == id);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return ListaUsuarios.ToList();
        }
    }
}
