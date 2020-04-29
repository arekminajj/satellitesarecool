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
    public class ApodController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY");
            var apod = JsonConvert.DeserializeObject<Apod>(response);

            return View(apod);
        }
    }
}