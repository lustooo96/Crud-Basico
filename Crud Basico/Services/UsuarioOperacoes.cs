using Crud_Basico.Model;

namespace Crud_Basico.Services
{
    class UsuarioOperacoes : ListaUsuario
    {
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
    }
}
