---
icon: material/chart-box-multiple
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/mixed.html)"
	With Chart.js, it is possible to create mixed charts that are a combination of two or more different chart types. A common example is a bar chart that also includes a line dataset.
	When creating a mixed chart, we specify the chart type on each dataset.

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
      "April"
    ],
    "datasets": [
      {
        "data": [
          10.0,
          20.0,
          30.0,
          40.0
        ],
        "label": "Bar Dataset",
        "type": "bar"
      },
      {
        "data": [
          50.0,
          40.0,
          45.0,
          50.0
        ],
        "label": "Line Dataset",
        "type": "line"
      }
    ]
  }
});
</script>

=== "helper"
	```csharp hl_lines="6 10" linenums="1"
	@(Html.Chart("canvasId")
	.Data(d => d
		.Labels("January", "February", "March", "April")
		.Datasets(ds =>
		{
			ds.Bar()
			.Label("Bar Dataset")
			.Data(10, 20, 30, 40);

			ds.Line()
			.Label("Line Dataset")
			.Data(50, 40, 45, 50);
		})
	)
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
		  "April"
		],
		"datasets": [
		  {
			"data": [
			  10.0,
			  20.0,
			  30.0,
			  40.0
			],
			"label": "My First Dataset",
			"type": "bar"
		  },
		  {
			"data": [
			  50.0,
			  40.0,
			  45.0,
			  50.0
			],
			"label": "Line Dataset",
			"type": "line"
		  }
		]
	  }
	});
	```

By default, datasets are drawn such that the first one is top-most. This can be altered by specifying ```order``` option to datasets. ```order``` defaults to ```0```. 
Note that this also affects stacking, legend, and tooltip. So it's essentially the same as reordering the datasets.

The ```order``` property behaves like a weight instead of a specific order, so the higher the number, 
the sooner that dataset is drawn on the canvas and thus other datasets with a lower order number will get drawn over it.