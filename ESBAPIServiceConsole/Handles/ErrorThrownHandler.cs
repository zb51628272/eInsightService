using Rebus.Handlers;
using System.Threading.Tasks;
using Rebus.Bus;
using ESB_Classes.Events;
using ESB_Classes.Events.ReservationService;
using Rebus.Retry.Simple;
using System;

namespace ESBAPIServiceConsole.Handles
{
    class ErrorThrownHandler : IHandleMessages<ErrorThrown>
    {
        IBus Bus;

        public ErrorThrownHandler(IBus bus)
        {
            this.Bus = bus;
        }

        public Task Handle(ErrorThrown message)
        {
            return Task.CompletedTask;
        }
    }
}
