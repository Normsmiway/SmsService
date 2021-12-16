using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace SmsMicroService.Application
{
    public static class Extension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assemblies.Application);
            return services;
        }
    }
}
