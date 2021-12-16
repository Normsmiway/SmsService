using System;

namespace SmsMicroService.Application.UseCases.SendSms
{
    public abstract class EventBase<TId> : IMessage
    {
        protected DateTime OccuredOn { get; }
        protected TId Id { get; }
        public EventBase(TId id, DateTime occuredOn)
        {
            Id = id;
            OccuredOn = occuredOn;
        }
    }
}
