---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/styling.html#border-configuration)"
	It defines options for the border that run perpendicular to the axis.
	
	Namespace: ```options.scales[scaleId].border```
	
```csharp hl_lines="5" linenums="1"
.Options(o => o
    .Scales(s => s
		.AxisId("y")
        .BeginAtZero(true)
        .Border(b => b
            .Color("#666")
            .Width(2))))
```

## Display
If true, draw a border at the edge between the axis and the chart area. Default ```true```
```csharp
.Display(false)
```

## Color
The color of the border line.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.Color("#666")
```

## Width
The width of the border line. Default ```1```
```csharp
.Width(2)
```

## Dash
Length and spacing of dashes on grid lines. Default ```[]```
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash)
```csharp
.Dash(1, 1, 2)
```

## DashOffset
Offset for line dashes. Default ```0.0```
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset)
```csharp
.DashOffset(0.2)
```

## Z
z-index of the border layer. Values less than equal ```0``` are drawn under datasets, grater than ```0``` on top. Default ```0```
```csharp
.Z(-1)
```

