using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Services
{
    class UsuarioAcoes : ListaUsuario
    {
        public static int ContadorDeIncide()
        {
            IdUsuario += 1;
            return IdUsuario;
        }
        public static int QuantidadeUsuarios() 
        {
            return ListaUsuarios.Count;
        }
    }
}
