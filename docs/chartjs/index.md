# RazorKit.ChartJs

[RazorKit.ChartJs](https://www.nuget.org/packages/RazorKit.ChartJs) is a powerful library that simplifies the integration of the [Chart.js](https://www.chartjs.org/) library into Razor views. With a fluent builder style, developers can effortlessly create highly functional and customizable charts.

## Features
- **Fluent API:** Create charts using an intuitive builder pattern.
- **Customization:** Easily configure datasets, options, and advanced features.
- **Integration:** Designed to work seamlessly with Chart.js.

## Setup

Install the NuGet package:

```bash
dotnet add package RazorKit.ChartJs
```
or
```bash
PM> Install-Package RazorKit.ChartJs
```

Add needed script and style links to layout: [Reference:](https://www.chartjs.org/docs/latest/getting-started/installation.html)

```html
<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
```
It is easy to implement with html helper:

```cs title="cshtml" linenums="1"
@using RazorKit

@(Html.Chart("canvasId")
    .Data(d => d
        .Labels("January", "February", "March", "April", "May", "June", "July")
        .Datasets(ds => ds
            .Line()
            .Label("Line Chart")
            .Data(65, 59, 80, 81, 56, 55, 40)
        )
    )
    .Render()
)
```