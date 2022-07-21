using Crud_Basico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Services
{
    class ListOperation
    {
        public static List<Usuario> SaveRegisterInList(List<Usuario> listUser ,Usuario usuario) 
        {
            listUser.Add(usuario);

            return listUser;
        }
        public static List<Usuario> UpdateRegisterInList(List<Usuario> listUser, Usuario usuario) 
        {
            listUser.Add(usuario);

            return listUser;
        }
        public static List<Usuario> DeleteRegisterInList(List<Usuario> listUser, Usuario userId) 
        {
            listUser.Remove(userId);

            return listUser;
        }

        public static List<Usuario> UpdateRegisterInList(List<Usuario> listUser, Usuario userId) 
        {


            return listUser;
        }
    }
}
