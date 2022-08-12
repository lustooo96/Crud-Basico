using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace CrudBasico.Infra.Migracoes
{
    public class Migracao
    {

        private static string ConexaoString = "Server=INVENT0081\\SQLEXPRESS;Database=dados;Trusted_Connection=True;Encrypt=False";
        public static IServiceProvider CriarServicos()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(ConexaoString)
                    .ScanIn(typeof(AdicionarTabelaDeUsuario).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        public static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
    }
}
