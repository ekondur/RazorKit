---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/fonts.html)"
	There are special global settings that can change all the fonts on the chart. These options are in ```Chart.defaults.font```. 
	The global font settings only apply when more specific options are not included in the config.
	
```csharp
.Font(f => f.Family("Helvetica").Size(10))
```

## Family
Default font family for all text, follows CSS font-family options.
```csharp
.Family("Helvetica")
```

## Size
Default font size (in px) for text. Does not apply to radialLinear scale point labels. Default ```12```
```csharp
.Size(15)
```

## Style
Default font style. Does not apply to tooltip title or footer.
Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
```csharp
.Style("normal")
```

## Weight
Set a weight. Default font weight ```boldness```.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/CSS/font-weight)
```csharp
.Weight(FontWeight.Bold)
```
Or, set a number.
```csharp
.Weight(100)
```

## LineHeight
Height of an individual line of text.
[:octicons-link-external-16:](https://developer.mozilla.org/en-US/docs/Web/CSS/line-height)
```csharp
.LineHeight("3em")
```
Or, use double. Default ```1.2```
```csharp
.LineHeight(1.3)
```

