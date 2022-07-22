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
        public static List<Usuario> SaveRegisterInList(List<Usuario> listaUsuarios, Usuario usuario) 
        {
            listaUsuarios.Add(usuario);

            return listaUsuarios;
        }
        public static List<Usuario> UpdateRegisterInList(List<Usuario> listaUsuarios, Usuario usuario) 
        {
            foreach (Usuario listaUsuario in listaUsuarios) 
            {
                if (listaUsuario.Id == usuario.Id) 
                {
                    listaUsuario.Nome = usuario.Nome;
                    listaUsuario.Senha = usuario.Senha;
                    listaUsuario.Email = usuario.Email;
                    listaUsuario.DataNascimento = usuario.DataNascimento;
                    listaUsuario.DataCriacao = usuario.DataCriacao;
                }
            }
            return listaUsuarios;
        }
        public static List<Usuario> DeleteRegisterInList(List<Usuario> listaUsuarios, int id) 
        {
            listaUsuarios.RemoveAll(v => v.Id == id);

            return listaUsuarios;
        }

        public static int ContadorDeIncide(List<Usuario> listaUsuarios) 
        { 
            if(listaUsuarios.Count == 0) 
            {
                return listaUsuarios.Count + 1;
            }
            else 
            {
                return listaUsuarios[listaUsuarios.Count - 1].Id + 1;
            }


            return 0;
        }


    }
}
