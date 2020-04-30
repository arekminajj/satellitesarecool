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
    public class AsteroidsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();

            var day = DateTime.Now.Day;
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;

            string url = "https://api.nasa.gov/neo/rest/v1/feed?start_date=" +
                         year +
                         "-" +
                         month +
                         "-" +
                         day +
                         "&api_key=DEMO_KEY";

            var response = await client.GetStringAsync(url);
            var asteroids = JsonConvert.DeserializeObject<Asteroid>(response);

            return View(asteroids);
        }
    }
}