using Microsoft.AspNetCore.Mvc;

namespace RazorKit.Web.Test.Controllers;

public class ChartJsController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Line() => View();
    public IActionResult Animation() => View();
    public IActionResult Radar() => View();
    public IActionResult Mixed() => View();
    public IActionResult Bar() => View();
    public IActionResult Bubble() => View();
    public IActionResult Doughnut() => View();
    public IActionResult Pie() => View();
    public IActionResult PolarArea() => View();
    public IActionResult Scatter() => View();
}
