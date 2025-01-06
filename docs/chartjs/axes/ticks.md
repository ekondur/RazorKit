---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/samples/scale-options/ticks.html)"
	This sample shows how to use different tick features to control how tick labels are shown on the X axis. These features include:

	- Multi-line labels
	- Filtering labels
	- Changing the tick color
	- Changing the tick alignment for the X axis
	
```csharp hl_lines="4" linenums="1"
.Options(o => o
    .Scales(s => s
        .ScaleId("y")
        .Ticks(t => t
            .AutoSkip(false)
            .CrossAlign(TicksCrossAlign.Far)
            .BackdropColor("green"))))
```

## Common Axis Options
These are the common tick options supported by all axes.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/cartesian/#common-tick-options-to-all-axes)

### BackdropColor
Color of label backdrops.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.BackdropColor("rgba(255, 255, 255, 0.75)")
```

### BackdropPadding
Padding of label backdrop. Default ```2```
```csharp
.BackdropPadding(3)
```
See padding configuration.
[:link:](../padding.md)
```csharp
.BackdropPadding(p => p.Top(5).Bottom(10))
```

### Callback
Returns the string representation of the tick value as it should be displayed on the chart.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/labelling.html#creating-custom-tick-formats)
```csharp
.Callback("functionName")
```

### Display
If ```true```, show tick labels. Default ```true```
```csharp
.Display(false)
```

### Color
Color of ticks.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.Color("#666")
```

### Font
See font configuration.
[:link:](../font.md)
```csharp
.Font(f => f.Family("...").Size(10))
```

### Major
If true, major ticks are generated. 
A major tick will affect autoskipping and major will be defined on ticks in the scriptable options context.
Default ```false```
```csharp
.Major(true)
```

### Padding
Sets the offset of the tick labels from the axis. Default ```3``` for all axes ```0``` for cartesian axes.
```csharp
.Padding(2)
```

### ShowLabelBackdrop
If true, draw a background behind the tick labels.
Default is ```true``` for radial scale, ```false``` otherwise.
```csharp
.ShowLabelBackdrop(true)
```

### TextStrokeColor
The color of the stroke around the text.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.TextStrokeColor("#666")
```

### TextStrokeWidth
Stroke width around the text. Default ```0```
```csharp
.TextStrokeWidth(1)
```

### Z
z-index of tick layer. Useful when ticks are drawn on chart area. Values ```<= 0``` are drawn under datasets, ```> 0``` on top.
```csharp
.Z(-1)
```

## Cartesian Axis Options

### Align
The tick alignment along the axis. ```'inner'``` alignment means align 'start' for first tick and 'end' for the last tick of horizontal axis.
Default ```'center'```
```csharp
.Align(default)
```

### CrossAlign
The tick alignment perpendicular to the axis. Default ```'near'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/axes/cartesian/#tick-alignment)
```csharp
.CrossAlign(default)
```

### SampleSize
The number of ticks to examine when deciding how many labels will fit. 
Setting a smaller value will be faster, but may be less accurate when there is large variability in label length.
Default ```ticks.length```
```csharp
.SampleSize(1)
```

### AutoSkip
If ```true```, automatically calculates how many labels can be shown and hides labels accordingly. 
Labels will be rotated up to ```maxRotation``` before skipping any. Turn ```autoSkip``` off to show all labels no matter what.
Default ```true```
```csharp
.AutoSkip(false)
```

### AutoSkipPadding
Padding between the ticks on the horizontal axis when ```autoSkip``` is enabled. Default ```3```
```csharp
.AutoSkipPadding(15)
```

### IncludeBounds
Should the defined min and max values be presented as ticks even if they are not ```"nice"```. Default ```true```
```csharp
.IncludeBounds(false)
```

### LabelOffset
Distance in pixels to offset the label from the centre point of the tick (in the x-direction for the x-axis, and the y-direction for the y-axis). 
Note: this can cause labels at the edges to be cropped by the edge of the canvas. Default ```0```
```csharp
.LabelOffset(1)
```

### MaxRotation
Maximum rotation for tick labels when rotating to condense labels. Note: Rotation doesn't occur until necessary. Note: Only applicable to horizontal scales.
Default ```50```
```csharp
.MaxRotation(55)
```

### MinRotation
Minimum rotation for tick labels. Note: Only applicable to horizontal scales. Default ```0```
```csharp
.MinRotation(1)
```

### Mirror
Flips tick labels around axis, displaying the labels inside the chart instead of outside. Note: Only applicable to vertical scales.
Default ```false```
```csharp
.Mirror(true)
```

### MaxTicksLimit
Maximum number of ticks and gridlines to show. Default ```11```
```csharp
.MaxTicksLimit(15)
```