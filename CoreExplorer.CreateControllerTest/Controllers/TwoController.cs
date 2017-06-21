using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreExplorer.CreateControllerTest.Controllers
{
    public class TwoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}