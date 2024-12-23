---
icon: material/menu-right
---

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

## Title Settings

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/legend.html#legend-title-configuration)"
	Set the legent title configuration.
	
	Namespace: ```options.plugins.legend.title```
	
=== "razor"
	```csharp hl_lines="3 5" linenums="1"
	.Options(o => o
    .Plugins(p => p
        .Legend(l => l
            .Display(true)
            .Title(t => t
                .Text("Legend Title")
                .Color("rgb(75, 192, 192)")))))
	```

=== "js"
	The script is produced:
	```js linenums="1"
	"options": {
		"plugins": {
		  "legend": {
			"display": true,
			"title": {
			  "color": "rgb(75, 192, 192)",
			  "text": "Legend Title"
			}
		  }
		}
	}
	```

### Color
Color of text.
```csharp
.Color("example")
```

### Display
Is the legend title displayed.
```csharp
.Display(true)
```

### Font

```csharp
.Font(default)
```

### Padding
Padding around the title.
```csharp
.Padding(2)
```
Or configure it:
[:octicons-link-external-16:](../padding.md)

### Text
The string title.
```csharp
.Text("example")
```

## Labels Settings

### BoxWidth
Width of coloured box. default 40
```csharp
.BoxWidth(15)
```

### BoxHeight
Height of the coloured box.
```csharp
.BoxHeight(15)
```

### Color
Color of label and the strikethrough.
```csharp
.Color("example")
```

### Font

```csharp
.Font(default)
```

### Padding
Padding between rows of colored boxes. Default 10
```csharp
.Padding(15)
```

### GenerateLabels
Generates legend items for each thing in the legend.
            Default implementation returns the text + styling for the color box.
```csharp
.GenerateLabels("example")
```

### Filter
Filters legend items out of the legend. Receives 2 parameters, a Legend Item and the chart data.
```csharp
.Filter("example")
```

### Sort
Sorts legend items. Type is : sort(a: LegendItem, b: LegendItem, data: ChartData): number;.
            Receives 3 parameters, two Legend Items and the chart data. 
            The return value of the function is a number that indicates the order of the two legend item parameters. 
            The ordering matches the return value of Array.prototype.sort()
```csharp
.Sort("example")
```

### PointStyle
If specified, this style of point is used for the legend. Only used if usePointStyle is true. default 'circle'
```csharp
.PointStyle(default)
```

### TextAlign
Horizontal alignment of the label text. Options are: 'left', 'right' or 'center'. default 'center'
```csharp
.TextAlign(default)
```

### UsePointStyle
Label style will match corresponding point style (size is based on pointStyleWidth or the minimum value between boxWidth and font.size).
            default false
```csharp
.UsePointStyle(true)
```

### PointStyleWidth
If UsePointStyle is true, the width of the point style used for the legend.
```csharp
.PointStyleWidth(15)
```

### UseBorderRadius
Label borderRadius will match corresponding borderRadius. default false
```csharp
.UseBorderRadius(true)
```

### BorderRadius
Override the borderRadius to use.
```csharp
.BorderRadius(default)
```