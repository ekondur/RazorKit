---
icon: material/chart-donut-variant
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/polar.html)"
	Polar area charts are similar to pie charts, but each segment has the same angle - the radius of the segment differs depending on the value.
	This type of chart is often useful when we want to show a comparison data similar to a pie chart, but also show a scale of values for context.

<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
<canvas id="canvasId"></canvas>
<script>
new Chart(document.getElementById('canvasId'),
    {
	  "data": {
		"labels": [
		  "Red",
		  "Green",
		  "Yellow",
		  "Grey",
		  "Blue"
		],
		"datasets": [
		  {
			"data": [
			  11,
			  16,
			  7,
			  3,
			  14
			],
			"label": "Polar Area Dataset",
			"type": "polarArea",
			"backgroundColor": [
			  "rgb(255, 99, 132)",
			  "rgb(75, 192, 192)",
			  "rgb(255, 205, 86)",
			  "rgb(201, 203, 207)",
			  "rgb(54, 162, 235)"
			]
		  }
		]
	  }
	});
</script>

=== "helper"
	```csharp hl_lines="5" linenums="1"
	@(Html.Chart("canvasId")
	.Data(d => d
		.Labels("Red", "Green", "Yellow", "Grey", "Blue")
		.Datasets(ds => ds
			.PolarArea()
			.Label("Polar Area Dataset")
			.Data(11, 16, 7, 3, 14)
			.BackgroundColors("rgb(255, 99, 132)", "rgb(75, 192, 192)", "rgb(255, 205, 86)", "rgb(201, 203, 207)", "rgb(54, 162, 235)")))
	.Render())
	```
=== "js output"
	```js linenums="1"
	new Chart(document.getElementById('canvasId'),
    {
	  "data": {
		"labels": [
		  "Red",
		  "Green",
		  "Yellow",
		  "Grey",
		  "Blue"
		],
		"datasets": [
		  {
			"data": [
			  11,
			  16,
			  7,
			  3,
			  14
			],
			"label": "Polar Area Dataset",
			"type": "polarArea",
			"backgroundColor": [
			  "rgb(255, 99, 132)",
			  "rgb(75, 192, 192)",
			  "rgb(255, 205, 86)",
			  "rgb(201, 203, 207)",
			  "rgb(54, 162, 235)"
			]
		  }
		]
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

## Arc Dataset Options

### BackgroundColors
Set backgrounds colors.
```csharp
.BackgroundColors("green", "yellow", "blue")
```

### BorderAlign
Default ```'center'```
```csharp
.BorderAlign(BorderAlign.Inner)
```

### BorderDash
Arc border length and spacing of dashes.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash)
```csharp
.BorderDash(15, 3, 3, 3)
```

### BorderDashOffset
Arc border offset for line dashes. Default ```0.0```
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset)
```csharp
.BorderDashOffset(0.1)
```

### BorderJoinStyle
Arc border join style.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineJoin)
```csharp
.BorderJoinStyle(JoinStyle.Bevel)
```

### Data
Set Data for arc chart.
```csharp
.Data(3, 5, 2, 4)
```

### HoverBorderDash
Arc border length and spacing of dashes when hovered.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash)
```csharp
.HoverBorderDash(15, 3, 3, 3)
```

### HoverBorderDashOffset
Arc border offset for line dashes when hovered.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset)
```csharp
.HoverBorderDashOffset(0.1)
```

### HoverBorderJoinStyle
Arc border join style when hovered.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineJoin)
```csharp
.HoverBorderJoinStyle(JoinStyle.Bevel)
```

## Polar Area Dataset Options

### Circular
By default the Arc is curved. If circular: false the Arc will be flat.
```csharp
.Circular(true)
```

