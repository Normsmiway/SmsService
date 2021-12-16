using MediatR;
using System.Threading;
using System.Threading.Tasks;
using SmsMicroService.Application.Contracts;

namespace SmsMicroService.Application.UseCases.SendSms
{
    internal sealed class SendSmsCommandHandler : IRequestHandler<SendSmsCommand, string>
    {
        private readonly ISmsProviderFactory _smsProviderFactory;
        private readonly IEventBus _eventBus;

        public SendSmsCommandHandler(ISmsProviderFactory providerFactory, IEventBus eventBus)
        {
            _smsProviderFactory = providerFactory;
            _eventBus = eventBus;
        }
        public async Task<string> Handle(SendSmsCommand request, CancellationToken cancellationToken)
        {
            //pick twilio bt default
            var smsProvider = _smsProviderFactory.Create();
            var result = await smsProvider.SendMessage(request.Body, request.PhoneNumber);

            if (result)
            {
                await _eventBus.PublishAsync(new SmsSent(request.Body, request.PhoneNumber));
            }

            return "Sms sent successfully";
        }
    }
}
