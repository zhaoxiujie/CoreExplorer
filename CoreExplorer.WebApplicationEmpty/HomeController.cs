using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreExplorer.WebApplicationEmpty
{
    public class HomeController : Controller
    {
        private IClock _clock;
        public HomeController(IClock clock)
        {
            this._clock = clock;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["CurrentTimeMsg"] =$"It is {_clock.GetCurrentTime().ToString("T")}";
            return View();
        }
    }
}
