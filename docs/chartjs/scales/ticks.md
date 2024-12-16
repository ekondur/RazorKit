---
icon: material/chart-timeline-variant-shimmer
---

## BackdropColor
Color of label backdrops.
```csharp
.BackdropColor("example")
```

## BackdropPadding
Padding of label backdrop. Default 2
```csharp
.BackdropPadding(15)
```

## BackdropPadding

```csharp
.BackdropPadding(default)
```

## Callback
Returns the string representation of the tick value as it should be displayed on the chart.
```csharp
.Callback("example")
```

## Display
If true, show tick labels. Default true
```csharp
.Display(true)
```

## Color
Color of ticks.
```csharp
.Color("example")
```

## Font

```csharp
.Font(default)
```

## Major
If true, major ticks are generated. 
            A major tick will affect autoskipping and major will be defined on ticks in the scriptable options context.
            Default false
```csharp
.Major(true)
```

## Padding
Sets the offset of the tick labels from the axis. Default 3
```csharp
.Padding(15)
```

## ShowLabelBackdrop
If true, draw a background behind the tick labels.
            Default is true for radial scale, false otherwise.
```csharp
.ShowLabelBackdrop(true)
```

## TextStrokeColor
The color of the stroke around the text.
```csharp
.TextStrokeColor("example")
```

## TextStrokeWidth
Stroke width around the text. Default 0
```csharp
.TextStrokeWidth(15)
```

## Z
z-index of tick layer. Useful when ticks are drawn on chart area. 
            Values less than equal 0 are drawn under datasets, grater than 0 on top
```csharp
.Z(15)
```

