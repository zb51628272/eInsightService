using Rebus.Handlers;
using ESB_Classes.Events.ReservationService;
using System.Threading.Tasks;
using Rebus.Bus;
using ESB_Classes.Commands.EmailService;
using Rebus.Retry.Simple;
using ESB_Classes.Events;
using System;

namespace ReservationService.ESB_Handlers
{
    class ReservationHandler : IHandleMessages<CancelReservation>, IHandleMessages<IFailed<CancelReservation>>
    {
        IBus Bus;

        public ReservationHandler(IBus bus)
        {
            this.Bus = bus;
        }

        public async Task Handle(CancelReservation message)
        {
            if (message.FailMessage)
                throw new Exception("I was told to fail so I did. I blame Marcos.");

            // First get the details of the reservation and then compose an email
            // to send to the person.
            var customer = ReservationService.databaseManager.GetCustomerForReservation(message.ReservationID);

            string emailBody = $@"
<html>
	<head>

	</head>
	<body>
		<h4>We're sorry to see you go.</h4>

		<p>
            Hello {customer.FirstName},<br/><br/>

            We saw that you recently cancelled your reservation on {message.CancellationDate.ToShortDateString()}. How dare you.<br/><br/>

            If, however, you change your mind in the recent future, we will forgive you.<br/><br/>

            Remember, <u>we know where you live.</u><br/><br/>

            Sincerely,<br/><br/>

            Killer Hotel Group<br/><br/>

            BTW we hate {message.Device} users.
		</p>

	</body>
</html>";

            await this.Bus.Send(new SendTransactionalEmail
            {
                ToEmail = "crussell@cendyn.com",
                ToName = customer.FirstName + " " + customer.LastName,
                FromEmail = "crussell@cendyn.com",
                FromName = "Killer Hotel Group",
                Subject = "Cancelled Reservation",
                BodyHTML = emailBody,
                ID = 1581236
            });
        }

        public async Task Handle(IFailed<CancelReservation> message)
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
