using Crud_Basico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Services
{
    public class UsuarioAcao
    {
        
        public static int ContarUsuarios() 
        {
            return ListaUsuario.ObterInstanciaListaUsuario.Count;
        }
    }
}
