---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/subtitle.html)"
	Subtitle is a second title placed under the main title, by default. It has exactly the same configuration options with the main title.
	
	Namespace: ```options.plugins.subtitle```

```csharp hl_lines="3" linenums="1"
.Options(o => o
    .Plugins(p => p
        .Subtitle(t => t
            .Text("Chart Title")
            .Color("green")
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
```csharp
.Font(f => f.Size(10))
```

## Padding
Padding around the title.
```csharp
.Padding(5)
```
See padding configuration.
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

