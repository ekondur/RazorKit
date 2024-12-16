---
icon: material/menu-right
---

## Mode
Sets which elements appear in the interaction. Default 'nearest'
```csharp
.Mode(default)
```

## Intersect
if true, the interaction mode only applies when the mouse position intersects an item on the chart.
            Default true
```csharp
.Intersect(true)
```

## Axis
Can be set to 'x', 'y', 'xy' or 'r' to define which directions are used in calculating distances.
            Defaults to 'x' for 'index' mode and 'xy' in dataset and 'nearest' modes.
```csharp
.Axis(default)
```

## IncludeInvisible
if true, the invisible points that are outside of the chart area will also be included when evaluating interactions.
            Default false
```csharp
.IncludeInvisible(true)
```

