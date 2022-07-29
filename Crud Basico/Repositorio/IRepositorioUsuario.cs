using Crud_Basico.Modelo;

namespace Crud_Basico.Repositorio
{
    public interface IUsuarioRepositorio
    {
        public List<Usuario> ListarUsuarios();

        public void SalvarRegistroUsuario(Usuario usuario);

        public void EditarRegistroUsuario(Usuario usuario);

        public void DeletarRegistroUsuario(int id);

    }
}
    