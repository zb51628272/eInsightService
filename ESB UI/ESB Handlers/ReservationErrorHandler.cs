using Rebus.Handlers;
using ESB_Classes.Events.ReservationService;
using System.Threading.Tasks;
using Rebus.Bus;
using Rebus.Retry.Simple;
using ESB_Classes.Events;
using System;

namespace ESB_UI.ESB_Handlers
{
    class ReservationErrorHandler : IHandleMessages<IFailed<CancelReservationExtended>>
    {
        IBus Bus;

        public ReservationErrorHandler(IBus bus)
        {
            this.Bus = bus;
        }
        
        public async Task Handle(IFailed<CancelReservationExtended> message)
        {
            await this.Bus.Advanced.Routing.Send(
                "ErrorThrownQueue",
                new ErrorThrown
                {
                    MessageName = "CancelReservation",
                    ErrorDesc = message.ErrorDescription,
                    Timestamp = DateTime.Now
                }
            );
        }
    }
}
