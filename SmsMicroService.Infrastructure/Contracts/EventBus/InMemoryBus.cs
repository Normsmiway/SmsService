using System.Threading.Tasks;
using SmsMicroService.Application;
using SmsMicroService.Application.Contracts;

namespace SmsMicroService.Infrastructure.Contracts.EventBus
{
    internal class InMemoryBus : IEventBus
    {
        public Task PublishAsync<TMessage>(TMessage message) where TMessage : IMessage
        {
            //Write into 
            return Task.CompletedTask;
        }
    }
}

