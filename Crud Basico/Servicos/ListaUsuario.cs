using Crud_Basico.Modelo;

namespace Crud_Basico.Servicos
{
    public sealed class ListaUsuario<T>
    {
        private static object ObjetoFechado = new object();
        private static List<T>? ListaUsuarios;
        private static int IdUsuario = 0;

        private ListaUsuario() 
        { 
        }
           
        public static List<T> ObterInstanciaDaListaUsuario
        {
            get
            {
                if (ListaUsuarios == null)
                {
                    lock (ObjetoFechado)
                    {
                        if (ListaUsuarios == null) ListaUsuarios = new List<T>();
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
