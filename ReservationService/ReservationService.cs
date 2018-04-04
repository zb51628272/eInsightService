using System;
using System.IO;
using System.Threading;
using DasMulli.Win32.ServiceUtils;
using ESB_Classes.Commands.EmailService;
using ESB_Classes.Events.ReservationService;
using Rebus.Activation;
using Rebus.Config;
using Rebus.Retry.Simple;
using Rebus.Routing.TypeBased;
using ReservationService.Classes.Managers;
using ReservationService.ESB_Handlers;

namespace ReservationService
{
    internal class ReservationService : IWin32Service
    {
        private readonly string[] commandLineArguments;
        private BuiltinHandlerActivator Adapter;

        private string ConnString = "amqp://localhost";
        private string Queue = "CancelReservationQueue";

        public static DatabaseManager databaseManager = new DatabaseManager();

        public ReservationService(string[] commandLineArguments)
        {
            this.commandLineArguments = commandLineArguments;

            if (Adapter != null)
                Adapter.Dispose();

            Adapter = new BuiltinHandlerActivator();
            Adapter.Register(x => new ReservationHandler(Adapter.Bus));

            Configure.With(Adapter)
                    .Transport(x => x.UseRabbitMq(ConnString, Queue))
                    .Options(o => o.SimpleRetryStrategy(maxDeliveryAttempts:1, secondLevelRetriesEnabled:true))
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