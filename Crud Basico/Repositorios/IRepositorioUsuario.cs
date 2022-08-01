using Crud_Basico.Modelo;

namespace Crud_Basico.Repositorios
{

    public interface IUsuarioRepositorio<T> where T : class
    {
        public List<Usuario> ListarUsuarios();

        public void SalvarRegistroUsuario(T entity);

        public void EditarRegistroUsuario(T entity);

        public void DeletarRegistroUsuario(int id);

    }
}
    