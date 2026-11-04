using Microsoft.AspNetCore.Mvc;
using RazorKit.Web.Test.Models;

namespace RazorKit.Web.Test.Controllers;

public class TomSelectController : Controller
{
    public IActionResult Index() => View(new TomSelectViewModel());

    public IActionResult Binding() => View(new BindingViewModel());

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Binding(BindingViewModel model)
    {
        model.Number = 1;
        model.Numbers = [2];
        model.Shipping.Country = "tr";
        return View(model);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Index(TomSelectViewModel model)
    {
        if (ModelState.IsValid)
            ViewData["Submitted"] = $"Country: {model.Country}; Languages: {string.Join(",", model.Languages)}; Remote: {model.Remote}; Address: {model.Address.Country}";
        // Deliberately change the model to verify posted ModelState values take precedence.
        model.Country = "de";
        model.Languages = ["py"];
        return View(model);
    }

    public IActionResult Search(string q = "", int page = 1)
    {
        var items = Enumerable.Range(1, 80)
            .Select(id => new { id = id.ToString(), name = $"Person {id:00}" })
            .Where(item => item.name.Contains(q, StringComparison.OrdinalIgnoreCase))
            .ToArray();
        return Json(new { results = items.Skip((page - 1) * 10).Take(10), next = page * 10 < items.Length ? Url.Action("Search", new { q, page = page + 1 }) : null });
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult SearchPost([FromBody] SearchRequest request) => Search(request.Query);

    public IActionResult Failure() => StatusCode(503);
    public IActionResult Malformed() => Json(new { results = "invalid" });

    public class SearchRequest { public string Query { get; set; } = ""; }
}
