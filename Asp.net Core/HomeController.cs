using _043backEndGiris.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _043backEndGiris.Controllers
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
            ViewBag.Message = "Asp.net Core'a Hoşgeldiniz";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            return View();
        }

        public IActionResult Hakkimda() {
            return View();        
        }

        public IActionResult Iletisim2() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
