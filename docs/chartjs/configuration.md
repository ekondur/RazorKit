---
icon: material/code-json
---

## Labels
Labels are used to define the categories or points along the ```x-axis``` or ```y-axis``` of a chart. 
They help describe the data points visually, making the chart easier to interpret.
```csharp hl_lines="3" linenums="1"
@(Html.Chart("canvasId")
    .Data(d => d
        .Labels("January", "February", "March", "April", "May", "June", "July")
        .Datasets(ds => ds
			...
        ))
    .Render())
```

## Datasets
A dataset represents a group of related data that is displayed in a chart.
```csharp
.Datasets(ds => ds
    .Line()
	.Label("Line Chart")
	.Data(65, 59, 80, 81, 56, 55, 40)
	...
)
```
Each dataset corresponds to a specific series or group of data points, and its appearance is customizable.
```csharp
.Datasets(ds =>
{
    ds.Bar().Label("Bar Dataset").Data(10, 20, 30, 40);
    ds.Line().Label("Line Dataset").Data(50, 40, 45, 50);
})
```

## Responsive Charts
When it comes to changing the chart size based on the window size, a major limitation is that the canvas render size (```canvas.width``` and ```.height```)
can not be expressed with relative values, contrary to the display size (```canvas.style.width``` and ```.height```). 
Furthermore, these sizes are independent of each other and thus the canvas render size does not adjust automatically based on the display size, making the rendering inaccurate.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/responsive.html)

### Responsive
Resizes the chart canvas when its container does. Default ```true```
```csharp
.Options(o => o.Responsive(false))
```

### MaintainAspectRatio
Maintain the original canvas aspect ratio (```width / height```) when resizing. Default ```true```
```csharp
.Options(o => o.MaintainAspectRatio(false))
```

### AspectRatio
Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas).
Note that this option is ignored if the height is explicitly defined either as attribute or via the style.
The default value varies by chart type; Radial charts (```doughnut, pie, polarArea, radar```) default to ```1``` and others default to ```2```.
```csharp
.Options(o => o.AspectRatio(1))
```

### OnResize
Called when a resize occurs. Gets passed two arguments: the chart instance and the new size.
```csharp
.Options(o => o.OnResize("onResize"))
```

### ResizeDelay
Delay the resize update by the given amount of milliseconds.
This can ease the resize process by debouncing the update of the elements. Default ```0```
```csharp
.Options(o => o.ResizeDelay(100))
```

## Events
The events option defines the browser events that the chart should listen to for. Each of these events trigger hover and are passed to plugins.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/interactions.html#events)
```csharp
.Options(o => o.Events(ChartEvent.Mousemove, ChartEvent.Touchstart))
```

### OnHover
Called when any of the events fire over chartArea. Passed the event, an array of active elements (bars, points, etc), and the chart.
```csharp
.Options(o => o.OnHover("onHover"))
```

### OnClick
Called if the event is of type 'mouseup', 'click' or 'contextmenu' over chartArea. Passed the event, an array of active elements, and the chart.
```csharp
.Options(o => o.OnClick("example"))
```

## Locale
For applications where the numbers of ticks on scales must be formatted accordingly with a language sensitive number formatting,
you can enable this kind of formatting by setting the locale option.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/locale.html)
```csharp
.Options(o => o.Locale("en-US"))
```

## Parsing
How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. 
If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/api/interfaces/ParsingOptions.html)
```csharp
.Options(o => o.Parsing(true))
```
Parsing with key.
```csharp
.Options(o => o.Parsing("key"))
```
Parsing with x and y axis keys.
```csharp
.Options(o => o.Parsing("xKey", "yKey"))
```

