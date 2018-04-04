using Rebus.Handlers;
using System.Threading.Tasks;
using Rebus.Bus;
using ESB_Classes.Events;
using ESB_Classes.Events.ReservationService;
using Rebus.Retry.Simple;
using System;

namespace ESB_UI.ESB_Handlers
{
    class ErrorThrownHandler : IHandleMessages<ErrorThrown>, IHandleMessages<IFailed<CancelReservationExtended>>
    {
        IBus Bus;
        ESB_UI Form;

        public ErrorThrownHandler(IBus bus, ESB_UI form)
        {
            this.Bus = bus;
            this.Form = form;
        }

        public Task Handle(ErrorThrown message)
        {
            Form.Errors.Add(message);

            return Task.CompletedTask;
        }

        public Task Handle(IFailed<CancelReservationExtended> message)
        {
            Form.Errors.Add
            (
                new ErrorThrown
                {
                    MessageName = "CancelReservationExtended",
                    Timestamp = DateTime.Now,
                    ErrorDesc = message.ErrorDescription
                }
            );

            return Task.CompletedTask;
        }
    }
}
