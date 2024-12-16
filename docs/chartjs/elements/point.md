---
icon: material/chart-timeline-variant
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/elements.html#point-configuration)"
	Point elements are used to represent the points in a line, radar or bubble chart.

	Namespace: ```options.elements.point```

```csharp hl_lines="3" linenums="1"
.Options(o => o
    .Elements(e => e
        .Point().Rotation(1).Radius(4)))
```

## Base Element Settings

### BackgroundColor
Fill color.
```csharp
.BackgroundColor("blue")
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

## Point Element Settings

### Radius
Point radius. Default ```3```
```csharp
.Radius(4)
```

### PointStyle
Is point style enabled. Default ```'circle'```
```csharp
.PointStyle(true)
```
```csharp
.PointStyle(PointStyle.Cross)
```

### Rotation
Point rotation (in degrees). Default ```0```
```csharp
.Rotation(1)
```

### HitRadius
Extra radius added to point radius for hit detection. Default ```1```
```csharp
.HitRadius(1)
```

### HoverRadius
Point radius when hovered.. Default ```4```
```csharp
.HoverRadius(5)
```

### HoverBorderWidth
Stroke width when hovered. Default ```1```
```csharp
.HoverBorderWidth(2)
```

