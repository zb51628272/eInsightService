using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ESBAPIServiceConsole
{
    public class Test2Controller : ApiController
    {
        [HttpGet]
        public string Date()
        {
            return DateTime.Today.ToString("MM/dd/yyyy");
        }
    }
}
