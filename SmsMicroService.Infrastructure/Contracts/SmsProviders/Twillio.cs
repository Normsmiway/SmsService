using System.Net.Http;
using System.Threading.Tasks;
using SmsMicroService.Application.Contracts;

namespace SmsMicroService.Infrastructure.Contracts.SmsProviders
{
    internal class Twillio : ISmsProvider
    {
        private readonly HttpClient _httpClient;

        public Twillio(IHttpClientFactory clientFactory)
        {
           // _httpClient = clientFactory.CreateClient("twilioClient");
        }
        public async Task<bool> SendMessage(string body, string phoneNumber)
        {
            return true;
        }
    }
}
