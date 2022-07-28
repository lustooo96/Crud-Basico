using Crud_Basico.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Validations
{
    public class ValidacaoUsuario
    {
        public static (bool validacao, string mensagem) EmailPodeSerCriado(string email, int id = 0)
        {
            var resultadoUsuario = ListaUsuario.ObterInstanciaListaUsuario.FirstOrDefault(
                usuario => usuario.Email.ToLower().Contains(email.ToLower()));

            if (resultadoUsuario == null || resultadoUsuario.Id == id)
            {
                return (true, "");
            }
            else
            {
                return (false, "Email já Cadastrado");
            }
        }
    }
}
