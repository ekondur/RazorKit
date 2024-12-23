---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/)"
	Axes are an integral part of a chart. They are used to determine how data maps to a pixel value on the chart.
	In a cartesian chart, there is 1 or more X-axis and 1 or more Y-axis to map points onto the 2-dimensional canvas. These axes are known as 'cartesian axes'.
	In a radial chart, such as a radar chart or a polar area chart, there is a single axis that maps points in the angular and radial directions. These are known as 'radial axes'.

```csharp hl_lines="3" linenums="1"
.Options(o => o
    .Scales(s => s
		.AxisId("x")
		.BeginAtZero(true)))
```
```csharp linenums="1"
.Data(d => d
    .Datasets(ds => ds
        .Line()
        .XAxisID("first-x-axis")
        .YAxisID("first-y-axis")))
.Options(x => x.Scales(s =>
    {
        s.AxisId("first-x-axis").Type("linear");
        s.AxisId("first-y-axis").Type("linear");
    }
))
```
The configuration must include the ```AxisId("id")``` method. ```x```, ```y```, ```r``` or a custom id can be assigned.

## Common Axis Options:
These are only the common options supported by all axes. Please see specific axis documentation for all the available options for that axis.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/#common-options-to-all-axes)

### Type
Type of scale being employed. Custom scales can be created and registered with a string key. 
This allows changing the type of an axis for a chart.
```csharp
.Type("logarithmic")
```

### AlignToPixels
Align pixel values to device pixels. Default ```false```
```csharp
.AlignToPixels(true)
```

### BackgroundColor
Background color of the scale area.
```csharp
.BackgroundColor("grey")
```

### Display
Controls the axis global visibility (visible when ```true```, hidden when ```false```).
Default ```true```
```csharp
.Display(true)
```
When display: ```'auto'```, the axis is visible only if at least one associated dataset is visible.
```csharp
.Display("auto")
```

### Min
User defined minimum number for the scale, overrides minimum value from data.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/#axis-range-settings)
```csharp
.Min(50)
```

### Max
User defined maximum number for the scale, overrides maximum value from data.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/#axis-range-settings)
```csharp
.Max(100)
```

### Reverse
Reverse the scale. Default ```false```
```csharp
.Reverse(true)
```

### Stacked
Should the data be stacked. Default ```false```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/#stacking)
```csharp
.Stacked(true)
```
For some charts, you might want to stack positive and negative values together. 
That can be achieved by specifying stacked: ```'single'```
```csharp
.Stacked("single")
```

### SuggestedMax
Adjustment used when calculating the maximum data value.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/#axis-range-settings)
```csharp
.SuggestedMax(50)
```

### SuggestedMin
Adjustment used when calculating the minimum data value.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/#axis-range-settings)
```csharp
.SuggestedMin(100)
```

### Weight
The weight used to sort the axis. Higher weights are further away from the chart area.
Default ```0```
```csharp
.Weight(1)
```

## Linear Axis Options:
The linear scale is used to chart numerical data. It can be placed on either the x or y-axis. 
The scatter chart type automatically configures a line chart to use one of these scales for the x-axis. As the name suggests, linear interpolation is used to determine where a value lies on the axis.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/cartesian/linear.html#linear-axis-specific-options)

### BeginAtZero
if ```true```, scale will include ```0``` if it is not already included.
```csharp
.BeginAtZero(true)
```

### Grace
Percentage (string ending with %) for added room in the scale range above and below data.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/cartesian/linear.html#grace)
```csharp
.Grace("5%")
```
Amount (number) for added room in the scale range above and below data.
```csharp
.Grace(50)
```

## Cartesian Axis Options:
Axes that follow a cartesian grid are known as 'Cartesian Axes'. Cartesian axes are used for line, bar, and bubble charts. Four cartesian axes are included in Chart.js by default.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/cartesian/#common-options-to-all-cartesian-axes)

### Bounds
Determines the scale bounds. Default ```'ticks'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/cartesian/#scale-bounds)
```csharp
.Bounds(Bounds.Data)
```

### Clip
If true, clip the dataset drawing against the size of the scale instead of chart area.
Default ```true```
```csharp
.Clip(false)
```

### Position
Position of the axis.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/cartesian/#axis-position)
```csharp
.Position(AxisPosition.Top)
```

### Stack
Stack group. Axes at the same ```position``` with same ```stack``` are stacked.
```csharp
.Stack("example")
```

### StackWeight
Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
Default ```1```
```csharp
.StackWeight(2)
```

### Axis
Which type of axis this is. Possible values are: ```'x'```, ```'y'```. 
If not set, this is inferred from the first character of the ID which should be ```'x'``` or ```'y'```.
```csharp
.Axis("x")
```

### Offset
If ```true```, extra space is added to the both edges and the axis is scaled to fit into the chart area.
This is set to ```true``` for a bar chart by default, for others ```false```.
```csharp
.Offset(true)
```
