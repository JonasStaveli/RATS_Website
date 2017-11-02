using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RATS_Website.Controllers
{
    public class DndController : Controller
    {
        public IActionResult Index()
        {
            return View("DndOverview");
        }

        public IActionResult DndOverview()
        {
            return View();
        }

        public IActionResult Maps()
        {
            return View();
        }

        public IActionResult Campaigns()
        {
            return View();
        }
    }
}