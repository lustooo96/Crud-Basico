using Crud_Basico.Dominio.Interfaces;
using Crud_Basico.Infra.Servicos;

namespace Crud_Basico.Infra.Repositorios
{
    public abstract class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected List<T> Lista = Lista<T>.ObterInstanciaDaListaSingleton;

        public abstract void Atualizar(T item);

        public virtual List<T> Listar() 
        {
            return Lista.ToList();
        }

        public abstract void Remover(int id);
            
        public virtual void Salvar(T item)
        {
            if (item == null) throw new Exception("Usuario não foi informado");
            Lista.Add(item);
        }
    }
}
