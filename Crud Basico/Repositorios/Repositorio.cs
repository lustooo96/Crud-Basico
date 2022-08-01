using Crud_Basico.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Repositorios
{
    public abstract class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected List<T> Lista = ListaUsuario<T>.ObterInstanciaDaListaUsuario;

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
