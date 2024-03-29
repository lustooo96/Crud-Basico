﻿
namespace CrudBasico.Dominio.Servicos
{
    public sealed class ServicoListaSingleton<T>
    {
        private static object ObjetoFechado = new object();
        private static List<T>? ListaSingleton;
        private static int Id = 0;

        private ServicoListaSingleton() 
        { 
        }
           
        public static List<T> ObterInstanciaDaListaSingleton
        {
            get
            {
                if (ListaSingleton == null)
                {
                    lock (ObjetoFechado)
                    {
                        if (ListaSingleton == null) ListaSingleton = new List<T>();
                    }
                }
                return ListaSingleton;
            }
        }

        public static int ReceberNumeroDoId()
        {
            Id++;
            return Id;
        }
    }
    
}
