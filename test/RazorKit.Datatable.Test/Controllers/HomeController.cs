using DatatableJS.Data;
using Microsoft.AspNetCore.Mvc;
using RazorKit.Datatable.Test.Models;
using System.Diagnostics;

namespace RazorKit.Datatable.Test.Controllers
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

        [HttpPost]
        public JsonResult GetDataResult(DataRequest request)
        {
            var list = new List<Person>
            {
                new Person{Id = 1, Name = "Jon Snow"},
                new Person{Id = 2, Name = "Arya Stark"},
            }.AsQueryable();

            var data = list.ToDataResult(request);

            return Json(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
