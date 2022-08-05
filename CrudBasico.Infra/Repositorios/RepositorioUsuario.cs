using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;

namespace CrudBasico.Infra.Repositorios
{
    public class RepositorioUsuario : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public RepositorioUsuario()
        {
        }
        public override void Atualizar(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuario não foi informado");
            var usuarioSelecionado = Lista.FirstOrDefault(listaUsuario => listaUsuario.IdUsuario == usuario.IdUsuario);
            usuarioSelecionado!.Nome = usuario.Nome;
            usuarioSelecionado.Senha = usuario.Senha;
            usuarioSelecionado.Email = usuario.Email;
            usuarioSelecionado.DataNascimento = usuario.DataNascimento;
        }
        public override Usuario BuscarUsuarioPorId(string id) 
        {
            var idUsuario = Convert.ToInt32(id);
            if (idUsuario == null) throw new Exception("Id não foi informado");
            Usuario usuario = Lista.FirstOrDefault(listaUsuario => listaUsuario.IdUsuario == idUsuario);
            return usuario;
        }

        public override void Remover(int id)
        {
            if (id == decimal.Zero) throw new Exception("O id não foi informado");
            Lista.RemoveAll(usuario => usuario.IdUsuario == id);
        }

    }
}
