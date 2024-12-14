!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/radar.html)"
	A radar chart is a way of showing multiple data points and the variation between them.
	They are often useful for comparing the points of two or more different data sets.

```csharp hl_lines="6 11" linenums="1"
@(Html.Chart("canvasId")
.Data(d => d
    .Labels("Eating", "Drinking", "Sleeping", "Designing", "Coding", "Cycling", "Running")
    .Datasets(ds =>
    {
        ds.Radar()
        .Label("My First Dataset")
        .Data(65, 59, 90, 81, 56, 55, 40)
        .Fill(true);

        ds.Radar()
        .Label("My Second Dataset")
        .Data(28, 48, 40, 19, 96, 27, 100)
        .Fill(true);
    }))
.Render())
```

## Base Dataset Options
These options are common to all datasets.

### BackgroundColor
The line fill color.
```csharp
.BackgroundColor("green")
```

### BorderColor
The line color.
```csharp
.BorderColor("grey")
```

### BorderWidth
The line width (in pixels).
```csharp
.BorderWidth(1)
```

### Clip
How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea.
0 = clip at chartArea.
```csharp
.Clip(3)
```
Is clip enabled?
```csharp
.Clip(false)
```
Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}
```csharp
.Clip(c => c.Left(5).Top(false).Right(-2).Bottom(0))
```

### Hidden
Configure the visibility of the dataset. Using hidden: true will hide the dataset from being rendered in the Chart.
```csharp
.Hidden(true)
```

### HoverBackgroundColor
Background color when hovered.
```csharp
.HoverBackgroundColor("blue")
```

### HoverBorderColor
Border color when hovered.
```csharp
.HoverBorderColor("grey")
```

### HoverBorderWidth
The line width (in pixels) when hovered.
```csharp
.HoverBorderWidth(3)
```

### Label
The label for the dataset which appears in the legend and tooltips.
```csharp
.Label("First Bar Dataset")
```

### Parsing
How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. 
If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
```csharp
.Parsing(true)
```
Parsing with key.
```csharp
.Parsing("key")
```
Parsing with x and y axis keys.
```csharp
.Parsing("xKey", "yKey")
```

## Radar Dataset Options

### Data
Sets the data for the Radar Dataset.
```csharp
.Data(default)
```

