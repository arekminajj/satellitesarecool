using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

            HttpClient geolocationClient = new HttpClient();
            var geoResponse = geolocationClient.GetAsync("https://geocode.xyz/" + location.Place + "?json=1").ToString();
            var geolocation = JsonConvert.DeserializeObject<GeolocationModel>(geoResponse);
            var url = "https://api.nasa.gov/planetary/earth/imagery?lon=" +
                      geolocation.Longt +
                      "&lat=" +
                      geolocation.Latt +
                      "&date=" +
                      location.Year +
                      "-" +
                      location.Month +
                      "-" +
                      location.Day +
                      "&dim=" +
                      location.Dim +
                      "&api_key=" +
                      "DEMO_KEY";
            location.Url = url;
            return View(location);
        }

        [HttpGet]
        public IActionResult EarthImage()
        {
            return View();
        }
    }
}