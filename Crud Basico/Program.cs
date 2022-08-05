using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CrudBasico.Infra.Repositorios;
using CrudBasico.Dominio.Interfaces;

namespace CrudBasico
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IHost builder = CriarServicoInjecao().Build();
            FormPrincipal formPrincipal = builder.Services.GetRequiredService<FormPrincipal>();
            Application.Run(formPrincipal);
        }

        private static IHostBuilder CriarServicoInjecao() =>
         Host.CreateDefaultBuilder()
             .ConfigureServices((context, services) => ConfigurarServicosInjecao(services));

        private static void ConfigurarServicosInjecao(IServiceCollection servicos) 
        {
            servicos.AddTransient<IUsuarioRepositorio, RepositorioUsuarioSqlServer>().AddTransient<FormPrincipal>();
        }
    }
}