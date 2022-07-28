using Crud_Basico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Services
{
    public class UsuarioAcao : ListaUsuario
    {
        private static int IdUsuario = 0;
        public static int ContadorDeIndice()
        {
            IdUsuario += 1;
            return IdUsuario;
        }
        public static int ContarUsuarios() 
        {
            return ListaUsuarios.Count;
        }
    }
}
