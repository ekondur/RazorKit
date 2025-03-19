---
icon: material/chart-pie
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/doughnut.html)"
	Pie and doughnut charts are probably the most commonly used charts. They are divided into segments, the arc of each segment shows the proportional value of each piece of data.
	They are excellent at showing the relational proportions between data.
	Pie and doughnut charts are effectively the same class in Chart.js, but have one different default value - their cutout. This equates to what portion of the inner should be cut out. 
	
	This defaults to ```0``` for pie charts, and ```'50%'``` for doughnuts.
	They are also registered under two aliases in the Chart core. Other than their different default value, and different alias, they are exactly the same.
	
<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
=== "Doughnut"
	<canvas id="canvasId1"></canvas>
	<script>
		new Chart(document.getElementById('canvasId1'),
				{
	  "data": {
		"labels": [
		  "Red",
		  "Blue",
		  "Yellow"
		],
		"datasets": [
		  {
			"hoverOffset": 4,
			"data": [
			  300,
			  50,
			  100
			],
			"label": "Doughnut Dataset",
			"type": "doughnut",
			"backgroundColor": [
			  "#0e9afd",
			  "#ff6285",
			  "#ff9f46"
			]
		  }
		]
	  }
	}
		);
	</script>

=== "Pie"
	<canvas id="canvasId2"></canvas>
	<script>
		new Chart(document.getElementById('canvasId2'),
				{
	  "data": {
		"labels": [
		  "Red",
		  "Blue",
		  "Yellow"
		],
		"datasets": [
		  {
			"hoverOffset": 4,
			"data": [
			  300,
			  50,
			  100
			],
			"label": "Doughnut Dataset",
			"type": "pie",
			"backgroundColor": [
			  "#0e9afd",
			  "#ff6285",
			  "#ff9f46"
			]
		  }
		]
	  }
	}
		);
	</script>

</hr>

=== "Doughnut"
	```csharp hl_lines="5" linenums="1"
	@(Html.Chart("canvasId")
	.Data(d => d
		.Labels("Red", "Blue", "Yellow")
		.Datasets(ds => ds
			.Doughnut()
			.Label("Doughnut Dataset")
			.Data(300, 50, 100)
			.BackgroundColors("#0e9afd", "#ff6285", "#ff9f46")
			.HoverOffset(4)))
	.Render())
	```
=== "Pie"
	```csharp hl_lines="5" linenums="1"
	@(Html.Chart("canvasId")
	.Data(d => d
		.Labels("Red", "Blue", "Yellow")
		.Datasets(ds => ds
			.Pie()
			.Label("Doughnut Dataset")
			.Data(300, 50, 100)
			.BackgroundColors("#0e9afd", "#ff6285", "#ff9f46")
			.HoverOffset(4)))
	.Render())
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

## Arc Dataset Options

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

## Dougnut&Pie Dataset Options

### Circumference
Per-dataset override for the sweep that the arcs cover.
```csharp
.Circumference(2)
```

### HoverOffset
Arc offset when hovered (in pixels). Default ```0```
```csharp
.HoverOffset(1)
```

### Offset
Arc offset (in pixels). Default ```0```
```csharp
.Offset(1)
```
Arc offset (in pixels). (multiple)
```csharp
.Offset(1, 2)
```

### Rotation
Per-dataset override for the starting angle to draw arcs from.
```csharp
.Rotation(1)
```

### Spacing
Fixed arc offset (in pixels). Similar to offset but applies to all arcs. Default ```0```
```csharp
.Spacing(1)
```

### Weight
The relative thickness of the dataset. Providing a value for weight will cause the pie or doughnut dataset to be drawn with
a thickness relative to the sum of all the dataset weight values. Default ```1```
```csharp
.Weight(2)
```

