using System;

namespace SmsMicroService.Application.Contracts
{
    public interface ISmsProviderFactory
    {
        ISmsProvider Create(string name = default);
    }
}
