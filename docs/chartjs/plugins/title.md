---
icon: material/menu-right
---


!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/title.html)"
	The chart title defines text to draw at the top of the chart.

```csharp hl_lines="3" linenums="1"
.Options(o => o
    .Plugins(p => p
        .Title(t => t
            .Text("Chart Title")
            .Color("blue")
            .Position(TitlePosition.Top))))
```

## Align
Alignment of the title. default ```'center'```
```csharp
.Align(TitleAlign.Center)
```

## Color
Color of text.
```csharp
.Color("rgb(75, 192, 192)")
```

## Display
Is the title shown? default ```false```
```csharp
.Display(true)
```

## FullSize
Marks that this box should take the full width/height of the canvas. 
If false, the box is sized and placed above/beside the chart area. default ```false```.
```csharp
.FullSize(true)
```

## Position
Position of title. default ```'top'```
```csharp
.Position(TitlePosition.Top)
```

## Font
See font configuration.
[:link:](../font.md)
```csharp
.Font(f => f.Family("...").Size(10))
```

## Padding
Padding around the title.
```csharp
.Padding(5)
```
See padding configuration.
[:link:](../padding.md)
```csharp
.Padding(p => p.Top(5).Bottom(10))
```

## Text
The string title.
```csharp
.Text("Chart Title")
```
Define multiple title.
```csharp
.Text("Title 1", "Title 2")
```

