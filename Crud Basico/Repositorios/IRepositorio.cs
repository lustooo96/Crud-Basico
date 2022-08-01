using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Basico.Repositorios
{
    public interface IRepositorio<T> where T : class
    {
        void Salvar(T item);

        void Atualizar(T item);

        void Remover(int id);
        List<T> Listar();
    }
}
