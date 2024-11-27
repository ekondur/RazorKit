## CubicInterpolationMode
The following interpolation modes are supported, 'default' and 'monotone'.
```csharp
.CubicInterpolationMode("example")
```

## DrawActiveElementsOnTop
Draw the active points of a dataset over the other points of the dataset.
```csharp
.DrawActiveElementsOnTop(true)
```

## IndexAxis
The base axis of the dataset. 'x' for horizontal lines and 'y' for vertical lines.
```csharp
.IndexAxis("example")
```

## Segment
Line segment styles can be overridden by scriptable options in the segment object.
```csharp
.Segment(default)
```

## ShowLine
If false, the line is not drawn for this dataset.
```csharp
.ShowLine(true)
```

## Stack
The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
```csharp
.Stack("example")
```

## Stepped
If the stepped value is set to anything other than false, 'tension' will be ignored.
```csharp
.Stepped(true)
```

## XAxisID
The ID of the x-axis to plot this dataset on.
```csharp
.XAxisID("example")
```

## YAxisID
The ID of the y-axis to plot this dataset on.
```csharp
.YAxisID("example")
```

