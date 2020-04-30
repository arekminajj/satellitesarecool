using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace satelitesarecool.Controllers
{
    public class AsteroidsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}