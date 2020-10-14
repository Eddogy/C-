
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First__Website_2.Properties
{
    [Route("[controller]")]
    public class MyTestController : Controller
    {
        public int Pitkas()
        {
            return 5;
        }

    }
}
