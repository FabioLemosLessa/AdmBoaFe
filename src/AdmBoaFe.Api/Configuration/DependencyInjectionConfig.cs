using AdmBoaFe.Api.Extensions;
using AdmBoaFe.Business.Intefaces;
using AdmBoaFe.Data.Context;
using AdmBoaFe.Data.Repository;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace AdmBoaFe.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IImovelRepository, ImovelRepository>();
            services.AddScoped<ICondominioRepository, CondominioRepository>();
            services.AddScoped<IProprietarioRepository, ProprietarioRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            return services;
        }
    }
}