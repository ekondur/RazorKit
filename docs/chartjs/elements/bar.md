!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/elements.html#bar-configuration)"
	Bar elements are used to represent the bars in a bar chart.

	Namespace: ```options.elements.bar```

```csharp hl_lines="3" linenums="1"
.Options(o => o
    .Elements(e => e
        .Bar().BorderWidth(1).BorderSkipped(false)))
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

## Bar Element Settings

### BorderSkipped
Skipped (excluded) border. Default is ```'start'```
```csharp
.BorderSkipped(true)
```
```csharp
.BorderSkipped(Skipped.Middle)
```

### BorderRadius
The bar border radius (in pixels). Default ```0```
```csharp
.BorderRadius(3)
```
The bar border radius (in pixels). { topLeft, topRight, bottomLeft, bottomRight }
```csharp
.BorderRadius(br => br.TopLeft(2).TopRight(3).BottomLeft(2).BottomRight(3))
```

### InflateAmount
The amount of pixels to inflate the bar rectangle(s) when drawing is ```'auto'```.
```csharp
.InflateAmount()
```
The amount of pixels to inflate the bar rectangle(s) when drawing.
```csharp
.InflateAmount(1)
```

### PointStyle
Style of the point for legend. Default is 'circle'.
```csharp
.PointStyle(PointStyle.Star)
```

