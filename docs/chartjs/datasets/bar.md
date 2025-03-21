---
icon: material/chart-bar
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/bar.html)"
	A bar chart provides a way of showing data values represented as vertical bars. 
	It is sometimes used to show trend data, and the comparison of multiple data sets side by side.
	
<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
<canvas id="canvasId"></canvas>
<script>
new Chart(document.getElementById('canvasId'),
{
  "data": {
    "labels": [
      "January",
      "February",
      "March",
      "April",
      "May",
      "June",
      "July"
    ],
    "datasets": [
      {
        "borderWidth": 1,
        "data": [
          65.0,
          59.0,
          80.0,
          81.0,
          56.0,
          55.0,
          40.0
        ],
        "label": "Bar Chart",
        "type": "bar",
        "backgroundColor": [
          "rgba(255, 99, 132, 0.2)",
          "rgba(255, 159, 64, 0.2)"
        ]
      }
    ]
  },
  "options": {
    "scales": {
      "y": {
        "beginAtZero": true
      }
    }
  }
});
</script>

=== "helper"
	```csharp hl_lines="5" linenums="1"
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
		.Scales(s => s.AxisId("y").BeginAtZero(true)))
	.Render())
	```

=== "js output"
	```js linenums="1"
	new Chart(document.getElementById('canvasId'),
	{
	  "data": {
		"labels": [
		  "January",
		  "February",
		  "March",
		  "April",
		  "May",
		  "June",
		  "July"
		],
		"datasets": [
		  {
			"borderWidth": 1,
			"data": [
			  65.0,
			  59.0,
			  80.0,
			  81.0,
			  56.0,
			  55.0,
			  40.0
			],
			"label": "Bar Chart",
			"type": "bar",
			"backgroundColor": [
			  "rgba(255, 99, 132, 0.2)",
			  "rgba(255, 159, 64, 0.2)"
			]
		  }
		]
	  },
	  "options": {
		"scales": {
		  "y": {
			"beginAtZero": true
		  }
		}
	  }
	});
	```

## Common Dataset Options
These options are common to all datasets.

### BackgroundColor
The line fill color.
```csharp
.BackgroundColor("green")
```
```csharp
.BackgroundColors("rgba(255, 99, 132, 0.2)", "rgba(255, 159, 64, 0.2)")
```

### BorderColor
The line color.
```csharp
.BorderColor("grey")
```
```csharp
.BorderColors("yellow", "blue")
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
```csharp
.HoverBackgroundColors("blue", "green")
```

### HoverBorderColor
Border color when hovered.
```csharp
.HoverBorderColor("grey")
```
```csharp
.HoverBorderColors("grey", "blue")
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

## Bar Dataset Options
Bar chart specific dataset options.

### Base
Base value for the bar in data units along the value axis. If not set, defaults to the value axis base value.
```csharp
.Base(1)
```

### BarPercentage
Percent (0-1) of the available width each bar should be within the category width.
```1.0``` will take the whole category width and put the bars right next to each other.
Default ```0.9```
```csharp
.BarPercentage(0.4)
```

### BarThickness
If this value is a number, it is applied to the width of each bar, in pixels. 
When this is enforced, barPercentage and categoryPercentage are ignored.
```csharp
.BarThickness(2)
```
If set to 'flex', the base sample widths are calculated automatically based on the previous and following samples
so that they take the full available widths without overlap. Then, bars are sized using barPercentage and categoryPercentage.
There is no gap when the percentage options are ```1```. 
This mode generates bars with different widths when data are not evenly spaced.
```csharp
.BarThickness("flex")
```

### BorderSkipped
This setting is used to avoid drawing the bar stroke at the base of the fill, or disable the border radius. 
In general, this does not need to be changed except when creating chart types that derive from a bar chart.
```csharp
.BorderSkipped(Skipped.Start)
```
Skip all borders (```true```), or don't skip any borders (```false```).
```csharp
.BorderSkipped(true)
```

### BorderWidth
If this value is a number, it is applied to all sides of the rectangle (```left```, ```top```, ```right```, ```bottom```), except ```borderSkipped```.
Default ```0```
```csharp
.BorderWidth(3)
```
If this value is an object, the left property defines the left border width. 
Similarly, the right, top, and bottom properties can also be specified. Omitted borders and ```borderSkipped``` are skipped.
```csharp
.BorderWidth(bw => bw.Top(3).Left(2).Right(3).Bottom(0))
```

### BorderRadius
If this value is a number, it is applied to all corners of the rectangle (```topLeft```, ```topRight```, ```bottomLeft```, ```bottomRight```),
except corners touching the ```borderSkipped```. Default ```0```
```csharp
.BorderRadius(1)
```
If this value is an object, the topLeft property defines the top-left corners border radius.
Similarly, the ```topRight```, ```bottomLeft```, and ```bottomRight```.
```csharp
.BorderRadius(br => br.TopLeft(2).TopRight(3).BottomLeft(2).BottomRight(3))
```

### CategoryPercentage
Percent (0-1) of the available width each category should be within the sample width.
```csharp
.CategoryPercentage(0.3)
```

### Data
Sets the data for the Dataset.
```csharp
.Data(1, 3, 5, 7)
```
```csharp
.Data(1.0, 3.2, 5.0, 7.0)
```
```csharp
.Data(IList<object> data)
```

### Grouped
Should the bars be grouped on index axis. When true, all the datasets at same index value will be placed next to each other centering on that index value. 
When false, each bar is placed on its actual index-axis value. Default ```true```
```csharp
.Grouped(false)
```

### HoverBorderRadius
The bar border radius when hovered (in pixels). Default ```0```
```csharp
.HoverBorderRadius(1)
```

### IndexAxis
The base axis of the dataset. ```'x'``` for vertical bars and ```'y'``` for horizontal bars.
```csharp
.IndexAxis(IndexAxis.X)
```

### Order
The drawing order of dataset. Also affects order for stacking, tooltip and legend.
Default ```0```
```csharp
.Order(1)
```

### PointStyle
Is style of the point enabled?  Default ```'circle'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/elements.html#types)
```csharp
.PointStyle(true)
```
Style of the point.
```csharp
.PointStyle(PointStyle.Cross)
```

### SkipNull
If true, null or undefined values will not be used for spacing calculations when determining bar size.
```csharp
.SkipNull(true)
```

### Stack
The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack). Default ```'bar'```
```csharp
.Stack("bar")
```

### XAxisID
The ID of the x-axis to plot this dataset on.
```csharp
.XAxisID("xAxis")
```

### YAxisID
The ID of the y-axis to plot this dataset on.
```csharp
.YAxisID("yAxis")
```

