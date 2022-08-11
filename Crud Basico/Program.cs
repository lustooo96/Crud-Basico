using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CrudBasico.Infra.Repositorios;
using CrudBasico.Dominio.Interfaces;
using CrudBasico.Infra.ConexaoLinqToDB;
using FluentValidation;
using CrudBasico.Dominio.Validacoes;
using CrudBasico.Dominio.Modelos;
using CrudBasico.Infra.Migracoes;

namespace CrudBasico
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceProvider = ConexaoMigracao.CriarServicos();

            using (var scope = serviceProvider.CreateScope())
            {
                ConexaoMigracao.AtualizarBancoDeDados(scope.ServiceProvider);
            }

            ApplicationConfiguration.Initialize();
            IHost builder = CriarServicoInjecao().Build();
            var usuarioRepositorio = builder.Services.GetService<IUsuarioRepositorio>();
            var usarioValidador = builder.Services.GetService<IValidator<Usuario>>();
            Application.Run(new FormPrincipal(usuarioRepositorio , usarioValidador));
        }

        private static IHostBuilder CriarServicoInjecao() =>
         Host.CreateDefaultBuilder()
             .ConfigureServices((context, services) => ConfigurarServicosInjecao(services));

        private static void ConfigurarServicosInjecao(IServiceCollection servicos) 
        {
            servicos.AddScoped<IUsuarioRepositorio, RepositorioUsuarioLinqToBd>()
            .AddScoped<BancoLinqToBD>()
            .AddScoped<IValidator<Usuario>, UsuarioValidador>();
        }
    }
}