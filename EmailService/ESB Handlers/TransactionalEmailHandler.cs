using ESB_Classes.Commands.EmailService;
using EmailService.Email_Clients;
using Rebus.Handlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Rebus.Retry.Simple;
using ESB_Classes.Events;
using Rebus.Bus;

namespace EmailService.ESB_Handlers
{
    class TransactionalEmailHandler : IHandleMessages<SendTransactionalEmail>, IHandleMessages<IFailed<SendTransactionalEmail>>
    {
        private SendGridEmailClient sendGridEmailClient = new SendGridEmailClient();
        private IBus Bus;

        public TransactionalEmailHandler(IBus bus)
        {
            this.Bus = bus;
        }

        public async Task Handle(SendTransactionalEmail message)
        {
            if (message.FailMessage)
                throw new Exception("I was told to fail so I did. I blame Marcos.");

            await sendGridEmailClient.SendTransactionalEmail(new Email_Classes.EmailParcel
            {
                FromEmail = message.FromEmail,
                FromName = message.FromName,
                HTMLContent = message.BodyHTML,
                PlainTextContent = message.BodyPlainText,
                Subject = message.Subject,

                Recipients = new List<Email_Classes.EmailRecipient> { new Email_Classes.EmailRecipient { ToEmail = message.ToEmail, ToName = message.ToName } }
            });
        }

        public async Task Handle(IFailed<SendTransactionalEmail> message)
        {
            await this.Bus.Advanced.Routing.Send(
                "ErrorThrownQueue",
                new ErrorThrown
                {
                    MessageName = "SendTransactionalEmail",
                    ErrorDesc = message.ErrorDescription,
                    Timestamp = DateTime.Now
                }
            );
        }
    }
}
