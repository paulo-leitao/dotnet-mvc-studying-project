using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_web_app.Models;

namespace mvc_web_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static IList<Archive> archive = 
        new List<Archive>(){
            new Archive(){
                ID=1,
                Description="Lesson 1 - Building your first App ('Hellow world').",
                Size=50.25m
            },
            new Archive(){
                ID=2,
                Description="Lesson 2 - Incrementing App from 'Lesson 1'",
                Size= 62.33m
            },
            new Archive(){
                ID=3,
                Description="Lesson 3 - App2 Using React",
                Size= 45.18m
            },
            new Archive(){
                ID=4,
                Description="Lesson 4 - Building an App with ASP.Net MVC",
                Size= 70.64m
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Archive()
        {
            return View(archive);
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
