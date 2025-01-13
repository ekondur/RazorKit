---
icon: material/chart-bubble
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/bubble.html)"
	A bubble chart is used to display three dimensions of data at the same time. 
	The location of the bubble is determined by the first two dimensions and the corresponding horizontal and vertical axes.
	The third dimension is represented by the size of the individual bubbles.

<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
<canvas id="canvasId"></canvas>	
<script>
new Chart(document.getElementById('canvasId'),
{
  "data": {
    "datasets": [
      {
        "data": [
          {
            "x": 20,
            "y": 30,
            "r": 15
          },
          {
            "x": 40,
            "y": 10,
            "r": 10
          }
        ],
        "label": "Bubble Dataset",
        "type": "bubble"
      }
    ]
  }
});
</script>

=== "helper"
	```csharp hl_lines="8" linenums="1"
	@{
		var data = new List<object> { new { x = 20, y = 30, r = 15 }, new { x = 40, y = 10, r = 10 } };
	}

	@(Html.Chart("canvasId")
	.Data(d => d
		.Datasets(ds => ds
			.Bubble()
			.Label("Bubble Dataset")
			.Data(data)))
	.Render())
	```

=== "js output"
	```js linenums="1"
	new Chart(document.getElementById('canvasId'),
    {
	  "data": {
		"datasets": [
		  {
			"data": [
			  {
				"x": 20,
				"y": 30,
				"r": 15
			  },
			  {
				"x": 40,
				"y": 10,
				"r": 10
			  }
			],
			"label": "Bubble Dataset",
			"type": "bubble"
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

## Bubble Dataset Options
Bubble chart specific dataset options.

### DrawActiveElementsOnTop
Draw the active bubbles of a dataset over the other bubbles of the dataset. Default ```true```
```csharp
.DrawActiveElementsOnTop(false)
```

### HoverRadius
bubble additional radius when hovered (in pixels). Default ```4```
```csharp
.HoverRadius(3)
```

### HitRadius
bubble additional radius for hit detection (in pixels). Default ```1```
```csharp
.HitRadius(2)
```

### Order
The drawing order of dataset. Also affects order for tooltip and legend. Default ```0```
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

### Rotation
bubble rotation (in degrees). Default ```0```
```csharp
.Rotation(1)
```

### Radius
bubble radius (in pixels). Default ```3```
```csharp
.Radius(1)
```

