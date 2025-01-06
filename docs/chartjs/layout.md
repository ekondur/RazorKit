---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/layout.html)"
	The layout configuration determines the padding around the chart area (the area where the data is displayed) within the canvas. 
	This allows you to add space between the chart area and other elements, such as legends, titles, and tooltips, 
	or to ensure that the chart looks better when embedded in a larger UI.
	
	Namespace: ```options.layout```

```csharp hl_lines="2" linenums="1"
.Options(o => o
	.Layout(l => l
		.AutoPadding(false)))
```

## AutoPadding
Apply automatic padding so visible elements are completely drawn. Default ```true```
```csharp
.AutoPadding(false)
```

## Padding
Padding around the title.
```csharp
.Padding(5)
```
See padding configuration.
[:link:](padding.md)
```csharp
.Padding(p => p.Top(5).Bottom(10))
```

