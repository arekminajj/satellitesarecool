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
            var epic = epics.ToArray()[0];

            //get date and check if format is good for url
            string year = epic.Date.Year.ToString();
            string month = epic.Date.Month.ToString();
            if (month.Length==1)
                month = "0" + month;
            string day = epic.Date.Day.ToString();
            if (day.Length==1)
                day = "0" + day;

            epic.ImageUrl = "https://api.nasa.gov/EPIC/archive/natural/" +
                                year +
                                "/" +
                                month +
                                "/" +
                                day +
                                "/png/" +
                                epic.Image +
                                ".png?api_key=DEMO_KEY";
            return View(epic);
        }
    }
}