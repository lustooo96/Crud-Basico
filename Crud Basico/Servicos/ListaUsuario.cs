using Crud_Basico.Modelo;

namespace Crud_Basico.Servicos
{
    public sealed class ListaUsuario : IUsuarioRepositorio
    {
        private static object ObjetoFechado = new object();
        private static List<Usuario>? ListaUsuarios;
        private static int IdUsuario = 0;

        private ListaUsuario() 
        { 
        }
           
        public static List<Usuario> ObterInstanciaDaListaUsuario
        {
            get
            {
                if (ListaUsuarios == null)
                {
                    lock (ObjetoFechado)
                    {
                        if (ListaUsuarios == null) ListaUsuarios = new List<Usuario>();
                    }
                }
                return ListaUsuarios;
            }
        }
        
        public static void SalvarRegistroUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não foi informado");
            ObterInstanciaDaListaUsuario.Add(usuario);
        }

        public static void EditarRegistroUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não foi informado");
            var posicaoUsuarioEditar = ListaUsuario.ObterInstanciaDaListaUsuario.FindIndex(listaUsuario => listaUsuario.Id == usuario.Id);
            ObterInstanciaDaListaUsuario[posicaoUsuarioEditar] = usuario;
        }

        public static void DeletarRegistroUsuario(int id)
        {
            if (id == decimal.Zero) throw new Exception("O id não foi informado");
            ObterInstanciaDaListaUsuario.RemoveAll(usuario => usuario.Id == id);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return ObterInstanciaDaListaUsuario.ToList();
        }

        public static int ReceberNumeroDoIdUsuario()
        {
            IdUsuario++;
            return IdUsuario;
        }

    }

}

public interface IUsuarioRepositorio
{
    int ReceberNumeroDoIdUsuario();
    List<Usuario> ObterInstanciaDaListaUsuario();
    List<Usuario> ListarUsuarios();
    void SalvarRegistroUsuario(Usuario usuario);
    void EditarRegistroUsuario(Usuario usuario);
    void DeletarRegistroUsuario(int id);
}