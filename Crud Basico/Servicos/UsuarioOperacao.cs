using Crud_Basico.Modelo;
using Crud_Basico.Repositorios;

namespace Crud_Basico.Servicos
{
    class UsuarioOperacao : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioOperacao() 
        { 
        }
       
        public override void Atualizar(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não foi informado");
            var usuarioSelecionado = Lista.FirstOrDefault(listaUsuario => listaUsuario.Id == usuario.Id);
            if(usuarioSelecionado == null) throw new Exception("Usuario não foi encontrado");
            usuarioSelecionado.Nome = usuario.Nome;
            usuarioSelecionado.Senha = usuario.Senha;
            usuarioSelecionado.Email = usuario.Email;
            usuarioSelecionado.DataNascimento = usuario.DataNascimento;
        }

        public override void Remover(int id)
        {
            if (id == decimal.Zero) throw new Exception("O id não foi informado");
            Lista.RemoveAll(usuario => usuario.Id == id);
        }

    }
}
