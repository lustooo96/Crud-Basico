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
            var usuarioRepositorio = builder.Services.GetService<IUsuarioRepositorio>();

            Application.Run(new FormPrincipal(usuarioRepositorio));
        }

        private static IHostBuilder CriarServicoInjecao() =>
         Host.CreateDefaultBuilder()
             .ConfigureServices((context, services) => ConfigurarServicosInjecao(services));

        private static void ConfigurarServicosInjecao(IServiceCollection servicos) 
        {
            //servicos.AddScoped<IUsuarioRepositorio, RepositorioUsuarioSqlServer>();
            servicos.AddScoped<IUsuarioRepositorio, RepositorioUsuarioLinqToBd>();
        }
    }
}