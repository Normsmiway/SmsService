using System;
using System.Linq;
using SmsMicroService.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace SmsMicroService.Infrastructure.Contracts.SmsProviders
{
    public class SmsProviderFactory : ISmsProviderFactory
    {
        private readonly IServiceProvider serviceProvider;
        public SmsProviderFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public ISmsProvider Create(string name = default)
        {
            var configuration = serviceProvider.GetService<IConfiguration>();
            var providerName = configuration["ConfigSection:SmsProvider"];
            //rather pick sms provider based on configuration
            if (string.IsNullOrWhiteSpace(name))
            {
                name = providerName;
            }

            return serviceProvider.GetServices<ISmsProvider>()
                .Where(c => c.GetType().Name == name).FirstOrDefault();
        }
    }
}
