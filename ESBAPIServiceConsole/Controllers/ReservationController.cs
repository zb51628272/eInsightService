using ESBAPIServiceConsole.Dal;
using ESBData.Models;
using Rebus.Activation;
using Rebus.Config;
using Rebus.Retry.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ESBAPIServiceConsole.Controllers
{
    public class ReservationController : ApiController
    {
        private static string ConnString = "amqp://localhost";
        private static string Queue = "ErrorThrownQueue";
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string ReservationPost(Reservation reservation)
        {
            var strResult = "ok";
            var test = reservation;
            if (test == null)
            {
                strResult = "false";
            }
            Depart depart = new Depart
            {
               depNo=1,
               depMan="qq",
               depName="qq"
            };
            DepartDal dal = new DepartDal();
            long n=dal.Add(depart);
            return strResult;

        }
        //public async Task SentEmail()
        //{
        //    //await    //启动rebus
        //    using (BuiltinHandlerActivator adapter = new BuiltinHandlerActivator())
        //    {
        //        adapter.Register(x => new Handles.ErrorThrownHandler(adapter.Bus));
        //        adapter.Register(x => new Handles.TransactionalEmailErrorHandler(adapter.Bus));

        //        Configure.With(adapter)
        //                .Transport(x => x.UseRabbitMq(ConnString, Queue))
        //                .Options(o => o.SimpleRetryStrategy(maxDeliveryAttempts: 1, secondLevelRetriesEnabled: true, errorQueueAddress: "ErrorThrownQueue"))
        //                .Start();
        //        await adapter.Bus.Advanced.Routing.Send(
        //        "TransactionalEmailQueue",
        //        new ESB_Classes.Commands.EmailService.SendTransactionalEmail
        //        {
        //            FromEmail = "wenqq2_flydog16@163.com",
        //            Subject = "mike测试邮件",
        //            ToEmail = "wenqq2_flydog16@163.com",
        //            BodyHTML = "mike测试邮件",
        //            FromName = null,
        //            ToName = null,
        //            BodyPlainText = null,
        //            ID = 3185312,
        //            FailMessage = false
        //        }
        //    );
                
        //    }
        //}
    }
}
