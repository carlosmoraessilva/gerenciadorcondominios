using Gerenciador_Condominios.DAL.Interfaces;
using Gerenciador_Condominios.DAL.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Gerenciador_Condominios.DAL
{
    public static class ConfiguracaoRepositoriosExtension
    {

        public static void ConfigurarRepositorios(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
        }

    }
}
