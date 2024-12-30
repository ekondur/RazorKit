---
icon: material/chart-line
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/line.html)"
	A line chart is a way of plotting data points on a line. Often, it is used to show trend data, or the comparison of two data sets.

```csharp hl_lines="5" linenums="1"
@(Html.Chart("canvasId")
.Data(d => d
    .Labels("January", "February", "March", "April", "May", "June", "July")
    .Datasets(ds => ds
        .Line()
        .Label("Line Chart")
        .Data(65, 59, 80, 81, 56, 55, 40)
        .Fill(false)
        .BorderColor("rgb(75, 192, 192)")
        .Tension(0.1)))
.Render())
```

## Common Dataset Options
These options are common to all datasets.

### BackgroundColor
The line fill color.
```csharp
.BackgroundColor("green")
```

### BorderColor
The line color.
```csharp
.BorderColor("grey")
```

### BorderWidth
The line width (in pixels).
```csharp
.BorderWidth(1)
```

### Clip
How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea.
0 = clip at chartArea.
```csharp
.Clip(3)
```
Is clip enabled?
```csharp
.Clip(false)
```
Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}
```csharp
.Clip(c => c.Left(5).Top(false).Right(-2).Bottom(0))
```

### Hidden
Configure the visibility of the dataset. Using hidden: true will hide the dataset from being rendered in the Chart.
```csharp
.Hidden(true)
```

### HoverBackgroundColor
Background color when hovered.
```csharp
.HoverBackgroundColor("blue")
```

### HoverBorderColor
Border color when hovered.
```csharp
.HoverBorderColor("grey")
```

### HoverBorderWidth
The line width (in pixels) when hovered.
```csharp
.HoverBorderWidth(3)
```

### Label
The label for the dataset which appears in the legend and tooltips.
```csharp
.Label("First Bar Dataset")
```

### Parsing
How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. 
If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
```csharp
.Parsing(true)
```
Parsing with key.
```csharp
.Parsing("key")
```
Parsing with x and y axis keys.
```csharp
.Parsing("xKey", "yKey")
```

## Point Dataset Options

### BorderCapStyle
Cap style of the line. Default ```'butt'```
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineCap)
```csharp
.BorderCapStyle(CapStyle.Square)
```

### BorderDash
Length and spacing of dashes.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash)
```csharp
.BorderDash(15, 3, 3, 3)
```

### BorderDashOffset
Offset for line dashes. Default ```0.0```
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset)
```csharp
.BorderDashOffset(0.1)
```

### BorderJoinStyle
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineJoin)
Line joint style. Default ```'miter'```
```csharp
.BorderJoinStyle(JoinStyle.Bevel)
```

### HoverBorderCapStyle
Border cap style when hovered.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineCap)
```csharp
.HoverBorderCapStyle(CapStyle.Square)
```

### HoverBorderDash
Length and spacing of dashes when hovered.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash)
```csharp
.HoverBorderDash(15, 3, 3, 3)
```

### HoverBorderDashOffset
Offset for line dashes when hovered.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset)
```csharp
.HoverBorderDashOffset(0.1)
```

### HoverBorderJoinStyle
Line joint style when hovered.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineJoin)
```csharp
.HoverBorderJoinStyle(oinStyle.Bevel)
```

### Fill
Is enabled? Default ```false```
```csharp
.Fill(true)
```
How to fill the area under the line. 
```csharp
.Fill("stack")
```
Fill with configuration.
```csharp
.Fill(f => f.Above("Blue").Below("Red"))
```

### Order
The drawing order of dataset. Also affects order for stacking, tooltip and legend.
```csharp
.Order(1)
```

### PointBackgroundColor
The fill color for points.
```csharp
.PointBackgroundColor("green")
```

### PointBorderColor
The border color for points.
```csharp
.PointBorderColor("grey")
```

### PointBorderWidth
The width of the point border in pixels. Default ```1```
```csharp
.PointBorderWidth(2)
```

### PointHitRadius
The pixel size of the non-displayed point that reacts to mouse events. Default ```1```
```csharp
.PointHitRadius(2)
```

### PointHoverBackgroundColor
Point background color when hovered.
```csharp
.PointHoverBackgroundColor("green")
```

### PointHoverBorderColor
Point border color when hovered.
```csharp
.PointHoverBorderColor("grey")
```

### PointHoverBorderWidth
Border width of point when hovered. Default ```1```
```csharp
.PointHoverBorderWidth(2)
```

### PointHoverRadius
The radius of the point when hovered. Default ```4```
```csharp
.PointHoverRadius(5)
```

### PointRadius
The radius of the point shape. If set to 0, the point is not rendered. Default ```3```
```csharp
.PointRadius(2)
```

### PointRotation
The rotation of the point in degrees. Default ```0```
```csharp
.PointRotation(1)
```

### PointStyle
Is style of the point enabled?
```csharp
.PointStyle(true)
```
Style of the point. Default ```'circle'```
```csharp
.PointStyle(PointStyle.Cross)
```

### SpanGaps
If ```true```, lines will be drawn between points with no or null data. If ```false```, points with null data will create a break in the line.
Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
```csharp
.SpanGaps(true)
```

### Tension
Bezier curve tension of the line. Set to ```0``` to draw straightlines. This option is ignored if monotone cubic interpolation is used.
```csharp
.Tension(0.1)
```

## Line Dataset Options

### CubicInterpolationMode
The following interpolation modes are supported, ```'default'``` and ```'monotone'```.
```csharp
.CubicInterpolationMode(InterpolationMode.Monotone)
```

### Data
Sets the data for the Dataset.
```csharp
.Data(1, 3, 5, 7)
```
```csharp
.Data(1.0, 3.2, 5.0, 7.0)
```
```csharp
.Data(IList<object> data)
```

### DrawActiveElementsOnTop
Draw the active points of a dataset over the other points of the dataset. Default ```true```
```csharp
.DrawActiveElementsOnTop(false)
```

### IndexAxis
The base axis of the dataset. ```'x'``` for horizontal lines and ```'y'``` for vertical lines. Default ```'x'```
```csharp
.IndexAxis(IndexAxis.Y)
```

### Segment
Line segment styles can be overridden by scriptable options in the segment object.
To get the segment object from a function, set a funtion name.
```csharp
.Segment("segmentStyleFunction")
```
```js
function segmentStyleFunction(ctx) {
	return {
        borderColor: ctx => skipped(ctx, 'rgb(0,0,0,0.2)') || down(ctx, 'rgb(192,75,75)'),
        borderDash: ctx => skipped(ctx, [6, 6]),
      };
}
```

### ShowLine
If ```false```, the line is not drawn for this dataset. Default ```true```
```csharp
.ShowLine(false)
```

### Stack
The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack). Default ```'line'```
```csharp
.Stack("line")
```

### Stepped
If the stepped value is set to anything other than ```false```, ```'tension'``` will be ignored.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/charts/line.html#stepped)
```csharp
.Stepped(true)
```
```csharp
.Stepped("after")
```

### XAxisID
The ID of the x-axis to plot this dataset on.
```csharp
.XAxisID("my-x-axis")
```

### YAxisID
The ID of the y-axis to plot this dataset on.
```csharp
.YAxisID("my-y-axis")
```

