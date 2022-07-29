using Crud_Basico.Modelo;

namespace Crud_Basico.Servicos
{
    public sealed class ListaUsuario 
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
        public static int ReceberNumeroDoIdUsuario()
        {
            IdUsuario++;
            return IdUsuario;
        }
    }
    
}
