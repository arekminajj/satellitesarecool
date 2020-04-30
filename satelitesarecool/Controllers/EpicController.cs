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
    public class EpicController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();

            string url = "https://api.nasa.gov/EPIC/api/natural?api_key=DEMO_KEY";
            var response = await client.GetStringAsync(url);
            var epics = JsonConvert.DeserializeObject<List<Epic>>(response);

            return View(epics.ToArray()[0]);
        }
    }
}