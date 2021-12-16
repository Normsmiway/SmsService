using MediatR;

namespace SmsMicroService.Application.UseCases.SendSms
{
    public class SendSmsCommand : IRequest<string>
    {
        public string Body { get; private set; }
        public string PhoneNumber { get; private set; }

        public SendSmsCommand(string body, string phoneNumber)
        {
            Body = body;
            PhoneNumber = phoneNumber;
        }
    }
}
