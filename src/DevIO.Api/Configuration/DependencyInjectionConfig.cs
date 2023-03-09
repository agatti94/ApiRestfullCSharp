using DevIO.Business.Intefaces;
using DevIO.Business.Notificacoes;
using DevIO.Business.Services;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using System.Runtime.CompilerServices;

namespace DevIO.Api.Configuration
{
    //É recomendado o uso de classes estáticas para manter métodos não associados com um objeto específico.
    //Elas são caracterizadas por não poderem ser herdadas, já que são seladas.
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
