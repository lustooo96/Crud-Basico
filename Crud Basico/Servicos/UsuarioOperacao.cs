using Crud_Basico.Modelo;

namespace Crud_Basico.Servicos
{
    class UsuarioOperacao
    {
        public static void SalvarRegistroUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não foi informado");
            ListaUsuario.ObterInstanciaDaListaUsuario.Add(usuario);
        }

        public static void EditarRegistroUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não foi informado");
            var posicaoUsuarioEditar = ListaUsuario.ObterInstanciaDaListaUsuario.FindIndex(listaUsuario => listaUsuario.Id == usuario.Id);
            ListaUsuario.ObterInstanciaDaListaUsuario[posicaoUsuarioEditar] = usuario;
        }

        public static void DeletarRegistroUsuario(int id)
        {
            if (id == decimal.Zero) throw new Exception("O id não foi informado");
            ListaUsuario.ObterInstanciaDaListaUsuario.RemoveAll(usuario => usuario.Id == id);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return ListaUsuario.ObterInstanciaDaListaUsuario.ToList();
        }
    }
}
