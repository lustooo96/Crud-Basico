using FluentMigrator.Runner;
using FluentMigrator.Runner.Initialization;
using Microsoft.Extensions.DependencyInjection;
using test;

namespace CrudBasico.Infra.Migracoes
{
    public class ConexaoMigracao
    {

        private static string ConexaoString = "Server=INVENT0081\\SQLEXPRESS;Database=dados;Trusted_Connection=True;Encrypt=False";
        public static IServiceProvider CriarServicos()
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

        public static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
    }
}
