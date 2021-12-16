using SmsMicroService.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using SmsMicroService.Infrastructure.Contracts.EventBus;
using SmsMicroService.Infrastructure.Contracts.SmsProviders;

namespace SmsMicroService.Infrastructure
{
    public static class Extension
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ISmsProvider, Twillio>();
            services.AddTransient<ISmsProvider, Linx>();
            services.AddTransient<ISmsProviderFactory,SmsProviderFactory>();
            services.AddSingleton<IEventBus, InMemoryBus>();
            return services;
        }
    }
}
