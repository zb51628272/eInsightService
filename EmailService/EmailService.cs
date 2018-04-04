using System;
using System.IO;
using System.Threading;
using DasMulli.Win32.ServiceUtils;
using ESB_Classes.Commands.EmailService;
using EmailService.ESB_Handlers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rebus.Activation;
using Rebus.Config;
using Rebus.Routing.TypeBased;
using SendGrid;
using SendGrid.Helpers.Mail;
using Rebus.Retry.Simple;

namespace EmailService
{
    internal class EmailService : IWin32Service
    {
        private readonly string[] commandLineArguments;
        private BuiltinHandlerActivator adapter;

        private string ConnString = "amqp://localhost";
        private string Queue = "TransactionalEmailQueue";

        public EmailService(string[] commandLineArguments)
        {
            this.commandLineArguments = commandLineArguments;

            this.adapter = new BuiltinHandlerActivator();
            this.adapter.Register(x => new TransactionalEmailHandler(this.adapter.Bus));

            Configure.With(adapter)
                    .Transport(x => x.UseRabbitMq(ConnString, Queue))
                    .Options(x => x.SimpleRetryStrategy(maxDeliveryAttempts:1, secondLevelRetriesEnabled:true))
                    //.Routing(r => r.TypeBased().MapAssemblyOf<SendTransactionalEmail>("TransactionalEmailQueue"))
                     .Routing(r => r.TypeBased().MapAssemblyOf<SendTransactionalEmail>("TransactionalEmailQueue"))
                    .Start();
        }

        public string ServiceName => Program.ServiceName;

        public void Start(string[] startupArguments, ServiceStoppedCallback serviceStoppedCallback)
        {
        }

        public void Stop()
        {
        }
    }
}