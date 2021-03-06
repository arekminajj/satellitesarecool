﻿using System;
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

        public async Task<IActionResult> Image(string solNumber, string number)
        {
            if (string.IsNullOrEmpty(solNumber)||string.IsNullOrEmpty(number))
            {
                solNumber = "1000";
                number = "30";
            }

            HttpClient client = new HttpClient();
            string url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=" +
                         solNumber +
                         "&api_key=DEMO_KEY";

            var response = await client.GetStringAsync(url);
            var image = JsonConvert.DeserializeObject<Curiosity>(response);
            
            return View(image.Photos[Int32.Parse(number)]);
        }
    }
}