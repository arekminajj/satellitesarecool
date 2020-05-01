using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Newtonsoft.Json;
using satelitesarecool.Models;

namespace satelitesarecool.Controllers
{
    public class CuriosityController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("ChooseSol");
        }

        public async Task<IActionResult> ChooseSol(string solNumber)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=" +
                         solNumber +
                         "&api_key=DEMO_KEY";

            var response = await client.GetStringAsync(url);
            var image = JsonConvert.DeserializeObject<Curiosity>(response);
            var rnd = new Random();
            int random = rnd.Next(1, image.Photos.Length);

            return View(image.Photos[random]);
        }

        
    }
}