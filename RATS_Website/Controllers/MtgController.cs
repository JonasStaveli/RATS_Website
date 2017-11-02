using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RATS_Website.Controllers
{
    public class MtgController : Controller
    {
        public IActionResult Index()
        {
            return View("MtgOverview");
        }

        public IActionResult Overview()
        {
            return View("MtgOverview");
        }

        public IActionResult Decks()
        {
            return View();
        }

        public IActionResult Collection()
        {
            return View();
        }
    }
}