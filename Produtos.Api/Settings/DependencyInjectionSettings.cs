using Produtos.Api.Interfaces;
using Produtos.Api.Services;

namespace Produtos.Api.Settings
{
    public static class DependencyInjectionSettings
    {
        public static void Ioc(this IServiceCollection services)
        {
            services.AddScoped<IProdutosService, ProdutosService>();
        }
    }
}