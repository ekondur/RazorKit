## Area Chart

## Bar Chart

## Bubble Chart

## Line Chart

```csharp title="line.cshtml" linenums="1" hl_lines="7"
@{
    var chart =
    Html.Chart("canvasId")
    .Data(d => d
        .Labels("January", "February", "March", "April", "May", "June", "July")
        .Datasets(ds => ds
            .Line()
            .Label("Line Chart")
            .Data(65, 59, 80, 81, 56, 55, 40)
            .Fill(false)
            .BorderColor("rgb(75, 192, 192)")
            .Tension(0.1)
        )
    );
}

@chart.Render()
```