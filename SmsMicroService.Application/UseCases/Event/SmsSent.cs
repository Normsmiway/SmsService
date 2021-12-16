using System;

namespace SmsMicroService.Application.UseCases.SendSms
{
    public class SmsSent : EventBase<Guid>
    {
        public string PhoneNumber { get; }
        public string Body { get; }
        public SmsSent(string body, string phoneNumber) : base(Guid.NewGuid(), DateTime.Now)
        {
            Body = body;
            PhoneNumber = phoneNumber;
        }

    }
}
