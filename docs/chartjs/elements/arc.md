---
icon: material/chart-arc
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/elements.html#arc-configuration)"
	Arcs are used in the polar area, doughnut and pie charts.

	Namespace: ```options.elements.arc```

```csharp hl_lines="3" linenums="1"
.Options(o => o
    .Elements(e => e
        .Arc().Angle(1).Circular(true)))
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

## Arc Element Settings

### Angle
Arc angle to cover (for polar only). Default ```circumference / (arc count)```
```csharp
.Angle(1)
```

### BorderAlign
Arc stroke alignment. Default ```'center'```
```csharp
.BorderAlign(BorderAlign.Inner)
```

### BorderDash
Arc line dash.
```csharp
.BorderDash(15, 3, 3)
```

### BorderDashOffset
Arc line dash offset. Default ```0.0```
```csharp
.BorderDashOffset(0.1)
```

### BorderJoinStyle
Line join style. The default is 'round' when borderAlign is 'inner'
```csharp
.BorderJoinStyle(JoinStyle.Miter)
```

### Circular
By default the Arc is curved. If circular: false the Arc will be flat. Default ```true```
```csharp
.Circular(false)
```

