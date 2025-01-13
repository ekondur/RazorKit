---
icon: material/chart-scatter-plot
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/scatter.html)"
	Scatter charts are based on basic line charts with the x-axis changed to a linear axis. 
	To use a scatter chart, data must be passed as objects containing X and Y properties. The example below creates a scatter chart with 4 points.

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
				"x": -10,
				"y": 0
			  },
			  {
				"x": 0,
				"y": 10
			  },
			  {
				"x": 10,
				"y": 5
			  },
			  {
				"x": 0.5,
				"y": 5.5
			  }
			],
			"label": "Scatter Dataset",
			"type": "scatter",
			"backgroundColor": "rgb(255, 99, 132)"
		  }
		]
	  },
	  "options": {
		"scales": {
		  "y": {
			"type": "linear",
			"position": "bottom"
		  }
		}
	  }
	});
</script>

=== "helper"
	```csharp hl_lines="8" linenums="1"
	@{
		var data = new List<object> { new { x = -10, y = 0 }, new { x = 0, y = 10 }, new { x = 10, y = 5 }, new { x = 0.5, y = 5.5 } };
	}

	@(Html.Chart("canvasId")
	.Data(d => d
		.Datasets(ds => ds
			.Scatter()
			.Label("Scatter Dataset")
			.Data(data)
			.BackgroundColor("rgb(255, 99, 132)")))
	.Options(x => x.Scales(s => s
		.AxisId("x")
		.Type("linear")
		.Position(AxisPosition.Bottom)
	))
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
				"x": -10,
				"y": 0
			  },
			  {
				"x": 0,
				"y": 10
			  },
			  {
				"x": 10,
				"y": 5
			  },
			  {
				"x": 0.5,
				"y": 5.5
			  }
			],
			"label": "Scatter Dataset",
			"type": "scatter",
			"backgroundColor": "rgb(255, 99, 132)"
		  }
		]
	  },
	  "options": {
		"scales": {
		  "y": {
			"type": "linear",
			"position": "bottom"
		  }
		}
	  }
	});
	```

## Dataset Properties
	
Namespaces:

- ```data.datasets[index]``` - options for this dataset only
- ```options.datasets.scatter``` - options for all scatter datasets
- ```options.elements.line``` - options for all line elements
- ```options.elements.point``` - options for all point elements
- ```options``` - options for the whole chart

The scatter chart supports all the same properties as the [line chart](line.md). By default, the scatter chart will override the showLine property of the line chart to ```false```.

The index scale is of the type ```linear```. This means, if you are using the labels array, the values have to be numbers or parsable to numbers, the same applies to the object format for the keys.

## Data Structure
Unlike the line chart where data can be supplied in two different formats, the scatter chart only accepts data in a point format.

```json
data: [{ x: 10, y: 20 }, { x: 15, y: 10 }]
```