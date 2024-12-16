---
icon: material/chart-box-multiple
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/mixed.html)"
	With Chart.js, it is possible to create mixed charts that are a combination of two or more different chart types. A common example is a bar chart that also includes a line dataset.
	When creating a mixed chart, we specify the chart type on each dataset.

```csharp hl_lines="6 10"
@(Html.Chart("canvasId")
.Data(d => d
    .Labels("January", "February", "March", "April")
    .Datasets(ds =>
    {
        ds.Bar()
        .Label("My First Dataset")
        .Data(10, 20, 30, 40);

        ds.Line()
        .Label("Line Dataset")
        .Data(50, 40, 45, 50);
    })
)
.Render())
```