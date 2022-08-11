using CrudBasico.Dominio.Modelos;
using LinqToDB;

namespace CrudBasico.Infra.ConexaoLinqToDB
{
    public class BancoLinqToBD : LinqToDB.Data.DataConnection
    {

        public BancoLinqToBD() : base("System.Data.SqlClient", "Server=INVENT0081\\SQLEXPRESS;Database=dados;Uid=sa;Pwd=Daniela@12;")
        {
        }

        public ITable<Usuario> Usuario { get { return this.GetTable<Usuario>(); } }

    }
}
