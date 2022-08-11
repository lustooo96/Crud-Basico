using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using test;

namespace CrudBasico.Infra.Migracoes
{
    public class ConexaoMigracao
    {

        private static string ConexaoString = "Server=INVENT0081\\SQLEXPRESS;Database=dados;Uid=sa;Pwd=Daniela@12;";
        private static IServiceProvider CriarServico()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(ConexaoString)
                    .ScanIn(typeof(AddUsuarioTable).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
    }
}
