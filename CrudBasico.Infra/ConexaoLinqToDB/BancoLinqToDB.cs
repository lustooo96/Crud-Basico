using CrudBasico.Dominio.Modelos;
using LinqToDB;

namespace CrudBasico.Infra.ConexaoLinqToDB
{
    public class BancoLinqToBD : LinqToDB.Data.DataConnection
    {
        private static string ProviderName = "System.Data.SqlClient";
        private static string ConexaoString = "Server=INVENT0081\\SQLEXPRESS;Database=dados;Uid=sa;Pwd=Daniela@12;";

        public BancoLinqToBD() : base(ProviderName, ConexaoString)
        {
        }

        public ITable<Usuario> Usuario { get { return this.GetTable<Usuario>(); } }

    }
}
