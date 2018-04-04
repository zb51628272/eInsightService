using ESBData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESBAPIServiceConsole.Dal
{
    public class DepartDal : BaseDal<Depart>, IDepartDal
    {
        protected override string DbName
        {
            get
            {
                return "SqlAllTheWay";

            }
        }
    }
}
