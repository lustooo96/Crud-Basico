using Crud_Basico.Model;

namespace Crud_Basico.Services
{
     public class ListaUsuario
     {
        private static object ObjetoFechado = new object();
        private static List<Usuario>? ListaUsuarios;
        private static int IdUsuario = 0;

        public static List<Usuario> ObterInstanciaListaUsuario
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
        public static int ContadorDeIndice()
        {
            IdUsuario += 1;
            return IdUsuario;
        }
    }
    
}
