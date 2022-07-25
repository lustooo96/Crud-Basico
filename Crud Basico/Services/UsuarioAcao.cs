using Crud_Basico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Services
{
    class UsuarioAcao : ListaUsuario
    {
        private static int IdUsuario = 0;
        public static int ContadorDeIncide()
        {
            IdUsuario += 1;
            return IdUsuario;
        }
        public static int QuantidadeUsuarios() 
        {
            return ListaUsuarios.Count;
        }

        public static bool BuscarEmailRepetido(string email)
        {
            foreach (Usuario listaUsuario in ListaUsuarios)
            {
                if (listaUsuario.Email!.ToLower() == email) return false;
            }

            return true;
        }
    }
}
