## Circular
If true, gridlines are circular (on radar and polar area charts only). Default false
```csharp
.Circular(true)
```

## Color
The color of the grid lines. If specified as an array, the first color applies to the first grid line,
            the second to the second grid line, and so on.
```csharp
.Color("example")
```

## Display
If false, do not display grid lines for this axis. Default true
```csharp
.Display(true)
```

## DrawOnChartArea
If true, draw lines on the chart area inside the axis lines. 
            This is useful when there are multiple axes and you need to control which grid lines are drawn.
            Default true
```csharp
.DrawOnChartArea(true)
```

## DrawTicks
If true, draw lines beside the ticks in the axis area beside the chart. Default true
```csharp
.DrawTicks(true)
```

## LineWidth
Stroke width of grid lines. Default 1
```csharp
.LineWidth(15)
```

## Offset
If true, grid lines will be shifted to be between labels. This is set to true for a bar chart by default.
            Default false
```csharp
.Offset(true)
```

## TickBorderDash
Length and spacing of the tick mark line. If not set, defaults to the grid line borderDash value.
            Default []
```csharp
.TickBorderDash(default)
```

## TickBorderDashOffset
Offset for the line dash of the tick mark. If unset, defaults to the grid line 'borderDashOffset' value.
```csharp
.TickBorderDashOffset(15)
```

## TickColor
Color of the tick line. If unset, defaults to the grid line color.
```csharp
.TickColor("example")
```

## TickLength
Length in pixels that the grid lines will draw into the axis area. Default 8
```csharp
.TickLength(15)
```

## TickWidth
Width of the tick mark in pixels. If unset, defaults to the grid line width.
```csharp
.TickWidth(15)
```

## Z
z-index of the gridline layer. Values less than equal are drawn under datasets, grater than 0 on top.
            Default -1
```csharp
.Z(15)
```

