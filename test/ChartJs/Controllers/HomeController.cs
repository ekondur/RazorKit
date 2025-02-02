using RazorKit.ChartJs.Test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace RazorKit.ChartJs.Test.Controllers
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

        public IActionResult Doughnut()
        {
            return View();
        }

        public IActionResult Pie()
        {
            return View();
        }

        public IActionResult PolarArea()
        {
            return View();
        }

        public IActionResult Scatter()
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
