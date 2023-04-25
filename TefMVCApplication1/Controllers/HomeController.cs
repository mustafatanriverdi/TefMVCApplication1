using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TefMVCApplication1.Models;

namespace TefMVCApplication1.Controllers
{
    public class HomeController : Base
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var value = HttpContext.Session.GetString("UserSession");
            //if (value == null)
            //{
            //    return RedirectToAction("Index", "Login");
            //}
           
            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }

        public IActionResult Contact()
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