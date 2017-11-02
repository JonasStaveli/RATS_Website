using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RATS_Website.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return View("OtherOverview");
        }

        public IActionResult OtherOverview()
        {
            return View();
        }

        public IActionResult Notes()
        {
            return View();
        }

        public IActionResult World()
        {
            return View();
        }

        public IActionResult Temp()
        {
            return View();
        }
    }
}