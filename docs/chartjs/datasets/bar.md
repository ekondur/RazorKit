!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/bar.html)"
	A bar chart provides a way of showing data values represented as vertical bars. 
	It is sometimes used to show trend data, and the comparison of multiple data sets side by side.

```csharp
@(Html.Chart("canvasId")
.Data(d => d
    .Labels("January", "February", "March", "April", "May", "June", "July")
    .Datasets(ds =>
        ds.Bar()
        .Label("Bar Chart")
        .Data(65, 59, 80, 81, 56, 55, 40)
        .BackgroundColors("rgba(255, 99, 132, 0.2)", "rgba(255, 159, 64, 0.2)")
        .BorderWidth(1)
    ))
.Options(o => o
    .Scales(Scales.Y, s => s.BeginAtZero(true)))
.Render())
```

## Base Dataset Options

### BackgroundColor
The line fill color.
```csharp
.BackgroundColor("example")
```

### BorderColor
The line color.
```csharp
.BorderColor("example")
```

### BorderWidth
The line width (in pixels). Default 3
```csharp
.BorderWidth(15)
```

### Clip
How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea.
            0 = clip at chartArea. Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}
```csharp
.Clip(15)
```

### Clip
How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea.
            0 = clip at chartArea. Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}
```csharp
.Clip(15, 15, 15, 15)
```

### Clip
Is clip enabled?
```csharp
.Clip(true)
```

### Hidden
Configure the visibility of the dataset. Using hidden: true will hide the dataset from being rendered in the Chart.
```csharp
.Hidden(true)
```

### HoverBackgroundColor
Background color when hovered.
```csharp
.HoverBackgroundColor("example")
```

### HoverBorderColor
Border color when hovered.
```csharp
.HoverBorderColor("example")
```

### HoverBorderWidth
The line width (in pixels) when hovered.
```csharp
.HoverBorderWidth(15)
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

### Parsing
Parsing with key.
```csharp
.Parsing("example")
```

### Parsing
Parsing with x and y axis keys.
```csharp
.Parsing("example", "example")
```

## Bar Dataset Options

### BackgroundColors
Set backgrounds colors.
```csharp
.BackgroundColors(default)
```

### BorderColors
Set border colors.
```csharp
.BorderColors(default)
```

### Base
Base value for the bar in data units along the value axis. If not set, defaults to the value axis base value.
```csharp
.Base(15)
```

### BarPercentage
Percent (0-1) of the available width each bar should be within the category width.
            1.0 will take the whole category width and put the bars right next to each other.
            Default 0.9
```csharp
.BarPercentage(default)
```

### BarThickness
If this value is a number, it is applied to the width of each bar, in pixels. 
            When this is enforced, barPercentage and categoryPercentage are ignored.
```csharp
.BarThickness(15)
```

### BarThickness
If set to 'flex', the base sample widths are calculated automatically based on the previous and following samples
            so that they take the full available widths without overlap. Then, bars are sized using barPercentage and categoryPercentage.
            There is no gap when the percentage options are 1. 
            This mode generates bars with different widths when data are not evenly spaced.
```csharp
.BarThickness("example")
```

### BorderSkipped
This setting is used to avoid drawing the bar stroke at the base of the fill, or disable the border radius. 
            In general, this does not need to be changed except when creating chart types that derive from a bar chart.
```csharp
.BorderSkipped("example")
```

### BorderSkipped
This setting is used to avoid drawing the bar stroke at the base of the fill, or disable the border radius. 
            In general, this does not need to be changed except when creating chart types that derive from a bar chart.
```csharp
.BorderSkipped(true)
```

### BorderWidth
If this value is a number, it is applied to all sides of the rectangle (left, top, right, bottom), except borderSkipped.
            Default 0
```csharp
.BorderWidth(15)
```

### BorderWidth
If this value is an object, the left property defines the left border width. 
            Similarly, the right, top, and bottom properties can also be specified. Omitted borders and borderSkipped are skipped.
```csharp
.BorderWidth(15, 15, 15, 15)
```

### BorderRadius
If this value is a number, it is applied to all corners of the rectangle (topLeft, topRight, bottomLeft, bottomRight),
            except corners touching the borderSkipped. Default 0
```csharp
.BorderRadius(15)
```

### BorderRadius
If this value is an object, the topLeft property defines the top-left corners border radius.
            Similarly, the topRight, bottomLeft, and bottomRight.
```csharp
.BorderRadius(15, 15, 15, 15)
```

### CategoryPercentage
Percent (0-1) of the available width each category should be within the sample width.
```csharp
.CategoryPercentage(default)
```

### Data
Sets the data for the Dataset.
```csharp
.Data(default)
```

### Grouped
Should the bars be grouped on index axis. When true, all the datasets at same index value will be placed next to each other centering on that index value. 
            When false, each bar is placed on its actual index-axis value. Default true
```csharp
.Grouped(true)
```

### HoverBorderRadius
The bar border radius when hovered (in pixels). Default 0
```csharp
.HoverBorderRadius(15)
```

### IndexAxis
The base axis of the dataset. 'x' for vertical bars and 'y' for horizontal bars.
```csharp
.IndexAxis(default)
```

### Order
The drawing order of dataset. Also affects order for stacking, tooltip and legend.
            Default 0
```csharp
.Order(15)
```

### PointStyle
Is style of the point enabled?
```csharp
.PointStyle(true)
```

### PointStyle
Style of the point.
```csharp
.PointStyle(default)
```

### SkipNull
If true, null or undefined values will not be used for spacing calculations when determining bar size.
```csharp
.SkipNull(true)
```

### Stack
The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
```csharp
.Stack("example")
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

