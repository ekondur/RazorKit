---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html)"
	The tooltip extension is a feature that allows you to customize the behavior and appearance of tooltips displayed when users interact with chart elements. 
	Tooltips provide additional information about a data point when the user hovers over or taps on it.
	
	Namespace: ```options.plugins.tooltip```
	
=== "helper"
	```csharp hl_lines="3" linenums="1"
	.Options(o => o
		.Plugins(p => p
			.Tooltip(t => t
				.Enabled(true)
				.Mode("index")
				.Intersect(false)
				.TitleColor("#fff"))))
	```
=== "js output"
	```json linenums="1"
	"options": {
		"plugins": {
		  "tooltip": {
			"enabled": true,
			"mode": "index",
			"intersect": false,
			"titleColor": '#fff'
		  }
		}
    }
	```

## Enabled
Are on-canvas tooltips enabled? Default ```true```
```csharp
.Enabled(false)
```

## External
External function name.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#external-custom-tooltips)
```csharp
.External("myExternalFunction")
```

## Mode
Sets which elements appear in the tooltip. Default ```interaction.mode```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/interactions.html#modes)
```csharp
.Mode("index")
```

## Intersect
If ```true```, the tooltip mode applies only when the mouse position intersects with an element. 
If ```false```, the mode will be applied at all times. Default ```interaction.intersect```
```csharp
.Intersect(true)
```

## Position
The mode for positioning the tooltip. Default ```'average'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#position-modes)
```csharp
.Position(TooltipPosition.Nearest)
```
Or, set the custom position.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#custom-position-modes)
```csharp
.Position("myCustomPosition")
```

## ItemSort
Sort tooltip items. Default ```function```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#sort-callback)
```csharp
.ItemSort("mySortFunction")
```

## Filter
Filter tooltip items. Default ```function```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#filter-callback)
```csharp
.Filter("myFilterFunction")
```

## BackgroundColor
Background color of the tooltip.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.BackgroundColor("rgba(0, 0, 0, 0.8)")
```

## TitleColor
Color of title text. Default ```'#fff'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.TitleColor("#fff")
```

## TitleFont
See font configuration.
[:link:](../font.md)
```csharp
.TitleFont(f => f.Family("...").Size(10))
```

## TitleAlign
Horizontal alignment of the title text lines. Default ```'left'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#text-alignment)
```csharp
.TitleAlign(TextAlign.Center)
```

## TitleSpacing
Spacing to add to top and bottom of each title line. Default ```2```
```csharp
.TitleSpacing(3)
```

## TitleMarginBottom
Margin to add on bottom of title section. Default ```6```
```csharp
.TitleMarginBottom(5)
```

## BodyColor
Color of body text. defautl ```'#fff'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.BodyColor("#fff")
```

## BodyFont
See font configuration.
[:link:](../font.md)
```csharp
.BodyFont(f => f.Family("...").Size(10))
```

## BodyAlign
Horizontal alignment of the body text lines. Default ```'left'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#text-alignment)
```csharp
.BodyAlign(TextAlign.Center)
```

## BodySpacing
Spacing to add to top and bottom of each tooltip item. Default ```2```
```csharp
.BodySpacing(3)
```

## FooterColor
Color of footer text. Default ```'#fff'```
```csharp
.FooterColor("#fff")
```

## FooterFont
See font configuration.
[:link:](../font.md)
```csharp
.FooterFont(f => f.Family("...").Size(10))
```

## FooterAlign
Horizontal alignment of the footer text lines. Default ```'left'```
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#text-alignment)
```csharp
.FooterAlign(TextAlign.Center)
```

## FooterSpacing
Spacing to add to top and bottom of each footer line. Default ```2```
```csharp
.FooterSpacing(3)
```

## FooterMarginTop
Margin to add before drawing the footer. Default ```6```
```csharp
.FooterMarginTop(5)
```

## Padding
Padding inside the tooltip. Default ```6```
```csharp
.Padding(5)
```

## Padding

```csharp
.Padding(default)
```

## CaretPadding
Extra distance to move the end of the tooltip arrow away from the tooltip point. Default ```2```
```csharp
.CaretPadding(15)
```

## CaretSize
Size, in px, of the tooltip arrow. Default ```5```
```csharp
.CaretSize(4)
```

## CornerRadius
Radius of tooltip corner curves. Default ```6```
```csharp
.CornerRadius(5)
```

## MultiKeyBackground
Color to draw behind the colored boxes when multiple items are in the tooltip. Default ```'#fff'```
```csharp
.MultiKeyBackground("#fff")
```

## DisplayColors
If ```true```, color boxes are shown in the tooltip. Default ```true```
```csharp
.DisplayColors(false)
```

## BoxWidth
Width of the color box if displayColors is ```true```. Default ```bodyFont.size```
```csharp
.BoxWidth(15)
```

## BoxHeight
Height of the color box if displayColors is ```true```. Default ```bodyFont.size```
```csharp
.BoxHeight(15)
```

## BoxPadding
Padding between the color box and the text. Default ```1```
```csharp
.BoxPadding(2)
```

## UsePointStyle
Use the corresponding point style (from dataset options) instead of color boxes, ex: star, triangle etc.
(size is based on the minimum value between ```boxWidth``` and ```boxHeight```). Default ```false```
```csharp
.UsePointStyle(true)
```

## BorderColor
Color of the border.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html)
```csharp
.BorderColor("'rgba(0, 0, 0, 0)'")
```

## BorderWidth
Size of the border. Default ```0```
```csharp
.BorderWidth(1)
```

## Rtl
```true``` for rendering the tooltip from right to left.
```csharp
.Rtl(true)
```

## TextDirection
This will force the text direction ```'rtl'``` or ```'ltr'``` on the canvas for rendering the tooltips, 
regardless of the css specified on the canvas.
```csharp
.TextDirection("rtl")
```

## XAlign
Position of the tooltip caret in the X direction.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#tooltip-alignment)
```csharp
.XAlign("left")
```

## YAlign
Position of the tooltip caret in the Y direction.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#tooltip-alignment)
```csharp
.YAlign("left")
```

## Callbacks
Namespace: ```options.plugins.tooltip.callbacks```, the tooltip has the following callbacks for providing text. 
For all functions, ```this``` will be the tooltip object created from the ```Tooltip``` constructor. 
If the callback returns ```undefined```, then the default callback will be used. To remove things from the tooltip callback should return an empty string.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/configuration/tooltip.html#tooltip-callbacks)
```csharp
.Callbacks(c => c.BeforeTitle("...").Title("..."))
```

### BeforeTitle
Returns the text to render before the title.
```csharp
.BeforeTitle("myFunction")
```

### Title
Returns text to render as the title of the tooltip.
```csharp
.Title("myFunction")
```

### AfterTitle
Returns text to render after the title.
```csharp
.AfterTitle("myFunction")
```

### BeforeBody
Returns text to render before the body section.
```csharp
.BeforeBody("myFunction")
```

### BeforeLabel
Returns text to render before an individual label. This will be called for each item in the tooltip.
```csharp
.BeforeLabel("myFunction")
```

### Label
Returns text to render for an individual item in the tooltip.
```csharp
.Label("myFunction")
```

### LabelColor
Returns the colors to render for the tooltip item.
```csharp
.LabelColor("myFunction")
```

### LabelTextColor
Returns the colors for the text of the label for the tooltip item.
```csharp
.LabelTextColor("myFunction")
```

### LabelPointStyle
Returns the point style to use instead of color boxes if usePointStyle is true (object with values pointStyle and rotation).
Default implementation uses the point style from the dataset points.
```csharp
.LabelPointStyle("myFunction")
```

### AfterLabel
Returns text to render after an individual label.
```csharp
.AfterLabel("myFunction")
```

### AfterBody
Returns text to render after the body section.
```csharp
.AfterBody("myFunction")
```

### BeforeFooter
Returns text to render before the footer section.
```csharp
.BeforeFooter("myFunction")
```

### Footer
Returns text to render as the footer of the tooltip.
```csharp
.Footer("myFunction")
```

### AfterFooter
Text to render after the footer section.
```csharp
.AfterFooter("myFunction")
```