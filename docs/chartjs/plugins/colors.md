---
icon: material/menu-right
---

!!! info "Reference [:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html#default-color-palette)"
	If you don't have any preference for colors, you can use the built-in ```Colors``` plugin. It will cycle through a palette of seven Chart.js brand colors:
	
```csharp hl_lines="3" linenums="1"
.Options(o => o
	.Plugins(p => p
		.Colors(c => c.ForceOverride(true))))
```

## Enabled
It will cycle through a palette of seven Chart.js brand colors. Default ```true```
```csharp
.Enabled(false)
```

## ForceOverride
By default, the colors plugin only works when you initialize the chart without any colors for the border or background specified.
If you want to force the colors plugin to always color your datasets, for example,
when using dynamic datasets at runtime you will need to set the ```forceOverride``` option to ```true```.
[:octicons-link-external-16:](https://www.chartjs.org/docs/latest/general/colors.html#dynamic-datasets-at-runtime)
```csharp
.ForceOverride(true)
```

