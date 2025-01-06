---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/samples/scale-options/titles.html)"
	A scale title is the label that appears alongside the axes (scales) of the chart, providing descriptive information about the data represented by that axis.
	It helps users understand the context of the chart by explaining what the axis values mean.
	
```csharp hl_lines="5" linenums="1"
.Options(o => o
    .Scales(s => s
		.ScaleId("y")
        .BeginAtZero(true)
        .Title(t => t
			.Display(true)
            .Color("#191")
            .Text("Value"))))
```
	
## Display
If true, display the axis title. Default ```false```
```csharp
.Display(true)
```

## Align
Alignment of the axis title. Possible options are ```'start'```, ```'center'``` and ```'end'```. Default ```'center'```
```csharp
.Align(TitleAlign.Start)
```

## Text
The text for the title. (i.e. "# of People" or "Response Choices").
```csharp
.Text("Response Choices")
```
The text for the title(s).
```csharp
.Text("text1", "text2")
```

## Color
Color of label.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.Color("#191")
```

## Font
See font configuration.
[:link:](../font.md)
```csharp
.Font(f => f.Family("Helvetica").Size(10))
```

## Padding
Padding to apply around scale labels. Only top, bottom and y are implemented.
Default ```4```
```csharp
.Padding(2)
```
See padding configuration.
[:link:](../padding.md)
```csharp
.Padding(p => p.Top(5).Bottom(10))
```

