using ESB_Classes.Commands.EmailService;
using Rebus.Handlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Rebus.Retry.Simple;
using ESB_Classes.Events;
using Rebus.Bus;

namespace ESB_UI.ESB_Handlers
{
    class TransactionalEmailErrorHandler : IHandleMessages<IFailed<SendTransactionalEmail>>
    {
        private IBus Bus;

        public TransactionalEmailErrorHandler(IBus bus)
        {
            this.Bus = bus;
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
