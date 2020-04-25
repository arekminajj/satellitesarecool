using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using satelitesarecool.Models;

namespace satelitesarecool.Controllers
{
    public class EarthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EarthImage([Bind("Place,Year,Month,Day,Dim")] Location location)
        {
            if (location.Dim == 0)
                location.Dim = 0.4f;
            return View(location);
        }

        [HttpGet]
        public IActionResult EarthImage()
        {
            return View();
        }
    }
}