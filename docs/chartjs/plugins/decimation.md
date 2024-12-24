---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/decimation.html)"
	The decimation plugin can be used with line charts to automatically decimate data at the start of the chart lifecycle. 
	Before enabling this plugin, review the [requirements](https://www.chartjs.org/docs/latest/configuration/decimation.html#requirements) to ensure that it will work with the chart you want to create.
	
	Namespace: ```options.plugins.decimation```
	
=== "helper"
	```csharp hl_lines="3" linenums="1"
	.Options(o => o
		.Plugins(p => p
			.Decimation(d => d
				.Algorithm(Algorithm.MinMax)
				.Threshold(5))))
	```

=== "js output"
	```js linenums="1"
	"options": {
		"plugins": {
		  "decimation": {
			"algorithm": "min-max",
			"threshold": 5
		  }
		}
	  }
	```

## Enabled
Is decimation enabled? Default ```false```
```csharp
.Enabled(true)
```

## Algorithm
Decimation algorithm to use. Default ```'min-max'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/decimation.html#decimation-algorithms)
```csharp
.Algorithm(Algorithm.Lttb)
```

## Samples
If the ```'lttb'``` algorithm is used, this is the number of samples in the output dataset. 
Defaults to the canvas width to pick ```1``` sample per pixel.
```csharp
.Samples(2)
```

## Threshold
If the number of samples in the current axis range is above this value, the decimation will be triggered. 
Defaults to ```4``` times the canvas width.
The number of point after decimation can be higher than the threshold value.
```csharp
.Threshold(5)
```

