# Welcome to RazorKit

RazorKit is a collection of lightweight, fluent-style Razor HTML helpers that make it easy for developers to integrate popular JavaScript libraries into their ASP.NET applications. 
With RazorKit, you can quickly implement features from libraries like [Chart.js](https://ekondur.github.io/RazorKit/chartjs/) and [DataTables](https://ekondur.github.io/RazorKit/datatables/), without the hassle of writing complex JavaScript or HTML code manually.

## Setup DataTables

Install the [RazorKit.DataTables](https://www.nuget.org/packages/RazorKit.DataTables/) package from nuget.

```
PM> Install-Package RazorKit.DataTables
```

Add related scripts and style links and implement. [Reference:](https://datatables.net/)


```csharp
@using RazorKit

@(Html.DataTable<Person>()
.Columns(c =>
{
    c.Field(f => f.Id).Visible(false);
    c.Field(f => f.Name).Title("Name");
})
.DataSource(ds => ds
    .URL(Url.Action("GetDataResult"))
    .Method("POST")
    .Naming(Convention.CamelCase))
.ServerSide(true)
.Render())
```

```csharp
using RazorKit.DataTables;

[HttpPost]
public JsonResult GetDataResult(DataRequest request)
{
    var result = ctx.People.ToDataResult(request);
    return Json(result);
}
``` 

## Setup ChartJs

Install the [RazorKit.ChartJs](https://www.nuget.org/packages/RazorKit.ChartJs/) package from nuget.

```
PM> Install-Package RazorKit.ChartJs
```

Add related scripts and implement. [Reference:](https://www.chartjs.org/docs/latest/getting-started/)

```csharp
<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>

@using RazorKit

@(Html.Chart("canvasId")
    .Data(d => d
        .Labels("January", "February", "March", "April", "May", "June", "July")
        .Datasets(ds => ds
            .Line()
            .Label("Line Chart")
            .Data(65, 59, 80, 81, 56, 55, 40)))
    .Render())
```
