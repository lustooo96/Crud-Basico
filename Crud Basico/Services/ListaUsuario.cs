using Crud_Basico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Services
{
    class ListaUsuario
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>();
        public static void SalvarRegistro(Usuario usuario) 
        {
            ListaUsuarios.Add(usuario);
        }

        public static void AlterarRegistro(Usuario usuario) 
        {
            foreach (Usuario listaUsuario in ListaUsuarios) 
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
        }

        public static void DeletarRegistro(int id) 
        {
            ListaUsuarios.RemoveAll(v => v.Id == id);
        }
        public static int ContadorDeIncide() 
        { 
            if(ListaUsuarios.Count == 0) 
            {
                return ListaUsuarios.Count + 1;
            }
            else 
            {
                return ListaUsuarios[ListaUsuarios.Count - 1].Id + 1;
            }
        }
    }
}
