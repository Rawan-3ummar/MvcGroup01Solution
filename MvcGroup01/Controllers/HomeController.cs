using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcGroup01.Models;

namespace MvcGroup01.Controllers
{
    //MVC Controller : Controller : ControllerBase
    //API Controller : ControllerBase 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Action
        //BaseUrl/Home/Index
        //BaseUrl/Home
        //Master action
        //Default method for action --> GET

        public IActionResult Index()
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
