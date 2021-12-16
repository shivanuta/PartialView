using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Films films = new Films();
            return View(films.FilmsDetails);
        }


        public ActionResult Default()
        {
            Films films = new Films();
            return View(films.FilmsDetails);
        }
    }
}
