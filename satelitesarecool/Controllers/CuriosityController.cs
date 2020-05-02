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
            return RedirectToAction("Image");
        }

        public IActionResult Photo(string solNumber, string number)
        {
            return View();
        }

        public async Task<IActionResult> Image(string solNumber, string number)
        {
            //TODO: MAKE INPUT TO ALLOW USER CHANGE SOL AND NUMBER, SINCE ERRORS MAYBE MAKE 1000 and 30 default.

            solNumber = "1000";
            number = "30";
            HttpClient client = new HttpClient();
            string url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=" +
                         solNumber +
                         "&api_key=DEMO_KEY";

            var response = await client.GetStringAsync(url);
            var image = JsonConvert.DeserializeObject<Curiosity>(response);
            var rnd = new Random();
            
            int random = rnd.Next(1, Int32.Parse(number));

            return View(image.Photos[random]);
        }

        
    }
}