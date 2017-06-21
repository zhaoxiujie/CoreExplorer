using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreExplorer.CreateControllerTest.Controllers
{
    [Produces("application/json")]
    [Route("api/One")]
    public class OneController : Controller
    {
    }
}