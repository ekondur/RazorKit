---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/samples/scale-options/ticks.html)"
	This sample shows how to use different tick features to control how tick labels are shown on the X axis. These features include:

	- Multi-line labels
	- Filtering labels
	- Changing the tick color
	- Changing the tick alignment for the X axis

## Common tick options to all axes
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

### BackdropPadding

```csharp
.BackdropPadding(default)
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

```csharp
.Font(default)
```

### Major
If true, major ticks are generated. 
A major tick will affect autoskipping and major will be defined on ticks in the scriptable options context.
Default ```false```
```csharp
.Major(true)
```

### Padding
Sets the offset of the tick labels from the axis. Default ```3```
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

