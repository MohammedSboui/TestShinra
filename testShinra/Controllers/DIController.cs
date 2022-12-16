using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testShinra.Service2;

namespace testShinra.Controllers
{
    [Route("[controller]")]
    public class DIController : Controller
    {
       private readonly IEnumerable<IService> _services;
       public DIController(IEnumerable<IService> services)
       {
        _services=services.ToList();
       }
    }
}