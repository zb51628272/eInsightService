using ESB_Classes.Commands.EmailService;
using ESB_Classes.Events;
using ESB_Classes.Events.ReservationService;
using ESB_UI.ESB_Handlers;
using Rebus.Activation;
using Rebus.Config;
using Rebus.Retry.Simple;
using Rebus.Routing.TypeBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESB_UI
{
    static class Program
    {
        private static string ConnString = "amqp://localhost";
        private static string Queue = "ErrorThrownQueue";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (BuiltinHandlerActivator adapter = new BuiltinHandlerActivator())
            {
                var ui = new ESB_UI(adapter);
                adapter.Register(x => new ErrorThrownHandler(adapter.Bus, ui));
                adapter.Register(x => new ReservationErrorHandler(adapter.Bus));
                adapter.Register(x => new TransactionalEmailErrorHandler(adapter.Bus));

                Configure.With(adapter)
                        .Transport(x => x.UseRabbitMq(ConnString, Queue))
                        .Options(o => o.SimpleRetryStrategy(maxDeliveryAttempts: 1, secondLevelRetriesEnabled: true, errorQueueAddress: "ErrorThrownQueue"))
                        //.Routing(r => r.TypeBased().MapAssemblyOf<CancelReservation>("CancelReservationQueue").MapAssemblyOf<SendTransactionalEmail>("TransactionalEmailQueue"))
                        .Start();

                Application.Run(ui);
            }
        }
    }
}
