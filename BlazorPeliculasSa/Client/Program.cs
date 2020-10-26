using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorPeliculasSa.Client.Repositorios;
using Blazor.FileReader;
using BlazorPeliculasSa.Client.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorPeliculasSa.Client.Auth;

namespace BlazorPeliculasSa.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions(); //Sistema de autorizacuion
            services.AddSingleton<ServicioSingleton>();
            services.AddTransient<ServicioTransient>();
            services.AddScoped<IRepositorio, Repositorio>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
            services.AddScoped<IMostrarMensajes, MostrarMensajes>();
            services.AddAuthorizationCore();

            services.AddScoped<ProveedorAutenticacionJWT>();

            services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacionJWT>(
                provider => provider.GetRequiredService<ProveedorAutenticacionJWT>());
            services.AddScoped<ILoginService, ProveedorAutenticacionJWT>(
               provider => provider.GetRequiredService<ProveedorAutenticacionJWT>());

            services.AddScoped<RenovadorToken>();
        }

    }
}
