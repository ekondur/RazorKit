## Display
Is the legend shown? default true.
```csharp
.Display(true)
```

## Position
Position of the legend.
```csharp
.Position(default)
```

## Align
Alignment of the legend.
```csharp
.Align(default)
```

## MaxHeight
Maximum height of the legend, in pixels.
```csharp
.MaxHeight(15)
```

## MaxWidth
Maximum width of the legend, in pixels.
```csharp
.MaxWidth(15)
```

## FullSize
Marks that this box should take the full width/height of the canvas (moving other boxes). 
            This is unlikely to need to be changed in day-to-day use. default true.
```csharp
.FullSize(true)
```

## OnClick
A callback that is called when a click event is registered on a label item.
            Arguments: [event, legendItem, legend].
```csharp
.OnClick("example")
```

## OnHover
A callback that is called when a 'mousemove' event is registered on top of a label item.
            Arguments: [event, legendItem, legend].
```csharp
.OnHover("example")
```

## OnLeave
A callback that is called when a 'mousemove' event is registered outside of a previously hovered label item. 
            Arguments: [event, legendItem, legend].
```csharp
.OnLeave("example")
```

## Reverse
Legend will show datasets in reverse order. default false.
```csharp
.Reverse(true)
```

## Labels

```csharp
.Labels(default)
```

## Rtl
'true' for rendering the legends from right to left.
```csharp
.Rtl(true)
```

## TextDirection
This will force the text direction 'rtl' or 'ltr' on the canvas for rendering the legend,
            regardless of the css specified on the canvas.
```csharp
.TextDirection("example")
```

## Title

```csharp
.Title(default)
```

