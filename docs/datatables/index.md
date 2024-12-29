# RazorKit.DataTables

[RazorKit.DataTables](https://www.nuget.org/packages/RazorKit.DataTables) is a powerful library that simplifies the integration of the [jQuery DataTables](https://datatables.net/) library into Razor views. With a fluent builder style, developers can effortlessly create highly functional and customizable data tables.

## Features
- **Fluent API:** Create tables using an intuitive builder pattern.
- **Customization:** Easily configure columns, data sources, and advanced features.
- **Integration:** Designed to work seamlessly with jQuery DataTables.
- **Data Manipulation:** ```ToDataResult``` is typically used to transform data (such as collections or query results) into a structured result that DataTables can consume,
 especially when dealing with server-side operations such as paging, filtering, and sorting.

## Setup

Install the NuGet package:

```bash
dotnet add package RazorKit.DataTables
```
Or via the NuGet Package Manager:
```bash
PM> Install-Package RazorKit.DataTables
```

Add needed script and style links to layout: [Configuration:](https://datatables.net/download/index)

```html
<link rel="stylesheet" href="//cdn.datatables.net/2.1.8/css/dataTables.dataTables.min.css" />
<script src="//cdn.datatables.net/2.1.8/js/dataTables.min.js"></script>
```

## Usage
It is easy to implement with html helper:

```cs title="cshtml" linenums="1"
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
	.Render()
)
```

If you want to perform the request on backend, just call `ToDataResult()` return the response:

```cs title="controller" linenums="1"
using RazorKit.DataTables;

[HttpPost]
public JsonResult GetDataResult(DataRequest request)
{
	 var result = ctx.People.ToDataResult(request);
	 return Json(result);
}
``` 