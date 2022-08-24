using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;
using CrudBasico.Dominio.Validacoes;
using CrudBasico.Infra.BancoLinqToDB;
using CrudBasico.Infra.Repositorios;
using FluentValidation;

namespace CrudBascio.WebApi
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(services =>
            {
                services.AddPolicy("CorsPolicy", build => build
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            });


            services.AddScoped<IUsuarioRepositorio, RepositorioUsuarioLinqToBd>()
                .AddScoped<BancoLinqToBD>();
            services.AddScoped<IValidator<Usuario>, UsuarioValidador>();
            
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("CorsPolicy");

            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
