using AdoreSoap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AdoreSoap.Controllers
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
            return View();//returns the contents that appears on the home page 
        }

        public IActionResult Privacy()
        {
            return View(); //returns the contents that appears on the privacy page 
        }

        public IActionResult AboutUs()
        {
            return View(); //goes through the AboutUs Content under the vires and returns it using this method
        }

        public IActionResult ProductCatelogue()
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
