## BoxWidth
Width of coloured box. default 40
```csharp
.BoxWidth(15)
```

## BoxHeight
Height of the coloured box.
```csharp
.BoxHeight(15)
```

## Color
Color of label and the strikethrough.
```csharp
.Color("example")
```

## Font

```csharp
.Font(default)
```

## Padding
Padding between rows of colored boxes. Default 10
```csharp
.Padding(15)
```

## GenerateLabels
Generates legend items for each thing in the legend.
            Default implementation returns the text + styling for the color box.
```csharp
.GenerateLabels("example")
```

## Filter
Filters legend items out of the legend. Receives 2 parameters, a Legend Item and the chart data.
```csharp
.Filter("example")
```

## Sort
Sorts legend items. Type is : sort(a: LegendItem, b: LegendItem, data: ChartData): number;.
            Receives 3 parameters, two Legend Items and the chart data. 
            The return value of the function is a number that indicates the order of the two legend item parameters. 
            The ordering matches the return value of Array.prototype.sort()
```csharp
.Sort("example")
```

## PointStyle
If specified, this style of point is used for the legend. Only used if usePointStyle is true. default 'circle'
```csharp
.PointStyle(default)
```

## TextAlign
Horizontal alignment of the label text. Options are: 'left', 'right' or 'center'. default 'center'
```csharp
.TextAlign(default)
```

## UsePointStyle
Label style will match corresponding point style (size is based on pointStyleWidth or the minimum value between boxWidth and font.size).
            default false
```csharp
.UsePointStyle(true)
```

## PointStyleWidth
If UsePointStyle is true, the width of the point style used for the legend.
```csharp
.PointStyleWidth(15)
```

## UseBorderRadius
Label borderRadius will match corresponding borderRadius. default false
```csharp
.UseBorderRadius(true)
```

## BorderRadius
Override the borderRadius to use.
```csharp
.BorderRadius(default)
```

