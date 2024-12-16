---
icon: material/chart-multiple
---

## Type
Type of scale being employed. Custom scales can be created and registered with a string key. 
            This allows changing the type of an axis for a chart.
```csharp
.Type("example")
```

## AlignToPixels
Align pixel values to device pixels. Default false
```csharp
.AlignToPixels(true)
```

## BackgroundColor
Background color of the scale area.
```csharp
.BackgroundColor("example")
```

## Border

```csharp
.Border(default)
```

## Display
Controls the axis global visibility (visible when true, hidden when false).
            Default true
```csharp
.Display(true)
```

## Display
When display: 'auto', the axis is visible only if at least one associated dataset is visible.
```csharp
.Display("example")
```

## Grid

```csharp
.Grid(default)
```

## Min
User defined minimum number for the scale, overrides minimum value from data.
```csharp
.Min(15)
```

## Max
User defined maximum number for the scale, overrides maximum value from data.
```csharp
.Max(15)
```

## Reverse
Reverse the scale. Default false
```csharp
.Reverse(true)
```

## Stacked
Should the data be stacked.
```csharp
.Stacked(true)
```

## Stacked
For some charts, you might want to stack positive and negative values together. 
            That can be achieved by specifying stacked: 'single'.
```csharp
.Stacked("example")
```

## SuggestedMax
Adjustment used when calculating the maximum data value.
```csharp
.SuggestedMax(15)
```

## SuggestedMin
Adjustment used when calculating the minimum data value.
```csharp
.SuggestedMin(15)
```

## Ticks

```csharp
.Ticks(default)
```

## Weight
The weight used to sort the axis. Higher weights are further away from the chart area.
            Default 0
```csharp
.Weight(15)
```

## Callbacks

```csharp
.Callbacks(default)
```

## BeginAtZero
if true, scale will include 0 if it is not already included.
```csharp
.BeginAtZero(true)
```

## Grace
Percentage (string ending with %) for added room in the scale range above and below data.
```csharp
.Grace("example")
```

## Grace
Amount (number) for added room in the scale range above and below data.
```csharp
.Grace(15)
```

## Bounds
Determines the scale bounds. Default 'ticks'
```csharp
.Bounds(default)
```

## Clip
If true, clip the dataset drawing against the size of the scale instead of chart area.
            Default true
```csharp
.Clip(true)
```

## Position
Position of the axis.
```csharp
.Position(default)
```

## Stack
Stack group. Axes at the same position with same stack are stacked.
```csharp
.Stack("example")
```

## StackWeight
Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
            Default 1
```csharp
.StackWeight(15)
```

## Axis
Which type of axis this is. Possible values are: 'x', 'y'. 
            If not set, this is inferred from the first character of the ID which should be 'x' or 'y'.
```csharp
.Axis("example")
```

## Offset
If true, extra space is added to the both edges and the axis is scaled to fit into the chart area.
            This is set to true for a bar chart by default, for others false.
```csharp
.Offset(true)
```

## Title

```csharp
.Title(default)
```

