using System.Threading.Tasks;
using SmsMicroService.Application.Contracts;

namespace SmsMicroService.Infrastructure.Contracts.SmsProviders
{
    internal class Linx : ISmsProvider
    {

        public Task<bool> SendMessage(string body, string phoneNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
