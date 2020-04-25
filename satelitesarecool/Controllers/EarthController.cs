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
            string url = "https://api.nasa.gov/planetary/earth/imagery?lon=" +
                         "100.75" +
                         "&lat=" +
                         "1.5" +
                         "&date=" +
                         location.Year +
                         "-" +
                         location.Month +
                         "-" +
                         location.Day +
                         "&api_key=" +
                         "DEMO_KEY";
            return View(location);
        }

        [HttpGet]
        public IActionResult EarthImage()
        {
            return View();
        }
    }
}