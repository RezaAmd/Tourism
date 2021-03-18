using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            var tours = new List<Tour>();
            tours.Add(new Tour
            {
                name = "تور مشهد",
                image = "https://berimtour.com/Administrator/files/AdsPicture/73917.jpg"
            });
            tours.Add(new Tour
            {
                name = "تور گلستان",
                image = "https://berimtour.com/Administrator/files/AdsPicture/photo_2021-03-04_11-47-00.jpg"
            });
            tours.Add(new Tour
            {
                name = "تور بندر عباس",
                image = "https://berimtour.com/Administrator/files/AdsPicture/73917.jpg"
            });
            return Ok(tours);
        }

        public class Tour
        {
            public string name { get; set; }
            public string image { get; set; }
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
