---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/elements.html#line-configuration)"
	Line elements are used to represent the line in a line chart.

	Namespace: ```options.elements.line```

```csharp hl_lines="3" linenums="1"
.Options(o => o
    .Elements(e => e
        .Line().Tension(0.2).Fill(true)))
```

## Base Element Settings

### BackgroundColor
Fill color.
```csharp
.BackgroundColor("blue")
```
```csharp
.BackgroundColors("rgba(255, 99, 132, 0.2)", "rgba(255, 159, 64, 0.2)")
```

### BorderWidth
Stroke width.
```csharp
.BorderWidth(1)
```

### BorderColor
Stroke color.
```csharp
.BorderColor("grey")
```
```csharp
.BorderColors("yellow", "blue")
```

## Line Element Settings

### Tension
Bézier curve tension (0 for no Bézier curves).
```csharp
.Tension(0.4)
```

### BorderCapStyle
Line cap style. Default ```'butt'```. 
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineCap)
```csharp
.BorderCapStyle(CapStyle.Round)
```

### BorderDash
Line dash. 
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash)
```csharp
.BorderDash(5, 15, 25)
```

### BorderDashOffset
Line dash offset. Default ```0.0```
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset)
```csharp
.BorderDashOffset(0.1)
```

### BorderJoinStyle
Line join style. Default ```'miter'```
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineJoin)
```csharp
.BorderJoinStyle(JoinStyle.Bevel)
```

### CapBezierPoints
```true``` to keep Bézier control inside the chart, ```false``` for no restriction. Default ```true```
```csharp
.CapBezierPoints(true)
```

### CubicInterpolationMode
Interpolation mode to apply. Default ```'default'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/line.html#cubicinterpolationmode)
```csharp
.CubicInterpolationMode("monotone")
```

### Fill
How to fill the area under the line. Default ```false```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/area.html#filling-modes)
```csharp
.Fill(true)
```
```csharp
.Fill("origin")
```

### Stepped
```true``` to show the line as a stepped line (tension will be ignored). Default ```false```
```csharp
.Stepped(true)
```

