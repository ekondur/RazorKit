!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/legend.html)"
	The chart legend displays data about the datasets that are appearing on the chart.
	
	Namespace: ```options.plugins.legend```

=== "razor"
	```csharp hl_lines="3" linenums="1"
	.Options(o => o
		.Plugins(p => p
			.Legend(l => l
				.Display(true)
				.Labels(lb => lb
					.Color("rgb(255, 99, 132)")))))
	```

=== "js"
	The script is produced:
	```js linenums="1"
	"options": {
		"plugins": {
		  "legend": {
			"display": true,
			"labels": {
			  "color": "rgb(255, 99, 132)"
			}
		  }
		}
	  }
	```

## Display
Is the legend shown? Default ```true```.
```csharp
.Display(false)
```

## Position
Position of the legend. Default ```top```.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/legend.html#position)
```csharp
.Position(LegendPosition.Left)
```

## Align
Alignment of the legend. Default ```center```.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/legend.html#align)
```csharp
.Align(LegendAlign.End)
```

## MaxHeight
Maximum height of the legend, in pixels.
```csharp
.MaxHeight(50)
```

## MaxWidth
Maximum width of the legend, in pixels.
```csharp
.MaxWidth(50)
```

## FullSize
Marks that this box should take the full width/height of the canvas (moving other boxes). 
This is unlikely to need to be changed in day-to-day use. Default ```true```.
```csharp
.FullSize(false)
```

## OnClick
A callback that is called when a click event is registered on a label item.
Arguments: ```[event, legendItem, legend]```.
```csharp
.OnClick("onClick")
```

## OnHover
A callback that is called when a 'mousemove' event is registered on top of a label item.
Arguments: ```[event, legendItem, legend]```.
```csharp
.OnHover("onHover")
```

## OnLeave
A callback that is called when a 'mousemove' event is registered outside of a previously hovered label item. 
Arguments: ```[event, legendItem, legend]```.
```csharp
.OnLeave("onLeave")
```

## Reverse
Legend will show datasets in reverse order. Default ```false```.
```csharp
.Reverse(true)
```

## Rtl
```true``` for rendering the legends from right to left.
```csharp
.Rtl(false)
```

## TextDirection
This will force the text direction ```'rtl'``` or ```'ltr'``` on the canvas for rendering the legend,
regardless of the css specified on the canvas.
```csharp
.TextDirection("example")
```

