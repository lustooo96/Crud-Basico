using CrudBasico.Dominio.Modelos;

namespace CrudBasico.Dominio.Interfaces
{

    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Usuario BuscarUsuarioPorId(int id);

        Usuario? BuscarUmUsuarioComEmailRepetido(string email);
    }
}
    