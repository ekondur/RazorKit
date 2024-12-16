---
icon: material/chart-line
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/line.html)"
	A line chart is a way of plotting data points on a line. Often, it is used to show trend data, or the comparison of two data sets.

```csharp hl_lines="5" linenums="1"
@(Html.Chart("canvasId")
.Data(d => d
    .Labels("January", "February", "March", "April", "May", "June", "July")
    .Datasets(ds => ds
        .Line()
        .Label("Line Chart")
        .Data(65, 59, 80, 81, 56, 55, 40)
        .Fill(false)
        .BorderColor("rgb(75, 192, 192)")
        .Tension(0.1)))
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

## Line Dataset Options

### CubicInterpolationMode
The following interpolation modes are supported, 'default' and 'monotone'.
```csharp
.CubicInterpolationMode("example")
```

### DrawActiveElementsOnTop
Draw the active points of a dataset over the other points of the dataset.
```csharp
.DrawActiveElementsOnTop(true)
```

### IndexAxis
The base axis of the dataset. 'x' for horizontal lines and 'y' for vertical lines.
```csharp
.IndexAxis("example")
```

### Segment
Line segment styles can be overridden by scriptable options in the segment object.
```csharp
.Segment(default)
```

### ShowLine
If false, the line is not drawn for this dataset.
```csharp
.ShowLine(true)
```

### Stack
The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
```csharp
.Stack("example")
```

### Stepped
If the stepped value is set to anything other than false, 'tension' will be ignored.
```csharp
.Stepped(true)
```

### XAxisID
The ID of the x-axis to plot this dataset on.
```csharp
.XAxisID("example")
```

### YAxisID
The ID of the y-axis to plot this dataset on.
```csharp
.YAxisID("example")
```

