using HelperJS.Chart.Test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelperJS.Chart.Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Line()
        {
            return View();
        }

        public IActionResult Animation()
        {
            return View();
        }

        public IActionResult Radar()
        {
            return View();
        }

        public IActionResult Mixed()
        {
            return View();
        }

        public IActionResult Bar()
        {
            return View();
        }
        public IActionResult Bubble()
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
