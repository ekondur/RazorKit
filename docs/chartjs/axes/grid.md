---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/samples/scale-options/grid.html)"
	This sample shows how to use scriptable grid options for an axis to control styling. In this case, the Y axis grid lines are colored based on their value. 
	In addition, booleans are provided to toggle different parts of the X axis grid visibility.

```csharp hl_lines="5" linenums="1"
.Options(o => o
    .Scales(s => s
		.ScaleId("y")
        .BeginAtZero(true)
        .Grid(g => g
            .Color("red")
            .LineWidth(1))))
```
Grid Line Options:
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/styling.html#grid-line-configuration)

## Circular
If true, gridlines are circular (on radar and polar area charts only). Default ```false```
```csharp
.Circular(true)
```

## Color
The color of the grid lines. If specified as an array, the first color applies to the first grid line,
the second to the second grid line, and so on.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.Color("#666")
```

## Display
If false, do not display grid lines for this axis. Default ```true```
```csharp
.Display(false)
```

## DrawOnChartArea
If true, draw lines on the chart area inside the axis lines. 
This is useful when there are multiple axes and you need to control which grid lines are drawn. Default ```true```
```csharp
.DrawOnChartArea(false)
```

## DrawTicks
If true, draw lines beside the ticks in the axis area beside the chart. Default true
```csharp
.DrawTicks(true)
```

## LineWidth
Stroke width of grid lines. Default ```1```
```csharp
.LineWidth(2)
```

## Offset
If true, grid lines will be shifted to be between labels. This is set to true for a bar chart by default. Default ```false```
```csharp
.Offset(true)
```

## TickBorderDash
Length and spacing of the tick mark line. If not set, defaults to the grid line borderDash value. Default ```[]```
```csharp
.TickBorderDash(1, 2, 3)
```

## TickBorderDashOffset
Offset for the line dash of the tick mark. If unset, defaults to the grid line ```'borderDashOffset'``` value.
```csharp
.TickBorderDashOffset(1)
```

## TickColor
Color of the tick line. If unset, defaults to the grid line color.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.TickColor("rgba(0, 0, 0, 0.1)")
```

## TickLength
Length in pixels that the grid lines will draw into the axis area. Default ```8```
```csharp
.TickLength(5)
```

## TickWidth
Width of the tick mark in pixels. If unset, defaults to the grid line width.
```csharp
.TickWidth(1)
```

## Z
z-index of the gridline layer. Values ```<= 0``` are drawn under datasets, ```> 0``` on top. Default ```-1```
```csharp
.Z(1)
```

