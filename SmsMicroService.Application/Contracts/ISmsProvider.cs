using System.Threading.Tasks;

namespace SmsMicroService.Application.Contracts
{
    public interface ISmsProvider
    {
        Task<bool> SendMessage(string body, string phoneNumber);
    }
}
