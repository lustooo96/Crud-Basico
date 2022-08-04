namespace CrudBasico.Dominio.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        void Salvar(T item);

        void Atualizar(T item);

        void Remover(int id);

        List<T> Listar();
    }
}
