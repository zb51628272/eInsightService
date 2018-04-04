using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ESBAPIServiceConsole.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string Date()
        {
            return DateTime.Today.ToString("yyyy/MM/dd");
        }
    }
}
