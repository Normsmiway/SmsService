using System.Threading.Tasks;

namespace SmsMicroService.Application.Contracts
{
    public interface IEventBus
    {
        Task PublishAsync<TMessage>(TMessage message) where TMessage : IMessage;
    }
}
